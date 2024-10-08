//using DataFactory.Infrastructure.common.activitylog;
using DataFactories.Infrastructure.common.usersession;
//using DataModels.ViewModels.ErpLogViewModel;
//using DataModels.ViewModels.ServicesViewModel.Portal.Selfcare;
using DataUtility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CTG_ERPWebApi
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public sealed class BasicAuthorization : Attribute, IAuthorizationFilter
    {
        //private const string _authorizedToken = "AuthorizedToken";
        //private const string _userAgent = "User-Agent";
        //public ApiSecurityEntities _ctx = null;
        //public tokenModel objModel = null;

        public void OnAuthorization(AuthorizationFilterContext filterContext)
        {
            var controllerInfo = filterContext.ActionDescriptor as ControllerActionDescriptor;
            if (filterContext != null)
            {
                // http header values
                //var authorizedToken = filterContext.HttpContext.Request.Headers[StaticInfos.api_key].ToString();
                var userAgent = filterContext.HttpContext.Request.Headers[StaticInfos.userAgent_key].ToString();
                //string originAccess = string.Concat(authorizedToken.TakeWhile((c) => c != '-'));
                var userId = filterContext.HttpContext.Request.Headers[StaticInfos.userId_key].ToString();
                //var platformId = filterContext.HttpContext.Request.Headers[StaticInfos.platformId_key].ToString();

                // test user id
                StaticInfos.LoggedUserID = string.IsNullOrEmpty(userId) ? 0 : Convert.ToInt32(userId);

                //string authorizedToken = string.Empty;
                //string userAgent = string.Empty;
                string controllerName = controllerInfo.ControllerName;
                string actionName = controllerInfo.ActionName;

                //Check If Portal or Mobile
                //if (originAccess == "PNP") // Pace Net Portal
                //{
                //    if (!IsAuthorize(authorizedToken, userAgent, originAccess))
                //    {
                //        string message = "Unauthorize access.";
                //        object result = new { message };
                //        filterContext.Result = new ContentResult()
                //        {
                //            Content = Newtonsoft.Json.JsonConvert.SerializeObject(result),
                //            StatusCode = (int)HttpStatusCode.Unauthorized,
                //            ContentType = "application/json"
                //        };
                //    }
                //}
                //else if (originAccess == "PNM") // Pace Net Mobile
                //{
                //    if (!IsAuthorize(authorizedToken, userAgent, originAccess))
                //    {
                //        string message = "Unauthorize access.";
                //        object result = new { message };
                //        filterContext.Result = new ContentResult()
                //        {
                //            Content = Newtonsoft.Json.JsonConvert.SerializeObject(result),
                //            StatusCode = (int)HttpStatusCode.Unauthorized,
                //            ContentType = "application/json"
                //        };
                //    }
                //}
                //else
                //{
                //    if (!IsAuthorize(authorizedToken, userAgent))
                //    {
                //        string message = "Unauthorize access.";
                //        object result = new { message };
                //        filterContext.Result = new ContentResult()
                //        {
                //            Content = Newtonsoft.Json.JsonConvert.SerializeObject(result),
                //            StatusCode = (int)HttpStatusCode.Unauthorized,
                //            ContentType = "application/json"
                //        };
                //    }
                //}

                #region save at log database
                //// insert into dbRGLERPLog.activityLog
                //vmActivityLog model = new vmActivityLog();
                //model.IP = filterContext.HttpContext.Connection.RemoteIpAddress.ToString();
                //model.UserAgent = userAgent;
                //model.Controller = controllerName;
                //model.Action = actionName;
                //ActivityLogMgt _managerActivityLog = new ActivityLogMgt();
                //_managerActivityLog.SaveActivity(model);

                //// insert into dbRGLERPLog.cmnUserActivityLog
                //vmCmnUserActivityLog oVmCmnUserActivityLog = new vmCmnUserActivityLog();
                //oVmCmnUserActivityLog.UserActivityLogDetails = filterContext.HttpContext.Connection.RemoteIpAddress.ToString();
                //oVmCmnUserActivityLog.UserActivityLogType = userAgent;
                //oVmCmnUserActivityLog.UserActivityLogEvent = controllerName + "/" + actionName;
                //oVmCmnUserActivityLog.IP = filterContext.HttpContext.Connection.RemoteIpAddress.ToString();
                //oVmCmnUserActivityLog.UserAgent = userAgent;
                //oVmCmnUserActivityLog.Controller = controllerName;
                //oVmCmnUserActivityLog.Action = actionName;
                //oVmCmnUserActivityLog.UserId = string.IsNullOrEmpty(userId) ? 0 : Convert.ToInt32(userId);
                //oVmCmnUserActivityLog.PlatformId = string.IsNullOrEmpty(platformId) ? 0 : Convert.ToInt32(platformId);
                //CmnUserActivityLogMgt _managerCmnUserActivityLogMgt = new CmnUserActivityLogMgt();
                //_managerCmnUserActivityLogMgt.SaveActivity(oVmCmnUserActivityLog);
                #endregion
            }
        }

        private bool IsAuthorize(string authorizedToken, string userAgent)
        {
            bool result = false;
            try
            {
                //result = objAuth.ValidateToken(authorizedToken, userAgent);
                if (StaticInfos.api_secret == Conversions.Decryptdata(authorizedToken))
                    result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        //private bool IsAuthorize(string authorizedToken, string userAgent, string originAccess)
        //{
        //    bool result = false;
        //    try
        //    {
        //        string[] _authorizedToken = authorizedToken.Split('-');
        //        result = ValidateToken(_authorizedToken[1], _authorizedToken[2], userAgent, originAccess);
        //    }
        //    catch (Exception)
        //    {
        //        result = false;
        //    }
        //    return result;
        //}

        //public bool ValidateToken(string userid, string authorizedToken, string userAgent, string origin)
        //{
        //    bool result = false;
        //    try
        //    {
        //        var _usrSession = new UserSessionMgt();
        //        //compare token
        //        //string serverToken = generateToken(userid, userAgent);
        //        string serverToken = _usrSession.GetUserSession(userid, origin, userAgent);
        //        if (authorizedToken == serverToken)
        //        {
        //            //result = ValidateAuthorization(objModel.userid, objModel.methodtype);
        //            result = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        e.ToString();
        //    }
        //    return result;
        //}

        public string generateToken(string userid, string userAgent)
        {
            string message = string.Join(":", new string[] { userid, userAgent });
            string key = "RGLKey";

            var encoding = new ASCIIEncoding();

            byte[] keyByte = encoding.GetBytes(key);
            byte[] messageBytes = encoding.GetBytes(message);

            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }
    }
}
