//using DataModels.EntityModels.ERPLogModel;
//using DataModels.EntityModels.ERPModel;
using DataModel.EntityModels.OraModel;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DataUtility
{
    public class Logs
    {
        public static string path = CurrentAssemblyDirectory().ToString();
        public static string assemblyFile = path.Remove(path.IndexOf("\\bin\\Debug")).ToString();
        private const string FILE_NAME = "wwwroot\\systemLog\\LogTextFile.txt";

        private static string ConfigFilePath
        {
            get { return assemblyFile + "\\" + FILE_NAME; }
        }

        public static void WriteLogFile(string message)
        {
            FileStream fs = null;
            if (!File.Exists(ConfigFilePath))
            {
                using (fs = File.Create(ConfigFilePath))
                {
                }
            }

            try
            {
                if (!string.IsNullOrEmpty(message))
                {
                    StreamWriter streamWriter = new StreamWriter(ConfigFilePath, true);
                    streamWriter.WriteLine(message);
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        static public string CurrentAssemblyDirectory()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            try
            {
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
            }
            catch (Exception)
            {
            }
            return Path.GetDirectoryName(path);
        }

        //public static void WriteBug(Exception ex)
        //{
        //    try
        //    {
        //        using (var _ctx = new dbRGLERPLogContext())
        //        {
        //             _ctx.BugLog.AddAsync(new BugLog
        //            {
        //                BugDetails = "Error~On:" + Convert.ToString(Extension.UtcToday) + "~Message:" + Convert.ToString(ex.InnerException.Message) + "~StackTrace:" + Convert.ToString(ex.StackTrace),
        //                CreateDate = Extension.UtcToday,
        //                IsSolved = false,
        //                CompanyId = StaticInfos.CompanyID,
        //                CreatedBy = StaticInfos.LoggedUserID
        //            });
        //            _ctx.SaveChangesAsync();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //public static void WriteBug(string error)
        //{
        //    try
        //    {
        //        var _ctx = new dbRGLERPLogContext();
        //        using (_ctx)
        //        {
        //            _ctx.BugLog.AddAsync(new BugLog
        //            {
        //                BugDetails = "Error~On:" + Extension.UtcToday.ToString() + "~Message:" + error.ToString(),
        //                CreateDate = Extension.UtcToday,
        //                IsSolved = false,
        //                CompanyId = StaticInfos.CompanyID,
        //                CreatedBy = StaticInfos.LoggedUserID
        //            });
        //            _ctx.SaveChangesAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        ex.ToString();
        //    }
        //}

        //Oracle Bug Log
        public static void Bug(Exception ex)
        {
            try
            {
                string UserID = Context.request.HttpContext.Request.Headers[StaticInfos.userId_key].ToString();
                string UserAgent = Context.request.HttpContext.Request.Headers[StaticInfos.userAgent_key].ToString();
                //string browser = Client.request.HttpContext.Request.Headers[StaticInfos.sec_ch_ua].ToString();
                string apiPath = Context.request.HttpContext.Request.Path.ToString();
                string reqType = Context.request.HttpContext.Request.Method.ToString();
                string reqIpAddres = Extension.Createpc();
                string errorMessage = string.IsNullOrEmpty(ex.Message) ? string.Empty : ex.Message.ToString();
                string stackTrace = ex.StackTrace.ToString();
                using (var _ctxOra = new ModelContext())
                {
                    var erLog = new TErrorLog();
                    erLog.Errorid = _ctxOra.TErrorLogs.DefaultIfEmpty().Max(x => x == null ? 0 : x.Errorid) + 1;
                    erLog.Errormessage = errorMessage;
                    erLog.Stacktrace = stackTrace;
                    erLog.Apipath = apiPath;
                    erLog.Requesttype = reqType;
                    erLog.Ipaddress = reqIpAddres;
                    erLog.Clientagent = UserAgent;
                    erLog.Browser = UserAgent;
                    erLog.Createby = UserID;
                    erLog.Createon = Extension.Today.ToString();
                    erLog.Createpc = reqIpAddres;

                    _ctxOra.TErrorLogs.AddAsync(erLog);
                    _ctxOra.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
