using DataFactories.BaseFactory;
//using DataFactory.Infrastructure.hrm.employee;
//using DataModels.EntityModels.ERPModel;
using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Common;
//using DataModels.ViewModels.ERPViewModel.HRM.employee;
using DataUtility;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.common.users
{
    public class UserMgt
    {
        #region Variable declaration & initialization
        //dbRGLERPContext _ctx = null;
        ModelContext _ctxOra = null;
        Hashtable ht = null;
        OracleParameter[] oprm = null;
        OracleCommand ocmd = null;
        IGenericFactory<vmCmnParameters> Generic_vmCmnParameters = null;
        IGenericFactoryOracle<vmCmnParameters> OraGeneric_vmCmnParameters = null;
        IGenericFactoryOracle<Cmnuser> OraGeneric_Cmnuser = null;
        IGenericFactoryOracle<vmCmnuser> OraGeneric_vmCmnuser = null;
        IGenericFactoryEF<Cmnuser> Cmnuser_EF = null;
        #endregion

        #region All Methods
        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        /// 
        //public async Task<object> GetWithPage1(vmCmnParameters cmnParam)
        //{
        //    List<vmUser> listUser = new List<vmUser>();

        //    object result = null; int recordsTotal = 0;
        //    try
        //    {
        //        //join ut in _ctx.CmnUserType on u.UserTypeId equals ut.TypeId
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            var listUsers = await (from u in _ctx.CmnUser
        //                                   join r in _ctx.CmnUserRole on u.UserRoleId equals r.RoleId
        //                                   join ul in _ctx.CmnUserLogin on u.UserId equals ul.UserId
        //                                   where u.UserRoleId != StaticInfos.SeedRoleID
        //                                   select new vmUser
        //                                   {
        //                                       UserId = u.UserId,
        //                                       //FullName=(u.FrstName.Trim()+" "+u.MiddleName.Trim()+" ").Trim()+u.LastName.Trim(),
        //                                       FullName = u.FrstName.Trim() + " " + u.MiddleName.Trim() + " " + u.LastName.Trim(),
        //                                       FrstName = u.FrstName,
        //                                       MiddleName = u.MiddleName,
        //                                       LastName = u.LastName,
        //                                       Email = u.Email,
        //                                       MobileNo = u.MobileNo,
        //                                       IsActive = u.IsActive == null ? false : u.IsActive,
        //                                       UserTypeId = 0,
        //                                       TypeName = String.Empty,
        //                                       UserRoleId = r.RoleId,
        //                                       RoleName = r.RoleName,
        //                                       UserName = ul.UserName,
        //                                       Password = ul.UserPass
        //                                   }).ToListAsync();
        //            foreach (var item in listUsers)
        //            {
        //                var tdata = await _ctx.CmnUserWiseType.Where(x => x.UserId == item.UserId).ToListAsync();
        //                //TypeName
        //                item.TypeName = String.Join(",", tdata.Select(x => _ctx.CmnUserType.Find((int)x.UserTypeId).TypeName.Trim()));
        //                listUser.Add(item);
        //            }
        //            if (cmnParam.values != "" && cmnParam.values != null)
        //            {
        //                //listUser = listUser.Where(x => x.TypeName.Trim().ToLower() == cmnParam.values.Trim().ToLower()).ToList();
        //                listUser = listUser.Where(x => x.TypeName.Trim().ToLower().Contains(cmnParam.values.Trim().ToLower())).ToList();
        //            }
        //            recordsTotal = listUser.Count;
        //            //listUser = await _ctx.CmnUser.OrderByDescending(x => x.UserId).Skip(Conversions.Skip(cmnParam)).Take((int)cmnParam.pageSize).ToListAsync();
        //            //recordsTotal = await _ctx.CmnUser.CountAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }
        //    return result = new
        //    {
        //        listUser,
        //        recordsTotal
        //    };
        //}


        public async Task<object> GetWithPagination(vmCmnParameter param) //vmCmnParameters cmnParam
        {
            OraGeneric_vmCmnParameters = new GenericFactoryOracle<vmCmnParameters>();
            string listUser = string.Empty;
            object result = null;
            try
            {
                ht = new Hashtable
                {
                    { "cresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "PageNumber", (1, Convert.ToDecimal(param.pageNumber))},
                    { "PageSize", (2, Convert.ToDecimal(param.pageSize)) }
                };

                listUser = await OraGeneric_vmCmnParameters.ExecuteCommandString(StoredProcedure.Ora_SpGet_CmnUser, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return result = new
            {
                listUser
            };
        }


        public async Task<object> GetByID(int id)
        {
            object result = null; string oVmCmnUser = string.Empty;
            try
            {
                OraGeneric_vmCmnParameters = new GenericFactoryOracle<vmCmnParameters>();
                ht = new Hashtable
                {
                    { "UserID", id }
                };

                oVmCmnUser = await OraGeneric_vmCmnParameters.ExecuteCommandString(StoredProcedure.SpGet_cmnUserById, ht, StaticInfos.conString.ToString());
            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }

            return result = new
            {
                oVmCmnUser
            };

        }


        public async Task<object> GetEmployeeDetailByID(string EmployeeId)
        {
            OraGeneric_vmCmnParameters = new GenericFactoryOracle<vmCmnParameters>();
            string empDetail = string.Empty;
            try
            {
                ht = new Hashtable
                {
                    { "gresult", (0, OracleDbType.RefCursor, ParameterDirection.Output) },
                    { "gEmployeeId", (1, EmployeeId) }
                };

                empDetail = await OraGeneric_vmCmnParameters.ExecuteCommandString(StoredProcedure.Ora_SpGet_EmployeeById, ht, StaticInfos.conStringOracle.ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
                Logs.Bug(ex);
            }
            return new
            {
                empDetail
            };
        }



        //public async Task<object> GetByEmpID(int id)
        //{
        //    object result = null; string oVmCmnUser = string.Empty;
        //    try
        //    {
        //        OraGeneric_vmCmnParameters = new GenericFactoryOracle<vmCmnParameters>();
        //        ht = new Hashtable
        //        {
        //            { "UserID", id }
        //        };

        //        oVmCmnUser = await Generic_vmCmnParameters.ExecuteCommandString(StoredProcedure.SpGet_cmnEmpUserById, ht, StaticInfos.conString.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        oVmCmnUser
        //    };

        //}



        public async Task<object> SaveUpdate(string _JsonData, vmCmnParameter param)
        {
            string message = string.Empty; bool resstate = false;
            OraGeneric_vmCmnParameters = new GenericFactoryOracle<vmCmnParameters>();
            string result = string.Empty;
            try
            {
                ocmd = new OracleCommand();
                ocmd.Parameters.Add("mresult", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                ocmd.Parameters.Add("JsonData", OracleDbType.Clob).Value = _JsonData;
                ocmd.Parameters.Add("mCreateBy", OracleDbType.Varchar2).Value = param.LoggedUserId;
                ocmd.Parameters.Add("mCreatePC", OracleDbType.Varchar2).Value = Extension.Createpc();
                result = await OraGeneric_vmCmnParameters.ExecuteNonQueryOutString(StoredProcedure.Ora_SpSet_CmnUser, ocmd, "mresult", StaticInfos.conStringOracle.ToString());
               
                if (!string.IsNullOrEmpty(result) && result != "0")
                {
                    message = result == "-1" ? "User already exists!!!" : MessageConstants.Saved;
                    resstate = MessageConstants.SuccessState;
                }
                else
                {
                    message = MessageConstants.SavedWarning;
                }
            }
            catch (Exception ex)
            {
                Logs.Bug(ex);
            }
            return new
            {
                result,
                message,
                resstate
            };
        }


        //public async Task<object> CheckUserIfExist(string username)
        //{
        //    bool isExist = false; object result = null;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            isExist = await _ctx.CmnUserLogin.AnyAsync(x => x.UserName.Trim().ToLower() == username.Trim().ToLower());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        isExist
        //    };

        //}


        /// <summary>
        /// Both insert and update can perform by CmnUser model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        //public async Task<object> SaveUpdate(vmCmnUser model, List<CmnUserType> userTypeModel)
        //{
        //    object result = null; string message = string.Empty; bool resstate = false; int cmWiseUserid = 0;
        //    using (_ctx = new dbRGLERPContext())
        //    {
        //        model.UserPass = string.IsNullOrEmpty(model.UserPass) ? "12345" : model.UserPass;
        //        using (var _ctxTransaction = _ctx.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var data = await _ctx.CmnUserWiseType.Where(x => x.UserId == model.UserId).ToListAsync();
        //                if (data != null && data.Count > 0)
        //                {
        //                    _ctx.CmnUserWiseType.RemoveRange(data);

        //                }

        //                if (model.UserId > 0) // update
        //                {
        //                    cmWiseUserid = model.UserId;
        //                    var objUser = await _ctx.CmnUser.FirstOrDefaultAsync(x => x.UserId == model.UserId);
        //                    objUser.BusinessId = model.BusinessId;
        //                    objUser.ServiceId = model.ServiceId;
        //                    objUser.UserTypeId = model.UserTypeId;
        //                    objUser.UserRoleId = model.UserRoleId;
        //                    objUser.UserGroupId = model.UserGroupId;
        //                    objUser.FrstName = model.FrstName;
        //                    objUser.MiddleName = model.MiddleName;
        //                    objUser.LastName = model.LastName;
        //                    objUser.Gender = model.Gender;
        //                    objUser.Address1Present = model.Address1Present;
        //                    objUser.Address2Present = model.Address2Present;
        //                    objUser.Address1Permanent = model.Address1Permanent;
        //                    objUser.Address2Permanent = model.Address2Permanent;
        //                    objUser.Email = model.Email;
        //                    objUser.Country = model.Country;
        //                    objUser.State = model.State;
        //                    objUser.City = model.City;
        //                    objUser.Lat = model.Lat;
        //                    objUser.Long = model.Long;
        //                    objUser.MobileNo = model.MobileNo;
        //                    objUser.PhoneNo = model.PhoneNo;
        //                    objUser.IsAlertEmail = model.IsAlertEmail;
        //                    objUser.IsAlertSms = model.IsAlertSms;
        //                    objUser.IsActive = model.IsActive;
        //                    objUser.IsMobileAttend = model.IsMobileAttend;
        //                    objUser.CompanyId = model.CompanyId;
        //                    objUser.CreatedBy = StaticInfos.LoggedUserID;
        //                    objUser.CreateDate = Extension.UtcToday;

        //                    // update in cmnUserLogin
        //                    var objUserLogin = await _ctx.CmnUserLogin.FirstOrDefaultAsync(x => x.UserId == objUser.UserId);
        //                    if (objUserLogin != null)
        //                    {
        //                        objUserLogin.UserId = objUser.UserId;
        //                        objUserLogin.UserName = model.UserName;
        //                        objUserLogin.UserPass = model.UserPass;
        //                        objUserLogin.ActivationDate = objUser.CreateDate;
        //                        objUserLogin.IsLocked = false;
        //                        objUserLogin.IsActive = model.IsActive;

        //                        objUserLogin.CreatedBy = StaticInfos.LoggedUserID;
        //                        objUserLogin.CreateDate = Extension.UtcToday;
        //                    }

        //                }
        //                else // insert
        //                {
        //                    var MaxID = _ctx.CmnUser.DefaultIfEmpty().Max(x => x == null ? 0 : x.UserId) + 1;
        //                    var objUser = new CmnUser();
        //                    objUser.UserId = MaxID;
        //                    cmWiseUserid = MaxID;
        //                    //objUser.UserCode  = model.UserCode;
        //                    objUser.BusinessId = model.BusinessId;
        //                    objUser.ServiceId = model.ServiceId;
        //                    objUser.UserTypeId = model.UserTypeId;
        //                    objUser.UserRoleId = model.UserRoleId;
        //                    objUser.UserGroupId = model.UserGroupId;
        //                    objUser.FrstName = model.FrstName;
        //                    objUser.MiddleName = model.MiddleName;
        //                    objUser.LastName = model.LastName;
        //                    objUser.Gender = model.Gender;
        //                    objUser.Address1Present = model.Address1Present;
        //                    objUser.Address2Present = model.Address2Present;
        //                    objUser.Address1Permanent = model.Address1Permanent;
        //                    objUser.Address2Permanent = model.Address2Permanent;
        //                    objUser.Email = model.Email;
        //                    objUser.Country = model.Country;
        //                    objUser.State = model.State;
        //                    objUser.City = model.City;
        //                    objUser.Lat = model.Lat;
        //                    objUser.Long = model.Long;
        //                    objUser.MobileNo = model.MobileNo;
        //                    objUser.PhoneNo = model.PhoneNo;
        //                    objUser.IsAlertEmail = model.IsAlertEmail;
        //                    objUser.IsAlertSms = model.IsAlertSms;
        //                    objUser.IsMobileAttend = model.IsMobileAttend;

        //                    //Common
        //                    objUser.IsActive = StaticInfos.IsActive;
        //                    objUser.CompanyId = model.CompanyId;
        //                    objUser.CreatedBy = StaticInfos.LoggedUserID;
        //                    objUser.CreateDate = Extension.UtcToday;

        //                    CmnUserLogin usrLogin = SetUserLogin(objUser);
        //                    var loginMaxID = _ctx.CmnUserLogin.DefaultIfEmpty().Max(x => x == null ? 0 : x.LoginId) + 1;
        //                    usrLogin.LoginId = loginMaxID;
        //                    usrLogin.UserId = objUser.UserId;
        //                    //usrLogin.UserName = objUser.FrstName.ToLower() + "" + objUser.UserId;
        //                    //usrLogin.UserPass = "12345";
        //                    usrLogin.UserName = model.UserName;
        //                    usrLogin.UserPass = model.UserPass;
        //                    usrLogin.ActivationDate = objUser.CreateDate;
        //                    usrLogin.IsLocked = false;

        //                    usrLogin.IsActive = objUser.IsActive;
        //                    usrLogin.CompanyId = objUser.CompanyId;
        //                    usrLogin.CreatedBy = objUser.CreatedBy;
        //                    usrLogin.CreateDate = objUser.CreateDate;

        //                    await _ctx.CmnUser.AddAsync(objUser);

        //                    if (usrLogin != null)
        //                    {
        //                        await _ctx.CmnUserLogin.AddAsync(usrLogin);
        //                    }

        //                    model.UserId = objUser.UserId;
        //                }

        //                if (userTypeModel != null)
        //                {
        //                    int i = 0;
        //                    var tyaxID = _ctx.CmnUserWiseType.DefaultIfEmpty().Max(x => x == null ? 0 : x.Id) + 1;
        //                    foreach (var item in userTypeModel)
        //                    {
        //                        CmnUserWiseType cm = new CmnUserWiseType();
        //                        //var tdata = _ctx.CmnUserType.Where(x => x.TypeName.ToLower().Trim() == split[i].ToLower().Trim()).FirstOrDefault();
        //                        var tdata = _ctx.CmnUserType.Find(item.TypeId);
        //                        cm.Id = tyaxID + i;
        //                        cm.UserId = cmWiseUserid;
        //                        cm.UserTypeId = tdata.TypeId;
        //                        cm.CompanyId = model.CompanyId;
        //                        cm.IsActive = StaticInfos.IsActive;
        //                        cm.CreateDate = Extension.UtcToday;
        //                        cm.CreatedBy = StaticInfos.LoggedUserID;
        //                        _ctx.CmnUserWiseType.Add(cm);
        //                        i++;
        //                    }
        //                }

        //                await _ctx.SaveChangesAsync();

        //                _ctxTransaction.Commit();
        //                message = MessageConstants.Saved;
        //                resstate = MessageConstants.SuccessState;

        //                // set mobile attendance
        //                if (model.IsMobileAttend == true)
        //                {
        //                    await SetMobileAttendace(model);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxTransaction.Rollback();
        //                Logs.WriteBug(ex);
        //                message = MessageConstants.SavedWarning;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //        }
        //    }
        //    return result = new
        //    {
        //        message,
        //        resstate
        //    };
        //}

        //public async Task<object> SetMobileAttendace(vmCmnUser model)
        //{
        //    object result = null; string message = string.Empty; bool resstate = false;
        //    using (_ctx = new dbRGLERPContext())
        //    {
        //        using (var _ctxTransaction = _ctx.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var objHrmEmployee = await _ctx.HrmEmployee.FirstOrDefaultAsync(x => x.UserId == model.UserId);
        //                //HrmEmployeeMgt oHrmEmployeeMgt = new HrmEmployeeMgt();
        //                var oVmHrmAssociation = new vmHrmAssociation();
        //                oVmHrmAssociation.EmployeeId = objHrmEmployee == null ? 0 : objHrmEmployee.EmployeeId;
        //                oVmHrmAssociation.FirstName = model.FrstName;
        //                oVmHrmAssociation.LastName = string.IsNullOrEmpty(model.MiddleName) ? "" : " " + model.MiddleName + (string.IsNullOrEmpty(model.LastName) ? "" : " " + model.LastName);
        //                //oVmHrmAssociation.DateOfBirth = model.DateOfBirth;
        //                oVmHrmAssociation.ContactNumber = model.MobileNo;
        //                //oVmHrmAssociation.Nid = model.Nid;
        //                //oVmHrmAssociation.MaritalStatus = model.MaritalStatus;
        //                //oVmHrmAssociation.Gender = model.Gender;
        //                //oVmHrmAssociation.Age = model.Age;
        //                oVmHrmAssociation.Email = model.Email;
        //                //oVmHrmAssociation.Religion = model.Religion;
        //                //oVmHrmAssociation.Designation = model.Designation;
        //                //oVmHrmAssociation.Department = model.Department;
        //                //oVmHrmAssociation.LocationId = model.LocationId;
        //                oVmHrmAssociation.UserId = model.UserId;
        //                //oVmHrmAssociation.PayGrade = model.PayGrade;
        //                //oVmHrmAssociation.PresentAddress = model.PresentAddress;
        //                //oVmHrmAssociation.DateOfJoining = model.DateOfJoining;
        //                //oVmHrmAssociation.DateOfLeaving = model.DateOfLeaving;
        //                //oVmHrmAssociation.Dependents = model.Dependents;
        //                //oVmHrmAssociation.Education = MaxID;
        //                //oVmHrmAssociation.Experience = MaxID;
        //                //oVmHrmAssociation.Performance = MaxID;
        //                oVmHrmAssociation.ShiftId = model.ShiftId;
        //                oVmHrmAssociation.ShiftType = model.ShiftType;
        //                oVmHrmAssociation.ShiftCat = model.ShiftCat;
        //                oVmHrmAssociation.WeekDay = model.WeekDay;
        //                oVmHrmAssociation.IsLineManager = model.IsLineManager;
        //                oVmHrmAssociation.LineManagerId = model.LineManagerId;

        //                //await oHrmEmployeeMgt.SaveUpdate(oVmHrmAssociation); // will be set weekend with employee save

        //                if (objHrmEmployee == null)
        //                {
        //                    var objUser = await _ctx.CmnUser.FirstOrDefaultAsync(x => x.UserId == model.UserId);
        //                    objUser.IsMobileAttend = true;
        //                }

        //                await _ctx.SaveChangesAsync();

        //                _ctxTransaction.Commit();
        //                message = MessageConstants.Saved;
        //                resstate = MessageConstants.SuccessState;
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxTransaction.Rollback();
        //                Logs.WriteBug(ex);
        //                message = MessageConstants.SavedWarning;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //        }
        //    }
        //    return result = new
        //    {
        //        message,
        //        resstate
        //    };
        //}

        //public async Task<object> Save(CmnUser model)
        //{
        //    object result = null, usr = null; string message = string.Empty; bool resstate = false;
        //    using (_ctx = new dbRGLERPContext())
        //    {
        //        using (var _ctxTransaction = _ctx.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var MaxID = _ctx.CmnUser.DefaultIfEmpty().Max(x => x == null ? 0 : x.UserId) + 1;
        //                var objUser = new CmnUser();
        //                objUser.UserId = MaxID;
        //                //objUser.UserCode  = model.UserCode;
        //                objUser.BusinessId = model.BusinessId;
        //                objUser.ServiceId = model.ServiceId;
        //                objUser.UserTypeId = model.UserTypeId;
        //                objUser.UserRoleId = model.UserRoleId;
        //                objUser.UserGroupId = model.UserGroupId;
        //                objUser.FrstName = model.FrstName;
        //                objUser.MiddleName = model.MiddleName;
        //                objUser.LastName = model.LastName;
        //                objUser.Gender = model.Gender;
        //                objUser.Address1Present = model.Address1Present;
        //                objUser.Address2Present = model.Address2Present;
        //                objUser.Address1Permanent = model.Address1Permanent;
        //                objUser.Address2Permanent = model.Address2Permanent;
        //                objUser.Email = model.Email;
        //                objUser.Country = model.Country;
        //                objUser.State = model.State;
        //                objUser.City = model.City;
        //                objUser.Lat = model.Lat;
        //                objUser.Long = model.Long;
        //                objUser.MobileNo = model.MobileNo;
        //                objUser.PhoneNo = model.PhoneNo;
        //                objUser.IsAlertEmail = model.IsAlertEmail;
        //                objUser.IsAlertSms = model.IsAlertSms;

        //                //Common
        //                objUser.IsActive = StaticInfos.IsActive;
        //                objUser.CompanyId = StaticInfos.CompanyID;
        //                objUser.CreatedBy = StaticInfos.LoggedUserID;
        //                objUser.CreateDate = Extension.UtcToday;

        //                CmnUserLogin usrLogin = SetUserLogin(objUser);

        //                await _ctx.CmnUser.AddAsync(objUser);

        //                if (usrLogin != null)
        //                {
        //                    await _ctx.CmnUserLogin.AddAsync(usrLogin);
        //                }

        //                await _ctx.SaveChangesAsync();

        //                usr = await (from cu in _ctx.CmnUser
        //                             where cu.IsActive == true && cu.CompanyId == StaticInfos.CompanyID && cu.UserId == MaxID
        //                             select new
        //                             {
        //                                 cu.UserId,
        //                                 FullName = ((cu.FrstName + " " + cu.MiddleName).Trim() + " " + cu.LastName).Trim()
        //                             }).FirstOrDefaultAsync();

        //                _ctxTransaction.Commit();
        //                message = MessageConstants.Saved;
        //                resstate = MessageConstants.SuccessState;
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxTransaction.Rollback();
        //                //Logs.WriteBug(ex);
        //                message = MessageConstants.SavedWarning;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //        }
        //    }
        //    return result = new
        //    {
        //        message,
        //        resstate,
        //        usr
        //    };
        //}

        //private CmnUserLogin SetUserLogin(CmnUser cu)
        //{
        //    var cul = new CmnUserLogin();
        //    if (cu.UserId > 0) // update
        //    {

        //    }
        //    else // insert
        //    {

        //    }

        //    return cul;
        //}

        /// <summary>
        /// Delete can perform to CmnUserType table by int parameter in database using asynchronous operation. It returns an object as status of success or failure.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public async Task<object> Delete(int id)
        //{
        //    object result = null; string message = string.Empty; bool resstate = false;
        //    using (_ctx = new dbRGLERPContext())
        //    {
        //        using (var _ctxTran = await _ctx.Database.BeginTransactionAsync())
        //        {
        //            try
        //            {
        //                if (id > 0)
        //                {
        //                    var delmodel = await _ctx.CmnUser.Where(x => x.UserId == id).FirstOrDefaultAsync();
        //                    _ctx.CmnUser.Remove(delmodel);

        //                    var delModel = await _ctx.CmnUserLogin.Where(x => x.UserId == id).FirstOrDefaultAsync();
        //                    _ctx.CmnUserLogin.Remove(delModel);
        //                    var data = await _ctx.CmnUserWiseType.Where(x => x.UserId == id).ToListAsync();
        //                    if (data != null && data.Count > 0)
        //                    {
        //                        _ctx.CmnUserWiseType.RemoveRange(data);

        //                    }
        //                }

        //                await _ctx.SaveChangesAsync();
        //                _ctxTran.Commit();
        //                message = MessageConstants.Deleted;
        //                resstate = MessageConstants.SuccessState;
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxTran.Rollback();
        //                //Logs.WriteBug(ex);
        //                message = MessageConstants.DeletedWarning;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //        }
        //    }
        //    return result = new
        //    {
        //        message,
        //        resstate
        //    };
        //}

        //public async Task<object> ChangePassword(vmCmnParameters model)
        //{
        //    object result = null, usr = null; string message = string.Empty; bool resstate = false;
        //    using (_ctx = new dbRGLERPContext())
        //    {
        //        using (var _ctxTransaction = _ctx.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var oCmnUserLogin = await (from o in _ctx.CmnUserLogin where o.UserId == model.LoggedUserID select o).FirstOrDefaultAsync();
        //                if (oCmnUserLogin != null)
        //                {
        //                    oCmnUserLogin.UserPass = model.userPass;
        //                    oCmnUserLogin.CreatedBy = StaticInfos.LoggedUserID;
        //                    oCmnUserLogin.CreateDate = Extension.UtcToday;

        //                    await _ctx.SaveChangesAsync();
        //                }

        //                _ctxTransaction.Commit();
        //                message = MessageConstants.Saved;
        //                resstate = MessageConstants.SuccessState;
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxTransaction.Rollback();
        //                //Logs.WriteBug(ex);
        //                message = MessageConstants.SavedWarning;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //        }
        //    }
        //    return result = new
        //    {
        //        message,
        //        resstate,
        //        usr
        //    };
        //}

        //public async Task<object> TestInsertOracleDbCmnUser(vmCmnParameters param)
        //{
        //    object result = null; string message = string.Empty; bool resstate = false;
        //    using (_ctxOra = new ModelContext())
        //    {
        //        using (var _ctxOraTran = await _ctxOra.Database.BeginTransactionAsync())
        //        {
        //            try
        //            {
        //                var oraCmnUser = new Cmnuser();
        //                decimal MaxID = _ctxOra.Cmnuser.DefaultIfEmpty().Max(x => x == null ? 0 : x.Userid) + 1;
        //                oraCmnUser.Userid = MaxID;
        //                oraCmnUser.Firstname = param.Name;
        //                oraCmnUser.Lastname = param.values;
        //                oraCmnUser.Phone = param.phone;

        //                await _ctxOra.Cmnuser.AddAsync(oraCmnUser);
        //                await _ctxOra.SaveChangesAsync();
        //                _ctxOraTran.Commit();
        //                message = MessageConstants.Saved;
        //                resstate = MessageConstants.SuccessState;
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxOraTran.Rollback();
        //                Logs.WriteBug(ex);
        //                message = MessageConstants.DeletedWarning;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //        }
        //    }
        //    return result = new
        //    {
        //        message,
        //        resstate
        //    };
        //}

        public async Task<object> GetOraUser(vmCmnParameters param)
        {
            object result = null; int recordsTotal = 0; string listUser = string.Empty;
            try
            {
                OraGeneric_vmCmnParameters = new GenericFactoryOracle<vmCmnParameters>();
                OraGeneric_Cmnuser = new GenericFactoryOracle<Cmnuser>();
                OraGeneric_vmCmnuser = new GenericFactoryOracle<vmCmnuser>();
                //Cmnuser_EF = new CmnUser_EF();

                //var ModelById=await Cmnuser_EF.FindBy(x => x.Userid == param.id);
                //var ModelAll = await Cmnuser_EF.GetAllAsync();
                //var ModelIfExist = await Cmnuser_EF.HasData(x => x.Userid == param.id);

                //ht = new Hashtable
                //{
                //    { "p_cursor", (0,OracleDbType.RefCursor, ParameterDirection.Output) },
                //    { "USERID", (1,OracleDbType.Decimal, Convert.ToDecimal(param.id)) }
                //};

                //ocmd = new OracleCommand();
                //ocmd.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                //ocmd.Parameters.Add("USERID", OracleDbType.Decimal).Value = Convert.ToDecimal(param.id);

                //oprm = new OracleParameter[] {
                //    new OracleParameter{ ParameterName="p_cursor", OracleDbType=OracleDbType.RefCursor, Direction=ParameterDirection.Output },
                //    new OracleParameter{ ParameterName="USERID", OracleDbType=OracleDbType.Decimal, Value=Convert.ToDecimal(param.id) },
                //};                

                //oprm = new OracleParameter[] {
                //    new OracleParameter("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output ),
                //    new OracleParameter("USERID", Convert.ToDecimal(param.id) )
                //};

                //listUser = await OraGeneric_vmCmnParameters.ExecuteCommandString(StoredProcedure.SpGETORA_CMNUSER, ht, StaticInfos.conStringOracle.ToString());
                //listUser = await OraGeneric_vmCmnParameters.ExecuteCommandString(StoredProcedure.SpGETORA_CMNUSER, ocmd, StaticInfos.conStringOracle.ToString());
                //listUser = await OraGeneric_vmCmnParameters.ExecuteCommandString(StoredProcedure.SpGETORA_CMNUSER, oprm, StaticInfos.conStringOracle.ToString());

                string Query = "select * from cmnuser";
                ht = new Hashtable
                {
                    { "USERID", Convert.ToDecimal(param.id) }
                };

                listUser = await OraGeneric_vmCmnParameters.GetByQueryJsonString(Query, ht, StaticInfos.conStringOracle.ToString());

            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }

            return result = new
            {
                listUser,
                recordsTotal
            };
        }


        public class vmCmnuser
        {
            public decimal USERID { get; set; }
            public string FIRSTNAME { get; set; }
            public string LASTNAME { get; set; }
            public string PHONE { get; set; }
        }


        public async Task<object> VerifyUser(object data)
        {
            object result = null; object loggeduser = null, resdatas = null; string message = string.Empty; bool resstate = false;
            dynamic loggeddata = JObject.Parse(data.ToString());
            string userId = loggeddata.EmpID.ToString();
            string password = loggeddata.UserPassw.ToString();
            TSysUser SysUser = null;
            using (_ctxOra = new ModelContext())
            {
                SysUser = await _ctxOra.TSysUsers.Where(x => x.Userid.ToLower() == userId.Trim().ToLower() && x.Password == password).FirstOrDefaultAsync();                
            }

            if (SysUser != null)
            {
                using (_ctxOra = new ModelContext())
                {
                    loggeduser = await (from ur in _ctxOra.TUserRoles
                                        join r in _ctxOra.TRoleSetups on ur.RoleId equals r.Roleid
                                        where ur.UserId.ToLower() == userId.Trim().ToLower()
                                        select new
                                        {
                                            userId = ur.UserId,
                                            password = password,
                                            roleId = ur.RoleId,
                                            rolename = r.Rolename,
                                            displayName = SysUser.Username,
                                            fullName = SysUser.Fullname,
                                            //email=SysUser.Email,
                                            //designation=SysUser.Designation,
                                            //photo=SysUser.Photo,
                                            isSys = true
                                        }
                              ).FirstOrDefaultAsync();
                }

                message = MessageConstants.LoginSuccess;
                resstate = MessageConstants.SuccessState;
            }
            else
            {
                using (var httpClientHandler = new HttpClientHandler())
                {
                    httpClientHandler.ServerCertificateCustomValidationCallback = (messages, cert, chain, errors) => { return true; };
                    using (var objClient = new HttpClient(httpClientHandler))
                    {
                        var serializedPackage = JsonConvert.SerializeObject(loggeddata);
                        var content = new StringContent(serializedPackage, Encoding.UTF8, StaticInfos.contentTypeJson);
                        //objClient.DefaultRequestHeaders.TryAddWithoutValidation(StaticInfos.authorization, token);
                        using (HttpResponseMessage resapidata = await objClient.PostAsync(StaticInfos.loginUrl, content))
                        {
                            resdatas = resapidata.Content.ReadAsStringAsync().Result;
                            if (resapidata.IsSuccessStatusCode)
                            {
                                string resdata = JsonConvert.DeserializeObject(resdatas.ToString()).ToString();
                                string[] spdata = resdata.ToString().Split('~');

                                if (spdata[0] == "1")
                                {
                                    using (_ctxOra = new ModelContext())
                                    {
                                        loggeduser = await (from ur in _ctxOra.TUserRoles
                                                            join r in _ctxOra.TRoleSetups on ur.RoleId equals r.Roleid
                                                            where ur.UserId == userId
                                                            select new
                                                            {
                                                                userId = ur.UserId,
                                                                password = password,
                                                                roleId = ur.RoleId,
                                                                rolename = r.Rolename,
                                                                displayName = spdata[1],
                                                                fullName = spdata[1],
                                                                //email = string.Empty,
                                                                //designation = string.Empty,
                                                                //photo = string.Empty,
                                                                isSys = false
                                                            }
                                                  ).FirstOrDefaultAsync();
                                    }

                                    message = MessageConstants.LoginSuccess;
                                    resstate = MessageConstants.SuccessState;
                                }
                                else
                                {
                                    message = spdata[0].ToString();
                                    resstate = MessageConstants.ErrorState;
                                }
                            }
                            else
                            {
                                message = MessageConstants.LoginFailed;
                                resstate = MessageConstants.ErrorState;
                            }
                        }
                    }
                }
            }

            result = new
            {
                message,
                loggeduser,
                resstate
            };

            return result;
        }

        public async Task<object> LoggedUserDetails(vmCmnParameter param)
        {
            object result = null; string data = null; string Message = string.Empty; bool resstate = false;

            string getUrl = StaticInfos.loggedInfoUrl + param.UserID;

            if (param.IsTrue)
            {
                using (_ctxOra = new ModelContext())
                {
                    var dd = await (from su in _ctxOra.TSysUsers
                                    where su.Userid.ToLower() == param.UserID.Trim().ToLower()
                                    select new
                                    {
                                        EMP_OID = string.Empty,
                                        EMP_ID = su.Userid,
                                        EMP_NAME = su.Fullname,
                                        EMP_DSIG = su.Designation,
                                        LOC_OID = string.Empty, //null
                                        LOC_NAME = string.Empty, //null
                                        COMP_OID = string.Empty, //null
                                        COMP_NAME = "Corporate Head Office",
                                        DEPT_OID = string.Empty, //null
                                        DEPT_NAME = "IT Department",
                                        EMP_JOB_LOCATION = "Head Office",
                                        EMP_PHOTO = su.Photo,
                                        EMP_VALIDITY = string.Empty, //null
                                        EMP_JOIN_DATE = "2021-09-01T00:00:00",
                                        EMP_BIRTH_DATE = "1988-01-29T00:00:00",
                                        EMP_GRADE = "4A",
                                        EMP_BLOOD_GROUP = "A+",
                                        OFFICE_MAIL = "soft@citygroupbd.com",
                                        MOBILE_NO = string.Empty, //null
                                        LOS = 0.0,
                                        AGE = 0.0,
                                        SALARY = 0.0,
                                        IS_VOUCHER_PRINTED = string.Empty, //null
                                        LOS_CG = string.Empty, //null
                                        LOS_CP = string.Empty, //null
                                        LAST_YEAR_APPR_GRADE = string.Empty, //null
                                        LAST_YEAR_INCR_AMNT = 0.0,
                                        CURRENT_SALARY = 0.0,
                                        PROB_STATUS = string.Empty, //null
                                        LAST_YEAR_PROMOTION = string.Empty, //null
                                        INCR_GRAD = string.Empty, //null
                                        EDU = string.Empty, //null
                                        INCR_PRCT = 0.0,
                                        PROMO_PRCT = 0.0,
                                        INCR_MBCP = 0.0,
                                        PR_FLG = string.Empty, //null
                                        NEW_GRAD = string.Empty, //null
                                        NEW_DSIG_NAME = string.Empty, //null
                                        INCR_RMKS = string.Empty, //null
                                        INCR_AMNT = 0.0,
                                        BASIC = 0.0,
                                        HR = 0.0,
                                        OTHER = 0.0,
                                        CONS = 0.0,
                                        PRCNT_14 = 0.0,
                                        PRCNT_15 = 0.0,
                                        PRCNT_16 = 0.0,
                                        PRCNT_17 = 0.0,
                                        PRCNT_18 = 0.0,
                                        PRCNT_19 = 0.0,
                                        PRCNT_20 = 0.0,
                                        PRCNT_21 = 0.0,
                                        SAL_14 = 0.0,
                                        SAL_15 = 0.0,
                                        SAL_16 = 0.0,
                                        SAL_17 = 0.0,
                                        SAL_18 = 0.0,
                                        SAL_19 = 0.0,
                                        SAL_20 = 0.0,
                                        SAL_21 = 0.0,
                                        INCR_14 = 0.0,
                                        INCR_15 = 0.0,
                                        INCR_16 = 0.0,
                                        INCR_17 = 0.0,
                                        INCR_18 = 0.0,
                                        INCR_19 = 0.0,
                                        INCR_20 = 0.0,
                                        INCR_21 = 0.0,
                                        D_YR = 0.0,
                                        D_MN = 0.0,
                                        D_DAY = 0.0

                                    }
                              ).FirstOrDefaultAsync();

                    data = JsonConvert.SerializeObject(dd);
                    resstate = MessageConstants.SuccessState;
                }
            }
            else
            {
                using (var httpClientHandler = new HttpClientHandler())
                {
                    httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

                    using (var objClient = new HttpClient(httpClientHandler))
                    {
                        //objClient.DefaultRequestHeaders.TryAddWithoutValidation(StaticInfos.authorization, token);
                        using (var resapidata = await objClient.GetAsync(getUrl))
                        {
                            if (resapidata.IsSuccessStatusCode)
                            {
                                var jsonString = resapidata.Content.ReadAsStringAsync().Result;
                                data = jsonString;
                                resstate = MessageConstants.SuccessState;
                            }
                            else
                            {
                                //Message = resapidata.ToString();
                                resstate = MessageConstants.ErrorState;
                            }
                        }
                    }
                }
            }

            result = new
            {
                data,
                resstate
            };

            return result;
        }

        public async Task<object> UpdatePassword(vmCmnParameter param, object data)
        {
            object result = null; object resdatas = null; string message = string.Empty; bool resstate = false;
            var loggeddata = JsonConvert.DeserializeObject<dynamic>(data.ToString());
            string userId = loggeddata.EmpID.ToString();
            string passwordNew = loggeddata.UserPassw.ToString();
            string passwordPrev = loggeddata.UserPrevPass.ToString();
            try
            {
                if (param.IsSys)
                {
                    using (_ctxOra = new ModelContext())
                    {
                        var SysUser = await _ctxOra.TSysUsers.Where(x => x.Userid.ToLower() == userId.Trim().ToLower() && x.Password == passwordPrev).FirstOrDefaultAsync();
                        SysUser.Password = passwordNew;
                        await _ctxOra.SaveChangesAsync();

                        message = MessageConstants.PasswordChangeSuccess;
                        resstate = MessageConstants.SuccessState;
                    }
                }
                else
                {
                    using (var httpClientHandler = new HttpClientHandler())
                    {
                        httpClientHandler.ServerCertificateCustomValidationCallback = (messages, cert, chain, errors) => { return true; };
                        using (var objClient = new HttpClient(httpClientHandler))
                        {
                            var serializedPackage = JsonConvert.SerializeObject(data);
                            var content = new StringContent(serializedPackage, Encoding.UTF8, StaticInfos.contentTypeJson);
                            //objClient.DefaultRequestHeaders.TryAddWithoutValidation(StaticInfos.authorization, token);
                            using (HttpResponseMessage resapidata = await objClient.PostAsync(StaticInfos.passUpdateUrl, content))
                            {
                                resdatas = resapidata.Content.ReadAsStringAsync().Result;
                                if (resapidata.IsSuccessStatusCode)
                                {
                                    string resdata = JsonConvert.DeserializeObject(resdatas.ToString()).ToString();

                                    if (resdata == "1")
                                    {
                                        message = MessageConstants.PasswordChangeSuccess;
                                        resstate = MessageConstants.SuccessState;
                                    }
                                    else
                                    {
                                        message = MessageConstants.PasswordResetFailed;
                                        resstate = MessageConstants.ErrorState;
                                    }
                                }
                                else
                                {
                                    message = MessageConstants.PasswordResetFailed;
                                    resstate = MessageConstants.ErrorState;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                message = MessageConstants.PasswordResetFailed;
                resstate = MessageConstants.ErrorState;
            }


            result = new
            {
                message,
                resstate
            };

            return result;
        }
        #endregion
    }
}
