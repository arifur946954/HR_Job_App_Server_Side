using DataFactories.BaseFactory;
//using DataFactory.Infrastructure.messageservice;
//using DataModels.EntityModels.ERPModel;
using DataModel.ViewModels;
//using DataModels.ViewModels.ServicesViewModel.Portal.PaceNet;
using DataUtility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.account
{
    public class AuthUserMgt
    {
        //dbRGLERPContext _ctx = null;
        private IGenericFactory<vmLoggeduser> Generic_vmLoggeduser = null;
        //Hashtable ht = null;
        //private emailmessageMgt _emanager = null;

        #region Constructor
        //public AuthUserMgt()
        //{
        //    _emanager = new emailmessageMgt();
        //}
        #endregion

        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        //public async Task<object> LoginUsers(vmCmnParameters cmnParam)
        //{
        //    object result = null; vmLoggeduser loggeduser = null; string message = string.Empty, notificationList = string.Empty; bool resstate = false, isNotify = false; object employee = null;

        //    Generic_vmLoggeduser = new GenericFactory<vmLoggeduser>();
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            var ifUsernameExist = _ctx.CmnUserLogin.SingleOrDefault(x => x.UserName == cmnParam.userName && x.IsActive == true);
        //            if (ifUsernameExist == null)
        //            {
        //                message = MessageConstants.UsernameNotExist;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //            else if (ifUsernameExist.UserPass != cmnParam.userPass)
        //            {
        //                message = MessageConstants.PasswordWrong;
        //                resstate = MessageConstants.ErrorState;
        //            }
        //            else
        //            {
        //                loggeduser = await (from ua in _ctx.CmnUserLogin
        //                                    join ur in _ctx.CmnUser on ua.UserId equals ur.UserId
        //                                    join role in _ctx.CmnUserRole on ur.UserRoleId equals role.RoleId
        //                                    join co in _ctx.AppCompany.Where(x => x.IsActive == true) on ua.CompanyId equals co.CompanyId
        //                                    where ua.UserName == cmnParam.userName && ua.IsActive == true
        //                                    select new vmLoggeduser
        //                                    {
        //                                        UserID = ua.UserId,
        //                                        UserName = ua.UserName,
        //                                        UserType = ur.UserTypeId,
        //                                        RoleID = ur.UserRoleId,
        //                                        RoleName = role.RoleName,
        //                                        RoleCode = role.RoleCode,
        //                                        DisplayName = ua.UserName,
        //                                        CompanyID = ua.CompanyId,
        //                                        Email = ur.Email,
        //                                        CompanyName = co.CompanyName,
        //                                        CompanyLogo = co.Logo,
        //                                        ReportLogo = co.LogoReport,
        //                                        BusinessId = ur.BusinessId,
        //                                        FullName = ur.FrstName + " " + ur.MiddleName + " " + ur.LastName,
        //                                        processFlowTeamCode = IspProcessFlowUserInformation(ua.UserId).TeamCode
        //                                    }).FirstOrDefaultAsync();

        //                //var salteam = await _ctx.SalIspTeam.Where(x => x.CmnUserId == loggeduser.UserID).FirstOrDefaultAsync();
        //                //if (salteam != null)
        //                //{
        //                //    isNotify = true;
        //                //    //noticount = _ctx.CmnProcessFlowTransactionDetail.Where(x => x.TeamId == salteam.TeamId && x.IsApproved == false).Count();
        //                //    //ht = new Hashtable
        //                //    //{
        //                //    //    { "UserID", loggeduser.UserID }
        //                //    //   ,{ "UserTypeID", loggeduser.UserType }
        //                //    //   ,{ "RoleID", loggeduser.RoleID }
        //                //    //   ,{ "TeamID", salteam.TeamId }
        //                //    //   ,{ "CompanyID", StaticInfos.CompanyID }
        //                //    //};
        //                //    //notificationList = await Generic_vmLoggeduser.ExecuteCommandString(StoredProcedure.SpGet_IspProcessNotification, ht, StaticInfos.conString.ToString());
        //                //}
        //                var salteamDTl = await _ctx.SalIspTeamDetail.Where(x => x.UserId == loggeduser.UserID).FirstOrDefaultAsync();
        //                if (salteamDTl != null)
        //                {
        //                    isNotify = true;
        //                }

        //                // employee info
        //                employee = await (from e in _ctx.HrmEmployee
        //                                  where e.UserId == loggeduser.UserID
        //                                  select new
        //                                  {
        //                                      e.EmployeeId,
        //                                      e.LineManagerId,
        //                                      e.IsLineManager,
        //                                      e.UserId
        //                                  }).FirstOrDefaultAsync();
        //                // end of employee info

        //                resstate = MessageConstants.SuccessState;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return result = new
        //    {
        //        loggeduser,
        //        isNotify,
        //        message,
        //        resstate,
        //        employee
        //    };
        //}
        //public SalIspTeam IspProcessFlowUserInformation(int? userId)
        //{
        //    string teamName = string.Empty; SalIspTeam objsit = new SalIspTeam(); _ctx = new dbRGLERPContext();
        //    try
        //    {
        //        var objProcessFlowUserInfo = (from std in _ctx.SalIspTeamDetail
        //                                      join it in _ctx.SalIspTeam on std.TeamId equals it.TeamId
        //                                      join u in _ctx.CmnUser on std.UserId equals u.UserId

        //                                      where std.IsActive == true && std.UserId == userId
        //                                      select new
        //                                      {
        //                                          it.TeamCode
        //                                      }).FirstOrDefault();
        //        if (objProcessFlowUserInfo != null)
        //        {
        //            objsit.TeamCode = objProcessFlowUserInfo.TeamCode;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }
        //    return objsit;
        //}

        //public async Task<object> ContactUs(VmContactUs model)
        //{
        //    object result = null; string message = string.Empty; bool resstate = false;
        //    using (_ctx = new dbRGLERPContext())
        //    {
        //        using (var _ctxTransaction = _ctx.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                var maxId = _ctx.CrmIspContactUs.DefaultIfEmpty().Max(x => x == null ? 0 : x.ContactId) + 1;
        //                var oContactUs = new CrmIspContactUs();
        //                oContactUs.ContactId = maxId;
        //                oContactUs.FullName = model.fullName;
        //                oContactUs.Email = model.email;
        //                oContactUs.Phone = model.phone;
        //                oContactUs.Message = model.message;
        //                //Common
        //                oContactUs.IsActive = StaticInfos.IsActive;
        //                oContactUs.CompanyId = StaticInfos.CompanyID;
        //                oContactUs.CreateDate = Extension.UtcToday;

        //                await _ctx.CrmIspContactUs.AddAsync(oContactUs);
        //                await _ctx.SaveChangesAsync();
        //                _ctxTransaction.Commit();

        //                message = MessageConstants.Saved;
        //                resstate = MessageConstants.SuccessState;

        //                await _emanager.EmailToBackOfficeOnContactUs(oContactUs);
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

        //public async Task<object> GetCalenderInvoice(string id = null)
        //{
        //    object result = null; string message = string.Empty;
        //    var listUserInvoice = new List<dynamic>();
        //    using (_ctx = new dbRGLERPContext())
        //    {
        //        using (var _ctxTransaction = _ctx.Database.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted))
        //        {
        //            try
        //            {
        //                // ----------------------------------------------
        //                // ConnectionTypeId == 2 then CORPORATE
        //                var listIspUser = new List<CmnUserIsp>();
        //                if (string.IsNullOrEmpty(id))
        //                {
        //                    listIspUser = await (from u in _ctx.CmnUserIsp
        //                                         where u.ConnectionTypeId == 2 //&& !u.FirstName.Contains("test") 
        //                                         select u).ToListAsync();
        //                }
        //                else
        //                {
        //                    string[] ids = id.Split(',');
        //                    listIspUser = await (from u in _ctx.CmnUserIsp
        //                                         where u.ConnectionTypeId == 2 && ids.Contains(u.UserCode) //&& !u.FirstName.Contains("test")
        //                                         select u).ToListAsync();
        //                }

        //                List<int> userIDs = listIspUser.Select(s => s.UserId).ToList<int>();
        //                var listBizIspUserPackService = await (from ip in _ctx.BizIspUserPackService
        //                                                       where userIDs.Contains((int)ip.UserId) && ip.ParentPackServiceName!= "IP Telephony" && ip.IsMonthly != true
        //                                                       select ip).OrderBy(a => a.UserPackServiceId).ToListAsync();

        //                if (listBizIspUserPackService.Count > 0)
        //                {
        //                    var listBizIspUserPackServiceHistory = await (from ip in _ctx.BizIspUserPackServiceHistory
        //                                                                  where userIDs.Contains((int)ip.UserId) && ip.ParentPackServiceName != "IP Telephony" && ip.IsMonthly != true
        //                                                                  select ip).OrderBy(a => a.UserPackServiceChangeId).ToListAsync();

        //                    var listBilIspinvoiceParent = await (from ip in _ctx.BilIspinvoiceParent
        //                                                         where userIDs.Contains((int)ip.IspuserId)
        //                                                         select ip).OrderBy(a => a.IspinvoiceParentId).ToListAsync();
        //                    var listBilIspinvoice = await (from ip in _ctx.BilIspinvoice
        //                                                   where userIDs.Contains((int)ip.IspuserId)
        //                                                   select ip).OrderBy(a => a.IspinvoiceId).ToListAsync();

        //                    var listBilIsppayment = await (from ip in _ctx.BilIsppayment
        //                                                   where userIDs.Contains((int)ip.IspuserId)
        //                                                   select ip).OrderBy(a => a.IsppaymentId).ToListAsync();

        //                    var listBilIsppaymentDetail = await (from ip in _ctx.BilIsppaymentDetail
        //                                                         where userIDs.Contains((int)ip.IspuserId)
        //                                                         select ip).OrderBy(a => a.IsppaymentDetailId).ToListAsync();

        //                    foreach (var oIspUser in listIspUser)
        //                    {
        //                        var listInvoiceParent = (from ip in listBilIspinvoiceParent
        //                                                 where ip.IspuserId == oIspUser.UserId
        //                                                 select ip).OrderBy(a => a.IspinvoiceParentId).ToList();

        //                        var listInvoiceChild = (from ic in listBilIspinvoice
        //                                                where ic.IspuserId == oIspUser.UserId
        //                                                select ic).OrderBy(a => a.IspinvoiceId).ToList();

        //                        var listPackService = (from ip in listBizIspUserPackService
        //                                               where ip.UserId == oIspUser.UserId
        //                                               select ip).OrderBy(a => a.UserPackServiceId).ToList();

        //                        var listPackServiceHistry = (from ip in listBizIspUserPackServiceHistory
        //                                                     where ip.UserId == oIspUser.UserId
        //                                                     select ip).OrderBy(a => a.UserPackServiceChangeId).ToList();

        //                        var listPayment = (from ip in listBilIsppayment
        //                                           where ip.IspuserId == oIspUser.UserId
        //                                           select ip).OrderBy(a => a.IsppaymentId).ToList();

        //                        var listPaymentDetail = (from ip in listBilIsppaymentDetail
        //                                                 where ip.IspuserId == oIspUser.UserId
        //                                                 select ip).OrderBy(a => a.IsppaymentDetailId).ToList();

        //                        int i = 0;
        //                        var fromDate = new DateTime();
        //                        var toDate = new DateTime();
        //                        DateTime toDateOld = new DateTime();
        //                        DateTime firstFromDate = new DateTime();
        //                        foreach (var oIp in listInvoiceParent)
        //                        {
        //                            DateTime fromDateOld = (DateTime)oIp.FromDate;
        //                            toDateOld = (DateTime)oIp.ToDate;

        //                            fromDate = fromDateOld.AddHours(6); // convert to bd time
        //                            if (i == 0) // 1st invoice
        //                            {
        //                                // set FROM datetime
        //                                oIp.FromDate = new DateTime(fromDate.Year
        //                                    , fromDate.Month
        //                                    , fromDate.Day
        //                                    , 00, 00, 00);

        //                                firstFromDate = Convert.ToDateTime(oIp.FromDate);
        //                                // set TO datetime
        //                                oIp.ToDate = new DateTime(fromDate.Year
        //                                   , fromDate.Month
        //                                   , DateTime.DaysInMonth(fromDate.Year, fromDate.Month)
        //                                   , 23, 59, 59);
        //                                toDate = (DateTime)oIp.ToDate;

        //                                int daysInMonth = DateTime.DaysInMonth(toDate.Year, toDate.Month);

        //                                int j = 0;
        //                                decimal lastPayable = 0;
        //                                int histryInMonth = 0, loopCount = 0;
        //                                foreach (var o in listPackServiceHistry.Where(x => Convert.ToDateTime(x.ExpireDate).Date == toDateOld.Date))
        //                                {
        //                                    if (loopCount == 0)
        //                                    {
        //                                        histryInMonth = (from psh in listPackServiceHistry where Convert.ToDateTime(psh.ExpireDate).Date == toDateOld.Date select psh).Count();
        //                                        loopCount = histryInMonth;
        //                                    }

        //                                    if (histryInMonth == 1)
        //                                    {
        //                                        if (Convert.ToDateTime(o.ExpireDate).Date == toDateOld.Date)
        //                                        {
        //                                            o.ActiveDate = firstFromDate;
                                                    
        //                                            o.BillingStartDate = oIp.FromDate;
        //                                            o.BillingEndDate = oIp.ToDate;

        //                                            o.ServiceStartDate = oIp.FromDate;
        //                                            o.ServiceEndDate = oIp.ToDate;

        //                                            o.ExpireDate = oIp.ToDate;

        //                                            o.CreateDate = o.ServiceStartDate;

        //                                            int totalDays = toDate.Date.Subtract(fromDate.Date).Days + 1;
        //                                            o.OneDayPrice = Convert.ToDecimal(o.PackServicePrice) / daysInMonth;
        //                                            o.DurationPrice = Math.Round(Convert.ToDecimal(o.OneDayPrice * totalDays));
        //                                            o.PayablePackService = o.DurationPrice + o.PackServiceInstallCharge + o.PackServiceOthersCharge + o.IpPrice;
        //                                        }
        //                                    }
        //                                    else if (histryInMonth > 1)
        //                                    {
        //                                        if (Convert.ToDateTime(o.ExpireDate).Date == toDateOld.Date)
        //                                        {
        //                                            if (j == 0)
        //                                            {
        //                                                int dayCountTo = Convert.ToDateTime(o.ServiceEndDate).Subtract(Convert.ToDateTime(o.ServiceStartDate)).Days+1;

        //                                                o.ActiveDate = firstFromDate;

        //                                                o.BillingStartDate = oIp.FromDate;
        //                                                o.BillingEndDate = oIp.ToDate;

        //                                                o.ServiceStartDate = oIp.FromDate;
        //                                                o.ServiceEndDate = Convert.ToDateTime(o.ServiceStartDate).AddDays(dayCountTo);//oIp.ToDate;

        //                                                o.ExpireDate = oIp.ToDate;

        //                                                o.CreateDate = o.ServiceStartDate;

        //                                                int totalDays = Convert.ToDateTime(o.ServiceEndDate).Date.Subtract(Convert.ToDateTime(o.ServiceStartDate).Date).Days + 1;
        //                                                o.OneDayPrice = Convert.ToDecimal(o.PackServicePrice) / daysInMonth;
        //                                                o.DurationPrice = Math.Round(Convert.ToDecimal(o.OneDayPrice) * totalDays);
        //                                                o.PayablePackService = o.DurationPrice + o.PackServiceInstallCharge + o.PackServiceOthersCharge + o.IpPrice;
        //                                            }
        //                                            else
        //                                            {
        //                                                int dayCountFrom = Convert.ToDateTime(o.ServiceStartDate).Subtract(Convert.ToDateTime(o.BillingStartDate)).Days+1;
        //                                                int dayCountTo = Convert.ToDateTime(o.ServiceEndDate).Subtract(Convert.ToDateTime(o.ServiceStartDate)).Days;

        //                                                o.ActiveDate = firstFromDate;

        //                                                o.BillingStartDate = oIp.FromDate;
        //                                                o.BillingEndDate = oIp.ToDate;

        //                                                o.ServiceStartDate = Convert.ToDateTime(oIp.FromDate).AddDays(dayCountFrom);
        //                                                o.ServiceEndDate = Convert.ToDateTime(o.ServiceStartDate).AddDays(dayCountTo);//oIp.ToDate;

        //                                                o.ExpireDate = oIp.ToDate;

        //                                                o.CreateDate = o.ServiceStartDate;

        //                                                int totalDays = Convert.ToDateTime(o.ServiceEndDate).Date.Subtract(Convert.ToDateTime(o.ServiceStartDate).Date).Days + 1;
        //                                                o.OneDayPrice = Convert.ToDecimal(o.PackServicePrice) / daysInMonth;
        //                                                o.DurationPrice = Math.Round(Convert.ToDecimal(o.OneDayPrice) * totalDays);
        //                                                o.PayablePackService = o.DurationPrice + o.PackServiceInstallCharge + o.PackServiceOthersCharge + o.IpPrice;
        //                                            }

        //                                            j++;
        //                                        }
        //                                    }
        //                                    o.IsMonthly = true;

        //                                    if (histryInMonth > 1)
        //                                    {
        //                                        lastPayable += Convert.ToDecimal(o.PayablePackService);
        //                                    }
        //                                    else {
        //                                        lastPayable = Convert.ToDecimal(o.PayablePackService);
        //                                    }

        //                                    loopCount--;
        //                                }

        //                                foreach (var o in listInvoiceChild.Where(x => Convert.ToDateTime(x.ToDate).Date == toDateOld.Date))
        //                                {
        //                                    o.InvoiceTotal = lastPayable==0?o.InvoiceTotal:lastPayable;
        //                                    o.DueAmount = o.IsPaid == false ? o.InvoiceTotal : 0;
        //                                    o.FromDate = oIp.FromDate;
        //                                    o.ToDate = oIp.ToDate;

        //                                    foreach (var pd in listPaymentDetail.Where(x => x.InvoiceNo == o.IspinvoiceId))
        //                                    {
        //                                        pd.PaidAmount = o.InvoiceTotal;
        //                                    }
        //                                }
        //                            }
        //                            else // 2nd invoive
        //                            {
        //                                // set FROM datetime
        //                                DateTime dtFrom = toDate.AddDays(5);
        //                                fromDate = new DateTime(dtFrom.Year, dtFrom.Month, 1, 0, 0, 0);
        //                                oIp.FromDate = fromDate;

        //                                // set TO datetime
        //                                oIp.ToDate = new DateTime(fromDate.Year
        //                                   , fromDate.Month
        //                                   , DateTime.DaysInMonth(fromDate.Year, fromDate.Month)
        //                                   , 23, 59, 59);
        //                                toDate = (DateTime)oIp.ToDate;
        //                                int daysInMonth = DateTime.DaysInMonth(toDate.Year, toDate.Month);
        //                                int j = 0;
        //                                decimal lastPayable = 0;
        //                                int histryInMonth = 0, loopCount=0;
        //                                foreach (var o in listPackServiceHistry.Where(x => Convert.ToDateTime(x.ExpireDate).Date == toDateOld.Date))
        //                                {
        //                                    if (loopCount == 0)
        //                                    {
        //                                        histryInMonth = (from psh in listPackServiceHistry where Convert.ToDateTime(psh.ExpireDate).Date == toDateOld.Date select psh).Count();
        //                                        loopCount = histryInMonth;
        //                                    }

        //                                    if (histryInMonth == 1)
        //                                    {
        //                                        if (Convert.ToDateTime(o.ExpireDate).Date == toDateOld.Date)
        //                                        {
        //                                            o.ActiveDate = firstFromDate;

        //                                            o.BillingStartDate = oIp.FromDate;
        //                                            o.BillingEndDate = oIp.ToDate;

        //                                            o.ServiceStartDate = oIp.FromDate;
        //                                            o.ServiceEndDate = oIp.ToDate;

        //                                            o.ExpireDate = oIp.ToDate;

        //                                            o.CreateDate = o.ServiceStartDate;

        //                                            int totalDays = toDate.Date.Subtract(fromDate.Date).Days + 1;
        //                                            o.OneDayPrice = Convert.ToDecimal(o.PackServicePrice) / daysInMonth;
        //                                            o.DurationPrice = Math.Round(Convert.ToDecimal(o.OneDayPrice * totalDays));
        //                                            o.PayablePackService = o.DurationPrice + o.PackServiceInstallCharge + o.PackServiceOthersCharge + o.IpPrice;
        //                                        }                                                
        //                                    }
        //                                    else if (histryInMonth > 1)
        //                                    {
        //                                        if (Convert.ToDateTime(o.ExpireDate).Date == toDateOld.Date)
        //                                        {
        //                                            if (j == 0)
        //                                            {
        //                                                int dayCountTo = Convert.ToDateTime(o.ServiceEndDate).Subtract(Convert.ToDateTime(o.ServiceStartDate)).Days+1;

        //                                                o.ActiveDate = firstFromDate;

        //                                                o.BillingStartDate = oIp.FromDate;
        //                                                o.BillingEndDate = oIp.ToDate;

        //                                                o.ServiceStartDate = oIp.FromDate;
        //                                                o.ServiceEndDate = Convert.ToDateTime(o.ServiceStartDate).AddDays(dayCountTo);//oIp.ToDate;

        //                                                o.ExpireDate = oIp.ToDate;

        //                                                o.CreateDate = o.ServiceStartDate;

        //                                                int totalDays = Convert.ToDateTime(o.ServiceEndDate).Date.Subtract(Convert.ToDateTime(o.ServiceStartDate).Date).Days + 1;
        //                                                o.OneDayPrice = Convert.ToDecimal(o.PackServicePrice) / daysInMonth;
        //                                                o.DurationPrice = Math.Round(Convert.ToDecimal(o.OneDayPrice * totalDays));
        //                                                o.PayablePackService = o.DurationPrice + o.PackServiceInstallCharge + o.PackServiceOthersCharge + o.IpPrice;
        //                                            }
        //                                            else
        //                                            {
        //                                                int dayCountFrom = Convert.ToDateTime(o.ServiceStartDate).Subtract(Convert.ToDateTime(o.BillingStartDate)).Days+1;
        //                                                int dayCountTo = Convert.ToDateTime(o.ServiceEndDate).Subtract(Convert.ToDateTime(o.ServiceStartDate)).Days;

        //                                                o.ActiveDate = firstFromDate;

        //                                                o.BillingStartDate = oIp.FromDate;
        //                                                o.BillingEndDate = oIp.ToDate;

        //                                                o.ServiceStartDate = Convert.ToDateTime(oIp.FromDate).AddDays(dayCountFrom);
        //                                                o.ServiceEndDate = Convert.ToDateTime(o.ServiceStartDate).AddDays(dayCountTo);//oIp.ToDate;

        //                                                o.ExpireDate = oIp.ToDate;

        //                                                o.CreateDate = o.ServiceStartDate;

        //                                                int totalDays = Convert.ToDateTime(o.ServiceEndDate).Date.Subtract(Convert.ToDateTime(o.ServiceStartDate).Date).Days + 1;
        //                                                o.OneDayPrice = Convert.ToDecimal(o.PackServicePrice) / daysInMonth;
        //                                                o.DurationPrice = Math.Round(Convert.ToDecimal(o.OneDayPrice * totalDays));
        //                                                o.PayablePackService = o.DurationPrice + o.PackServiceInstallCharge + o.PackServiceOthersCharge + o.IpPrice;
        //                                            }

        //                                            j++;
        //                                        }
        //                                    }
        //                                    o.IsMonthly = true;

        //                                    if (histryInMonth > 1)
        //                                    {
        //                                        lastPayable += Convert.ToDecimal(o.PayablePackService);
        //                                    }
        //                                    else {
        //                                        lastPayable = Convert.ToDecimal(o.PayablePackService);
        //                                    }

        //                                    loopCount--;
        //                                }

        //                                foreach (var o in listInvoiceChild.Where(x => Convert.ToDateTime(x.ToDate).Date == toDateOld.Date))
        //                                {
        //                                    o.InvoiceTotal = lastPayable == 0 ? o.InvoiceTotal : lastPayable;
        //                                    o.DueAmount = o.IsPaid == false ? o.InvoiceTotal : 0;
        //                                    o.FromDate = oIp.FromDate;
        //                                    o.ToDate = oIp.ToDate;

        //                                    foreach (var pd in listPaymentDetail.Where(x => x.InvoiceNo == o.IspinvoiceId))
        //                                    {
        //                                        pd.PaidAmount = o.InvoiceTotal;
        //                                    }
        //                                }
        //                            }

        //                            oIp.InvoiceTotal = (from o in listInvoiceChild
        //                                                where Convert.ToDateTime(o.ToDate).Date == toDate.Date
        //                                                select o).Sum(s => s.InvoiceTotal);
        //                            oIp.DueAmount = (from o in listInvoiceChild
        //                                             where Convert.ToDateTime(o.ToDate).Date == toDate.Date
        //                                             select o).Sum(s => s.DueAmount);                                    

        //                            oIp.IsPaid = oIp.DueAmount == 0 ? true : false;                                    

        //                            i++;
        //                        }

        //                        // update payment master
        //                        foreach (var pd in listPayment)
        //                        {
        //                            pd.PaidAmount = listPaymentDetail.Sum(s => s.PaidAmount);
        //                        }

        //                        foreach (var o in listPackService.Where(x => x.UserId == oIspUser.IspuserId))
        //                        {
        //                            var oPsh = (from psh in listPackServiceHistry
        //                                        where psh.UserPackServiceId == o.UserPackServiceId && psh.UserId==o.UserId
        //                                        select psh).OrderByDescending(d => d.UserPackServiceChangeId).FirstOrDefault();
                                    
        //                            if (oPsh != null)
        //                            {
        //                                o.FirstActiveDate = firstFromDate;
        //                                o.ActiveDate = firstFromDate;
        //                                o.BillingStartDate = oPsh.BillingStartDate;
        //                                o.BillingEndDate = oPsh.ExpireDate;
        //                                o.ExpireDate = oPsh.ExpireDate;
        //                                o.CreateDate = oPsh.CreateDate;
        //                                o.PayablePackService = oPsh.PayablePackService;
        //                                o.IsMonthly = true;

        //                                if (o.PackServiceTypeId == 1) {

        //                                }
        //                            }
        //                        }

        //                        #region Final Update
        //                        if (listPackService.Where(x => x.IsMonthly == true).ToList().Count > 0)
        //                        {
        //                            foreach (var ups in listPackService.Where(x => x.IsMonthly == true).ToList())
        //                            {
        //                                ups.FirstActiveDate = Convert.ToDateTime(ups.FirstActiveDate).AddHours(-6);
        //                                ups.ActiveDate = Convert.ToDateTime(ups.ActiveDate).AddHours(-6);
        //                                ups.BillingStartDate = Convert.ToDateTime(ups.BillingStartDate).AddHours(-6);
        //                                ups.BillingEndDate = Convert.ToDateTime(ups.BillingEndDate).AddHours(-6);
        //                                ups.ExpireDate = Convert.ToDateTime(ups.ExpireDate).AddHours(-6);
        //                                ups.CreateDate = Convert.ToDateTime(ups.CreateDate).AddHours(-6);
        //                            }
        //                        }

        //                        if (listPackServiceHistry.Where(x => x.IsMonthly == true).ToList().Count > 0)
        //                        {
        //                            foreach (var upsh in listPackServiceHistry.Where(x => x.IsMonthly == true).ToList())
        //                            {
        //                                upsh.ActiveDate = Convert.ToDateTime(upsh.ActiveDate).AddHours(-6);
        //                                upsh.BillingStartDate = Convert.ToDateTime(upsh.BillingStartDate).AddHours(-6);
        //                                upsh.BillingEndDate = Convert.ToDateTime(upsh.BillingEndDate).AddHours(-6);
        //                                upsh.ExpireDate = Convert.ToDateTime(upsh.ExpireDate).AddHours(-6);
        //                                upsh.ServiceStartDate = Convert.ToDateTime(upsh.ServiceStartDate).AddHours(-6);
        //                                upsh.ServiceEndDate = Convert.ToDateTime(upsh.ServiceEndDate).AddHours(-6);
        //                                upsh.CreateDate = Convert.ToDateTime(upsh.CreateDate).AddHours(-6);
        //                            }
        //                        }

        //                        if (listInvoiceParent.Count > 0)
        //                        {
        //                            foreach (var invp in listInvoiceParent.ToList())
        //                            {
        //                                invp.FromDate = Convert.ToDateTime(invp.FromDate).AddHours(-6);
        //                                invp.InvoiceDate = invp.FromDate;
        //                                invp.ToDate = Convert.ToDateTime(invp.ToDate).AddHours(-6);
        //                                invp.DueDate = invp.ToDate;
        //                                invp.CreateDate = invp.FromDate;
        //                            }
        //                        }

        //                        if (listInvoiceChild.Count > 0)
        //                        {
        //                            foreach (var inv in listInvoiceChild.ToList())
        //                            {
        //                                inv.FromDate = Convert.ToDateTime(inv.FromDate).AddHours(-6);
        //                                inv.InvoiceDate = inv.FromDate;
        //                                inv.ToDate = Convert.ToDateTime(inv.ToDate).AddHours(-6);
        //                                inv.DueDate = inv.ToDate;
        //                                inv.CreateDate = inv.FromDate;
        //                            }
        //                        }
        //                        #endregion


        //                        //object userInvoice = new
        //                        //{
        //                        //    listInvoiceParent,
        //                        //    listInvoiceChild,
        //                        //    listPackService,
        //                        //    listPackServiceHistry,
        //                        //    listPayment,
        //                        //    listPaymentDetail
        //                        //};

        //                        //listUserInvoice.Add(userInvoice);
        //                    }

        //                    object userInvoice = new
        //                    {
        //                        listBilIspinvoiceParent,
        //                        listBilIspinvoice,
        //                        listBizIspUserPackService,
        //                        listBizIspUserPackServiceHistory,
        //                        listBilIsppayment,
        //                        listBilIsppaymentDetail
        //                    };

        //                    listUserInvoice.Add(userInvoice);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxTransaction.Rollback();
        //                Logs.WriteBug(ex);
        //                message = MessageConstants.SavedWarning;
        //            }
        //        }
        //    }

        //    return result = new
        //    {
        //        listUserInvoice
        //    };
        //}

    }
}
