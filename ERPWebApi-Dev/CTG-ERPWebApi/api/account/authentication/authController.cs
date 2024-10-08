using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataFactories.Infrastructure.account;
//using DataFactory.Infrastructure.messageservice;
using DataModel.ViewModels;
//using DataModels.ViewModels.ServicesViewModel.Portal.PaceNet;
using DataUtility;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CTG_ERPWebApi.api.account.authentication
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class authController : ControllerBase
    {
        #region Variable Declaration & Initialization
        private AuthUserMgt _manager = null;
        #endregion

        #region Constructor
        public authController(IConfiguration iConfig, IWebHostEnvironment hostingEnvironment)
        {
            _manager = new AuthUserMgt();
            //new emailmessageMgt(iConfig, hostingEnvironment.WebRootPath);
        }
        #endregion

        #region All Http Methods
        // POST: api/auth/loginusers
        //[HttpPost("[action]")]
        //public async Task<object> loginusers([FromBody]object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        //dynamic data = JsonConvert.DeserializeObject(param);
        //        //vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        //resdata = await _manager.LoginUsers(cmnParam);
        //        if (!string.IsNullOrEmpty(data[0].ToString()))
        //        {
        //            var cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //            if (cmnParam != null)
        //            {
        //                resdata = await _manager.LoginUsers(cmnParam);
        //            }
        //        }
        //    }
        //    catch (Exception) {

        //    }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// POST: api/auth/contactus
        //[HttpPost("[action]")]
        //public async Task<object> contactus([FromBody]object data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
                
        //        if (!string.IsNullOrEmpty(data.ToString()))
        //        {
        //            var vmContactUs = JsonConvert.DeserializeObject<VmContactUs>(data.ToString());
        //            if (vmContactUs != null)
        //            {
        //                resdata = await _manager.ContactUs(vmContactUs);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        // GET: api/auth/getstaticinfos
        [HttpGet("[action]"), BasicAuthorization]
        public async Task<object> getstaticinfos()
        {
            object result = null; object resdata = null;
            try
            {                
                resdata = new {
                    IsLive= StaticInfos.IsLive,
                    IsLiveSMS=StaticInfos.IsLiveSms,
                    IsLiveBkash=StaticInfos.IsLiveBkash
                };

                await Task.Yield();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/auth/GetClinetDt
        [HttpGet("[action]")]
        public async Task<object> GetClinetDt([FromQuery] double timezoneOffset)
        {
            object result = null; object resdata = null;
            try
            {
                resdata = new
                {
                    clientDatetime = Convert.ToDateTime("2021-06-20 08:00:00").AddMinutes(Math.Abs(timezoneOffset))
                };

                await Task.Yield();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/auth/SetClinetDt
        [HttpGet("[action]")]
        public async Task<object> SetClinetDt([FromQuery] double timezoneOffset, string datetime)
        {
            object result = null; object resdata = null;
            try
            {
                resdata = new
                {
                    serviceDatetime = Convert.ToDateTime(datetime).AddMinutes(timezoneOffset)
                };

                await Task.Yield();
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }
        #endregion

        //#region Test
        //// GET: api/auth/getstaticinfos
        //[HttpGet("[action]")]
        //public async Task<object> getcalenderinvoice(string id = null)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        resdata = await _manager.GetCalenderInvoice(id);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //#endregion
    }
}