using DataFactories.Infrastructure.business.client;
using DataFactories.Infrastructure.business.register;

//using DataModels.EntityModels.ERPModel;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Business;
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

namespace CTG_ERPWebApi.api.business.register
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class RegisterController : ControllerBase
    {

        #region Variable Declaration & Initialization
        private RegisterMgt _manager = null;
        #endregion

        #region Constructor
        public RegisterController()
        {
            _manager = new RegisterMgt();
        }
        #endregion

        #region All Http Methods
      
        
       

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
                    resdata = await _manager.SaveUpdate(mstr, cparam);
                }
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
