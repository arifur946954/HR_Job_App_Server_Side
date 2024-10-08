using DataFactories.BaseFactory;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
using DataUtility;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.common.userroles
{
    public class UserRoleMgt
    {
        #region Variable declaration & initialization
        ModelContext _ctxOra = null;
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;
        Hashtable ht = null; OracleParameter[] oprm = null;
        #endregion

        #region All Methods
        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetWithPagination(vmCmnParameter param)
        {
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            string listUserRole = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "urresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "CompanyID", (1, param.values) },
                    { "PageNumber", (2, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (3, Convert.ToDecimal(param.pageSize)) }
                };

                listUserRole = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_UserRoleByPage, ht, StaticInfos.conStringOracle.ToString());

                //oprm = new OracleParameter[] {
                //    new OracleParameter{ ParameterName="rresult", OracleDbType=OracleDbType.RefCursor, Direction=ParameterDirection.Output },
                //    new OracleParameter{ ParameterName="p_RoleId", OracleDbType=OracleDbType.NVarchar2, Value=param.id },
                //    new OracleParameter{ ParameterName="PageNumber", OracleDbType=OracleDbType.Decimal, Value=Convert.ToDecimal(param.pageNumber) },
                //    new OracleParameter{ ParameterName="PageSize", OracleDbType=OracleDbType.Decimal, Value=Convert.ToDecimal(param.pageSize) },
                //};

                //listUserRole = await OraGeneric_vmCmnParameter.ExecuteCommandString(StoredProcedure.Ora_SpGet_Menu_By_RoleID, oprm, StaticInfos.conStringOracle.ToString());                
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }
            return result = new
            {
                listUserRole
            };
        }



        /// <summary>
        /// This method returns data from database as an object using asynchronous operation by an int parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> GetByID(vmCmnParameter param)
        {
            object result = null, userRole = null;
            try
            {
                using (var _ctxOra = new ModelContext())
                {
                    userRole = await (from rl in _ctxOra.TUserRoles
                                      where rl.Userroleid == param.id
                                      select new
                                      {
                                          userRoleId = rl.Userroleid,
                                          userId = rl.UserId,
                                          roleId = rl.RoleId,
                                          isActive = Extension.BoolVal(rl.Isactive)
                                      }).FirstOrDefaultAsync();
                }
            }
            catch (Exception ex)
            {
                ////Logs.WriteBug(ex);
            }
            return result = new
            {
                userRole
            };
        }



        /// <summary>
        /// Both insert and update can perform by CmnUserRole model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<object> SaveUpdate(vmRoles _Roles, vmCmnParameter param)
        {
            object result = null; string message = string.Empty; bool resstate = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTransaction = _ctxOra.Database.BeginTransaction())
                {
                    try
                    {
                        if (_Roles.UserRoleId > 0)
                        {
                            var userrole = await _ctxOra.TUserRoles.FirstOrDefaultAsync(x => x.Userroleid == _Roles.UserRoleId);
                            userrole.UserId = _Roles.UserId;
                            userrole.RoleId = _Roles.RoleId;
                            userrole.Isactive = Extension.BoolVal(_Roles.IsActive);

                            //Common
                            userrole.Updatepc = Extension.Createpc();
                            userrole.Updateby = param.LoggedUserId;
                            userrole.Updateon = Extension.Today;
                            
                            message = MessageConstants.Updated;
                            resstate = MessageConstants.SuccessState;
                        }
                        else
                        {
                            var exUserrole = await _ctxOra.TUserRoles.FirstOrDefaultAsync(x => x.UserId == _Roles.UserId);
                            if (exUserrole == null)
                            {
                                var MaxID = _ctxOra.TUserRoles.DefaultIfEmpty().Max(x => x == null ? 0 : x.Userroleid) + 1;

                                var role = new TUserRole();
                                role.Userroleid = MaxID;
                                role.UserId = _Roles.UserId;
                                role.RoleId = _Roles.RoleId;
                                role.Isactive = Extension.BoolVal(_Roles.IsActive);

                                //Common
                                role.Createpc = Extension.Createpc();
                                role.Createby = param.LoggedUserId;
                                role.Createon = Extension.Today;

                                await _ctxOra.TUserRoles.AddAsync(role);
                                
                                message = MessageConstants.Saved;
                                resstate = MessageConstants.SuccessState;
                            }
                            else
                            {
                                message = MessageConstants.AlreadyExist;
                                resstate = MessageConstants.ErrorState;
                            }
                        }

                        await _ctxOra.SaveChangesAsync();

                        _ctxOraTransaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        _ctxOraTransaction.Rollback();
                        //Logs.WriteBug(ex);
                        message = MessageConstants.SavedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }
            return result = new
            {
                message,
                resstate
            };
        }


        /// <summary>
        /// Delete can perform to CmnUserRole table by int parameter in database using asynchronous operation. It returns an object as status of success or failure.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> Delete(vmCmnParameter param)
        {
            object result = null; string message = string.Empty; bool resstate = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
                {
                    try
                    {
                        if (param.id > 0)
                        {
                            var delmodel = await _ctxOra.TUserRoles.Where(x => x.Userroleid == param.id).FirstOrDefaultAsync();

                            delmodel.Isdelete = Extension.BoolVal(true);
                            delmodel.Deletepc = Extension.Createpc();
                            delmodel.Deleteby = param.LoggedUserId;
                            delmodel.Deleteon = Extension.Today;
                        }

                        await _ctxOra.SaveChangesAsync();
                        _ctxOraTran.Commit();
                        message = MessageConstants.Deleted;
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTran.Rollback();
                        //Logs.WriteBug(ex);
                        message = MessageConstants.DeletedWarning;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }

            return result = new
            {
                message,
                resstate
            };
        }
        #endregion





    }
}
