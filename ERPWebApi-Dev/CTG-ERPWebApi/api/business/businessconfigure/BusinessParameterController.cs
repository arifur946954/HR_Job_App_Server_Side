using DataFactories.Infrastructure.business.businessconfigure;
using DataModel.ViewModels;
using DataUtility;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CTG_ERPWebApi.api.business.businessconfigure
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class BusinessParameterController : ControllerBase
    {

        #region Variable Declaration & Initialization
        private BusinessSetupMgt _manager = null;
        #endregion

        #region Constructor
        public BusinessParameterController()
        {
            _manager = new BusinessSetupMgt();
        }
        #endregion

        #region All Http Methods
        // GET: api/customer/getbypage
        [HttpGet("[action]")]//, BasicAuthorization
        public async Task<object> getbypage([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetParameterWithPage(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }
        
        // GET: api/customer/getbyid
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getbyid([FromQuery] string param)
        {
            //var remoteIpAddress = HttpContext.Connection.RemoteIpAddress;
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetParameterByID(cmnParam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // POST: api/customer/saveupdate
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdate([FromBody]object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateParameter(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // DELETE: api/customer/delete
        [HttpDelete("[action]")]//BasicAuthorization
        public async Task<object> delete([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.DeleteParameter(cparam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }
        #endregion
    }
}
