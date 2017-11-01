using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using bill.Common.Const;

namespace bill.DataAccess.Common
{
    class ExcelDataAccess
    {
        private static OleDbConnection connection;
        
        private static bool allowConnectionFlag = false;
        public static OleDbConnection getConnection(string connectionString)
        {
            if (connection == null && allowConnectionFlag)
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
                allowConnectionFlag = false;
            }
            else if (connection.State == System.Data.ConnectionState.Closed && allowConnectionFlag)
            {
                connection.Open();
                allowConnectionFlag = false;
            }
            else if (connection.State == System.Data.ConnectionState.Broken && allowConnectionFlag)
            {
                connection.Close();
                connection.Open();
                allowConnectionFlag = false;
            }
            return connection;
        }
        /// <summary>
        /// 获取id对应sheet名
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string getExcelSheetNameById(string connectionString,int id)
        {
            allowConnectionFlag = true;
            
            OleDbConnection conn = getConnection(connectionString);
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string sheetName  = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null).Rows[id][2].ToString().Trim();
            return sheetName;
        }
        /// <summary>
        /// 获取id对应的sheet表最大id，如果表为空，返回0
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="id"></param>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        public static int getExcelSheetMaxId(string connectionString,int id,out string errMsg)
        {
            errMsg = "";
            allowConnectionFlag = true;
            int maxId=0;
            try
            {
                string sql= "select count(*) from [" + getExcelSheetNameById(connectionString, id) + "]";
                int count = GetScalar(sql, connectionString);
                if (count>0)
                {
                    sql = "select max(id) from [" + getExcelSheetNameById(connectionString, id) + "]";
                    maxId = GetScalar(sql, connectionString);
                }
            }
            catch(Exception err)
            {
                maxId = -1;
                errMsg = err.Message;
            }
            return maxId;
        }
        /// <summary>  
        /// 执行无参数的SQL语句  
        /// </summary>  
        /// <param name="sql">SQL语句</param>  
        /// <returns>返回受SQL语句影响的行数</returns>  
        public static int ExecuteCommand(string sql,string connectionString,out string errMsg)
        {
            errMsg = "";
            allowConnectionFlag = true;
            try
            {
                
                OleDbCommand cmd = new OleDbCommand(sql, getConnection(connectionString));
                int result = cmd.ExecuteNonQuery();
                connection.Close();
                return result;
            }
            catch(Exception err)
            {
                errMsg = err.Message;
                return -1;
            }
            
        }

        /// <summary>  
        /// 执行有参数的SQL语句  
        /// </summary>  
        /// <param name="sql">SQL语句</param>  
        /// <param name="values">参数集合</param>  
        /// <returns>返回受SQL语句影响的行数</returns>  
        public static int ExecuteCommand(string sql,string connectionString, out string errMsg, params OleDbParameter[] values)
        {
            errMsg = "";
            allowConnectionFlag = true;
            OleDbCommand cmd = new OleDbCommand(sql, getConnection(connectionString));
            cmd.Parameters.AddRange(values);
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        /// <summary>  
        /// 返回单个值无参数的SQL语句  
        /// </summary>  
        /// <param name="sql">SQL语句</param>  
        /// <returns>返回受SQL语句查询的行数</returns>  
        public static int GetScalar(string sql,string connectionString)
        {
            allowConnectionFlag = true;
            OleDbCommand cmd = new OleDbCommand(sql, getConnection(connectionString));
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return result;
        }
        /// <summary>  
        /// 返回单个值有参数的SQL语句  
        /// </summary>  
        /// <param name="sql">SQL语句</param>  
        /// <param name="parameters">参数集合</param>  
        /// <returns>返回受SQL语句查询的行数</returns>  
        public static int GetScalar(string sql,string connectionString, params OleDbParameter[] parameters)
        {
            allowConnectionFlag = true;
            OleDbCommand cmd = new OleDbCommand(sql, getConnection(connectionString));
            cmd.Parameters.AddRange(parameters);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return result;
        }

        /// <summary>  
        /// 执行查询无参数SQL语句  
        /// </summary>  
        /// <param name="sql">SQL语句</param>  
        /// <returns>返回数据集</returns>  
        public static DataSet GetReader(string sql,string connectionString)
        {
            allowConnectionFlag = true;
            OleDbDataAdapter da = new OleDbDataAdapter(sql, getConnection(connectionString));
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            return ds;
        }

        /// <summary>  
        /// 执行查询有参数SQL语句  
        /// </summary>  
        /// <param name="sql">SQL语句</param>  
        /// <param name="parameters">参数集合</param>  
        /// <returns>返回数据集</returns>  
        public static DataSet GetReader(string sql,string connectionString, params OleDbParameter[] parameters)
        {

            OleDbDataAdapter da = new OleDbDataAdapter(sql, getConnection(connectionString));
            da.SelectCommand.Parameters.AddRange(parameters);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            return ds;
        }  
    }
}
