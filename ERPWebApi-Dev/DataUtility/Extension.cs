//using DataModels.EntityModels.ERPModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

//using Microsoft.AspNetCore.Http;
//using Oracle.ManagedDataAccess.Client;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;
using Oracle.ManagedDataAccess.Client;

namespace DataUtility
{
    public class Extension
    {
        //private static string HttpContext = "MS_HttpContext";
        //private static string RemoteEndpointMessage = "System.ServiceModel.Channels.RemoteEndpointMessageProperty";
        private static IConfiguration _configuration = null;

        private static String[] units = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
        private static String[] tens = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        public Extension()
        {

        }

        public Extension(IConfiguration iConfig)
        {
            _configuration = iConfig;
        }

        //public static DateTime Today
        //{
        //    get
        //    {
        //        DateTime now = DateTime.Now;
        //        return now;
        //    }
        //}

        public static DateTime UtcToday
        {
            get
            {
                DateTime now = DateTime.UtcNow;
                //DateTime now = TimeZoneInfo.ConvertTimeToUtc(DateTime.UtcNow);
                return now;
            }
        }

        public static DateTime Today
        {
            get
            {
                DateTime now = DateTime.Now;
                //DateTime now = TimeZoneInfo.ConvertTimeToUtc(DateTime.UtcNow);
                return now;
            }
        }

        //public static DateTime LocalToUtc(DateTime local)
        //{
        //    DateTime now = TimeZoneInfo.ConvertTimeToUtc(local, TimeZoneInfo.Local);
        //    //DateTime now = TimeZoneInfo.ConvertTimeToUtc(local, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time"));            
        //    return now;
        //}

        public static DateTime LocalToUtc(DateTime local)
        {
            DateTime now = local.ToUniversalTime();
            //DateTime now = TimeZoneInfo.ConvertTimeToUtc(local);
            //DateTime now = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(local, "Central Standard Time");
            return now;
        }

        public static DateTime LocalToUtcWithTimeZoneNumber(DateTime local, double zoneNumber)//Region hour base-Cloud
        {
            DateTime now = new DateTime();
            if (zoneNumber > 0)
            {
                zoneNumber = Math.Abs(zoneNumber);
                now = local.AddHours(-zoneNumber);
            }
            else
            {
                zoneNumber = Math.Abs(zoneNumber);
                now = local.AddHours(zoneNumber);
            }
            return now;
        }

        public static DateTime UtcToLocalWithTimeZoneNumber(DateTime utc, double zoneNumber)//Region hour base-Cloud
        {
            DateTime now = utc.AddHours(zoneNumber);
            return now;
        }

        public static DateTime LocalToUtcWithTimeZoneNumber(DateTime local, string zoneOperator, double zoneNumber)//Region hour base-Cloud
        {
            DateTime now = new DateTime();
            string Operator = zoneOperator == "-" ? "-" : "+";
            if (Operator == "+")
            {
                now = local.AddHours(-zoneNumber);
            }
            else
            {
                now = local.AddHours(zoneNumber);
            }
            return now;
        }

        public static DateTime UtcToLocalWithTimeZoneNumber(DateTime utc, string zoneOperator, double zoneNumber)//Region hour base-Cloud
        {
            DateTime now = new DateTime();
            string Operator = zoneOperator == "-" ? "-" : "+";
            if (Operator == "+")
            {
                now = utc.AddHours(zoneNumber);
            }
            else
            {
                now = utc.AddHours(-zoneNumber);
            }
            return now;
        }

        public static DateTime BDToUtc(DateTime local)
        {
            DateTime now = local.AddHours(-6);
            return now;
        }

        public static DateTime UtcToBD(DateTime utc)
        {
            DateTime now = utc.AddHours(6);
            return now;
        }

        //public static DateTime UtcToLocal(DateTime utc)
        //{
        //    DateTime now = utc.ToLocalTime();
        //    return now;
        //}

        public static DateTime UtcToLocal(string timeZoneId)
        {
            if (Environment.OSVersion.Platform.ToString() != "Win32NT")
                timeZoneId = StaticInfos.LinuxTimeZoneBD;
            DateTime timeUtc = DateTime.UtcNow;
            //DateTime timeLocal = TimeZoneInfo.ConvertTime(timeUtc, TimeZoneInfo.FindSystemTimeZoneById(timeZoneId));
            DateTime timeLocal = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, TimeZoneInfo.FindSystemTimeZoneById(timeZoneId));
            return timeLocal;
        }

        public static DateTime UtcToLocal(DateTime UserDate, string timeZoneId)
        {
            if (Environment.OSVersion.Platform.ToString() != "Win32NT")
                timeZoneId = StaticInfos.LinuxTimeZoneBD;
            //DateTime timeLocal = TimeZoneInfo.ConvertTime(timeUtc, TimeZoneInfo.FindSystemTimeZoneById(timeZoneId));
            DateTime timeLocal = TimeZoneInfo.ConvertTimeFromUtc(UserDate, TimeZoneInfo.FindSystemTimeZoneById(timeZoneId));
            return timeLocal;
        }

        #region OSTime
        public static int OsDeployMinutes(string os)
        {
            /*
                CentOS 6 = 1min
                CentOS 7 = 1min
                NFS as Service = 1min
                Ubuntu 16.04 = 1min
                Windows 2012 = 5min
            */

            int minutes = 0;

            try
            {
                //if (_configuration != null)
                //{
                switch (os)
                {
                    case "CentOS 6":
                        minutes = 4;
                        break;
                    case "CentOS 7":
                        minutes = 4;
                        break;
                    case "NFS as Service":
                        minutes = 5;
                        break;
                    case "Ubuntu 16.04":
                        minutes = 5;
                        break;
                    case "Windows Server 2012":
                        minutes = 8;
                        break;
                    case "WordPress Application":
                        minutes = 7;
                        break;
                    case "WordPress On Docker":
                        minutes = 7;
                        break;
                    case "TestModel":
                        minutes = 7;
                        break;
                    case "NextCloud":
                        minutes = 5;
                        break;
                    case "Windows Server 2019":
                        minutes = 8;
                        break;
                    case "Oracle Linux 6.10":
                        minutes = 6;
                        break;
                    case "Oracle Linux 7.7":
                        minutes = 6;
                        break;
                    case "Zabbix":
                        minutes = 6;
                        break;
                    default:
                        minutes = 9;
                        break;
                }
                //}
            }
            catch (Exception)
            {
                minutes = 7;
            }

            return minutes;

        }
        #endregion

        public static string GetSubString(string str, int length)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Length > length)
                {
                    str = str.Substring(0, length) + "..";
                }
            }
            return str;
        }
        public static async Task<bool> IsServerAvailable()
        {
            int StatusCode = 0; bool IsServerAvailable = false;

            try
            {
                HttpClient Client = new HttpClient();
                var result = await Client.GetAsync("https://cloudportal.pacecloud.com");
                StatusCode = (int)result.StatusCode;
                if (StatusCode == 200)
                    IsServerAvailable = true;
                else
                    IsServerAvailable = false;
            }
            catch (Exception)
            {

            }

            return IsServerAvailable;
        }

        //public static async Task<bool> IsISPServerAvailable()
        //{
        //    int StatusCode = 0; bool IsServerAvailable = false;

        //    try
        //    {
        //        HttpClient Client = new HttpClient();
        //        var url = StaticInfos.GetIspApiUrl();
        //        string getUrl = url[5].URL; // apistatus

        //        var result = await Client.GetAsync(getUrl);
        //        //var result = await Client.GetAsync("http://123.136.24.102:8080");
        //        //var result = await Client.GetAsync("http://123.136.24.6:8080");
        //        //var result = await Client.GetAsync("http://123.136.26.38:8080");
        //        //var result = await Client.GetAsync("https://123.136.29.119/index.php");

        //        StatusCode = (int)result.StatusCode;
        //        if (StatusCode == 200)
        //            IsServerAvailable = true;
        //        else
        //            IsServerAvailable = false;
        //    }
        //    catch (Exception)
        //    {

        //    }

        //    return IsServerAvailable;
        //}

        //public static async Task<bool> IsDateBetweenFinancialYear(DateTime inputDate)
        //{
        //    bool IsPass = false;

        //    try
        //    {
        //        using (var _ctx = new dbRGLERPContext())
        //        {
        //            var financeYear = await _ctx.AccFinancialYear.Where(x => x.IsCurrent == true).FirstOrDefaultAsync();
        //            DateTime StartDate = Convert.ToDateTime(financeYear.FinancialYearStart); DateTime EndDate = Convert.ToDateTime(financeYear.FinancialYearEnd);
        //            IsPass = inputDate >= StartDate && inputDate <= EndDate ? true : false;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }

        //    return IsPass;
        //}

        //public static async Task<bool> IsDateBetweenFinancialYear(string SDate, string EDate)
        //{
        //    bool IsPass = false;

        //    try
        //    {
        //        using (var _ctx = new dbRGLERPContext())
        //        {
        //            if (SDate != string.Empty && EDate.ToString() != string.Empty)
        //            {
        //                DateTime sDate = Convert.ToDateTime(SDate);
        //                DateTime eDate = Convert.ToDateTime(EDate);
        //                var financeYear = await _ctx.AccFinancialYear.Where(x => x.IsCurrent == true).FirstOrDefaultAsync();
        //                DateTime StartDate = Convert.ToDateTime(financeYear.FinancialYearStart); DateTime EndDate = Convert.ToDateTime(financeYear.FinancialYearEnd);
        //                IsPass = (sDate >= StartDate && sDate <= EndDate) && (eDate >= StartDate && eDate <= EndDate) ? true : false;
        //            }
        //            else
        //            {
        //                IsPass = true;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }

        //    return IsPass;
        //}
        public static string GetDefaultDateFormat(DateTime? date)
        {
            return date == null ? string.Empty : Convert.ToDateTime(date).ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        public static DateTime UTCDefaultDateFormat(DateTime local)
        {
            //DateTime date = local.ToUniversalTime();

            DateTime date = TimeZoneInfo.ConvertTimeToUtc(local);
            return date = Convert.ToDateTime(date.ToString("MM/dd/yyyy hh:mm:ss tt"));
        }

        public static string UTCDefaultDateFormatString(DateTime? local)
        {
            //DateTime? date = local == null ? null : (DateTime?)Convert.ToDateTime(local).ToUniversalTime();
            DateTime? date = local == null ? null : local; //(DateTime?)TimeZoneInfo.ConvertTimeToUtc(Convert.ToDateTime(local));
            return date == null ? string.Empty : TimeZoneInfo.ConvertTimeToUtc(Convert.ToDateTime(date)).ToString("MM/dd/yyyy hh:mm:ss tt");
        }


        public static String ConvertAmountInWord(double amount)
        {
            try
            {
                Int64 amount_int = (Int64)amount;
                Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);
                if (amount_dec == 0)
                {
                    return ConvertInt64(amount_int) + " Only.";
                }
                else
                {
                    return ConvertInt64(amount_int) + " Point " + ConvertInt64(amount_dec) + " Only.";
                }
            }
            catch (Exception e)
            {
                e.ToString();
                // TODO: handle exception  
            }
            return "";
        }

        public static String ConvertInt64(Int64 i)
        {
            if (i < 20)
            {
                return units[i];
            }
            if (i < 100)
            {
                return tens[i / 10] + ((i % 10 > 0) ? " " + ConvertInt64(i % 10) : "");
            }
            if (i < 1000)
            {
                return units[i / 100] + " Hundred"
                        + ((i % 100 > 0) ? " And " + ConvertInt64(i % 100) : "");
            }
            if (i < 100000)
            {
                return ConvertInt64(i / 1000) + " Thousand "
                + ((i % 1000 > 0) ? " " + ConvertInt64(i % 1000) : "");
            }
            if (i < 10000000)
            {
                return ConvertInt64(i / 100000) + " Lakh "
                        + ((i % 100000 > 0) ? " " + ConvertInt64(i % 100000) : "");
            }
            if (i < 1000000000)
            {
                return ConvertInt64(i / 10000000) + " Crore "
                        + ((i % 10000000 > 0) ? " " + ConvertInt64(i % 10000000) : "");
            }
            return ConvertInt64(i / 1000000000) + " Billion "
                    + ((i % 1000000000 > 0) ? " " + ConvertInt64(i % 1000000000) : "");
        }

        public static DateTime SetUTCCycleFromDate(DateTime? utc)
        {
            DateTime utcs = UtcToBD((DateTime)utc);
            DateTime now = BDToUtc(Convert.ToDateTime(utcs.AddDays(1).ToString("MM/dd/yyyy") + " 00:00:00"));
            return now;
        }

        public static DateTime SetBDBillStartDate(DateTime? bd, double days)
        {
            DateTime now = Convert.ToDateTime(Convert.ToDateTime(bd).AddDays(days).ToString("MM/dd/yyyy") + " 00:00:00");
            return now;
        }

        public static DateTime SetBDBillStartDate(DateTime? bd)
        {
            DateTime now = Convert.ToDateTime(Convert.ToDateTime(bd).ToString("MM/dd/yyyy") + " 00:00:00");
            return now;
        }

        public static DateTime SetUTCBillStartDate(DateTime? utc)
        {
            DateTime utcs = UtcToBD((DateTime)utc);
            DateTime now = BDToUtc(Convert.ToDateTime(utcs.ToString("MM/dd/yyyy") + " 00:00:00"));
            return now;
        }

        public static DateTime SetUTCBillEndDate(DateTime? utc)
        {
            DateTime utcs = UtcToBD((DateTime)utc);
            DateTime now = BDToUtc(Convert.ToDateTime(utcs.AddDays(29).ToString("MM/dd/yyyy") + " 23:59:59"));
            return now;
        }

        public static DateTime SetBDBillEndDate(DateTime? bd)
        {
            DateTime now = Convert.ToDateTime(Convert.ToDateTime(bd).AddDays(29).ToString("MM/dd/yyyy") + " 23:59:59");
            return now;
        }

        public static string SetBDStartDate(DateTime? bd)
        {
            string now = Convert.ToDateTime(bd).ToString("MM/dd/yyyy") + " 00:00:00";
            return now;
        }

        public static string SetBDEndDate(DateTime? bd)
        {
            string now = Convert.ToDateTime(bd).ToString("MM/dd/yyyy") + " 23:59:59";
            return now;
        }

        public static string SetBDToUtcStartDate(DateTime? bd)
        {
            DateTime dates = Convert.ToDateTime(Convert.ToDateTime(bd).ToString("MM/dd/yyyy") + " 00:00:00");
            string now = BDToUtc(dates).ToString("MM/dd/yyyy HH:mm:ss");
            return now;
        }

        public static string SetBDToUtcEndDate(DateTime? bd)
        {
            DateTime dates = Convert.ToDateTime(Convert.ToDateTime(bd).ToString("MM/dd/yyyy") + " 23:59:59");
            string now = BDToUtc(dates).ToString("MM/dd/yyyy HH:mm:ss");
            return now;
        }

        public static DateTime SetBDEOMDate(DateTime? bd, bool isBdToUtc)
        {
            DateTime tBD = Convert.ToDateTime(bd);
            DateTime dates = Convert.ToDateTime(new DateTime(tBD.Year, tBD.Month + 1, 1).AddDays(-1).ToString("MM/dd/yyyy") + " 23:59:59");
            DateTime now = isBdToUtc == false ? dates : BDToUtc(dates);
            return now;
        }

        public static DateTime SetBDBOMDate(DateTime? bd, bool isBdToUtc)
        {
            DateTime tBD = Convert.ToDateTime(bd);
            DateTime dates = Convert.ToDateTime(new DateTime(tBD.Year, tBD.Month, 1).ToString("MM/dd/yyyy") + " 00:00:00");
            DateTime now = isBdToUtc == false ? dates : BDToUtc(dates);
            return now;
        }

        public static DateTime SetUTCEOMDate(DateTime? utc, bool isUtcToBd)
        {
            DateTime tBD = UtcToBD(Convert.ToDateTime(utc));
            DateTime dates = Convert.ToDateTime(new DateTime(tBD.Year, tBD.Month + 1, 1).AddDays(-1).ToString("MM/dd/yyyy") + " 23:59:59");
            DateTime now = isUtcToBd == false ? BDToUtc(dates) : dates;
            return now;
        }

        public static DateTime SetUTCBOMDate(DateTime? utc, bool isUtcToBd)
        {
            DateTime tBD = UtcToBD(Convert.ToDateTime(utc));
            DateTime dates = Convert.ToDateTime(new DateTime(tBD.Year, tBD.Month, 1).ToString("MM/dd/yyyy") + " 00:00:00");
            DateTime now = isUtcToBd == false ? BDToUtc(dates) : dates;
            return now;
        }

        public static string BoolVal(bool? Bool)
        {
            return Bool == true ? "1" : "0";
        }

        public static bool BoolVal(string Str)
        {
            return Str == "1" ? true : false;
        }

        public static string Createpc()
        {
            var request = Context.request;
            string IpAddress = string.Empty;
            if (request.HttpContext.Request.Host.Host != "localhost")
            {
                IpAddress = request.HttpContext.Connection.RemoteIpAddress.ToString();
            }
            else
            {
                var ipHosts = Dns.GetHostEntry(Dns.GetHostName()).AddressList.ToList().Where(p => p.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToList();
                var hosts = String.Join(",", ipHosts.Select(x => x));
                IpAddress = hosts;
            }

            return IpAddress;
        }

        public static string Get_OID(string tableName, string primaryKeyId, string concateString, string conString)
        {
            string result = string.Empty;
            OracleConnection con = new OracleConnection(conString);
            using (OracleCommand objCmd = new OracleCommand())
            {
                using (objCmd.Connection = con)
                {
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandText = "SELECT GET_OID('" + tableName + "', '" + primaryKeyId + "', '" + concateString + "') FROM DUAL";
                    objCmd.Connection.Open();
                    result = objCmd.ExecuteScalar().ToString();
                    objCmd.Connection.Close();
                }
            }
            return result;
        }

        public static string GET_CODE(string tableName, string primaryKeyId, string conString)
        {
            string result = string.Empty;
            OracleConnection con = new OracleConnection(conString);
            using (OracleCommand objCmd = new OracleCommand())
            {
                using (objCmd.Connection = con)
                {
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandText = "SELECT GET_CODE('" + tableName + "', '" + primaryKeyId + "') FROM DUAL";
                    objCmd.Connection.Open();
                    result = objCmd.ExecuteScalar().ToString();
                    objCmd.Connection.Close();
                }
            }
            return result;
        }

        public static string GET_INC_OID(string concateString, int maxIdStartFrom, int incNumber, string conString)
        {
            string result = string.Empty;
            OracleConnection con = new OracleConnection(conString);
            using (OracleCommand objCmd = new OracleCommand())
            {
                using (objCmd.Connection = con)
                {
                    objCmd.CommandType = CommandType.Text;
                    objCmd.CommandText = "SELECT GET_INC_OID('" + concateString + "', " + maxIdStartFrom + ", " + incNumber + ") FROM DUAL";
                    objCmd.Connection.Open();
                    result = objCmd.ExecuteScalar().ToString();
                    objCmd.Connection.Close();
                }
            }
            return result;
        }

        public static object GetDynamicValue(dynamic Obj, string col)
        {
            return Obj.GetType().GetProperty(col).GetValue(Obj, null);
        }

        public static string GetJsonValue(string json, string col)
        {
            string strVal = string.Empty;
            string strCorr = json.Replace("[", "").Replace("]", "");
            JObject obj = JObject.Parse(strCorr);
            strVal = obj[col].ToString();
            return strVal;
        }

        public static DataTable GetReportDataTable(object dataList)
        {            
            DataTable dataTable = new DataTable();
            var serializeData = JsonConvert.SerializeObject(dataList);
            var deSerializeData = JsonConvert.DeserializeObject(serializeData);
            dataTable = JsonConvert.DeserializeObject<DataTable>(deSerializeData.ToString());
            if (dataTable==null || dataTable.Rows.Count==0)
            {
                dataTable= new DataTable();
                DataRow dr = dataTable.NewRow();
                dataTable.Rows.InsertAt(dr, 0);
            }
            return dataTable;
        }

        public static DataTable GetDataTable(object dataList)
        {
            DataTable dataTable = new DataTable();
            var serializeData = JsonConvert.SerializeObject(dataList);
            var deSerializeData = JsonConvert.DeserializeObject(serializeData);
            dataTable = JsonConvert.DeserializeObject<DataTable>(deSerializeData.ToString());            
            return dataTable;
        }

        public static string dataColumn = "DataSet";
        public static DataTable AddDataSetName(DataTable dataTable, string dataSetName)
        {
            DataColumn dataCol = new DataColumn(dataColumn, typeof(String));
            dataCol.DefaultValue = dataSetName;
            dataTable.Columns.Add(dataCol);
            return dataTable;
        }

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }

    public class Context
    {
        public static IHttpContextAccessor request { get; set; }
        public static void setContext(IHttpContextAccessor req)
        {
            request = req;
        }
    }
}