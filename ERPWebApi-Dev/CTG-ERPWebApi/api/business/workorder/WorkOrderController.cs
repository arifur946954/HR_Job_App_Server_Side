using DataFactories.Infrastructure.business.businessconfigure;
using DataFactories.Infrastructure.business.workorder;
using DataModel.ViewModels.ERPViewModel.Business;
using DataModel.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DataModel.ViewModels.ERPViewModel.Common;

namespace CTG_ERPWebApi.api.business.workorder
{
   // [Route("api/[controller]")]
[Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
[ApiController]
public class WorkOrderController : ControllerBase
{
        private IWebHostEnvironment _hostingEnvironment;

        #region Variable Declaration & Initialization
        private WorkOrderMgt _manager = null;
        private BusinessSetupMgt _srvManager = null;
        #endregion

        #region Constructor
        public WorkOrderController(IWebHostEnvironment hostingEnvironment)
        {
            _manager = new WorkOrderMgt();
            _srvManager = new BusinessSetupMgt();
            _hostingEnvironment = hostingEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        #endregion


        // POST: api/workorder/saveupdate
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdate([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string JsonData_Mstr = data[1].ToString();
                string JsonData_Dtl = data[2].ToString();
                string JsonData_TCN = string.Empty;
                JsonData_TCN = data[3].ToString();
                List<vmTermsCondition> vTCList = JsonConvert.DeserializeObject<List<vmTermsCondition>>(data[3].ToString());
                var nTCList = vTCList.Where(x => string.IsNullOrEmpty(x.tcOid) && !string.IsNullOrEmpty(x.termsConditions)).ToList();
                if (nTCList.Count > 0)
                {
                    JsonData_TCN = await _manager.SaveUpdateTermsConditions(vTCList, cparam);
                }
                else
                {
                    JsonData_TCN = data[3].ToString();
                }

                if (!string.IsNullOrEmpty(JsonData_Mstr) && !string.IsNullOrEmpty(JsonData_Dtl))
                {
                    resdata = await _manager.SaveUpdate(JsonData_Mstr, JsonData_Dtl, JsonData_TCN, cparam);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return result = new
            {
                resdata
            };
        }



        // GET: api/workorder/getbypages
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getbypages([FromQuery] string param)
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

        // GET: api/workorder/getworkorderfreequotation
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getworkorderfreequotation([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetWorkOrderFreeQootatonWithPagination(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }




        // GET: api/workorder/getbyid
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetByID(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }


        // GET: api/workorder/getregularreport
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> getregularreport([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmReportModel rptm = new vmReportModel();
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[2].ToString());
                dynamic cparam = JsonConvert.DeserializeObject(data[0].ToString());
                rptm.ReportPath = _hostingEnvironment.WebRootPath + cparam.reportPath;
                rptm.RenderType = cparam.reportType;
                resdata = await _manager.GetRegularReport(rptm, cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/workorder/getWorkOrderreference
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getWorkOrderreference([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetWorkOrderReference(cparam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }


       







    }


}
