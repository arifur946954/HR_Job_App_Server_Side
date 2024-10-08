using DataFactories.Infrastructure.common.documentupload;
using DataModel.JobEntityModel.JobOraModelTest;
using DataModel.ViewModels;
using DataModel.ViewModels.ERPViewModel.Business;
using DataUtility;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CTG_ERPWebApi.api.common.documentupload
{
    [Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
    [ApiController]
    public class documentUploadController : ControllerBase
    {
        #region Variable Declaration & Initialization
        private DocumentUploadMgt _manager = null;
        private IWebHostEnvironment _hostingEnvironment;
        #endregion

        #region Constructor
        public documentUploadController(IWebHostEnvironment hostingEnvironment)
        {
            _manager = new DocumentUploadMgt();
            _hostingEnvironment = hostingEnvironment;
        }
        #endregion

        #region All Http Methods
        // GET: api/documentUpload/getbypage
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getbypage([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                //resdata = await _manager.GetWithPagination(cmnParam);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }

        // GET: api/documentUpload/getbyid
        [HttpGet("[action]")]//BasicAuthorization
        public async Task<object> getbyid([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cmnParam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                //resdata = await _manager.GetByID((int)cmnParam.id);
            }
            catch (Exception) { }
            return result = new
            {
                resdata
            };
        }



     



        // POST: api/documentUpload/saveupdateform
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdateform()
        {
            object resdata = null;
            try
            {
                var req = Context.request;
                ////Value From Web
                //var allDocs = req.HttpContext.Request.Form.Files;
                ////var allDocs = Request.Form.Files;

                IFormCollection form;
                form = await req.HttpContext.Request.ReadFormAsync();
                var allDocs = form.Files;

                dynamic data = JsonConvert.DeserializeObject(form["data"]);
                List<vmCmnDocument> documentList = JsonConvert.DeserializeObject<List<vmCmnDocument>>(data[0].ToString());
                //Value From Web
                resdata = await _manager.SaveUpdateFiles(allDocs, documentList);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return new
            {
                resdata
            };
        }

        // DELETE: api/documentUpload/delete
        [HttpDelete("[action]")]//BasicAuthorization
        public async Task<object> delete([FromQuery] string param)
        {
            object result = null; object resdata = null;
            try
            {
                dynamic data = JsonConvert.DeserializeObject(param);
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                //resdata = await _manager.Delete(cparam);
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
