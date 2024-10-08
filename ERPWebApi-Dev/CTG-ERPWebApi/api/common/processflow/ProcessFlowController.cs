using DataFactories.Infrastructure.common.processflow;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Business;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTG_ERPWebApi.api.common.processflow
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class processFlowController : ControllerBase
    {
        #region Variable Declaration & Initialization
        private ProcessFlowMgt _manager = null;
        #endregion

        #region Constructor
        public processFlowController()
        {
            _manager = new ProcessFlowMgt();
        }
        #endregion

        #region All Http Methods
        // GET: api/ProcessFlow/getbypage
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getbypage([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetListByhPage(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/ProcessFlow/getbyid
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetByID(cmnParam.strId);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/ProcessFlow/getbyid
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getprocessflowstepsbycategoryid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetProcessFlowStepsByCategoryId(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // POST: api/ProcessFlow/saveupdate
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatebak([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string JsonData_Mstr = data[1].ToString();
                string JsonData_Dtl = data[2].ToString();


                if (!string.IsNullOrEmpty(JsonData_Mstr) && !string.IsNullOrEmpty(JsonData_Dtl))
                {
                    resdata = await _manager.SaveUpdate(JsonData_Mstr, JsonData_Dtl, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/ProcessFlow/saveupdate
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdate([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                vmProcessFlow master = JsonConvert.DeserializeObject<vmProcessFlow>(data[1].ToString());
                List<vmProcessFlowDetail> detail = JsonConvert.DeserializeObject<List<vmProcessFlowDetail>>(data[2].ToString());

                if (master != null && detail.Count > 0)
                {
                    resdata = await _manager.SaveUpdate(cparam, master, detail);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/ProcessFlow/gotoproceednext
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> gotoproceednext([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.ProceedFirstForwardToNext(cparam);
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/ProcessFlow/processforwardonly
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> processforwardonly([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                vmProcessTransaction vTrn = JsonConvert.DeserializeObject<vmProcessTransaction>(data[1].ToString());
                resdata = await _manager.ProcessForwardOnly(cparam, vTrn);
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/ProcessFlow/processforwardonly
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> processbackwardonly([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                vmProcessTransaction vTrn = JsonConvert.DeserializeObject<vmProcessTransaction>(data[1].ToString());
                resdata = await _manager.ProcessBackwardOnly(cparam, vTrn);
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // GET: api/ProcessFlow/getbyid
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getapprovalcomments([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetApprovalComments(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/ProcessFlow/getapprovalcommentsbyloggeduser
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getapprovalcommentsbyloggeduser([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetApprovalCommentsByLoggedUser(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // DELETE: api/ProcessFlow/delete
        [HttpDelete("[action]")]//BasicAuthorization
        public async Task<object> delete([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.DeleteByID(cparam);
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
