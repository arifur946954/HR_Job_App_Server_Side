using DataModel.EntityModels.OraModel;
using DataModel.ViewModels;
using DataUtility;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataFactories.Infrastructure.common.documentupload
{
    public class DocumentUploadMgt
    {
        #region Variable declaration & initialization
        ModelContext _ctxOra = null;
        #endregion

        #region All Methods
        /// <summary>
        /// This method returns an object from database as object with pagination using asynchronous operation by vmCmnParameters class as parameter.
        /// </summary>
        /// <param name="cmnParam"></param>
        /// <returns></returns>
        public async Task<object> SaveUpdateFiles(IFormFileCollection allDocs, List<vmCmnDocument> documentList)
        {
            object result = null, docSave = null; string message = string.Empty; bool resstate = false;
            List<vmCmnDocument> ndocList = new List<vmCmnDocument>();
            vmCmnDocument ndoc = null;

            string referenceId = documentList[0].ReferenceId.ToString();
            string loggedUserId = documentList[0].CreateBy;
            string filePath = documentList[0].DocumentPath;
            string basePath = "E:/UploadFile/";
            string newPath = basePath + filePath;
            string _newPath = newPath.ToString().Replace(@"\", @"/");

            //Virtual Directory
            string vIpAdd = "http://192.168.61.246";
            string vPort = "84";
            string vPath = vIpAdd + ":" + vPort;
            //Virtual Directory

            int totalfile = allDocs.Count;
            foreach (var docInfo in documentList)
            {
                IFormFile docFile = null;
                if (totalfile > 0)
                {
                    docFile = allDocs.Where(x => x.FileName == docInfo.OriginalDocName).FirstOrDefault();
                }

                if (docFile != null)
                {
                    if (!Directory.Exists(_newPath))
                    {
                        Directory.CreateDirectory(_newPath);
                    }

                    if (docFile.Length > 0)
                    {
                        string originalFileName = ContentDispositionHeaderValue.Parse(docFile.ContentDisposition).FileName.Trim('"');
                        var newFileName = Extension.UtcToday.ToString("yyyyMMddHHmmssfff");
                        var arrayExtens = originalFileName.Split(".");
                        var exten = arrayExtens[arrayExtens.Length - 1];
                        string fileName = originalFileName.Substring(0, originalFileName.Length - (exten.Length + 1)) + "_" + newFileName + "." + exten;

                        string fullPath = Path.Combine(_newPath, fileName);

                        if (docInfo.DocumentId == 0)
                        {
                            using (var stream = new FileStream(fullPath, FileMode.Create))
                            {
                                docFile.CopyTo(stream);

                                ndoc = new vmCmnDocument();
                                ndoc.DocumentId = docInfo.DocumentId;
                                ndoc.ReferenceId = docInfo.ReferenceId;
                                ndoc.OriginalDocName = originalFileName;
                                ndoc.DocumentName = fileName;
                                ndoc.DocumentType = docFile.ContentType;
                                ndoc.DocumentSize = docFile.Length;
                                ndoc.BasePath = basePath;
                                ndoc.DocumentPath = filePath;
                                ndoc.DocumentFullPath = fullPath;
                                ndoc.VirtualPath = vPath + filePath + "/" + fileName;
                                ndoc.IsActive = docInfo.IsActive;
                                ndoc.IsDelete = docInfo.IsDelete;
                                ndoc.CreateBy = docInfo.CreateBy;
                                ndocList.Add(ndoc);
                            }
                        }
                        else
                        {
                            if (docInfo.IsDelete)
                            {
                                if (File.Exists(docInfo.DocumentFullPath))
                                {
                                    File.Delete(docInfo.DocumentFullPath);
                                }
                            }
                        }
                    }
                }
                else
                {
                    ndoc = new vmCmnDocument();
                    ndoc.DocumentId = docInfo.DocumentId;
                    ndoc.ReferenceId = docInfo.ReferenceId;
                    ndoc.OriginalDocName = docInfo.OriginalDocName;
                    ndoc.DocumentName = docInfo.DocumentName;
                    ndoc.DocumentType = docInfo.DocumentType;
                    ndoc.DocumentSize = docInfo.DocumentSize;
                    ndoc.BasePath = docInfo.BasePath;
                    ndoc.DocumentPath = docInfo.DocumentPath;
                    ndoc.DocumentFullPath = docInfo.DocumentFullPath;
                    ndoc.VirtualPath = docInfo.VirtualPath;
                    ndoc.IsActive = docInfo.IsActive;
                    ndoc.IsDelete = docInfo.IsDelete;
                    ndoc.CreateBy = docInfo.CreateBy;
                    ndocList.Add(ndoc);

                    if (docInfo.IsDelete)
                    {
                        if (File.Exists(docInfo.DocumentFullPath))
                        {
                            File.Delete(docInfo.DocumentFullPath);
                        }
                    }
                }
            }

            if (ndocList.Count > 0)
            {
                docSave = await SaveUpdate(ndocList);
                dynamic res = docSave;
                message = res.message;
                resstate = res.resstate;
            }

            return result = new
            {
                message,
                resstate
            };
        }

        /// <summary>
        /// Both insert and update can perform by CmnUserRole model in database using asynchronous operation. when id is more than 0 update is performed otherwise insert. it returns an object as status of success or failure.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<object> SaveUpdate(List<vmCmnDocument> docList)
        {
            object result = null; string message = string.Empty; bool resstate = false;
            using (_ctxOra = new ModelContext())
            {
                using (var _ctxOraTransaction = _ctxOra.Database.BeginTransaction())
                {
                    try
                    {
                        List<TCmndocument> ndocList = new List<TCmndocument>();
                        List<TCmndocument> udocList = new List<TCmndocument>();
                        var MaxID = _ctxOra.TCmndocuments.DefaultIfEmpty().Max(x => x == null ? 0 : x.Documentid) + 1;
                        foreach (var docFile in docList)
                        {
                            if (docFile.DocumentId > 0)
                            {
                                var udoc = await _ctxOra.TCmndocuments.FirstOrDefaultAsync(x => x.Documentid == docFile.DocumentId);
                                //docFile.DocumentId = Convert.ToInt32(udoc.Documentid);

                                udoc.Referenceid = Convert.ToDecimal(docFile.ReferenceId);
                                udoc.Originaldocname = docFile.OriginalDocName;
                                udoc.Documentname = docFile.DocumentName;
                                udoc.Documenttype = docFile.DocumentType;
                                udoc.Documentsize = docFile.DocumentSize;

                                udoc.Documentpath = docFile.DocumentPath;
                                udoc.Basepath = docFile.BasePath;
                                udoc.Documentfullpath = docFile.DocumentFullPath;
                                udoc.Virtualpath = docFile.VirtualPath;

                                udoc.Isactive = Extension.BoolVal(docFile.IsActive);
                                udoc.Isdelete = Extension.BoolVal(docFile.IsDelete);
                                //Common
                                udoc.Updatepc = Extension.Createpc();
                                udoc.Updateby = docFile.CreateBy;
                                udoc.Updateon = Extension.Today;

                                udocList.Add(udoc);
                            }
                            else
                            {
                                //docFile.DocumentId = Convert.ToInt32(MaxID);
                                var ndoc = new TCmndocument();
                                ndoc.Documentid = MaxID;
                                ndoc.Referenceid = Convert.ToDecimal(docFile.ReferenceId);
                                ndoc.Originaldocname = docFile.OriginalDocName;
                                ndoc.Documentname = docFile.DocumentName;
                                ndoc.Documenttype = docFile.DocumentType;
                                ndoc.Documentsize = docFile.DocumentSize;

                                ndoc.Documentpath = docFile.DocumentPath;
                                ndoc.Basepath = docFile.BasePath;
                                ndoc.Documentfullpath = docFile.DocumentFullPath;
                                ndoc.Virtualpath = docFile.VirtualPath;

                                ndoc.Isactive = Extension.BoolVal(docFile.IsActive);
                                ndoc.Isdelete = Extension.BoolVal(docFile.IsDelete);

                                //Common
                                ndoc.Createpc = Extension.Createpc();
                                ndoc.Createby = docFile.CreateBy;
                                ndoc.Createon = Extension.Today;

                                ndocList.Add(ndoc);

                                MaxID++;
                            }
                        }

                        if (ndocList.Count > 0)
                        {
                            await _ctxOra.TCmndocuments.AddRangeAsync(ndocList);
                        }

                        await _ctxOra.SaveChangesAsync();
                        message = MessageConstants.FileSuccess;

                        _ctxOraTransaction.Commit();
                        resstate = MessageConstants.SuccessState;
                    }
                    catch (Exception ex)
                    {
                        _ctxOraTransaction.Rollback();
                        //Logs.WriteBug(ex);
                        message = MessageConstants.FileError;
                        resstate = MessageConstants.ErrorState;
                    }
                }
            }
            return result = new
            {
                //docList,
                message,
                resstate
            };
        }
        #endregion





    }
}
