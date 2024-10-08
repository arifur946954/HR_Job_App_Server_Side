using System;

namespace DataUtility
{
    public class JobConfig
    {
        //public static string JobRunSchedule = WebConfigurationManager.AppSettings["JobRunSchedule"];
        //public static string dbname = WebConfigurationManager.AppSettings["DBName"];
        //public static string msServer = WebConfigurationManager.AppSettings["MSServer"];
        //public static string msServerUID = WebConfigurationManager.AppSettings["MSServerUID"];
        //public static string msServerPWD = WebConfigurationManager.AppSettings["MSServerPWD"];
        //public static string bkpType = WebConfigurationManager.AppSettings["BkpType"];

        public static string JobRunSchedule = "";
        public static string dbname = "";
        public static string msServer = "";
        public static string msServerUID = "";
        public static string msServerPWD = "";
        public static string bkpType = "";

        //public static string backupDir = HostingEnvironment.MapPath("~/DatabaseBackup/");
        public static string backupDir = "D:\\BackupDB";

        public static void RegisterJobs()
        {
            var date = DateTime.Now;
            //LogFile.WriteLogFile("Scheduled On : " + Convert.ToDateTime(date).ToString("yyyy-MM-dd hh:mm:ss"));

            //waits certan time and run the code
            //System.Threading.Tasks.Task.Delay(1000).ContinueWith((x) => JobMethod());
            JobMethod();
        }

        public static void JobMethod()
        {
            try
            {

            }
            catch (Exception ex)
            {
                //Logs.WriteBug(ex);
            }

            // recursive
            //RegisterJobs();
        }
    }

    public static class DateTimeExtensions
    {
        public static DateTime GetNextWeekDay(this DateTime currentDate, DayOfWeek dow)
        {
            int currentDay = (int)currentDate.DayOfWeek, gotoDay = (int)dow;
            return currentDate.AddDays(gotoDay - currentDay);
        }
    }

    //public class LogFile
    //{
    //    private const string FILE_NAME = "LogTextFile.txt";
    //    public static string backupDir = "D:\\BackupDB\\";

    //    private static string ConfigFilePath
    //    {
    //        get { return backupDir + FILE_NAME; }
    //    }

    //    public static void WriteLogFile(string fileName, string methodName, string message)
    //    {
    //        FileStream fs = null;
    //        if (!File.Exists(ConfigFilePath))
    //        {
    //            using (fs = File.Create(ConfigFilePath))
    //            {
    //            }
    //        }

    //        try
    //        {
    //            if (!string.IsNullOrEmpty(message))
    //            {
    //                StreamWriter streamWriter = new StreamWriter(ConfigFilePath, true);
    //                streamWriter.WriteLine((((System.DateTime.Now + " ~ ") + fileName + " ~ ") + methodName + " ~ ") + message + "\r");
    //                streamWriter.Close();
    //            }
    //        }
    //        catch
    //        {

    //        }
    //    }

    //    public static void WriteLogFile(string message)
    //    {
    //        System.IO.FileStream fs = null;
    //        if (!System.IO.File.Exists(ConfigFilePath))
    //        {
    //            using (fs = System.IO.File.Create(ConfigFilePath))
    //            {
    //            }
    //        }

    //        try
    //        {
    //            if (!string.IsNullOrEmpty(message))
    //            {
    //                var streamWriter = new System.IO.StreamWriter(ConfigFilePath, true);
    //                streamWriter.WriteLine(DateTime.Now + " - " + message + ",");
    //                streamWriter.Close();
    //            }
    //        }
    //        catch
    //        {

    //        }
    //    }

    //}

}
