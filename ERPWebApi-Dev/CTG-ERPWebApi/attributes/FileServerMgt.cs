//using DataModels.EntityModels.ERPModel;
using DataUtility;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CTG_ERPWebApi.attributes
{
    public class FileServerMgt
    {
        //public async Task<CmnDocUpload> SaveToFileServer(IFormFile file, StaticInfos.Platform platform)
        //{
        //    var oDocUpload = new CmnDocUpload();
        //    try
        //    {
        //        string strPlatform = "erp";
        //        // switch statement
        //        switch (platform)
        //        {
        //            case StaticInfos.Platform.Cloud:
        //                strPlatform = "cloud";
        //                break;

        //            case StaticInfos.Platform.ISP :
        //                strPlatform = "isp";
        //                break;

        //            case StaticInfos.Platform.ERP:
        //                strPlatform = "erp";
        //                break;

        //            default:
        //                strPlatform = "erp";
        //                break;
        //        }

        //        string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
        //        var newFileName = Extension.UtcToday.ToString("yyyyMMddHHmmssfff");
        //        var arrayExtens = fileName.Split(".");
        //        var exten = arrayExtens[arrayExtens.Length - 1];
        //        fileName = fileName.Substring(0, fileName.Length - (exten.Length + 1)) + "_" + newFileName + "." + exten;
        //        string baseUri = "ftp://100.120.2.12/docs/"+ strPlatform + "/";
        //        string uri = baseUri + fileName;
        //        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
        //        request.Credentials = new NetworkCredential("fileupload", "12345");
        //        request.Method = WebRequestMethods.Ftp.UploadFile;
        //        using (Stream ftpStream = request.GetRequestStream())
        //        {
        //            file.CopyTo(ftpStream);
        //        }
        //        string virtualPath = "http://100.120.2.12:8080/" + strPlatform + "/" + fileName;

        //        oDocUpload.FileName = fileName;
        //        oDocUpload.FileExtension = exten;
        //        oDocUpload.PhysicalPath = uri;
        //        oDocUpload.VirtualPath = virtualPath;
        //        oDocUpload.PlatformId = (int)platform;
        //        oDocUpload.IsActive = StaticInfos.IsActive;
        //    }
        //    catch
        //    {
        //        oDocUpload.IsActive = false;
        //    }
            
        //    await Task.Yield();

        //    return oDocUpload;
        //}
    }
}
