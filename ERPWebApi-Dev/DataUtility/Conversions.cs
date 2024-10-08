//using DataModels.EntityModels.ERPModel;
using DataModel.ViewModels;
//using Microsoft.Extensions.Configuration;
//using OpenHtmlToPdf;
//using Syncfusion.HtmlConverter;
//using Syncfusion.Pdf;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace DataUtility
{
    public static class Conversions
    {
        #region DataMapping
        public static List<T> DataReaderMapToList<T>(IDataReader reader)
        {
            var results = new List<T>();

            var columnCount = reader.FieldCount;
            while (reader.Read())
            {
                var item = Activator.CreateInstance<T>();
                try
                {
                    var rdrProperties = Enumerable.Range(0, columnCount).Select(i => reader.GetName(i)).ToArray();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        if ((typeof(T).GetProperty(property.Name).GetGetMethod().IsVirtual) || (!rdrProperties.Contains(property.Name)))
                        {
                            continue;
                        }
                        else
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                            {
                                Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                                property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
                            }
                        }
                    }
                    results.Add(item);
                }
                catch (Exception)
                {

                }
            }
            return results;
        }

        public static List<T> ToCollection<T>(this DataTable dt)
        {
            List<T> lst = new System.Collections.Generic.List<T>();
            Type tClass = typeof(T);
            PropertyInfo[] pClass = tClass.GetProperties();
            List<DataColumn> dc = dt.Columns.Cast<DataColumn>().ToList();
            T cn;
            foreach (DataRow item in dt.Rows)
            {
                cn = (T)Activator.CreateInstance(tClass);
                foreach (PropertyInfo pc in pClass)
                {
                    // Can comment try catch block. 
                    try
                    {
                        DataColumn d = dc.Find(c => c.ColumnName == pc.Name);
                        if (d != null)
                            pc.SetValue(cn, item[pc.Name], null);
                    }
                    catch
                    {
                    }
                }
                lst.Add(cn);
            }
            return lst;
        }

        #endregion

        #region Pagination
        public static List<T> SkipTake<T>(List<T> model, vmCmnParameters cmncls)
        {
            List<T> lst = new List<T>();
            int skipnumber = 0;
            if (cmncls.pageNumber > 0)
            {
                skipnumber = ((int)cmncls.pageNumber - 1) * (int)cmncls.pageSize;
            }
            lst = model.Skip(skipnumber).Take((int)cmncls.pageSize).ToList();
            return lst;
        }

        public static int Skip(vmCmnParameter cmncls)
        {
            int skipnumber = 0;
            if (cmncls.pageNumber > 0)
            {
                skipnumber = ((int)cmncls.pageNumber - 1) * (int)cmncls.pageSize;
            }
            return skipnumber;
        }

        public static int Skip(vmCmnParameters cmncls)
        {
            int skipnumber = 0;
            if (cmncls.pageNumber > 0)
            {
                skipnumber = ((int)cmncls.pageNumber - 1) * (int)cmncls.pageSize;
            }
            return skipnumber;
        }

        #endregion

        #region APIAuth
        public static string GetApiAuthenticationKey(string username, string password)
        {
            username += ":" + password;
            return "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username));
        }
        //public static string GetTenantCloudAccessToken(int? cloudUserId)
        //{
        //    dbRGLERPContext _ctx = new dbRGLERPContext(); string accessToken = string.Empty;
        //    if (cloudUserId > 0)
        //    {
        //        var cmnClouduser = _ctx.CmnUserCloud.Where(x => x.CloudUserId == cloudUserId).FirstOrDefault();
        //        if (cmnClouduser != null)
        //        {
        //            var subTenatInfo = _ctx.LookupCloudTenantSub.Where(x => x.CloudSubTenantId == Convert.ToInt32(cmnClouduser.TenantId)).SingleOrDefault();
        //            if (subTenatInfo != null)
        //            {
        //                var cmnCloudusersSubTNT = _ctx.CmnUserCloud.Where(x => x.CloudUserId == Convert.ToInt32(subTenatInfo.UserId)).FirstOrDefault();
        //                if (cmnCloudusersSubTNT != null)
        //                {
        //                    accessToken = GetApiAuthenticationKey(cmnCloudusersSubTNT.Username, cmnCloudusersSubTNT.AccessKeys);
        //                }
        //            }
        //            var TenatInfo = _ctx.LookupCloudTenant.Where(x => x.CloudTenantId == Convert.ToInt32(cmnClouduser.TenantId)).SingleOrDefault();
        //            if (TenatInfo != null)
        //            {
        //                accessToken = GetApiAuthenticationKey(TenatInfo.UserName, TenatInfo.Password);
        //            }
        //        }
        //    }
        //    return accessToken;
        //}
        //public static string GetUserCloudAccessToken(int? cloudUserId)
        //{
        //    dbRGLERPContext _ctx = new dbRGLERPContext(); string accessToken = string.Empty;
        //    if (cloudUserId > 0)
        //    {
        //        var cmnClouduser = _ctx.CmnUserCloud.Where(x => x.CloudUserId == cloudUserId).FirstOrDefault();
        //        if (cmnClouduser != null)
        //        {
        //            accessToken = GetApiAuthenticationKey(cmnClouduser.Username, cmnClouduser.AccessKeys);
        //        }
        //    }
        //    return accessToken;
        //}
        //public static int GetTenantIdAsInteger(int? cloudUserId)
        //{
        //    dbRGLERPContext _ctx = new dbRGLERPContext(); int tenantId = 0;
        //    if (cloudUserId > 0)
        //    {
        //        var cmnClouduser = _ctx.CmnUserCloud.Where(x => x.CloudUserId == cloudUserId).FirstOrDefault();
        //        if (cmnClouduser != null)
        //        {
        //            tenantId = Convert.ToInt32(cmnClouduser.TenantId);
        //        }
        //    }

        //    return tenantId;
        //}
        //public static string GetTenantIdAsString(int? cloudUserId)
        //{
        //    dbRGLERPContext _ctx = new dbRGLERPContext(); string tenantId = string.Empty;
        //    if (cloudUserId > 0)
        //    {
        //        var cmnClouduser = _ctx.CmnUserCloud.Where(x => x.CloudUserId == cloudUserId).FirstOrDefault();
        //        if (cmnClouduser != null)
        //        {
        //            tenantId = cmnClouduser.TenantId;
        //        }
        //    }

        //    return tenantId;
        //}

        #endregion

        #region DateTime
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static DateTime UnixTimeStampToDateTimeMiliSec(double unixTimeStamp)
        {
            string strTime = unixTimeStamp.ToString();
            double dTime = Convert.ToDouble(strTime.Substring(0, strTime.Length - 3));
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(dTime).ToLocalTime();
            return dtDateTime;
        }

        public static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            return (TimeZoneInfo.ConvertTimeToUtc(dateTime) -
                   new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
        }

        public static double DateTimeToUnixTimestampExact(DateTime dateTime)
        {
            return (dateTime -
                   new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
        }

        public static double getMinutes(DateTime fromdate)
        {
            return DateTime.Now.Subtract(fromdate).TotalMinutes;
        }

        public static double getHour(DateTime fromdate)
        {
            return DateTime.Now.Subtract(fromdate).TotalHours;
        }

        public static double getDay(DateTime fromdate)
        {
            return DateTime.Now.Subtract(fromdate).TotalDays;
        }

        /// <summary>
        /// UniversalToLocal is a method to convert a universal time to local time. input a parameter as universal time
        /// </summary>
        /// <param name="universalTime"></param>
        /// <returns></returns>
        public static DateTime UniversalToLocal(DateTime universalTime)
        {
            DateTime convertedUtc = Convert.ToDateTime(universalTime).ToUniversalTime();
            return convertedUtc;
        }

        /// <summary>
        /// LocalToUniversal is a method to convert a local time to universal time. input a parameter as local time
        /// </summary>
        /// <param name="localTime"></param>
        /// <returns></returns>
        public static DateTime LocalToUniversal(DateTime localTime)
        {
            DateTime convertedLocal = Convert.ToDateTime(localTime).ToLocalTime();
            return convertedLocal;
        }
        #endregion

        #region Encrypt-Decrypt
        public static string Encryptdata(string inputString)
        {
            string strmsg = string.Empty;
            try
            {
                byte[] encode = new byte[inputString.Length];
                encode = Encoding.UTF8.GetBytes(inputString);
                strmsg = Convert.ToBase64String(encode);
            }
            catch (Exception) { }

            return strmsg;
        }

        public static string Decryptdata(string inputString)
        {
            string decryptpwd = string.Empty;
            try
            {
                UTF8Encoding encodepwd = new UTF8Encoding();
                Decoder Decode = encodepwd.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(inputString);
                int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                decryptpwd = new String(decoded_char);
            }
            catch (Exception) { }
            return decryptpwd;
        }

        private static Random random = new Random();
        public static string getRandomNumber()
        {
            return genRandomNumber(11);
        }

        public static string getRandomNumber(int length)
        {
            return genRandomNumber(length);
        }

        private static string genRandomNumber(int length)
        {
            string rndm = string.Empty;
            try
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                rndm = new string(Enumerable.Repeat(chars, length).Select(x => x[random.Next(x.Length)]).ToArray());
            }
            catch (Exception) { }
            return rndm;
        }

        public static string getJsonString(string bodys)
        {
            try
            {
                bodys = bodys.Remove(0, 0);
                bodys = bodys.Remove(bodys.Length - 1, 0);
            }
            catch (Exception) { }
            return bodys;
        }
        #endregion

        #region Validation
        /// <summary>
        /// ValidateRequiredField is a method to validate required field with method overloading parameters
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ValidateRequiredField(string value)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(value))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(value))
            {
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// ValidateRequiredField is a method to validate required field with method overloading parameters
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ValidateRequiredField(int? value)
        {
            bool isValid = true;
            if (value == null)
            {
                isValid = false;
            }
            if (int.MinValue < value)
            {
                isValid = false;
            }
            if (int.MaxValue > value)
            {
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// ValidateRangField is a method to validate rang of field with method overloading parameters
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ValidateRangField(string value, int min, int max)
        {
            bool isValid = true;
            if (value.Length > max)
            {
                isValid = false;
            }
            if (value.Length < min)
            {
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// ValidateRangField is a method to validate rang of field with method overloading parameters
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ValidateRangField(int value, int min, int max)
        {
            bool isValid = true;
            if (value > max)
            {
                isValid = false;
            }
            if (value < min)
            {
                isValid = false;
            }
            return isValid;
        }
        #endregion
        public static string RemoveMultipleSpaceFromString(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                data = string.Join(" ", data.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }
            
            return data;
        }

        //public static byte[] ConvertHTMLtoPDF(string EmailFormatPath, string html)
        //{
        //    //It was developed according to following tutorial
        //    //https://help.syncfusion.com/file-formats/pdf/convert-html-to-pdf/webkit?cs-save-lang=1&cs-lang=csharp
        //    HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);

        //    WebKitConverterSettings webKitSettings = new WebKitConverterSettings();

        //    //Set WebKit path
        //    // settings.WebKitPath = rootPath+"/QtBinaries/";

        //    //Assign WebKit settings to HTML converter
        //    //htmlConverter.ConverterSettings = webKitSettings;

        //    //Convert HTML string to PDF
        //    //Enable TOC

        //    //webKitSettings.EnableToc = true;

        //    //Assign the WebKit settings

        //    // Enable html table header repeat on every page.
        //    webKitSettings.EnableRepeatTableHeader = true;
        //    //Enable html table footer repeat on every page.
        //    //webKitSettings.EnableRepeatTableFooter = true;

        //    //Set PDF page margin 
        //    webKitSettings.Margin = new Syncfusion.Pdf.Graphics.PdfMargins { Top = 40, Left = 30, Right = 30, Bottom = 40 };

        //    htmlConverter.ConverterSettings = webKitSettings;

        //    //Syncfusion.Pdf.Graphics.PdfLayoutResult layoutResult = null;

        //    PdfDocument document = htmlConverter.Convert(html, EmailFormatPath); //htmlConverter.ConvertPartialHtml(html, EmailFormatPath, "id"); 

        //    //Draw the text at the end of HTML content
        //    //Syncfusion.Pdf.Graphics.PdfFont font = new Syncfusion.Pdf.Graphics.PdfStandardFont(Syncfusion.Pdf.Graphics.PdfFontFamily.Helvetica, 11);

        //    //document.Pages[document.Pages.Count - 1].Graphics.DrawString("End of HTML content", font, Syncfusion.Pdf.Graphics.PdfBrushes.Red, new Syncfusion.Drawing.PointF(0, layoutResult.Bounds.Bottom));

        //    byte[] fileContents = null;
        //    using (MemoryStream stream = new MemoryStream())
        //    {
        //        document.Save(stream);
        //        fileContents = stream.ToArray();
        //    }

        //    return fileContents;
        //}

        //public static byte[] html2pdf(string htmlCode)
        //{
        //   Spire.Pdf.PdfDocument pdf = new Spire.Pdf.PdfDocument();


           
            

        //    Spire.Pdf.PdfPageSettings setting = new Spire.Pdf.PdfPageSettings();
        //    Spire.Pdf.HtmlConverter.LoadHtmlType htmlLayoutFormat = new Spire.Pdf.HtmlConverter.LoadHtmlType();
        //    //PdfHtmlLayoutFormat htmlLayoutFormat = new PdfHtmlLayoutFormat();
          
        //    setting.Size = Spire.Pdf.PdfPageSize.A4;
           

        //       // string htmlCode = File.ReadAllText("..\\..\\2.html");
            




        //        Thread thread = new Thread(() =>
        //        {
        //            pdf.LoadFromFile(htmlCode);
        //        });

	       //     thread.SetApartmentState(ApartmentState.STA);

	       //     thread.Start();

	       //     //thread.Join();
	 

	       //    // pdf.SaveToFile("output.pdf");

        //    byte[] fileContents = null;
        //    using (MemoryStream stream = new MemoryStream())
        //    {
        //        pdf.SaveToStream(stream);
        //        fileContents = stream.ToArray();
        //    }
        //    // System.Diagnostics.Process.Start("output.pdf");
        //    return fileContents;
        //}
//        public static byte[] Html2Pdf1(string htmlString, string baseUrl)
//        {
//            byte[] res = null;
//            SelectPdf.HtmlToPdf _htmlToPdf = new SelectPdf.HtmlToPdf();
//            try
//            {
//                SelectPdf.PdfDocument doc = _htmlToPdf.ConvertHtmlString(htmlString, baseUrl);
//                using (MemoryStream ms = new MemoryStream())
//                {
//                    doc.Save(ms)
//;
//                    res = ms.ToArray();
//                    doc.Close();
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            return res;
//        }
//        public static byte[] Html2PdfMultiplePages(List<string> pages, string templateUrl, string fullname, string address, string usercode, string date)
//        {
//            byte[] res = null;

//            try
//            {
//                SelectPdf.PdfDocument pdf = new SelectPdf.PdfDocument();
//                int count = 0;
//                foreach (var page in pages)
//                {
//                    if (count == 0)
//                    {
//                        SelectPdf.HtmlToPdf _htmlToPdf = new SelectPdf.HtmlToPdf();
//                        _htmlToPdf.Options.PdfPageSize = SelectPdf.PdfPageSize.A4;
//                        _htmlToPdf.Options.PdfPageOrientation = SelectPdf.PdfPageOrientation.Portrait;
//                        _htmlToPdf.Options.MarginLeft = 10;
//                        _htmlToPdf.Options.MarginRight = 10;
//                        _htmlToPdf.Options.MarginTop = 10;
//                        _htmlToPdf.Options.MarginBottom = 10;
//                        SelectPdf.HtmlToPdfResult result = _htmlToPdf.ConversionResult;
//                        // header settings
//                        _htmlToPdf.Options.DisplayHeader = true;
//                        _htmlToPdf.Header.DisplayOnFirstPage = true;
//                        _htmlToPdf.Header.DisplayOnOddPages = false;
//                        _htmlToPdf.Header.DisplayOnEvenPages = false;
//                        _htmlToPdf.Header.Height = 120;
//                        // add some html content to the header
//                        string _headerHtml = templateUrl + "/emailTemplates/header.html"; //Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/emailTemplates/header.html");
//                        string _headerPortion = File.ReadAllText(_headerHtml);
//                        StringBuilder newBody = new StringBuilder(_headerPortion);
//                        newBody.Replace("#FULLNAME#", fullname);
//                        newBody.Replace("#ADDRESS#", address);
//                        newBody.Replace("#USERCODE#", usercode);
//                        newBody.Replace("#PROPOSALDATE#", date);
//                        SelectPdf.PdfHtmlSection headerHtml = new SelectPdf.PdfHtmlSection(newBody.ToString(), _headerHtml);
//                        headerHtml.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//                        _htmlToPdf.Header.Add(headerHtml);
//                        // footer settings
//                        _htmlToPdf.Options.DisplayFooter = true;
//                        _htmlToPdf.Footer.DisplayOnFirstPage = true;
//                        _htmlToPdf.Footer.DisplayOnOddPages = true;
//                        _htmlToPdf.Footer.DisplayOnEvenPages = true;
//                        _htmlToPdf.Footer.Height = 50;

//                        // add some html content to the footer
//                        string _footerHtml = templateUrl + "/emailTemplates/footer.html"; //Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/emailTemplates/footer.html");
//                        string _footerPortion = File.ReadAllText(_footerHtml);

//                        SelectPdf.PdfHtmlSection footerHtml = new SelectPdf.PdfHtmlSection(_footerPortion, _footerHtml);

//                        footerHtml.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//                        _htmlToPdf.Footer.Add(footerHtml);
//                        SelectPdf.PdfDocument doc = _htmlToPdf.ConvertHtmlString(page);
                       
//                        SelectPdf.PdfPage p = doc.Pages[0];
//                        pdf.Pages.Add(p);
//                    }
//                    else
//                    {
//                        SelectPdf.HtmlToPdf _htmlToPdf = new SelectPdf.HtmlToPdf();
//                        _htmlToPdf.Options.PdfPageSize = SelectPdf.PdfPageSize.A4;
//                        _htmlToPdf.Options.PdfPageOrientation = SelectPdf.PdfPageOrientation.Portrait;
//                        _htmlToPdf.Options.MarginLeft = 10;
//                        _htmlToPdf.Options.MarginRight = 10;
//                        _htmlToPdf.Options.MarginTop = 10;
//                        _htmlToPdf.Options.MarginBottom = 10;
//                        SelectPdf.HtmlToPdfResult result = _htmlToPdf.ConversionResult;
//                        // header settings
//                        _htmlToPdf.Options.DisplayHeader = true;
//                        _htmlToPdf.Header.DisplayOnFirstPage = true;
//                        _htmlToPdf.Header.DisplayOnOddPages = false;
//                        _htmlToPdf.Header.DisplayOnEvenPages = false;
//                        _htmlToPdf.Header.Height = 50;
//                        SelectPdf.PdfHtmlSection headerHtml = new SelectPdf.PdfHtmlSection("", "");
//                        headerHtml.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//                        _htmlToPdf.Header.Add(headerHtml);
//                        // footer settings
//                        _htmlToPdf.Options.DisplayFooter = true;
//                        _htmlToPdf.Footer.DisplayOnFirstPage = true;
//                        _htmlToPdf.Footer.DisplayOnOddPages = true;
//                        _htmlToPdf.Footer.DisplayOnEvenPages = true;
//                        _htmlToPdf.Footer.Height = 50;

//                        // add some html content to the footer
//                        string _footerHtml = templateUrl + "/emailTemplates/footer.html"; //Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/emailTemplates/footer.html");
//                        string _footerPortion = File.ReadAllText(_footerHtml);

//                        SelectPdf.PdfHtmlSection footerHtml = new SelectPdf.PdfHtmlSection(_footerPortion, _footerHtml);

//                        footerHtml.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//                        _htmlToPdf.Footer.Add(footerHtml);
//                        SelectPdf.PdfDocument doc = _htmlToPdf.ConvertHtmlString(page);
                       
//                        SelectPdf.PdfPage p = doc.Pages[0];

//                        pdf.Pages.Add(p);
//                    }
//                    count++;
//                }
//                using (MemoryStream ms = new MemoryStream())
//                {
//                    pdf.DocumentInformation.Title = "VMOfferDetails.pdf";
//                    pdf.Save(ms);
//                    res = ms.ToArray();
//                    pdf.Close();
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            return res;
//        }
//        public static byte[] Html2Pdf(string htmlString, string baseUrl, string fullname, string address, string usercode, string date)
//        {
//            byte[] res = null;
//            SelectPdf.HtmlToPdf _htmlToPdf = new SelectPdf.HtmlToPdf();
//            // set converter options
           
//            _htmlToPdf.Options.PdfPageSize = SelectPdf.PdfPageSize.A4;
//            _htmlToPdf.Options.PdfPageOrientation = SelectPdf.PdfPageOrientation.Portrait;
//            _htmlToPdf.Options.MarginLeft = 10;
//            _htmlToPdf.Options.MarginRight = 10;
//            _htmlToPdf.Options.MarginTop = 10;
//            _htmlToPdf.Options.MarginBottom = 10;
//            _htmlToPdf.Options.WebPageWidth = 1024;
//            _htmlToPdf.Options.WebPageHeight = 0;
//            _htmlToPdf.Options.WebPageFixedSize = false;
//            _htmlToPdf.Options.AutoFitWidth = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//            _htmlToPdf.Options.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;

//            _htmlToPdf.Options.KeepTextsTogether = false;
//            _htmlToPdf.Options.KeepImagesTogether = true;
//            // header settings
//            _htmlToPdf.Options.DisplayHeader = true;
//            _htmlToPdf.Header.DisplayOnFirstPage = true;
//            _htmlToPdf.Header.DisplayOnOddPages = false;
//            _htmlToPdf.Header.DisplayOnEvenPages = false;
//            _htmlToPdf.Header.Height = 120;
//            // add some html content to the header
//            //string _headerHtml = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/emailTemplates/header.html");
//            string _headerHtml = baseUrl+ "/emailTemplates/header.html";
//            string _headerPortion = File.ReadAllText(_headerHtml);
//            StringBuilder newBody = new StringBuilder(_headerPortion);
//            newBody.Replace("#FULLNAME#", fullname);
//            newBody.Replace("#ADDRESS#", address);
//            newBody.Replace("#USERCODE#", usercode);
//            newBody.Replace("#PROPOSALDATE#", date);
//            SelectPdf.PdfHtmlSection headerHtml = new SelectPdf.PdfHtmlSection(newBody.ToString(), _headerHtml);
//            headerHtml.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//            _htmlToPdf.Header.Add(headerHtml);


//            // footer settings
//            _htmlToPdf.Options.DisplayFooter = true;
//            _htmlToPdf.Footer.DisplayOnFirstPage = true;
//            _htmlToPdf.Footer.DisplayOnOddPages = true;
//            _htmlToPdf.Footer.DisplayOnEvenPages = true;
//            _htmlToPdf.Footer.Height = 50;

//            // add some html content to the footer
//            string _footerHtml = baseUrl + "/emailTemplates/footer.html";
//            string _footerPortion = File.ReadAllText(_footerHtml);

//            SelectPdf.PdfHtmlSection footerHtml = new SelectPdf.PdfHtmlSection(_footerPortion, _footerHtml);

//            footerHtml.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//            _htmlToPdf.Footer.Add(footerHtml);

//            //// page numbers can be added using a PdfTextSection object
//            //SelectPdf.PdfTextSection text = new SelectPdf.PdfTextSection(-5, 40, "Page: {page_number} of {total_pages}  ", new System.Drawing.Font("Arial", 8));
//            //text.HorizontalAlign = SelectPdf.PdfTextHorizontalAlign.Right;
//            //_htmlToPdf.Footer.Add(text);

//            SelectPdf.HtmlToPdfResult result = _htmlToPdf.ConversionResult;
//            try
//            {
//                SelectPdf.PdfDocument doc = _htmlToPdf.ConvertHtmlString(htmlString);
//                // set the document properties
//                doc.DocumentInformation.Title = "CloudOffer.pdf";
//                //doc.DocumentInformation.Subject = result.WebPageInformation.Description;
//                //doc.DocumentInformation.Keywords = result.WebPageInformation.Keywords;
//                //doc.DocumentInformation.Author = "enamul hoque";
//                //doc.DocumentInformation.CreationDate = DateTime.Now;

//                using (MemoryStream ms = new MemoryStream())
//                {
                   
//                    doc.Save(ms);
//                    res = ms.ToArray();
//                    doc.Close();
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            return res;
//        }
//        public static byte[] Html2PdfInvoice(string htmlString, string baseUrl, string fullname, string address, string usercode, string date, string invoceno = "", string vat = "", string invoicedate = "", string fromdate = "", string todate = "")
//        {
//            byte[] res = null;
//            SelectPdf.HtmlToPdf _htmlToPdf = new SelectPdf.HtmlToPdf();
//            // set converter options
//            _htmlToPdf.Options.PdfPageSize = SelectPdf.PdfPageSize.A4;
//            _htmlToPdf.Options.PdfPageOrientation = SelectPdf.PdfPageOrientation.Portrait;
//            _htmlToPdf.Options.MarginLeft = 10;
//            _htmlToPdf.Options.MarginRight = 10;
//            _htmlToPdf.Options.MarginTop = 10;
//            _htmlToPdf.Options.MarginBottom = 10;
//            _htmlToPdf.Options.WebPageWidth = 1024;
//            _htmlToPdf.Options.WebPageHeight = 0;
//            _htmlToPdf.Options.WebPageFixedSize = false;
//            _htmlToPdf.Options.AutoFitWidth = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//            _htmlToPdf.Options.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;

//            _htmlToPdf.Options.KeepTextsTogether = false;
//            _htmlToPdf.Options.KeepImagesTogether = true;
//            // header settings
//            _htmlToPdf.Options.DisplayHeader = true;
//            _htmlToPdf.Header.DisplayOnFirstPage = true;
//            _htmlToPdf.Header.DisplayOnOddPages = false;
//            _htmlToPdf.Header.DisplayOnEvenPages = false;
//            _htmlToPdf.Header.Height = 150;
//            // add some html content to the header
//            string _headerHtml = baseUrl + "/emailTemplates/cloudinvoiceheader.html";
//            string _headerPortion = File.ReadAllText(_headerHtml);
//            StringBuilder newBody = new StringBuilder(_headerPortion);
//            newBody.Replace("#FULLNAME#", fullname);
//            newBody.Replace("#ADDRESS#", address);
//            newBody.Replace("#USERCODE#", usercode);
//            newBody.Replace("#INVOICENO#", invoceno);
//            newBody.Replace("#INVOICEDATE#", invoicedate);
//            newBody.Replace("#FROMDATE#", fromdate);
//            newBody.Replace("#TODATE#", todate);
//            SelectPdf.PdfHtmlSection headerHtml = new SelectPdf.PdfHtmlSection(newBody.ToString(), _headerHtml);
//            headerHtml.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//            _htmlToPdf.Header.Add(headerHtml);


//            // footer settings
//            _htmlToPdf.Options.DisplayFooter = true;
//            _htmlToPdf.Footer.DisplayOnFirstPage = true;
//            _htmlToPdf.Footer.DisplayOnOddPages = true;
//            _htmlToPdf.Footer.DisplayOnEvenPages = true;
//            _htmlToPdf.Footer.Height = 190;

//            // add some html content to the footer
//            string _footerHtml = baseUrl + "/emailTemplates/cloudinvoicefooter.html";
//            string _footerPortion = File.ReadAllText(_footerHtml);

//            SelectPdf.PdfHtmlSection footerHtml = new SelectPdf.PdfHtmlSection(_footerPortion, _footerHtml);

//            footerHtml.AutoFitHeight = SelectPdf.HtmlToPdfPageFitMode.AutoFit;
//            _htmlToPdf.Footer.Add(footerHtml);
//            SelectPdf.HtmlToPdfResult result = _htmlToPdf.ConversionResult;
//            try
//            {
//                SelectPdf.PdfDocument doc = _htmlToPdf.ConvertHtmlString(htmlString);

//                using (MemoryStream ms = new MemoryStream())
//                {
//                    doc.Save(ms);
//                    res = ms.ToArray();
//                    doc.Close();
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            return res;
//        }
//        public static byte[] OpenHtml2PDF(string html, string title)
//        {
//            var pdf = Pdf.From(html);
//            pdf.WithTitle(title);
//            pdf.Portrait();
//            pdf.WithoutOutline();
            
//            pdf.WithMargins(PaperMargins.All(Length.Inches(1.5)));
//            byte[] content = pdf.Content();
//            return content;
//        }
//        public static byte[] OpenHtml2PDFLandscape(string html, string title)
//        {
//            var pdf = Pdf.From(html);
//            pdf.WithTitle(title);
//            pdf.Landscape();
//            pdf.WithoutOutline();

//            pdf.WithMargins(PaperMargins.All(Length.Inches(1.5)));
//            byte[] content = pdf.Content();
//            return content;
//        }
    }

    
    public static class FosterPGW
    {
        public static string GetNewHashCode(string mcnt_OrderNo, string mcnt_Amount)
        {
            //string Hashvalue = GenerateHashValue(mcnt_OrderNo, mcnt_Amount);

            // Console.WriteLine(Hashvalue.ToLower());

            //string TxnResponse = "2";
            //string MerchantTxnNo = "13";
            //string SecurityKey = Guid.NewGuid().ToString();
            //string phpmd5convertcsharp = Convertmd5(string.Concat(string.Concat(TxnResponse, MerchantTxnNo, SecurityKey)));
            //Console.WriteLine(phpmd5convertcsharp.ToLower()); 
            // string[] s1 = new string[4];


            // s1[0] = Hashvalue.ToLower();
            //   s1[2] = phpmd5convertcsharp;

            return GenerateHashValue(mcnt_OrderNo, mcnt_Amount).ToLower();
        }
        public static String GetHash(String text, String secretKey)
        {
            string key = secretKey.ToUpper();
            // change according to your needs, an UTF8Encoding
            // could be more suitable in certain situations
            ASCIIEncoding encoding = new ASCIIEncoding();

            Byte[] textBytes = encoding.GetBytes(text);
            Byte[] keyBytes = encoding.GetBytes(key);

            Byte[] hashBytes;

            using (HMACSHA256 hash = new HMACSHA256(keyBytes))
                hashBytes = hash.ComputeHash(textBytes);

            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
        public static string CreateSHA256(string message, string secretKey)
        {
            string key = secretKey.ToUpper();
            string checkKey1 = "";
            string checkKey2 = "";
            string checkKey3 = "";
            string checkKey4 = "";
            string checkKey = "";
            checkKey1 += Convert.ToString(Convert.ToInt32(key.Substring(0, 8), 16), 2);
            checkKey2 += Convert.ToString(Convert.ToInt32(key.Substring(8, 8), 16), 2);
            checkKey3 += Convert.ToString(Convert.ToInt32(key.Substring(16, 8), 16), 2);
            checkKey4 += Convert.ToString(Convert.ToInt32(key.Substring(24, 8), 16), 2);

            checkKey = (checkKey1.Length == 32 ? checkKey1 : "0" + checkKey1) + (checkKey2.Length == 32 ? checkKey2 : "0" + checkKey2) + (checkKey3.Length == 32 ? checkKey3 : "0" + checkKey3) + (checkKey4.Length == 32 ? checkKey4 : "0" + checkKey4);

            Console.WriteLine("checkKey1:" + (checkKey1.Length == 32 ? checkKey1 : "0" + checkKey1));
            Console.WriteLine("checkKey2:" + (checkKey2.Length == 32 ? checkKey2 : "0" + checkKey2));
            Console.WriteLine("checkKey3:" + (checkKey3.Length == 32 ? checkKey3 : "0" + checkKey3));
            Console.WriteLine("checkKey4:" + (checkKey4.Length == 32 ? checkKey4 : "0" + checkKey4));

            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            byte[] keyByte = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            byte[] posA = { 128, 64, 32, 16, 8, 4, 2, 1 };
            byte zero = 0;
            for (int ikb = 0; ikb < keyByte.Length; ikb++)
            {
                int pos = 0;
                for (int ick = ikb * 8; ick < ((ikb + 1) * 8); ick++, pos++)
                {
                    byte nv = checkKey.Substring(ick, 1) == "0" ? zero : posA[pos];
                    keyByte[ikb] += nv;
                }
            }

            HMACSHA256 hmacsha256 = new HMACSHA256(keyByte);
            byte[] messageBytes = enc.GetBytes(message);
            byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);

            return ByteToString(hashmessage);
        }
        public static string GenerateHashValue(string mcnt_OrderNo, string mcnt_Amount)
        {
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            queryString["mcnt_AccessCode"] = StaticInfos.mcnt_AccessCode;
            queryString["mcnt_TxnNo"] = "Txn" + mcnt_OrderNo;
            queryString["mcnt_ShortName"] = StaticInfos.mcnt_ShortName;
            queryString["mcnt_OrderNo"] = mcnt_OrderNo;
            queryString["mcnt_ShopId"] = StaticInfos.mcnt_ShopId;
            queryString["mcnt_Amount"] = mcnt_Amount;
            queryString["mcnt_Currency"] = "BDT";
            //old api where pack use
            //string hashValue = CreateSHA256(queryString.ToString(), "754f788b67607c148844ba70a5d4784c");

            //Console.WriteLine(queryString.ToString());
            //no pack use 
            string hashValue = GetHash(queryString.ToString(), StaticInfos.secretkey);
            return hashValue;
        }
        public static string ByteToString(byte[] buff)
        {
            string sbinary = "";
            for (int i = 0; i < buff.Length; i++)
            {
                sbinary += buff[i].ToString("X2"); // hex format
            }
            return (sbinary);
        }
        public static string Convertmd5(string a)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputbytes = System.Text.Encoding.ASCII.GetBytes(a);
            byte[] hash = md5.ComputeHash(inputbytes);

            return ByteToString(hash);
        }

      
    }
}
