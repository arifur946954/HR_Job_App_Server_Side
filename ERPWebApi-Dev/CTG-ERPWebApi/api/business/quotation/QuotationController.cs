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
    public class quotationController : ControllerBase
    {
        private IWebHostEnvironment _hostingEnvironment;

        #region Variable Declaration & Initialization
        private QuotationMgt _manager = null;
        private BusinessSetupMgt _srvManager = null;
        #endregion

        #region Constructor
        public quotationController(IWebHostEnvironment hostingEnvironment)
        {
            _manager = new QuotationMgt();
            _srvManager = new BusinessSetupMgt();
            _hostingEnvironment = hostingEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        #endregion

        #region All Http Methods
        // GET: api/quotation/getbypage
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

        // GET: api/quotation/getbyid
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
                ////Parameter Section if have has
                //List<vmReportParameters> repParam=JsonConvert.DeserializeObject<List<vmReportParameters>>(data[3].ToString());
                //rptm.ParameterList = repParam;
                ////Parameter Section if have has
                resdata = await _manager.GetRegularReport(rptm, cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdate
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

        //// DELETE: api/quotation/delete
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
        #endregion

        #region service head group
        // POST: api/quotation/saveupdatesrvheadgroup
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatesrvheadgroup([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateServiceHeadGroup(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }
        #endregion service head group
        #region service head
        // POST: api/quotation/saveupdatesrvhead
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatesrvhead([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateServiceHead(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdatemediabroadcast
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatemediabroadcast([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateMediaBroadcast(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdatemediaprogram
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatemediaprogram([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateMediaProgram(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdateprintmediapublisher
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdateprintmediapublisher([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdatePrintMediaPublisher(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdateprintmediasupplement
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdateprintmediasupplement([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdatePrintMediaSupplement(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdateprintmediaplacement
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdateprintmediaplacement([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdatePrintMediaPlacement(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdatemediagenre
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatemediagenre([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateMediaGenre(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdatemediaadposition
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatemediaadposition([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateMediaAdPosition(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdatemediaday
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatemediaday([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateMediaDay(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdatemediadaypart
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatemediadaypart([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateMediaDayPart(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdatemediasponsor
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatemediasponsor([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateMediaSponsor(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdatemediasponsoredproject
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatemediasponsoredproject([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateMediaSponsoredProject(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdateplatform
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdateplatform([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdatePlatform(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdateparameter
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdateparameter([FromBody] object[] data)
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

        // POST: api/quotation/saveupdateparametertask
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdateparametertask([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateParameterTask(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdatemetrics
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdatemetrics([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateMetrics(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // POST: api/quotation/saveupdateassettype
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdateassettype([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string mstr = data[1].ToString();
                if (mstr != null)
                {
                    resdata = await _manager.SaveUpdateAssetType(mstr, cparam);
                }
            }
            catch (Exception) { }

            return result = new
            {
                resdata
            };
        }

        // GET: api/quotation/getserviceheadbyheadgroupandcategoryid
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getserviceheadbyheadgroupandcategoryid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                resdata = await _srvManager.GetServiceHeadByHeadGroupAndCategoryID(cmnParam.strId, cmnParam.strId2);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        //// GET: api/quotation/geregularreport
        //[HttpPost("[action]")]//BasicAuthorization
        //public async Task<object> getregularreports([FromBody] object[] data)
        //{
        //    object result = null; object resdata = null; dynamic resdt = null; bool resstate = false;
        //    try
        //    {
        //        vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[2].ToString());
        //        dynamic cparam = JsonConvert.DeserializeObject(data[0].ToString());
        //        string filePath = _hostingEnvironment.WebRootPath + cparam.reportPath;
        //        string repType = cparam.reportType;

        //        dynamic dtList = await _manager.GetRegularReports(filePath, repType, cmnParam);
                
        //        var tblList = Extension.GetDynamicValue(dtList, "listDataTable");
        //        resdata = ReportViewer.Report(tblList, string.Empty, filePath, repType);
                
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }
        //    return result = new
        //    {
        //        resdata,
        //    };
        //}

        #endregion service head
    }
}
