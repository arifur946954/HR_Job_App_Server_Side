using DataModel.ViewModels;
//using DataModels.ViewModels.ERPViewModel.Business.ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DataUtility
{
    public static class StaticInfos
    {
        public const bool IsLive = true;
        public const bool IsLiveBkash = false;
        public const bool IsLiveNagad = false;
        public const bool IsLiveSms = false;
        public const bool IsLiveDev = false;

        #region All ConnectionString
        #region ERP ConnectionString 
        public const String conErpLocal = @"Server=192.168.61.201;Database=dbRGLERP;User Id=sa; Password=sa@12345#;";
        public const String conErpDevLive = @"Server=100.120.2.56;Database=dbRGLERP;User Id=sa; Password=@sa12345#;";
        public const String conErpLive = @"Server=100.120.2.55;Database=dbRGLERP;User Id=sa; Password=@sa12345#;";
        public const String conString = IsLive && !IsLiveDev ? conErpLive : !IsLive && IsLiveDev ? conErpDevLive : conErpLocal;
        #endregion
        #region ERP Log ConnectionString
        public const String conStringLog = @"Server=100.120.2.55;Database=dbRGLERPLog;User Id=sa; Password=@sa12345#;";
        #endregion
        #region ERP IPTV ConnectionString
        public const String conStringTv = @"Server=100.120.2.55;Database=dbRGLTV;User Id=sa; Password=@sa12345#;";
        #endregion
        #region ERP Attendance ConnectionString
        public const String conStringAtt = IsLive ? @"Server=100.120.2.55;Database=dbRGLAttendance;User Id=sa; Password=@sa12345#;" : @"Server=100.120.2.57;Database=dbRGLAttendance;User Id=sa; Password=@sa12345#;";
        #endregion
        #region MySQL ConnectionString
        public const String conStringMySQL = @"server=123.136.24.102;database=radius;userid=software;password=PaceRadius1419;SslMode=none;";
        #endregion
        #region Oracle ConnectionString
        //public const String conStringOracle = @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl.citygroupbd.com)));User Id=jtest;Password=WeCity123;;Persist Security Info=True";
        //public const String conStringOracle = @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=192.168.61.129)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=oram.citygroupbd.com)));User Id=speecbubble;Password=WelcomeSpeech21;Persist Security Info=True";
        //public const String conStringOracleOld = @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=erp-standby)(PORT=1528))(CONNECT_DATA=(SERVICE_NAME=MEDIAPDB)));User Id=city_media;Password=citymedia.it;Persist Security Info=True";
        //public const String conStringOracle = IsLive? @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=erpprd)(PORT=1528))(CONNECT_DATA=(SERVICE_NAME=MEDIAPDB)));User Id=city_media;Password=citymedia.it;Persist Security Info=True" 
                                                // : @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=192.168.61.129)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=oram.citygroupbd.com)));User Id=speecbubble;Password=WelcomeSpeech21;Persist Security Info=True";
        //"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=erp-standby)(PORT=1528))(CONNECT_DATA=(SERVICE_NAME=MEDIAPDB)));User Id=city_media;Password=citymedia.it;;Persist Security Info=True"
        public const String conStringOracleCTN = @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=erpprd)(PORT=1523))(CONNECT_DATA=(SERVICE_NAME=CITYNPDB)));User Id=cityn;Password=CITY.IT;Persist Security Info=True";

        //public const String conStringOracle="";
        //public const String conStringOracleCTN = "";
        public const String conStringOracle = IsLive ? @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=erpprd)(PORT=1525))(CONNECT_DATA=(SERVICE_NAME=hrdpdb)));User Id=hr_job_app;Password=hr_job_it;Persist Security Info=True"
                                                 : @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=erpprd)(PORT=1525))(CONNECT_DATA=(SERVICE_NAME=hrdpdb)));User Id=hr_job_app;Password=hr_job_it;Persist Security Info=True";
        #endregion
        #endregion
        #region Super Admin Logged Info
        public const String SuperAdmin_UserId = "sys_admin";
        public const String SuperAdmin_Password = "sysad@12345#";
        public const String SuperAdmin_FullName = "City Group Software Unit";

        #endregion
        #region CTG Logged Detail
       public const String loginUrl = "https://cssap.citygroupbd.com/acmsapi/api/usersetup/verifyuser";
       public const String loggedInfoUrl = "https://app.citygroupbd.com/portal/eportal.api/api/getEmployeeById?Id=";
       public const String passUpdateUrl = "https://cssap.citygroupbd.com/acmsapi/api/usersetup/changepassword";
       

        #endregion
        public const String recapsecretKey = "6LdKM8MUAAAAAB6KhEwcx41PV5ztNs-lFi4-X5kG";
        public const String GlobalDateFormat = "MM/dd/yyyy";
        public const int CompanyID = 1;
        public static int LoggedUserID = 1;
        public const int SeedRoleID = 1;
        public const bool IsActive = true;
        public const String seckey = "Basic bXVraGxhc19COjNEMTkyRUY2QTk0NjY2NTE=";
        public const String contentTypeJson = "application/json";
        public const String authorization = "Authorization";
        public const String vmTerminate = "Terminated";
        public const String vmError = "Error";
        public const String vmStop = "Stopped";
        public const String vmStart = "Running";
        public const int PayAsYoGoID = 1;
        public const int PrepaidID = 2;
        public const int PostpaidID = 3;
        public const int TrialID = 4;
        public const int IspUserNameStartFrom = 100000;
        public const int Prepaid = 1;
        public const int Postpaid = 2;
        public const string bkashNo = "01777706750";

        // test user id
        //public static int LoggedInUserID = 0;

        //public const int PostpaidID = 41;
        //public const int PayAsYoGoID = 40;
        //public const int PrepaidID = 38;

        public const int IspPrepaidID = 1;
        public const int IspPostpaidID = 2;

        //If stop Error bilCloudUserClientMgt billPaymentMgt
        public const int PayAsYoGoPlanID = 17;
        public const int PrePaidPlanID = 18;
        public const int PostPaidPlanID = 78;

        public const int radactPageSize = 100;
        public const int pageSize = 20;
        public const int packageTotalDays = 30;
        public const int packageTotalHour = 24;
        public const int CashPayment = 1;
        public const int ChequePayment = 2;
        public const int bKashPayment = 3;
        public const int fosterPayment = 4;
        public const int nagadPayment = 5;
        public const int exstBalancePayment = 100;
        // PackServiceTypeId == 1 means shared bandwidth
        public enum ISPPackServices
        {
            Radius = 1,//Shared Bandwidth
            Others = 2//Others Services
        }

        public enum ISPUserConType
        {
            Home = 1,//Residential User
            Corporate = 2,//Corporate User
            SME = 4//SME User
        }

        //Cloud User Email Policy
        public const string Cloud_Down_Email_Policy = "2";
        public const string Cloud_Storage_exceeded_80_Percent_usage_Email_Policy = "3";
        public const string Job_Status_Change_Email_Policy = "1";
        //BKash Cloud
        //public const String username = "ROYALGREENLTD";
        //public const String password = "P@ssword123##";
        //public const String bk_username = "sandboxTestUser";
        //public const String bk_password = "hWD@8vtzw0";
        //public const String app_key = "5tunt4masn6pv2hnvte1sb5n3j";
        //public const String app_secret = "1vggbqd4hqk9g96o9rrrp2jftvek578v7d2bnerim12a87dbrrka";

        //Demo BKash
        public const int bk_TokenExpire = 55;
        public const String bk_username = "testdemo";
        public const String bk_password = "test%#de23@msdao";
        public const String app_key = "5nej5keguopj928ekcj3dne8p";
        public const String app_secret = "1honf6u1c56mqcivtc9ffl960slp4v2756jle5925nbooa46ch62";

        //Live BKash
        public const int lbk_TokenExpire = 55;
        public const String lbk_username = "ROYALGREENLTD";
        public const String lbk_password = "rO3@Ya1LgrM6K";
        public const String lapp_key = "2447s684evsg9rdu8g7042snsa";
        public const String lapp_secret = "10eudpd3ffspont7llmd3labdoitli29s9lpd0qebb6aqt0hmf8j";

        #region BKash ISP Static Info
        //public const String isp_username = "ROYALGREENLTD";
        //public const String isp_password = "P@ssword123##";
        //public const String bk_username_isp = "sandboxTestUser";
        //public const String bk_password_isp = "hWD@8vtzw0";
        //public const String app_key_isp = "5tunt4masn6pv2hnvte1sb5n3j";
        //public const String app_secret_isp = "1vggbqd4hqk9g96o9rrrp2jftvek578v7d2bnerim12a87dbrrka";
        #endregion BKash ISP Static Info

        // rgl_secret_api_key
        public const String api_secret = "rgl_secret_api_key";
        // http header values
        public const String userAgent_key = "User-Agent";
        public const String sec_ch_ua = "sec-ch-ua";
        public const String api_key = "AuthorizedToken";
        public const String userId_key = "userId";
        public const String platformId_key = "platformId";
        public enum OriginAccess
        {
            ERP,
            PCP,
            PCM,
            PNP,
            PNM
        }
        public const string TokenKey = "RGLKey";
        public enum Platform
        {
            ERP = 1,
            Cloud = 2,
            ISP = 3
        }

        public enum MessageType
        {
            Individual = 1,
            Multiple = 2
        }

        public const int tokenValidity = 30;

        //Payment foster for sandbox
        //public const String mcnt_AccessCode = "190331053509";
        //public const String mcnt_ShortName = "FosterTest";
        //public const String mcnt_ShopId = "104";
        //public const String secretkey = "b5b50bcefaa3140c5775ed49469983da";
        //public const String cust_CustomerServiceName = "ISP Bill COLLECTION";
        //public const String mcnt_Currency = "BDT";
        //public const String cust_orderitems = "Recharge";
        //public const String merchentdomainname = "pacecloud.com";
        //public const String merchentip = "pacecloud.com";
        //public const String success_url = "https://pacecloud.com/cloud/#/billpay?paymentStatus=true";//must
        //public const String fail_url = "https://pacecloud.com/cloud/#/billpay?paymentStatus=false";//must
        //public const String cancel_url = "https://pacecloud.com/cloud/#/billpay?paymentStatus=false";//must


        //Payment foster for Live Cloud        
        public const String mcnt_AccessCode = "180227061958";
        public const String mcnt_ShortName = "RoyalGreen";
        public const String mcnt_ShopId = "43";
        public const String secretkey = "69098db6d95fc7053f854870fe57ff1f";
        public const String cust_CustomerServiceName = "ISP Bill COLLECTION";
        public const String mcnt_Currency = "BDT";
        public const String cust_orderitems = "Recharge";
        public const String merchentdomainname = "https://api.pacecloud.com/";
        public const String merchentip = "https://api.pacecloud.com/";
        public const String success_url = IsLive == true ? "https://pacecloud.com/cloud/#/billpay?paymentStatus=true" : "http://localhost:56045/cloud/#/billpay?paymentStatus=true";//must
        //public const String success_urlL = "http://localhost:56045/cloud/#/billpay?paymentStatus=true";//must[Local]
        public const String fail_url = "https://pacecloud.com/cloud/#/billpay?paymentStatus=false";//must
        public const String cancel_url = "https://pacecloud.com/cloud/#/billpay?paymentStatus=false";//must

        //User Activation Cloud
        //public const String activation_url = "http://pacecloud.com/cloud/#/activation/";//must
        public const String activation_url = "https://pacecloud.com/cloud/#/activation/";//must

        //Payment foster for Live ISP        
        public const String mcnt_AccessCode_isp = "180227061958";
        public const String mcnt_ShortName_isp = "RoyalGreen";
        public const String mcnt_ShopId_isp = "43";
        public const String secretkey_isp = "69098db6d95fc7053f854870fe57ff1f";
        public const String cust_CustomerServiceName_isp = "ISP Bill COLLECTION";
        public const String mcnt_Currency_isp = "BDT";
        public const String cust_orderitems_isp = "Recharge";
        public const String merchentdomainname_isp = "https://api.pacenet.net/";
        public const String merchentip_isp = "https://api.pacenet.net/";
        public const String success_url_isp = IsLive == true ? "https://pacenet.net/isp/#/billpay?paymentStatus=true" : "http://localhost:56046/isp/#/billpay?paymentStatus=true";//must[Live]
        //public const String success_url_ispL = "http://localhost:56046/isp/#/billpay?paymentStatus=true";//must[Local]
        public const String fail_url_isp = "https://pacenet.net/isp/#/billpay?paymentStatus=false";//must
        public const String cancel_url_isp = "https://pacenet.net/isp/#/billpay?paymentStatus=false";//must

        //User Activation ISP
        //public const String activation_url = "http://pacenet.net/isp/#/activation/";//must
        public const String activation_url_isp = "https://pacenet.net/isp/#/activation/";//must

        //public static List<vmCloudAPI> GetCloudAPIURL()
        //{
        //    List<vmCloudAPI> data = null;
        //    try
        //    {
        //        var ur1 = new vmCloudAPI(1, "https://cloudportal.pacecloud.com/v1/users");
        //        var ur2 = new vmCloudAPI(2, "https://cloudportal.pacecloud.com/v1/tenants/18/activationProfiles");
        //        var ur3 = new vmCloudAPI(3, "https://cloudportal.pacecloud.com/v2/tenants/{tenantId}/reports?reportType=USAGE_DETAILS_REPORT");
        //        var ur4 = new vmCloudAPI(4, "https://cloudportal.pacecloud.com/v1/tenants/{tenantId}/plans");
        //        var ur5 = new vmCloudAPI(5, "https://cloudportal.pacecloud.com/v1/virtualMachines?listType=MANAGED_VMS&includeTenantUsersVMs=true&status=Running,Starting,Stopped,Error,Stopping,Terminated"); //Get VM List with status
        //        var ur6 = new vmCloudAPI(6, "https://cloudportal.pacecloud.com/v1/tenants/{tenantId}/contracts");
        //        var ur7 = new vmCloudAPI(7, "https://cloudportal.pacecloud.com/v1/virtualMachines?listType=MANAGED_VMS&includeTenantUsersVMs=true");//Get VM List without status
        //        var ur8 = new vmCloudAPI(8, "https://cloudportal.pacecloud.com/v1/actions/1/executions"); //Stop VM
        //        var ur9 = new vmCloudAPI(9, "https://cloudportal.pacecloud.com/v1/actions/2/executions"); //Start VM
        //        var ur10 = new vmCloudAPI(10, "https://cloudportal.pacecloud.com/v1/executions/");
        //        var ur11 = new vmCloudAPI(11, "https://cloudportal.pacecloud.com/v1/tenants/{tenantId}/activationProfiles");
        //        var ur12 = new vmCloudAPI(12, "https://cloudportal.pacecloud.com/v1/actions/4/executions"); //Terminate VM
        //        var ur13 = new vmCloudAPI(13, "https://cloudportal.pacecloud.com/v1/actions/3/executions"); //Reboot VM
        //        var ur14 = new vmCloudAPI(14, "https://cloudportal.pacecloud.com/v1/apps");
        //        var ur15 = new vmCloudAPI(15, "https://cloudportal.pacecloud.com/v1/tenants/18/clouds/3/regions");
        //        var ur16 = new vmCloudAPI(16, "https://cloudportal.pacecloud.com/v1/environments");
        //        var ur17 = new vmCloudAPI(17, "https://cloudportal.pacecloud.com/v2/jobs");//vm deploy
        //        var ur18 = new vmCloudAPI(18, "https://cloudportal.pacecloud.com/v1/users/cloudUserId/keys");//
        //        var ur19 = new vmCloudAPI(19, "https://cloudportal.pacecloud.com/v1/tenants/{tenantId}/clouds/3/regions");
        //        var ur20 = new vmCloudAPI(20, "https://cloudportal.pacecloud.com/v2/regions/");
        //        var ur21 = new vmCloudAPI(21, "https://cloudportal.pacecloud.com/v1/regions/");
        //        var ur22 = new vmCloudAPI(22, "https://cloudportal.pacecloud.com/v1/regions/{regionid}/volumeSettings");
        //        var ur23 = new vmCloudAPI(23, "https://cloudportal.pacecloud.com/v2/jobs/{parentjobid}?hide=true");
        //        var ur24 = new vmCloudAPI(24, "https://cloudportal.pacecloud.com/job/service/webssh/{jobid}/{nodeid}?checkDepEnvPerms=false");
        //        var ur25 = new vmCloudAPI(25, "https://cloudportal.pacecloud.com/job/service/fetch_default_winpasswd/{jobid}/{nodeid}");
        //        var ur26 = new vmCloudAPI(26, "https://cloudportal.pacecloud.com/v1/jobs?appDetails=true&includeBenchmark=false");
        //        var ur27 = new vmCloudAPI(27, "https://cloudportal.pacecloud.com/policy/service/save_policy/");
        //        var ur28 = new vmCloudAPI(28, "https://cloudportal.pacecloud.com/policy/service/get_policies/scaling");
        //        var ur29 = new vmCloudAPI(29, "https://cloudportal.pacecloud.com/policy/service/get_all_metrics");
        //        var ur30 = new vmCloudAPI(30, "https://cloudportal.pacecloud.com/policy/service/get_policy/{id}");
        //        var ur31 = new vmCloudAPI(31, "https://cloudportal.pacecloud.com/v2/agingPolicies?hideNonAdminPolicies=false");
        //        var ur32 = new vmCloudAPI(32, "https://cloudportal.pacecloud.com/v2/agingPolicies/");
        //        var ur33 = new vmCloudAPI(33, "https://cloudportal.pacecloud.com/v2/agingPolicies/{id}");
        //        var ur34 = new vmCloudAPI(34, "https://cloudportal.pacecloud.com/policy/service/delete_policy/{id}");
        //        var ur35 = new vmCloudAPI(35, "https://cloudportal.pacecloud.com/v2/suspensionPolicies/");
        //        var ur36 = new vmCloudAPI(36, "https://cloudportal.pacecloud.com/v2/suspensionPolicies?hideNonAdminPolicies=false");
        //        var ur37 = new vmCloudAPI(37, "https://cloudportal.pacecloud.com/v2/suspensionPolicies/{id}");
        //        var ur38 = new vmCloudAPI(38, "https://cloudportal.pacecloud.com/v1/tenants/{tenantid}/bundles?page={pagenum}&size={pagesize}&sort=name&order=asc");
        //        var ur39 = new vmCloudAPI(39, "https://cloudportal.pacecloud.com/v1/tenants/{tenantid}/bundles");
        //        var ur40 = new vmCloudAPI(40, "https://cloudportal.pacecloud.com/v1/tenants/{tenantid}/bundles/{bundleid}");
        //        //var ur41 = new vmCloudAPI(41, "http://123.136.26.38:5000/log/{Limit}/{Offset}"); active but not used
        //        var ur41 = new vmCloudAPI(41, "http://123.136.26.38:5000/log1/{StartDateTime}/{EndDateTime}/{Limit}/{Offset}");//For log report paging
        //        var ur42 = new vmCloudAPI(42, "http://123.136.26.38:5000/log2/{StartDateTime}/{EndDateTime}");
        //        var ur43 = new vmCloudAPI(43, "https://cloudportal.pacecloud.com/v1/environments");
        //        var ur44 = new vmCloudAPI(44, "https://cloudportal.pacecloud.com/v1/tenants/?detail=true&page={page}&size={size}&sort=name&order=asc");
        //        var ur45 = new vmCloudAPI(45, "https://cloudportal.pacecloud.com/v1/tenants/");
        //        var ur46 = new vmCloudAPI(46, "https://cloudportal.pacecloud.com/v1/tenants/{tenantId}/clouds");
        //        var ur47 = new vmCloudAPI(47, "https://cloudportal.pacecloud.com/v1/virtualMachines?listType=MANAGED_VMS&includeTenantUsersVMs=true&status=Running,Starting");
        //        var ur48 = new vmCloudAPI(48, "https://cloudportal.pacecloud.com/v2/cloudentities/resource/regionid?resourceType=Instance&cloudAccount=cloudAccountId&resourceIds=vmid&entities=AttachedVolumes");
        //        var ur49 = new vmCloudAPI(49, "https://cloudportal.pacecloud.com/v1/executions/{executionsId}/status?logs=true");
        //        var ur50 = new vmCloudAPI(50, "https://cloudportal.pacecloud.com/v1/actions/5/executions");//attach volume
        //        var ur51 = new vmCloudAPI(51, "https://cloudportal.pacecloud.com/v1/actions/6/executions");//detach volume
        //        var ur52 = new vmCloudAPI(52, "https://cloudportal.pacecloud.com/v1/actions/8/executions");//Resize Instance
        //        var ur53 = new vmCloudAPI(53, "https://cloudportal.pacecloud.com/v1/virtualMachines?listType=MANAGED_VMS&includeTenantUsersVMs=true&status=Running,Starting,Stopped,Stopping");//for sync tenant vm url
        //        var ur54 = new vmCloudAPI(54, "https://cloudportal.pacecloud.com/job/service/get_job_info/{parentJobId}");//Resize Instance
        //        var ur55 = new vmCloudAPI(55, "https://cloudportal.pacecloud.com/v1/regions/{regionId}/volumeSettings");//Resize Instance
        //        var ur56 = new vmCloudAPI(56, "https://cloudportal.pacecloud.com/v1/actions/12/executions");//Sync VM Information From VMware or CISCO //Post API
        //        var ur57 = new vmCloudAPI(57, "https://cloudportal.pacecloud.com/policy/custom/state/{EmailNo}/enable");//Enable email with user activity for individual user, Here {EmailNo} will 1,2,3
        //        var ur58 = new vmCloudAPI(58, "https://cloudportal.pacecloud.com/policy/custom/state/{EmailNo}/disable");//Disable email with user activity for individual user,  Here {EmailNo} will 1,2,3
        //        var ur59 = new vmCloudAPI(59, "https://cloudportal.pacecloud.com/v1/jobs?appDetails=true&includeBenchmark=false&page={page}&size={size}&sort=id-&order=asc");
        //        var ur60 = new vmCloudAPI(60, "https://cloudportal.pacecloud.com/v1/virtualMachines?listType=MANAGED_VMS&includeTenantUsersVMs=false&status=Running,Starting,Stopped,Stopping");//for sync tenant' own vm url
        //        var ur61 = new vmCloudAPI(61, "https://cloudportal.pacecloud.com/v2/jobs/{JobId}?hide=true");//for terminate and hide job

        //        data = new List<vmCloudAPI> { ur1, ur2, ur3, ur4, ur5, ur6, ur7, ur8, ur9, ur10, ur11, ur12, ur13, ur14, ur15, ur16, ur17, ur18, ur19, ur20, ur21, ur22, ur23, ur24, ur25, ur26, ur27, ur28, ur29, ur30, ur31, ur32, ur33, ur34, ur35, ur36, ur37, ur38, ur39, ur40, ur41, ur42, ur43, ur44, ur45, ur46, ur47, ur48, ur49, ur50, ur51, ur52, ur53, ur54, ur55, ur56, ur57, ur58, ur59, ur60, ur61 };
        //    }
        //    catch (Exception) { }
        //    return data;
        //}

        //public static List<vmIspApi> GetIspApiUrl1()
        //{
        //    List<vmIspApi> data = null;
        //    try
        //    {
        //        //OLD
        //        //var ur1 = new vmCloudAPI(1, "http://123.136.26.38:8080/package");
        //        //var ur2 = new vmCloudAPI(2, "http://123.136.26.38:8080/user");
        //        //var ur3 = new vmCloudAPI(3, "http://123.136.26.38:8080/online");
        //        //var ur4 = new vmCloudAPI(4, "http://123.136.26.38:8080/acct");

        //        //NEW
        //        //var ur1 = new vmCloudAPI(1, "http://123.136.24.6:8080/package");
        //        //var ur2 = new vmCloudAPI(2, "http://123.136.24.6:8080/user");
        //        //var ur3 = new vmCloudAPI(3, "http://123.136.24.6:8080/online");
        //        //var ur4 = new vmCloudAPI(4, "http://123.136.24.6:8080/acct");

        //        //NEWER
        //        //var url1 = new vmIspApi(1, "http://123.136.24.102:8080/package", "package");
        //        //var url2 = new vmIspApi(2, "http://123.136.24.102:5000/user", "user");
        //        //var url3 = new vmIspApi(3, "http://123.136.24.102:5000/online", "online"); // http://123.136.24.102:8080/online/{userName}
        //        //var url4 = new vmIspApi(4, "http://123.136.24.102:8080/acct", "acct"); // http://123.136.24.102:8080/acct/{userName}/{limit}/{offset}
        //        //var url5 = new vmIspApi(5, "http://123.136.24.102:5000/user2pac", "user2pac");

        //        // NEWEST
        //        //string baseUrl = "http://123.136.24.102:8080";
        //        //var url1 = new vmIspApi(1, "http://123.136.24.102:5000/package", "package");    //  http://123.136.24.102:5000/package/{limit}/{offset}  
        //        //var url2 = new vmIspApi(2, "http://123.136.24.102:5000/user", "user");          //  http://123.136.24.102:5000/user/{limit}/{offset}
        //        //var url3 = new vmIspApi(3, "http://123.136.24.102:5000/online", "online");      //  http://123.136.24.102:5000/online/{userName}
        //        //var url4 = new vmIspApi(4, "http://123.136.24.102:5000/acct", "acct");          //  http://123.136.24.102:5000/acct/{userName}/{limit}/{offset} if user input 'all' instead of {userName} it get all radacct data
        //        //var url5 = new vmIspApi(5, "http://123.136.24.102:5000/user2pac", "user2pac");  //  http://123.136.24.102:5000/user2pac/{limit}/{offset}
        //        //var url6 = new vmIspApi(6, "http://123.136.24.102:5000", "apistatus");          //  http://123.136.24.102:5000

        //        // NEWEST NEW
        //        var url1 = new vmIspApi(1, "http://123.136.24.102:5000/package", "package");    //  http://123.136.24.102:5000/package/{limit}/{offset} 
        //        var url2 = new vmIspApi(2, "http://123.136.24.102:5000/user", "user");          //  http://123.136.24.102:5000/user/{limit}/{offset}
        //        var url3 = new vmIspApi(3, "http://123.136.24.102:5000/online", "online");      //  http://123.136.24.102:5000/online/{userName}
        //        var url4 = new vmIspApi(4, "http://123.136.24.102:5000/acct", "acct");          //  http://123.136.24.102:5000/acct/{userName}/{limit}/{offset} if user input 'all' instead of {userName} it get all radacct data
        //        var url5 = new vmIspApi(5, "http://123.136.24.102:5000/user2pac", "user2pac");  //  http://123.136.24.102:5000/user2pac/{limit}/{offset}  
        //        var url6 = new vmIspApi(6, "http://123.136.24.102:5000", "apistatus");          //  http://123.136.24.102:5000
        //        var url7 = new vmIspApi(7, "http://123.136.24.102:5000/log", "log");            //  http://123.136.24.102:5000/log/{userName}/{limit}/{offset} if user input 'all' instead of {userName} it get all login attempt data data

        //        data = new List<vmIspApi> { url1, url2, url3, url4, url5, url6, url7 };
        //    }
        //    catch (Exception) { }
        //    return data;
        //}

        //public static List<vmIspApi> GetIspApiUrl()
        //{
        //    List<vmIspApi> data = null;
        //    try
        //    {
        //        // old
        //        var URL1 = new vmIspApi(1, "http://123.136.24.102:5000/package", "package");    //  http://123.136.24.102:5000/package/{limit}/{offset} 
        //        var URL2 = new vmIspApi(2, "http://123.136.24.102:5000/user", "user");          //  http://123.136.24.102:5000/user/{limit}/{offset}
        //        var URL3 = new vmIspApi(3, "http://123.136.24.102:5000/online", "online");      //  http://123.136.24.102:5000/online/{userName}
        //        var URL4 = new vmIspApi(4, "http://123.136.24.102:5000/acct", "acct");          //  http://123.136.24.102:5000/acct/{userName}/{limit}/{offset} if user input 'all' instead of {userName} it get all radacct data
        //        var URL5 = new vmIspApi(5, "http://123.136.24.102:5000/user2pac", "user2pac");  //  http://123.136.24.102:5000/user2pac/{limit}/{offset}  
        //        var URL6 = new vmIspApi(6, "http://123.136.24.102:5000", "apistatus");          //  http://123.136.24.102:5000
        //        var URL7 = new vmIspApi(7, "http://123.136.24.102:5000/log", "log");            //  http://123.136.24.102:5000/log/{userName}/{limit}/{offset} if user input 'all' instead of {userName} it get all login attempt data data

        //        /* what we required
        //        1. http://123.136.24.102:5000/user/{userName}
        //        2. http://123.136.24.102:5000/acct/{userName}/{limit}/{offset}/{startDateTime}/{endDateTime}
        //        3. http://123.136.24.102:5000/user2pac/{userName}
        //        4. http://123.136.24.102:5000/log/{userName}/{limit}/{offset}/{startDateTime}/{endDateTime}
        //        5. API for Online user count
        //        6. API for Offline user count
        //        7. API for delete user from radius.
        //        8. http://123.136.24.102:5000/online/{limit}/{offset}/{sortBySessionUpdatetime}
        //        9. http://123.136.24.102:5000/offline/{limit}/{offset}/{sortBySessionStoptime}
        //        */

        //        /* what we get
        //        Date Format: 2020-09-06 09:10:00
        //        http://123.136.24.102:7000/user/<username>
        //        http://123.136.24.102:7000/acct/<username>/<limit>/<offset>/<start_date>/<end_date>
        //        http://123.136.24.102:7000/user2pac/<username>
        //        http://123.136.24.102:7000/log/<username>/<limit>/<offset>/<start_date>/<end_date>
        //        API for Online user count
        //        http://123.136.24.102:7000/onlinecount
        //        API for delete user from radius
        //        http://123.136.24.102:7000/user/<username>
        //        http://123.136.24.102:7000/online/<limit>/<offset>
        //        */

        //        // new
        //        var URL8 = new vmIspApi(8, "http://123.136.24.102:5000/acct", "acctNew");                       // http://123.136.24.102:7000/acct/<username>/<limit>/<offset>/<start_date>/<end_date>
        //        var URL9 = new vmIspApi(9, "http://123.136.24.102:5000/log", "logNew");                         // http://123.136.24.102:7000/log/<username>/<limit>/<offset>/<start_date>/<end_date>
        //        var URL10 = new vmIspApi(10, "http://123.136.24.102:5000/user2pac", "user2pacNew");             // http://123.136.24.102:7000/user2pac/<limit>/<offset>
        //        var URL11 = new vmIspApi(10, "http://123.136.24.102:5000/user2pac", "user2pacByUser");          // http://123.136.24.102:7000/user2pac/<username>
        //        var URL12 = new vmIspApi(11, "http://123.136.24.102:5000/package", "packageNew");               // http://123.136.24.102:7000/package/<limit>/<offset>
        //        var URL13 = new vmIspApi(12, "http://123.136.24.102:5000/online", "onlineStatus");              // http://123.136.24.102:7000/online/<username>
        //        var URL14 = new vmIspApi(13, "http://123.136.24.102:5000/onlinecount", "onlineCount");          // http://123.136.24.102:7000/onlinecount
        //        var URL15 = new vmIspApi(14, "http://123.136.24.102:5000/online", "onlineNew");                 // http://123.136.24.102:7000/online/<limit>/<offset>
        //        var URL16 = new vmIspApi(16, "http://123.136.24.102:5000", "apiStatusNew");                     // http://123.136.24.102:7000
        //        var URL17 = new vmIspApi(17, "http://123.136.24.102:5000/delete", "deleteUser");                // http://123.136.24.102:5000/delete/<username>
        //        var URL18 = new vmIspApi(17, "http://123.136.24.102:5000/disconnect", "disconnectUserSession"); // http://123.136.24.102:5000/disconnect/<username>
        //        data = new List<vmIspApi> {
        //            URL1
        //            , URL2
        //            , URL3
        //            , URL4
        //            , URL5
        //            , URL6
        //            , URL7
        //            , URL8
        //            , URL9
        //            , URL10
        //            , URL11
        //            , URL12
        //            , URL13
        //            , URL13
        //            , URL14
        //            , URL15
        //            , URL16
        //            , URL17
        //            , URL18
        //        };
        //    }
        //    catch (Exception) { }
        //    return data;
        //}

        /*public static List<vmIspApi> GetIspApiUrl()
        {
            List<vmIspApi> data = null;
            try
            {
                var api1 = new vmIspApi(20, "sharafat_test", "RGL@246$$", "https://123.136.29.119/index.php/api?secret=RGL@246$$&op=20&username=sharafat_test");

                data = new List<vmIspApi> { api1 };
            }
            catch (Exception) { }
            return data;
        }*/

        #region bKash sandbox
        //Demo BKash
        //public static List<vmCloudAPI> GetBKashApiUrl()
        //{
        //    List<vmCloudAPI> data = null;
        //    try
        //    {
        //        var ur1 = new vmCloudAPI(1, "https://checkout.sandbox.bka.sh/v1.2.0-beta/checkout/token/grant"); //Sandbox endpoint: https://<service-name>.sandbox.bka.sh
        //        var ur2 = new vmCloudAPI(2, "https://checkout.sandbox.bka.sh/v1.2.0-beta/checkout/payment/create"); //Production endpoint: https://<service-name>.pay.bka.sh
        //        var ur3 = new vmCloudAPI(3, "https://checkout.sandbox.bka.sh/v1.2.0-beta/checkout/payment/execute"); //Production endpoint: https://<service-name>.pay.bka.sh
        //        var ur4 = new vmCloudAPI(4, "https://checkout.sandbox.bka.sh/v1.2.0-beta/checkout/payment/query"); //Production endpoint: https://<service-name>.pay.bka.sh
        //        var ur5 = new vmCloudAPI(5, "https://checkout.sandbox.bka.sh/v1.2.0-beta/checkout/payment/search"); //Production endpoint: https://<service-name>.pay.bka.sh

        //        data = new List<vmCloudAPI> { ur1, ur2, ur3, ur4, ur5 };
        //    }
        //    catch (Exception) { }
        //    return data;
        //}

        ////Live BKash
        //public static List<vmCloudAPI> GetlBKashApiUrl()
        //{
        //    List<vmCloudAPI> data = null;
        //    try
        //    {
        //        //base URL bKash
        //        //https://checkout.pay.bka.sh/v1.2.0-beta
        //        var ur1 = new vmCloudAPI(1, "https://checkout.pay.bka.sh/v1.2.0-beta/checkout/token/grant"); //Sandbox endpoint: https://<service-name>.sandbox.bka.sh
        //        var ur2 = new vmCloudAPI(2, "https://checkout.pay.bka.sh/v1.2.0-beta/checkout/payment/create"); //Production endpoint: https://<service-name>.pay.bka.sh
        //        var ur3 = new vmCloudAPI(3, "https://checkout.pay.bka.sh/v1.2.0-beta/checkout/payment/execute"); //Production endpoint: https://<service-name>.pay.bka.sh
        //        var ur4 = new vmCloudAPI(4, "https://checkout.pay.bka.sh/v1.2.0-beta/checkout/payment/query"); //Production endpoint: https://<service-name>.pay.bka.sh
        //        var ur5 = new vmCloudAPI(5, "https://checkout.pay.bka.sh/v1.2.0-beta/checkout/payment/search"); //Production endpoint: https://<service-name>.pay.bka.sh

        //        data = new List<vmCloudAPI> { ur1, ur2, ur3, ur4, ur5 };
        //    }
        //    catch (Exception) { }
        //    return data;
        //}
        #endregion

        #region nagad sandbox
        // keys
        public static string nagadMarchentPrivateKey = IsLiveNagad ? "MIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCJakyLqojWTDAVUdNJLvuXhROV+LXymqnukBrmiWwTYnJYm9r5cKHj1hYQRhU5eiy6NmFVJqJtwpxyyDSCWSoSmIQMoO2KjYyB5cDajRF45v1GmSeyiIn0hl55qM8ohJGjXQVPfXiqEB5c5REJ8Toy83gzGE3ApmLipoegnwMkewsTNDbe5xZdxN1qfKiRiCL720FtQfIwPDp9ZqbG2OQbdyZUB8I08irKJ0x/psM4SjXasglHBK5G1DX7BmwcB/PRbC0cHYy3pXDmLI8pZl1NehLzbav0Y4fP4MdnpQnfzZJdpaGVE0oI15lq+KZ0tbllNcS+/4MSwW+afvOw9bazAgMBAAECggEAIkenUsw3GKam9BqWh9I1p0Xmbeo+kYftznqai1pK4McVWW9//+wOJsU4edTR5KXK1KVOQKzDpnf/CU9SchYGPd9YScI3n/HR1HHZW2wHqM6O7na0hYA0UhDXLqhjDWuM3WEOOxdE67/bozbtujo4V4+PM8fjVaTsVDhQ60vfv9CnJJ7dLnhqcoovidOwZTHwG+pQtAwbX0ICgKSrc0elv8ZtfwlEvgIrtSiLAO1/CAf+uReUXyBCZhS4Xl7LroKZGiZ80/JE5mc67V/yImVKHBe0aZwgDHgtHh63/50/cAyuUfKyreAH0VLEwy54UCGramPQqYlIReMEbi6U4GC5AQKBgQDfDnHCH1rBvBWfkxPivl/yNKmENBkVikGWBwHNA3wVQ+xZ1Oqmjw3zuHY0xOH0GtK8l3Jy5dRL4DYlwB1qgd/Cxh0mmOv7/C3SviRk7W6FKqdpJLyaE/bqI9AmRCZBpX2PMje6Mm8QHp6+1QpPnN/SenOvoQg/WWYM1DNXUJsfMwKBgQCdtddE7A5IBvgZX2o9vTLZY/3KVuHgJm9dQNbfvtXw+IQfwssPqjrvoU6hPBWHbCZl6FCl2tRh/QfYR/N7H2PvRFfbbeWHw9+xwFP1pdgMug4cTAt4rkRJRLjEnZCNvSMVHrri+fAgpv296nOhwmY/qw5Smi9rMkRY6BoNCiEKgQKBgAaRnFQFLF0MNu7OHAXPaW/ukRdtmVeDDM9oQWtSMPNHXsx+crKY/+YvhnujWKwhphcbtqkfj5L0dWPDNpqOXJKV1wHt+vUexhKwus2mGF0flnKIPG2lLN5UU6rs0tuYDgyLhAyds5ub6zzfdUBG9Gh0ZrfDXETRUyoJjcGChC71AoGAfmSciL0SWQFU1qjUcXRvCzCK1h25WrYS7E6pppm/xia1ZOrtaLmKEEBbzvZjXqv7PhLoh3OQYJO0NM69QMCQi9JfAxnZKWx+m2tDHozyUIjQBDehve8UBRBRcCnDDwU015lQN9YNb23Fz+3VDB/LaF1D1kmBlUys3//r2OV0Q4ECgYBnpo6ZFmrHvV9IMIGjP7XIlVa1uiMCt41FVyINB9SJnamGGauW/pyENvEVh+ueuthSg37e/l0Xu0nm/XGqyKCqkAfBbL2Uj/j5FyDFrpF27PkANDo99CdqL5A4NQzZ69QRlCQ4wnNCq6GsYy2WEJyU2D+K8EBSQcwLsrI7QL7fvQ=="
            : "MIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCJakyLqojWTDAVUdNJLvuXhROV+LXymqnukBrmiWwTYnJYm9r5cKHj1hYQRhU5eiy6NmFVJqJtwpxyyDSCWSoSmIQMoO2KjYyB5cDajRF45v1GmSeyiIn0hl55qM8ohJGjXQVPfXiqEB5c5REJ8Toy83gzGE3ApmLipoegnwMkewsTNDbe5xZdxN1qfKiRiCL720FtQfIwPDp9ZqbG2OQbdyZUB8I08irKJ0x/psM4SjXasglHBK5G1DX7BmwcB/PRbC0cHYy3pXDmLI8pZl1NehLzbav0Y4fP4MdnpQnfzZJdpaGVE0oI15lq+KZ0tbllNcS+/4MSwW+afvOw9bazAgMBAAECggEAIkenUsw3GKam9BqWh9I1p0Xmbeo+kYftznqai1pK4McVWW9//+wOJsU4edTR5KXK1KVOQKzDpnf/CU9SchYGPd9YScI3n/HR1HHZW2wHqM6O7na0hYA0UhDXLqhjDWuM3WEOOxdE67/bozbtujo4V4+PM8fjVaTsVDhQ60vfv9CnJJ7dLnhqcoovidOwZTHwG+pQtAwbX0ICgKSrc0elv8ZtfwlEvgIrtSiLAO1/CAf+uReUXyBCZhS4Xl7LroKZGiZ80/JE5mc67V/yImVKHBe0aZwgDHgtHh63/50/cAyuUfKyreAH0VLEwy54UCGramPQqYlIReMEbi6U4GC5AQKBgQDfDnHCH1rBvBWfkxPivl/yNKmENBkVikGWBwHNA3wVQ+xZ1Oqmjw3zuHY0xOH0GtK8l3Jy5dRL4DYlwB1qgd/Cxh0mmOv7/C3SviRk7W6FKqdpJLyaE/bqI9AmRCZBpX2PMje6Mm8QHp6+1QpPnN/SenOvoQg/WWYM1DNXUJsfMwKBgQCdtddE7A5IBvgZX2o9vTLZY/3KVuHgJm9dQNbfvtXw+IQfwssPqjrvoU6hPBWHbCZl6FCl2tRh/QfYR/N7H2PvRFfbbeWHw9+xwFP1pdgMug4cTAt4rkRJRLjEnZCNvSMVHrri+fAgpv296nOhwmY/qw5Smi9rMkRY6BoNCiEKgQKBgAaRnFQFLF0MNu7OHAXPaW/ukRdtmVeDDM9oQWtSMPNHXsx+crKY/+YvhnujWKwhphcbtqkfj5L0dWPDNpqOXJKV1wHt+vUexhKwus2mGF0flnKIPG2lLN5UU6rs0tuYDgyLhAyds5ub6zzfdUBG9Gh0ZrfDXETRUyoJjcGChC71AoGAfmSciL0SWQFU1qjUcXRvCzCK1h25WrYS7E6pppm/xia1ZOrtaLmKEEBbzvZjXqv7PhLoh3OQYJO0NM69QMCQi9JfAxnZKWx+m2tDHozyUIjQBDehve8UBRBRcCnDDwU015lQN9YNb23Fz+3VDB/LaF1D1kmBlUys3//r2OV0Q4ECgYBnpo6ZFmrHvV9IMIGjP7XIlVa1uiMCt41FVyINB9SJnamGGauW/pyENvEVh+ueuthSg37e/l0Xu0nm/XGqyKCqkAfBbL2Uj/j5FyDFrpF27PkANDo99CdqL5A4NQzZ69QRlCQ4wnNCq6GsYy2WEJyU2D+K8EBSQcwLsrI7QL7fvQ=="; //Get just the base64 content.

        public static string nagadMarchentPublicKey = IsLiveNagad ? "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAiWpMi6qI1kwwFVHTSS77l4UTlfi18pqp7pAa5olsE2JyWJva+XCh49YWEEYVOXosujZhVSaibcKccsg0glkqEpiEDKDtio2MgeXA2o0ReOb9RpknsoiJ9IZeeajPKISRo10FT314qhAeXOURCfE6MvN4MxhNwKZi4qaHoJ8DJHsLEzQ23ucWXcTdanyokYgi+9tBbUHyMDw6fWamxtjkG3cmVAfCNPIqyidMf6bDOEo12rIJRwSuRtQ1+wZsHAfz0WwtHB2Mt6Vw5iyPKWZdTXoS822r9GOHz+DHZ6UJ382SXaWhlRNKCNeZavimdLW5ZTXEvv+DEsFvmn7zsPW2swIDAQAB"
            : "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAiWpMi6qI1kwwFVHTSS77l4UTlfi18pqp7pAa5olsE2JyWJva+XCh49YWEEYVOXosujZhVSaibcKccsg0glkqEpiEDKDtio2MgeXA2o0ReOb9RpknsoiJ9IZeeajPKISRo10FT314qhAeXOURCfE6MvN4MxhNwKZi4qaHoJ8DJHsLEzQ23ucWXcTdanyokYgi+9tBbUHyMDw6fWamxtjkG3cmVAfCNPIqyidMf6bDOEo12rIJRwSuRtQ1+wZsHAfz0WwtHB2Mt6Vw5iyPKWZdTXoS822r9GOHz+DHZ6UJ382SXaWhlRNKCNeZavimdLW5ZTXEvv+DEsFvmn7zsPW2swIDAQAB";

        public static string nagadPublicKey = IsLiveNagad ? "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAjBH1pFNSSRKPuMcNxmU5jZ1x8K9LPFM4XSu11m7uCfLUSE4SEjL30w3ockFvwAcuJffCUwtSpbjr34cSTD7EFG1Jqk9Gg0fQCKvPaU54jjMJoP2toR9fGmQV7y9fz31UVxSk97AqWZZLJBT2lmv76AgpVV0k0xtb/0VIv8pd/j6TIz9SFfsTQOugHkhyRzzhvZisiKzOAAWNX8RMpG+iqQi4p9W9VrmmiCfFDmLFnMrwhncnMsvlXB8QSJCq2irrx3HG0SJJCbS5+atz+E1iqO8QaPJ05snxv82Mf4NlZ4gZK0Pq/VvJ20lSkR+0nk+s/v3BgIyle78wjZP1vWLU4wIDAQAB"
            : "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAjBH1pFNSSRKPuMcNxmU5jZ1x8K9LPFM4XSu11m7uCfLUSE4SEjL30w3ockFvwAcuJffCUwtSpbjr34cSTD7EFG1Jqk9Gg0fQCKvPaU54jjMJoP2toR9fGmQV7y9fz31UVxSk97AqWZZLJBT2lmv76AgpVV0k0xtb/0VIv8pd/j6TIz9SFfsTQOugHkhyRzzhvZisiKzOAAWNX8RMpG+iqQi4p9W9VrmmiCfFDmLFnMrwhncnMsvlXB8QSJCq2irrx3HG0SJJCbS5+atz+E1iqO8QaPJ05snxv82Mf4NlZ4gZK0Pq/VvJ20lSkR+0nk+s/v3BgIyle78wjZP1vWLU4wIDAQAB";

        public static string nagadMerchantId = IsLiveNagad ? "683002007104225" : "683002007104225";

        public static string initializeApiNagad = IsLiveNagad ? "http://sandbox.mynagad.com:10080/remote-payment-gateway-1.0/api/dfs/check-out/initialize/"
            : "http://sandbox.mynagad.com:10080/remote-payment-gateway-1.0/api/dfs/check-out/initialize/";

        public static string checkOutApiNagad = IsLiveNagad ? "http://sandbox.mynagad.com:10080/remote-payment-gateway-1.0/api/dfs/check-out/complete/"
            : "http://sandbox.mynagad.com:10080/remote-payment-gateway-1.0/api/dfs/check-out/complete/";

        public static string verifyPaymentApiNagad = IsLiveNagad ? "http://sandbox.mynagad.com:10080/remote-payment-gateway-1.0/api/dfs/verify/payment/"
            : "http://sandbox.mynagad.com:10080/remote-payment-gateway-1.0/api/dfs/verify/payment/";

        public static string merchantCallbackURL = IsLiveNagad ? "https://pacenet.net/isp/#/billpay" : "http://localhost:56046/isp/#/billpay";//Callback URL

        public static string rglPgNagadApi = "https://npg.pacenet.net" + "/api/nagad/initializenagadpayment"; // RGL Payment Gateway Nagad Api

        public static double ReqMinutes = IsLiveNagad ? 0 : 0;
        #endregion

        #region bKash ISP API Url
        //public static List<vmCloudAPI> GetBKashISPApiUrl()
        //{
        //    List<vmCloudAPI> data = null;
        //    try
        //    {
        //        //var ur1 = new vmCloudAPI(1, "https://checkout.sandbox.bka.sh/v1.2.0-beta/checkout/token/grant"); //Sandbox endpoint: https://<service-name>.sandbox.bka.sh
        //        //var ur2 = new vmCloudAPI(2, "https://checkout.pay.bka.sh/v1.2.0-beta/checkout/token/grant"); //Production endpoint: https://<service-name>.pay.bka.sh

        //        var ur1 = new vmCloudAPI(1, "https://checkout.sandbox.bka.sh/v1.2.0-beta/checkout/token/grant"); //Sandbox endpoint: https://<service-name>.sandbox.bka.sh
        //        var ur2 = new vmCloudAPI(2, "https://checkout.sandbox.bka.sh/v1.2.0-beta/checkout/payment/create"); //Production endpoint: https://<service-name>.pay.bka.sh
        //        var ur3 = new vmCloudAPI(3, "https://checkout.sandbox.bka.sh/v1.2.0-beta/checkout/payment/execute"); //Production endpoint: https://<service-name>.pay.bka.sh

        //        data = new List<vmCloudAPI> { ur1, ur2, ur3 };
        //    }
        //    catch (Exception) { }
        //    return data;
        //}
        #endregion bKash ISP API Url

        //public static List<vmCloudAPI> GetFosterPGApiUrl()
        //{
        //    List<vmCloudAPI> data = null;
        //    try
        //    {
        //        var ur1 = new vmCloudAPI(1, "https://demo.fosterpayments.com.bd/fosterpayments/paymentrequest.php"); //demo foster payment         
        //        var ur2 = new vmCloudAPI(2, "https://demo.fosterpayments.com.bd/fosterpayments/TransactionStatus/txstatus.php?mcnt_TxnNo={mcnt_TxnNo}&mcnt_SecureHashValue={mcnt_SecureHashValue}");
        //        var ur3 = new vmCloudAPI(3, "https://demo.fosterpayments.com.bd/fosterpayments/validationalldata.php?payment_id={payment_id}"); //demo foster payment
        //        data = new List<vmCloudAPI> { ur1,ur2 , ur3 };
        //    }
        //    catch (Exception) { }
        //    return data;
        //}

        //public static List<vmCloudAPI> GetFosterPGApiUrl()
        //{
        //    List<vmCloudAPI> data = null;
        //    try
        //    {
        //        var ur1 = new vmCloudAPI(1, "https://payment.fosterpayments.com.bd/fosterpayments/paymentrequest.php"); //live foster payment         
        //        var ur2 = new vmCloudAPI(2, "https://payment.fosterpayments.com.bd/fosterpayments/TransactionStatus/txstatus.php?mcnt_TxnNo={mcnt_TxnNo}&mcnt_SecureHashValue={mcnt_SecureHashValue}");
        //        var ur3 = new vmCloudAPI(3, "https://payment.fosterpayments.com.bd/fosterpayments/validationalldata.php?payment_id={payment_id}"); //live foster payment
        //        data = new List<vmCloudAPI> { ur1, ur2, ur3 };
        //    }
        //    catch (Exception) { }
        //    return data;
        //}

        ////SMS Gateway
        //public const String SmsApi_key = "f1e8345a1b4156fb";
        //public const String SmsSecret_key = "d06d526d";
        //public const String ISPsmsSender_Id = "PacENeT";
        //public const String CloudsmsSender_Id = "PacEClouD";
        //public const String SmsClientName = "Royalgreen";
        //public static List<vmCloudAPI> GetReveSMSGateWay()
        //{
        //    List<vmCloudAPI> data = null;
        //    try
        //    {
        //        var ur1 = new vmCloudAPI(1, "https://smpp.ajuratech.com:7790/sendtext?apikey={API_KEY}&secretkey={SECRET_KEY}&callerID={SENDER_ID}&toUser={MOBILE_NUMBER}&messageContent={MESSAGE}");//Submit API-https-Post
        //        var ur2 = new vmCloudAPI(2, "http://smpp.ajuratech.com:7788/sendtext?apikey={API_KEY}&secretkey={SECRET_KEY}&callerID={SENDER_ID}&toUser={MOBILE_NUMBER}&messageContent={MESSAGE}");//Submit API-http-Post
        //        var ur3 = new vmCloudAPI(3, "https://smpp.ajuratech.com:7790/send?apikey={API_KEY}&secretkey={SECRET_KEY}&content={content}");//content pattern-[{"callerID":"8801847","toUser":"452621,568468","messageContent":"abcd"},{"callerID":"9101847","toUser":"918468,912621","messageContent":"abcd"}] //Submit API-Multiple-https-Post
        //        var ur4 = new vmCloudAPI(4, "http://smpp.ajuratech.com:7788/send?apikey={API_KEY}&secretkey={SECRET_KEY}&content={content}");//content pattern-[{"callerID":"8801847","toUser":"452621,568468","messageContent":"abcd"},{"callerID":"9101847","toUser":"918468,912621","messageContent":"abcd"}] //Submit API-Multiple-https-Post
        //        var ur5 = new vmCloudAPI(5, "https://smpp.ajuratech.com:7790/getstatus?apikey={API_KEY}&secretkey={SECRET_KEY}&messageid={MESSAGE_ID}");//Delivery API-https-Post
        //        var ur6 = new vmCloudAPI(6, "http://smpp.ajuratech.com:7788/getstatus?apikey={API_KEY}&secretkey={SECRET_KEY}&messageid={MESSAGE_ID}");//Delivery API-http-Post
        //        var ur7 = new vmCloudAPI(7, "https://smpp.ajuratech.com/portal/sms/smsConfiguration/smsClientBalance.jsp?client={ClientName}");//Balance Check-https-Get
        //        var ur8 = new vmCloudAPI(8, "http://smpp.ajuratech.com/portal/sms/smsConfiguration/smsClientBalance.jsp?client={ClientName}");//Balance Check-http-Get
        //        data = new List<vmCloudAPI> { ur1, ur2, ur3, ur4, ur5, ur6, ur7, ur8 };
        //    }
        //    catch (Exception) { }
        //    return data;
        //}


        public enum ISPUserStatus
        {
            Expired, Suspended
        }

        //public const int ExpireDays = 30; // isp
        public const int ExpireDays = 15; // isp
        public const int GraceDay = 3; // isp

        //Mail Type
        public enum Mail
        {
            UserRegistrationMail = 1,
            VmDeploymentMail = 2,
            AdditionalServiceMAil = 3,
            NoCCmail = 4,
            EmailVerification = 5,
            ContactUs = 6
        }

        public const string SalesMailAccount = "sales@pacecloud.com";
        public const string CloudMailAccount = "cloud@pacecloud.com";
        //public const string CrmIspContactUsMail = "rjdnath@outlook.com,farukjnu1@gmail.com,lunaranik1@gmail.com";
        public const string CrmIspContactUsMail = "clientcare.rgl@royalgreen.net,sales@royalgreen.net";

        #region time zone
        public const string LinuxTimeZoneBD = "Asia/Dhaka";
        public const string TimeZoneBD = "Bangladesh Standard Time";
        public const string IspDateFormat = "dd MMM yyyy HH:mm:ss"; // post request to radius api call
        public const string ddMMMyyyhhmmsstt = "dd MMM yyyy hh:mm:ss tt"; // get date time
        public const string yyyyMMddHHmmss = "yyyy-MM-dd HH:mm:ss"; // get date time
        #endregion
        public enum TicketReopenAction
        {
            Equipment = 1,
            Change = 2,
            New = 3,
            None = 4
        }

        public enum IspDeleteType
        {
            User,
            Service,
            Invoice,
            Payment
        }

        public enum VoucherPreference
        {
            Receipt = 1,
            Payment = 2,
            Journal = 3,
            Contra = 4,
            PettyCash = 5

        }
        #region enum Cloud 
        public enum CloudProposalStatus
        {
            Pending = 1, Approve = 2, Decline = 3, Forward = 4, Hold = 5
        }
        #endregion
        //#region Connection String List
        //public static List<vmConnectionString> listConnectionString()
        //{
        //    List<vmConnectionString> listConn = new List<vmConnectionString>();
        //    var cnstring1 = new vmConnectionString(1, @"Server=100.120.2.57;Database=dbRGLERP;User Id=sa; Password=@sa12345#;", 1, "ERPDevLocal", false);
        //    var cnstring2 = new vmConnectionString(2, @"Server=100.120.2.55;Database=dbRGLERP;User Id=sa; Password=@sa12345#;", 1, "ERPLive", true);
        //    var cnstring3 = new vmConnectionString(3, @"Server=100.120.2.55;Database=dbRGLERPDev;User Id=sa; Password=@sa12345#;", 2, "ERPDevLive", false);
        //    var cnstring4 = new vmConnectionString(4, @"Server=100.120.2.55;Database=dbRGLERPLog;User Id=sa; Password=@sa12345#;", 3, "ERPLogLive", true);
        //    var cnstring5 = new vmConnectionString(5, @"Server=100.120.2.55;Database=dbRGLERPLog;User Id=sa; Password=@sa12345#;", 3, "ERPLogLive", false);
        //    var cnstring6 = new vmConnectionString(6, @"Server=100.120.2.55;Database=dbRGLTV;User Id=sa; Password=@sa12345#;", 4, "ERPTVLive", true);
        //    var cnstring7 = new vmConnectionString(7, @"Server=100.120.2.55;Database=dbRGLTV;User Id=sa; Password=@sa12345#;", 4, "ERPTVLive", false);
        //    var cnstring8 = new vmConnectionString(8, @"server=123.136.24.102;database=radius;userid=software;password=PaceRadius1419;SslMode=none;", 5, "RadiusMySQL", true);
        //    var cnstring9 = new vmConnectionString(9, @"server=123.136.24.102;database=radius;userid=software;password=PaceRadius1419;SslMode=none;", 5, "RadiusMySQL", false);
        //    var cnstring10 = new vmConnectionString(10, @"Server=100.120.2.57;Database=dbRGLAttendance;User Id=sa; Password=@sa12345#;", 6, "ERPAttLocal", false);
        //    var cnstring11 = new vmConnectionString(11, @"Server=100.120.2.55;Database=dbRGLAttendance;User Id=sa; Password=@sa12345#;", 6, "ERPAttLive", true);
        //    listConn = new List<vmConnectionString>() { cnstring1, cnstring2, cnstring3, cnstring4, cnstring5, cnstring6, cnstring7, cnstring8, cnstring9, cnstring10, cnstring11 };
        //    return listConn;
        //}
        //#endregion
        #region All SMS ISP
        public static string paymentReceived = "Payment Received!Thank you for your payment: Tk. <receivedTotal> against ID: <ClientID>.Your account is now updated ";
        public static string onBoot = "Welcome to PacENeT! You are now member of PacENeT family.\nUid: <ClientID>,\nPass: <Password>\nPlease use this user id as ref. when making any payment: https://pacenet.net/.";
        public static string onDue = "Your ID: <ClientID> due on <ExpireDate>, please pay here: https://pacenet.net/, bkash or credit/debit card before due date.";
        public static string onDisconnection = "Your ID: <ClientID> due on <ExpireDate>, you were disconnected due to unpaid bill. Please pay here: https://pacenet.net/ to reconnect.";
        public static string onExpire = "Your ID: <ClientID> due on <ExpireDate>, please pay here: https://pacenet.net/, bkash or credit/debit card to avoid disconnection.";
        public static string onReconnection = "Your ID: <ClientID>, internet connection re-established. Pls pay here: https://pacenet.net/  by  bkash or credit/debit card timely for uninterrupted service.";
        public static string onNewServiceActivation = "Your ID: <ClientID>, your service(<service>) has been activated.";
        public enum SMSBody
        {
            paymentReceived = 1,
            onBoot = 2,
            onDue = 3,
            onExpire = 4,
            onDisconnection = 5,
            onReconnection = 6,
            onNewServiceActivation = 7
        }

        #endregion
        #region All SMS CLOUD
        public static string paymentReceived_PC = "Payment Received!Thank you for your payment: Tk. <receivedTotal> against ID: <ClientID>.Your account is now updated ";
        public static string onBoot_PC = "Welcome to PacENeT! You are now member of PacENeT family.\nUid: <ClientID>,\nPass: <Password>\nPlease use this user id as ref. when making any payment: https://pacecloud.com/.";
        public static string onDue_PC = "Your ID: <ClientID> due on <ExpireDate>, please pay here: https://pacecloud.com/, bkash or credit/debit card before due date.";
        public static string onDisconnection_PC = "Your ID: <ClientID> due on <ExpireDate>, you were disconnected due to unpaid bill. Please pay here: https://pacecloud.com/ to reconnect.";
        public static string onExpire_PC = "Your ID: <ClientID> due on <ExpireDate>, please pay here: https://pacecloud.com/, bkash or credit/debit card to avoid disconnection.";
        public static string onReconnection_PC = "Your ID: <ClientID>, internet connection re-established. Pls pay here: https://pacecloud.com/  by  bkash or credit/debit card timely for uninterrupted service.";
        public static string onNewServiceActivation_PC = "Your ID: <ClientID>, your service(<service>) has been activated.";
        //public enum CloudSmsBody
        //{
        //    paymentReceived_PC = 1,
        //    onBoot_PC = 2,
        //    onDue_PC = 3,
        //    onExpire_PC = 4,
        //    onDisconnection_PC = 5,
        //    onReconnection_PC = 6,
        //    onNewServiceActivation_PC = 7
        //}

        #endregion
        #region VM Activity operation and type
        public static class vmActivityType
        {
            public const string policy = "VM Policy";
            public const string StartStop = "VM Start/Stop";
            public const string Terminate = "VM Terminate";
            public const string Storage = "VM Storage";
            public const string Instance = "VM Cpu And Ram";
        }
        public static class vmActivityTypeOperation
        {
            public const string policyOperationAdd = "Addition";
            public const string policyOperationReplace = "Replace";
            public const string policyOperationRemove = "Remove";
            public const string vmOperationStart = "Start";
            public const string vmOperationStop = "Stop";
            public const string VmOperationTerminate = "Terminate";
            public const string VmStorageAdd = "Attach";
            public const string VmStorageDelete = "Detach";
            public const string VmInstanceResize = "Resize";
        }
        #endregion
    }
}
