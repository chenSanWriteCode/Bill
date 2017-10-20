using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using bill.DataAccess.Common;
using System.Data.SqlClient;
namespace bill.DataAccess
{
    class BillDataAccess
    {
        /// <summary>
        /// 通过存储过程查询数据
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="dt">返回表</param>
        /// <returns></returns>
        public static bool ExecuteStoredProcedure(string procedureName, out DataTable dt)
        {
            string errMessage;
            return SQLCommon.ExecuteStoredProcedure(procedureName, ApplicationConfig.connectionString, out dt, out errMessage);
        }

        /// <summary>
        /// 提供通用的调用存储过程的方法（增加数据的数据表的到数据库的调用）
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="sqlParameters">存储过程参数数组</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public static bool ExecuteStoredProcedure(string procedureName, ref SqlParameter[] sqlParameters, out string errorMessage)
        {
            return SQLCommon.ExecuteStoredProcedure(procedureName, ApplicationConfig.connectionString, ref sqlParameters, out  errorMessage);
        }
        /// <summary>
        /// 提供通用的调用存储过程的方法(通过参数查询数据)
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="sqlParameters">存储过程参数数组</param>
        /// <param name="dt">返回表</param>
        /// <returns></returns>
        public static bool ExecuteStoredProcedure(string procedureName, ref SqlParameter[] sqlParameters, out DataTable dt, out string errorMessage)
        {
            return SQLCommon.ExecuteStoredProcedure(procedureName, ApplicationConfig.connectionString, ref sqlParameters, out dt, out  errorMessage);
        }

    }
}
