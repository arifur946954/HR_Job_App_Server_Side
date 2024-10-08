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
using DataFactories.Infrastructure.business.reqform;
using DataModel.JobEntityModel.JobOraModelTest;
using System.DirectoryServices.Protocols;
using System.IO;
using Microsoft.CodeAnalysis;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace CTG_ERPWebApi.api.business.reqform
{
   // [Route("api/[controller]")]
[Route("api/[controller]"), Produces("application/json"), EnableCors("AppPolicy")]
[ApiController]
public class ReqFormController : ControllerBase
{



       
        private IWebHostEnvironment _hostingEnvironment;

        #region Variable Declaration & Initialization
        private ReqFormMgt _manager = null;
        private BusinessSetupMgt _srvManager = null;
        private ModelContext _ctxOr=null;
        #endregion

        #region Constructor
        public ReqFormController( IWebHostEnvironment hostingEnvironment)
        {
           
            _manager = new ReqFormMgt();
            _srvManager = new BusinessSetupMgt();
            _hostingEnvironment = hostingEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            _ctxOr = new ModelContext();
        }
        #endregion


        // POST: api/reqform/saveupdate
        [HttpPost("[action]")]//BasicAuthorization
        public async Task<object> saveupdate([FromBody] object[] data)
        {
            object result = null; object resdata = null;
            try
            {
                vmCmnParameter cparam = JsonConvert.DeserializeObject<vmCmnParameter>(data[0].ToString());
                string JsonData_Mstr = data[1].ToString();
                string JsonData_acQlf = data[2].ToString();
                string JsonData_experience = data[3].ToString();
          

                if (!string.IsNullOrEmpty(JsonData_Mstr) && !string.IsNullOrEmpty(JsonData_acQlf))
                {
                    resdata = await _manager.SaveUpdate(JsonData_Mstr, JsonData_acQlf, JsonData_experience, cparam);
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



     

        //FOR IMAGE UPLOAD AS BLOB
        [HttpPost("[action]")]
        public async Task<IActionResult> dbsinleuploadfileBlob(IFormFileCollection fileCollection)
        {
            ApiResponse response = new ApiResponse();
            int passcount = 0; int errorCount = 0;
            List<decimal> documentIds = new List<decimal>();
            try
            {
                foreach (var file in fileCollection)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        await file.CopyToAsync(stream);
                        TJobApplicantDocument document = new TJobApplicantDocument
                        {
                            File = stream.ToArray()
                        };
                        this._ctxOr.TJobApplicantDocuments.Add(document);
                        await this._ctxOr.SaveChangesAsync();

                        // After SaveChangesAsync, the Documentid will be populated
                        documentIds.Add(document.Documentid);
                        passcount++;
                    }
                }
            }
            catch (Exception ex)
            {
                errorCount++;
                response.Message = ex.Message;
            }
            response.ResponseCode = 200;
            response.Data = documentIds;
            response.Result = passcount + " File Upload & " + errorCount + "files failed";
            return Ok(response);
        }


        //FOR IMAGE PATH UPLOAD
        [HttpPost("[action]")]
        public async Task<IActionResult> dbsinleuploadfile(IFormFileCollection fileCollection)
        {
            ApiResponse response = new ApiResponse();
            int passcount = 0;
            int errorCount = 0;
           List<decimal> documentIds = new List<decimal>();
            string uploadFolder = @"C:\UploadedFiles\";  // Define the folder to store the files. Make sure the folder exists and has the correct permissions.

            try
            {
                // Ensure the folder exists
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);  // Create the folder if it does not exist
                }
                foreach (var file in fileCollection)
                {
                    if (file != null && file.Length > 0)
                    {
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;  // Generate a unique file name
                        string filePath = Path.Combine(uploadFolder, uniqueFileName);  // Combine folder path and file name
                        // Save the file to the specified folder
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        // Save the file path to the database
                        TJobApplicantDocument document = new TJobApplicantDocument
                        {
                            Basepath = filePath, // Save the file path in the database
                            Documentname = file.Name,
                            Documenttype = file.ContentType,


                        };
                        this._ctxOr.TJobApplicantDocuments.Add(document);
                        await this._ctxOr.SaveChangesAsync();

                        // After SaveChangesAsync, the DocumentId will be populated
                        documentIds.Add(document.Documentid); // Add the saved file path to the list
                        passcount++;
                    }
                }
            }
            catch (Exception ex)
            {
                errorCount++;
                response.Message = ex.Message;
            }

            response.ResponseCode = 200;
            response.Data = documentIds;  // Return the file paths as response data
            response.Result = passcount + " File(s) Uploaded & " + errorCount + " File(s) Failed";
            return Ok(response);
        }




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
