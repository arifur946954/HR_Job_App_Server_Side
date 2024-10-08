using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataFactory.Infrastructure.common.dashboard;
using DataModels.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CTG_ERPWebApi.api.common.dashboard
{
    [Route("api/cmn/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class dashboardController : ControllerBase
    {
        #region Variable Declaration & Initialization
        private DashboardMgt _manager = null;
        #endregion

        #region Constructor
        public dashboardController()
        {
            _manager = new DashboardMgt();
        }
        #endregion

        #region All Http Methods        
        // GET: api/cmn/dashboard/getdashboard
        [HttpGet("[action]"), BasicAuthorization]
        public async Task<object> getdashboard([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
                resdata = await _manager.GetDashboard(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/cmn/dashboard/getdashboardchart
        [HttpGet("[action]"), BasicAuthorization]
        public async Task<object> getdashboardchart([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameters cmnParam = JsonConvert.DeserializeObject<vmCmnParameters>(data[0].ToString());
                resdata = await _manager.GetDashboardChart(cmnParam);
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