//using DataFactory.Infrastructure.common.modules;
//using DataModels.EntityModels.ERPModel;
using DataModel.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CTG_ERPWebApi.api.common.modules
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class moduleController : ControllerBase
    {
        #region Variable Declaration & Initialization
        //private ModuleMgt _manager = null;
        #endregion

        #region Constructor
        public moduleController()
        {
           // _manager = new ModuleMgt();
        }
        #endregion

        #region All Http Methods
        // GET: api/module/getbypage
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getbypage([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetWithPagination(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> GetSalesTeamId([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetSalesTeamID(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> GetSalesTeamAll([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        //dynamic data = JsonConvert.DeserializeObject(param);
        //        //vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetSalesTeamAll();
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/module/getmodulebyuser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getmodulebyuser([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetModuleByUserID(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/module/getbyid
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getbyid([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetByID((int)cmnParam.ModuleID);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// POST: api/module/saveupdate
        //[HttpPost("[action]"), BasicAuthorization]
        //public async Task<object> saveupdate([FromBody]object[] data)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        vmModules _UserType = JsonConvert.DeserializeObject<vmModules>(data[0].ToString());
        //        if (_UserType != null)
        //        {
        //            resdata = await _manager.SaveUpdate(_UserType);
        //        }
        //    }
        //    catch (Exception) { }

        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// DELETE: api/module/delete
        //[HttpDelete("[action]"), BasicAuthorization]
        //public async Task<object> delete([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.Delete((int)cmnParam.ModuleID);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/module/getnotificationbyuser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getnotificationbyuser([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetNotificationByUser(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}
        //// GET: api/module/getAllNotificationCountByUser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getAllNotificationCountByUser([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.getAllNotificationCountByUser(cmnParam);
        //    }
        //    catch (Exception) { }
        //    return result = new
        //    {
        //        resdata
        //    };
        //}

        //// GET: api/module/getNotificationCommonbyUser
        //[HttpGet("[action]"), BasicAuthorization]
        //public async Task<object> getNotificationCommonbyUser([FromQuery] string param)
        //{
        //    object result = null; object resdata = null;
        //    try
        //    {
        //        dynamic data = JsonConvert.DeserializeObject(param);
        //        vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
        //        resdata = await _manager.GetNotificationCommonByUser(cmnParam);
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