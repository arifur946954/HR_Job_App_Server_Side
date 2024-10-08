using DataFactories.Infrastructure.business.businessconfigure;
using DataFactories.Infrastructure.business.quotation;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Business;
using DataModel.ViewModels.ERPViewModel.Common;
using DataUtility;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
//using Microsoft.ReportingServices.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTG_ERPWebApi.api.business.quotation
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class quotationsController : ControllerBase
    {
        private IWebHostEnvironment _hostingEnvironment;

        #region Variable Declaration & Initialization
        private QuotationsMgt _manager = null;
        private BusinessSetupMgt _srvManager = null;
        #endregion

        #region Constructor
        public quotationsController(IWebHostEnvironment hostingEnvironment)
        {
            _manager = new QuotationsMgt();
            _srvManager = new BusinessSetupMgt();
            _hostingEnvironment = hostingEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        #endregion

        #region All Http Methods
        // GET: api/quotations/getbypage
        [HttpGet("[action]")]//BasicAuthorization
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

        // GET: api/quotations/getbypage
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getbypagetest([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetWithPaginationTest(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }






        // GET: api/quotations/getbyid
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





        // POST: api/quotations/saveupdate
     /*   [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdates([FromBody] object[] data)
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
        }*/







        // POST: api/quotations/saveupdate
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveup([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string JsonData_Mstr = data[1].ToString();
                //string JsonData_Dtl = data[2].ToString();
                string JsonData_TCN = string.Empty;
                //JsonData_TCN = data[3].ToString();
                //List<vmTermsCondition> vTCList = JsonConvert.DeserializeObject<List<vmTermsCondition>>(data[3].ToString());
                //var nTCList = vTCList.Where(x => string.IsNullOrEmpty(x.tcOid)).ToList();
           
              
                    //JsonData_TCN = data[3].ToString();
               

                if (!string.IsNullOrEmpty(JsonData_Mstr) )
                {
                    resdata = await _manager.SaveUpdate(JsonData_Mstr, JsonData_TCN, cparam);
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




















            // GET: api/quotation/getquotationreference
            [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getquotationreference([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _manager.GetQuotationReference(cparam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }



        // GET: api/quotation/geregularreport
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> getregularreport([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                //dynamic data = JsonConvert.DeserializeObject(param);
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

        #endregion

    


    }
}
