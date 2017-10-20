using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace bill.DataAccess.Common
{
    class SQLCommon
    {
        /// <summary>
        /// SqlServer连接状态
        /// =true 连接正常
        /// =false 连接失败
        /// </summary>
        static bool sqlServerConnectionStatus = true;
        /// <summary>
        /// SqlServer连接状态
        /// =true 连接正常
        /// =false 连接失败
        /// </summary>
        public static bool SqlServerConnectionStatus
        {
            get
            {
                return sqlServerConnectionStatus;
            }
            set
            {
                // SqlServer 与数据通讯状态
                //MisDataOnChange.tagDataSqlServerConnectionStatus.InvokeTagData(value);
                sqlServerConnectionStatus = value;
            }
        }
        /// <summary>
        /// 提供通用的调用存储过程的方法（需要返回查询的记录集的调用）
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="connectionString">连库字符串</param>
        /// 
        /// <param name="dt">存储过程里面返回的记录集</param>
        /// <param name="errorMessage">错误信息</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public static bool ExecuteStoredProcedure(string procedureName, string connectionString, out DataTable dt, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {

                    if (!SqlServerConnectionStatus) return false;
                    conn.Open();
                    using (SqlDataAdapter dsCommand = new SqlDataAdapter())
                    {
                        dsCommand.SelectCommand = new SqlCommand(procedureName, conn);
                        dsCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
                        dsCommand.Fill(dt);
                    }
                    SqlServerConnectionStatus = true;
                    result = true;
                }
                catch (Exception e)
                {
                    errorMessage = e.ToString();
                    //TestConnection();
                    //ApplicationLog.WriteLog(e, "\r\nExecuteStoredProcedure\r\n存储过程：\r\n" + procedureName + "\r\n连接字符串：\r\n" + connectionString);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return result;
        }

        /// <summary>
        /// 提供通用的调用存储过程的方法（不需要返回查询的记录集的调用）
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="connectionString">连库字符串</param>
        /// <param name="sqlParameters">存储过程参数数组</param>
        /// <param name="errorMessage">错误信息</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public static bool ExecuteStoredProcedure(string procedureName, string connectionString, ref SqlParameter[] sqlParameters, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if (!SqlServerConnectionStatus) return false;
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        for (int i = 0; i < sqlParameters.Length; i++)
                        {
                            cmd.Parameters.Add(sqlParameters[i]);
                        }
                        cmd.ExecuteNonQuery();
                    }
                    SqlServerConnectionStatus = true;
                    result = true;
                }
                catch (Exception e)
                {
                    errorMessage = e.ToString();
                    //ApplicationLog.WriteLog(e, "\r\nExecuteStoredProcedure\r\n存储过程：\r\n" + procedureName + "\r\n连接字符串：\r\n" + connectionString);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// 提供通用的调用存储过程的方法（需要返回查询的记录集的调用）
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="connectionString">连库字符串</param>
        /// <param name="sqlParameters">存储过程参数数组</param>
        /// <param name="ds">存储过程里面返回的记录集</param>
        /// <param name="errorMessage">错误信息</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public static bool ExecuteStoredProcedure(string procedureName, string connectionString, ref SqlParameter[] sqlParameters, out DataTable dt, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                if (!SqlServerConnectionStatus) return false;
                conn.Open();
                SqlDataAdapter dsCommand = new SqlDataAdapter();
                dsCommand.SelectCommand = new SqlCommand(procedureName, conn);
                dsCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Length; i++)
                {
                    dsCommand.SelectCommand.Parameters.Add(sqlParameters[i]);
                }
                dsCommand.Fill(dt);
                SqlServerConnectionStatus = true;
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
                //ApplicationLog.WriteLog(e, "\r\nExecuteStoredProcedure\r\n存储过程：\r\n" + procedureName + "\r\n连接字符串：\r\n" + connectionString);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
    }
}
