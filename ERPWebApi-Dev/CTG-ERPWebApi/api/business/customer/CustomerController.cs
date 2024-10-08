using DataFactories.Infrastructure.business.customer;
//using DataModels.EntityModels.ERPModel;
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

namespace CTG_ERPWebApi.api.business.customer
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class customerController : ControllerBase
    {

        #region Variable Declaration & Initialization
        private CustomerMgt _manager = null;
        #endregion

        #region Constructor
        public customerController()
        {
            _manager = new CustomerMgt();
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
                resdata = await _manager.GetWithPagination(cmnParam);
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
                resdata = await _manager.GetByID((int)cmnParam.id);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        //// POST: api/customer/saveupdate
        //[HttpPost("[action]")]//BasicAuthorization
        //public async Task<object> saveupdate([FromBody]object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        vmCustomer _customer = JsonConvert.DeserializeObject<vmCustomer>(data[1].ToString());
        //        List<vmContactPerson> _listContact = JsonConvert.DeserializeObject<List<vmContactPerson>>(data[2].ToString());
        //        if (_customer != null)
        //        {
        //            resdata = await _manager.SaveUpdate(_customer, _listContact, cparam);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// DELETE: api/customer/delete
        //[HttpDelete("[action]")]//BasicAuthorization
        //public async Task<object> delete([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
        //        resdata = await _manager.Delete(cparam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        #endregion
    }
}
