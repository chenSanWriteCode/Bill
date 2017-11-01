using System;
using System.Configuration;
using System.Text;

namespace bill.Common
{
    public class Log
    {
        private static string logPath = ConfigurationManager.AppSettings.GetValues("logPath")[0];
        public static void writeLog(string errMsg)
        {
            string userName = System.Environment.UserName;
            string machineName = System.Environment.MachineName;
            StringBuilder sb = new StringBuilder(DateTime.Now.ToString());
            sb.Append("  ***  machineName:").Append(machineName).Append("  ***  userName:").Append(userName).Append("  ***  errMsg:").Append(errMsg).Append("\r\n");
            System.IO.File.AppendAllText(logPath, sb.ToString(),Encoding.Unicode);
        }
    }
}
