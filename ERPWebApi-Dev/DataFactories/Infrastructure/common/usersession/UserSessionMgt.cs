using DataFactories.Infrastructure.services.httpservice;
//using DataModels.EntityModels.ERPModel;
using DataModel.ViewModels;
//using DataModels.ViewModels.ErpLogViewModel;
using DataUtility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.common.usersession
{
    public class UserSessionMgt
    {
        #region Variable Declaration & Initialization
        //dbRGLERPContext _ctx = null;
        #endregion

        #region All Methods

        /// <summary>
        /// This method returns list of Cloud User Activity Log.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        //public string GetUserSession(string userid, string origin, string userAgent)
        //{
        //    string sessionToken = string.Empty;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            DateTime utcNow = Extension.UtcToday;
        //            //var sessionModel = _ctx.CmnUserSession.Where(x => x.UserId.ToString() == userid && x.Origin == origin && x.UserAgent==userAgent && x.SessionTimeOut >= utcNow && x.IsSignedIn == true).FirstOrDefault();// It will be applicabe
        //            var sessionModel = _ctx.CmnUserSession.Where(x => x.UserId.ToString() == userid && x.Origin == origin && x.UserAgent == userAgent && x.IsSignedIn == true).FirstOrDefault();
        //            if (sessionModel != null)
        //            {
        //                sessionToken = sessionModel.Token;
        //                sessionModel.SessionTime = utcNow;
        //                sessionModel.SessionTimeOut = utcNow.AddMinutes((int)sessionModel.TokenValidity);
        //                _ctx.SaveChanges();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //    }

        //    return sessionToken;
        //}

        /// <summary>
        /// CloudActivity
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        //public async Task<CmnUserSession> SetPutUserSession(string userid, string origin, string userAgent, int tokenValidity)
        //{
        //    CmnUserSession cusr = new CmnUserSession();
        //    string message = string.Empty;
        //    using (_ctx = new dbRGLERPContext())
        //    {
        //        using (var _ctxTransaction = _ctx.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                DateTime utcNow = Extension.UtcToday;
        //                var cu = await _ctx.CmnUserSession.Where(x => x.UserId.ToString() == userid && x.Origin == origin && x.UserAgent==userAgent).FirstOrDefaultAsync();
        //                if (cu != null)
        //                {
        //                    cu.TokenValidity = tokenValidity;
        //                    cu.SessionTime = utcNow;
        //                    cu.SessionTimeOut = utcNow.AddMinutes(tokenValidity);
        //                    cu.IsSignedIn = true;
        //                    cusr = cu;
        //                }
        //                else
        //                {
        //                    string token = string.Empty;
        //                    string tkmessage = string.Join(":", new string[] { userid, userAgent });
        //                    string key = "RGLKey";

        //                    var encoding = new ASCIIEncoding();
        //                    byte[] keyByte = encoding.GetBytes(key);
        //                    byte[] messageBytes = encoding.GetBytes(tkmessage);
        //                    using (var hmacsha256 = new HMACSHA256(keyByte))
        //                    {
        //                        byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
        //                        token = Convert.ToBase64String(hashmessage);
        //                    }
        //                    string tokenId = string.Join("-", new string[] { origin, userid });
        //                    string serverToken = string.Join("-", new string[] { tokenId, token });

        //                    cusr.UserId = Convert.ToInt32(userid);
        //                    cusr.TokenId = tokenId;
        //                    cusr.Token = token;
        //                    cusr.GenKey = key;
        //                    cusr.Origin = origin;
        //                    cusr.ServerToken = serverToken;
        //                    cusr.Portal = origin == "PNP" ? "Pace Net Portal" : origin == "PNM" ? "Pace Net Mobile" : origin == "PCP" ? "Pace Cloud Portal" : origin == "PCM" ? "Pace Cloud Mobile" : origin;
        //                    cusr.UserAgent = userAgent;
        //                    cusr.IsSignedIn = true;
        //                    cusr.SessionTime = utcNow;
        //                    cusr.SessionTimeOut = utcNow.AddMinutes(tokenValidity);
        //                    cusr.TokenValidity = tokenValidity;
        //                    cusr.CompanyId = StaticInfos.CompanyID;
        //                    cusr.CreateDate = utcNow;
        //                    cusr.CreatedBy = Convert.ToInt32(userid);
        //                    _ctx.CmnUserSession.Add(cusr);
        //                }

        //                await _ctx.SaveChangesAsync();
        //                _ctxTransaction.Commit();
        //            }
        //            catch (Exception ex)
        //            {
        //                _ctxTransaction.Rollback();
        //                //Logs.WriteBug(ex);
        //            }
        //        }
        //    }

        //    return cusr;
        //}

        //public async Task<object> LoggedOut(vmCmnParameters param, string userAgent)
        //{
        //    object result = null; string message = ""; bool resstate = false;
        //    try
        //    {
        //        using (_ctx = new dbRGLERPContext())
        //        {
        //            string[] _authorizedToken = param.values.Split('-');
        //            DateTime utcNow = Extension.UtcToday;
        //            var sessionModel = await _ctx.CmnUserSession.Where(x => x.UserId == param.UserID && x.Origin == _authorizedToken[0] && x.UserAgent==userAgent).FirstOrDefaultAsync();
        //            if (sessionModel != null)
        //            {
        //                sessionModel.SessionTime = utcNow;
        //                sessionModel.SessionTimeOut = utcNow;
        //                sessionModel.IsSignedIn = false;
        //                await _ctx.SaveChangesAsync();

        //                message = "Successfully Logged Out";
        //                resstate = MessageConstants.SuccessState;
        //            }
        //            else
        //            {
        //                message = "No Session Found";
        //                resstate = MessageConstants.ErrorState;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Logs.WriteBug(ex);
        //        message = MessageConstants.ErrorMessage;
        //        resstate = MessageConstants.ErrorState;
        //    }

        //    return result = new
        //    {
        //        resstate,
        //        message
        //    };
        //}
        #endregion
    }
}
