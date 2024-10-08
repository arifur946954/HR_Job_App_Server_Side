using DataFactories.BaseFactory;
using DataFactories.DBService;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
using DataUtility;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.common.roles
{
    public class RoleMgt
    {
        #region Variable declaration & initialization
        ModelContext _ctxOra = null;
        private IGenericFactoryOracle<vmCmnParameter> OraGeneric_vmCmnParameter = null;
        #endregion

        #region All Methods
        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> GetWithPagination(vmCmnParameter cmnParam) //vmCmnParameters cmnParam
        {
            int recordsTotal = 0; object rolePagy = null, result = null;
            try
            {
                using (_ctxOra = new ModelContext())
                {
                    rolePagy = await (from rl in _ctxOra.TRoleSetups
                                      where rl.Roleid != StaticInfos.SeedRoleID && rl.Isdelete == Extension.BoolVal(false)
                                      select new
                                      {
                                          roleId = rl.Roleid,
                                          roleName = rl.Rolename,
                                          remarks = rl.Remarks,
                                          isActive = Extension.BoolVal(rl.Isactive)
                                      }).OrderByDescending(x => x.roleId).Skip(Conversions.Skip(cmnParam)).Take((int)cmnParam.pageSize).ToListAsync();

                    recordsTotal = await _ctxOra.TRoleSetups.Where(x => x.Roleid != StaticInfos.SeedRoleID && x.Isdelete == Extension.BoolVal(false)).CountAsync();
                }
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }

            result = new
            {
                rolePagy,
                recordsTotal
            };

            return result;
        }



        /// <summary>
        /// This method returns data from database as an object using asynchronous operation by an int parameter.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<object> GetByID(int id)
        {
            dynamic result = null, objRole = null;
            try
            {
                using (var _ctxOra = new ModelContext())
                {
                    objRole = await (from rl in _ctxOra.TRoleSetups
                                     where rl.Roleid == id
                                     select new
                                     {
                                         roleId = rl.Roleid,
                                         roleName = rl.Rolename,
                                         remarks = rl.Remarks,
                                         isActive = Extension.BoolVal(rl.Isactive)
                                     }).FirstOrDefaultAsync();
                }
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }
            result = new
            {
                objRole
            };
            return result;
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
                        if (_Roles.RoleId > 0)
                        {
                            var role = await _ctxOra.TRoleSetups.FirstOrDefaultAsync(x => x.Roleid == _Roles.RoleId);
                            role.Rolename = _Roles.RoleName;
                            role.Remarks = _Roles.Remarks;
                            role.Isactive = Extension.BoolVal(_Roles.IsActive);
                            //Common
                            role.Updatepc = Extension.Createpc();
                            role.Updateby = param.LoggedUserId;
                            role.Updateon = Extension.Today;

                            message = MessageConstants.Updated;
                        }
                        else
                        {
                            var MaxID = _ctxOra.TRoleSetups.DefaultIfEmpty().Max(x => x == null ? 0 : x.Roleid) + 1;

                            var role = new TRoleSetup();
                            role.Roleid = MaxID;
                            role.Rolename = _Roles.RoleName;
                            role.Remarks = _Roles.Remarks;
                            role.Isactive = Extension.BoolVal(_Roles.IsActive);

                            //Common
                            role.Createpc = Extension.Createpc();
                            role.Createby = param.LoggedUserId;
                            role.Createon = Extension.Today;

                            await _ctxOra.TRoleSetups.AddAsync(role);
                            message = MessageConstants.Saved;
                        }

                        await _ctxOra.SaveChangesAsync();

                        _ctxOraTransaction.Commit();
                        resstate = MessageConstants.SuccessState;
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

        public async Task<object> SaveUpdateBak(vmRoles _Roles, vmCmnParameter param)
        {
            object result = null; string message = string.Empty; bool resstate = false;
            //OraGeneric_TRoleSetup = new TRoleSetup_EF();
            OraGeneric_vmCmnParameter = new GenericFactoryOracle<vmCmnParameter>();
            DBService<TRoleSetup> dbs = new DBService<TRoleSetup>();
            try
            {
                if (_Roles.RoleId > 0)
                {
                    string query = "SELECT * FROM T_ROLE_SETUP WHERE ROLEID=" + _Roles.RoleId;
                    TRoleSetup rol = await dbs.GetSingleRow(query);
                    //string query = "SELECT * FROM T_ROLE_SETUP WHERE ROLEID=" + _Roles.RoleId;                            
                    //query = await OraGeneric_vmCmnParameter.GetByQueryJsonString(query, StaticInfos.conStringOracle);
                    //TRoleSetup role=JsonConvert.DeserializeObject<List<TRoleSetup>>(query).FirstOrDefault();

                    //var rol = OraGeneric_TRoleSetup.GetById(x => x.Roleid == _Roles.RoleId);
                    var role = await _ctxOra.TRoleSetups.FirstOrDefaultAsync(x => x.Roleid == _Roles.RoleId);
                    role.Rolename = _Roles.RoleName;
                    role.Remarks = _Roles.Remarks;
                    role.Isactive = Extension.BoolVal(_Roles.IsActive);
                    //Common
                    role.Updatepc = Extension.Createpc();
                    role.Updateby = param.LoggedUserId;
                    role.Updateon = Extension.Today;

                    message = MessageConstants.Updated;
                }
                else
                {
                    var MaxID = _ctxOra.TRoleSetups.DefaultIfEmpty().Max(x => x == null ? 0 : x.Roleid) + 1;

                    var role = new TRoleSetup();
                    role.Roleid = MaxID;
                    role.Rolename = _Roles.RoleName;
                    role.Remarks = _Roles.Remarks;
                    role.Isactive = Extension.BoolVal(_Roles.IsActive);

                    //Common
                    role.Createpc = Extension.Createpc();
                    role.Createby = param.LoggedUserId;
                    role.Createon = Extension.Today;

                    await _ctxOra.TRoleSetups.AddAsync(role);
                    message = MessageConstants.Saved;
                }

                resstate = MessageConstants.SuccessState;
            }
            catch (Exception ex)
            {
                message = MessageConstants.SavedWarning;
                resstate = MessageConstants.ErrorState;
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
                            var delmodel = await _ctxOra.TRoleSetups.Where(x => x.Roleid == param.id).FirstOrDefaultAsync();
                            delmodel.Isdelete = Extension.BoolVal(true);
                            delmodel.Deletelpc = Extension.Createpc();
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
