using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
namespace bill.DataAccess.Common
{
    public class ApplicationConfig
    {
        public static string connectionString { get { return ConfigurationManager.AppSettings.GetValues("connectionString")[0]; } }
        //规定 记账文件存放在程序运行的根目录下的data目录下，并且为office2003版本，名称为 账单
        /// <summary>
        /// excle文件名
        /// </summary>
        public static string fileName = "账单.xls";
        /// <summary>
        /// excle文件地址
        /// </summary>
        public static string filePath = System.Windows.Forms.Application.StartupPath + "\\data\\";
        /// <summary>
        /// excle连接字符串
        /// </summary>
        public static string ExcleConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";

        public static string isUseSqlServer { get { return ConfigurationManager.AppSettings.GetValues("sqlserver")[0]; } }
    }
}
