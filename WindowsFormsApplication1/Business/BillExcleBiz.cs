using System;
using System.Data;
using System.IO;
using bill.DataAccess.Common;
using bill.Common;
using bill.Entity;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using bill.Common.ExcelTool;
using bill.Common.Const;
using System.Windows.Forms;
using System.Text;

namespace bill.Business
{
    /// <summary>
    /// oledb宛如狗屎  鉴定完毕
    /// 1. 用oledb创建excel连接
    /// 2. 通过sql进行excel操作
    /// 3. ctrl+a delete
    /// 4. 用npoi重写
    /// 从入门到放弃 呵呵哒
    /// </summary>
    public class BillExcleBiz : IBillBusiness
    {
        #region 底层变量
        //1. 首先判断文件目录是否存在 不存在则创建
        //2. 判断文件是否存在 不存在则创建
        //3. 判断账单（bill）sheet是否存在 不存在则创建
        //4. 判断商品类型（goodsType）sheet是否存在 不存在则创建


        private string fileName = ApplicationConfig.fileName;

        private string filePath = ApplicationConfig.filePath;

        private string connectionString = ApplicationConfig.ExcleConnectionString;
        /// <summary>
        /// 根据id获取在excel中对应的sheet名
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        private string getExcelSheetNameById(TableId tableId)
        {
            string name = ExcelDataAccess.getExcelSheetNameById(connectionString, (int)tableId);
            return name;
        }
        /// <summary>
        /// 获取id对应的sheet表的最大id（获取表的序列.nextVal）
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        private int getExcelSheetMaxId(TableId tableId, out string errMsg)
        {
            int maxId;
            maxId = ExcelDataAccess.getExcelSheetMaxId(connectionString, (int)tableId, out errMsg);
            if (maxId < 0)
            {
                //写入log文件
                Log.writeLog(errMsg);
            }
            return maxId;
        }
        #endregion

        #region 实例化
        /// <summary>
        /// 判断账单是否存在，不存在则创建
        /// </summary>
        public void init()
        {
            dirExistOrCreate(filePath);
            fileExsitOrCreate(filePath + fileName);
        }
        /// <summary>
        /// 判断目录（文件夹）是否存在，不存在则创建
        /// </summary>
        /// <param name="path"></param>
        private void dirExistOrCreate(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        /// <summary>
        /// 判断文件是否存在，不存在则创建
        /// </summary>
        /// <param name="fileFullPath">目录名+文件名</param>
        private void fileExsitOrCreate(string fileFullPath)
        {
            if (!File.Exists(fileFullPath))
            {
                ReflectEntityProp<BillForExcel> goodsReflect = new ReflectEntityProp<BillForExcel>();
                ReflectEntityProp<GoodsTypeForExcel> goodsTypeReflect = new ReflectEntityProp<GoodsTypeForExcel>();

                HSSFWorkbook wb = new HSSFWorkbook();
                //格式
                ICellStyle style = wb.CreateCellStyle();
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                IFont font = wb.CreateFont();
                font.IsBold = true;
                font.FontHeightInPoints = 12;
                style.SetFont(font);

                if (goodsReflect != null)
                {
                    ExcelTool.createExcelColumns(ref wb, goodsReflect.table.name, goodsReflect.table.columns, style);
                }
                if (goodsTypeReflect != null)
                {
                    ExcelTool.createExcelColumns(ref wb, goodsTypeReflect.table.name, goodsTypeReflect.table.columns, style);
                }
                FileStream fs = new FileStream(fileFullPath, FileMode.Create);
                wb.Write(fs);
                fs.Close();
            }
        }
        #endregion

        #region 商品类别
        /// <summary>
        /// 查询商品类别
        /// </summary>
        /// <returns></returns>
        public DataTable searchGoodsType()
        {
            string sql = "SELECT * FROM [" + getExcelSheetNameById(TableId.GoodsTypeForExcel) + "] ";
            DataSet dt = new DataSet();
            dt = ExcelDataAccess.GetReader(sql, connectionString);
            return dt.Tables[0];
        }
        /// <summary>
        /// 增加商品类别
        /// </summary>
        /// <param name="goodsType"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public DataTable addGoodsType(GoodsType goodsType, out string errorMessage)
        {
            int maxId = getExcelSheetMaxId(TableId.GoodsTypeForExcel, out errorMessage);
            DataTable dt_goodsType = null;
            if (maxId < 0)
            {
                return dt_goodsType;
            }
            else
            {
                string sql = "insert into [" + getExcelSheetNameById(TableId.GoodsTypeForExcel) + "] (id,类别代码,商品类别) values(" + maxId + "," + goodsType.goodsTypeCode + "," + goodsType.goodsTypeName + ")";
                int execCount = ExcelDataAccess.ExecuteCommand(sql, connectionString,out errorMessage);
                if (execCount < 1)
                {
                    //errorMessage = "增加失败！请检查excel";
                    return dt_goodsType;
                }
                sql = "select * from [" + getExcelSheetNameById(TableId.GoodsTypeForExcel) + "] ";
                DataSet ds = ExcelDataAccess.GetReader(sql, connectionString);
                if (ds != null)
                {
                    dt_goodsType = ds.Tables[0];
                }
                return dt_goodsType;
            }
        }
        /// <summary>
        /// 删除商品类别
        /// </summary>
        /// <param name="goodsType"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool deleteGoodsType(GoodsType goodsType, out string errorMessage)
        {
            errorMessage = "";
            string sql = "delete from [" + getExcelSheetNameById(TableId.GoodsTypeForExcel) + "] where 类别代码=" + goodsType.goodsTypeCode;
            int execCount = ExcelDataAccess.ExecuteCommand(sql, connectionString,out errorMessage);
            if (execCount<1)
            {
                //errorMessage += "删除失败，请稍后重试，或手动删除";
                return false;
            }
             return true;
        }
        /// <summary>
        /// 修改商品类别
        /// </summary>
        /// <param name="goodsType"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool updateGoodsType(GoodsType goodsType, out string errorMessage)
        {
            errorMessage = "";
            string sql = "update [" + getExcelSheetNameById(TableId.GoodsTypeForExcel) + "] set 商品类别 = " + goodsType.goodsTypeName + "where 类别代码 =" + goodsType.goodsTypeCode;
            int execCount = ExcelDataAccess.ExecuteCommand(sql, connectionString,out errorMessage);
            if (execCount<1)
            {
                errorMessage = "修改失败，手动删除";
                return false;
            }
             return true;
        }

        #endregion

        #region 账单
        /// <summary>
        /// 账单查询
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public DataTable searchBillByCondition(Goods goods)
        {
            string sql = "select id as 序号,* from [" + getExcelSheetNameById(TableId.BillForExcel) + "]";
            //sql += combineBillCondition(goods);
            DataTable dt_bill = new DataTable();
            dt_bill = ExcelDataAccess.GetReader(sql, connectionString).Tables[0];
            return dt_bill;
        }
        /// <summary>
        /// 增加账单
        /// </summary>
        /// <param name="goods"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public DataTable addBills(Goods goods, out string errorMessage)
        {
            int maxId = getExcelSheetMaxId(TableId.BillForExcel, out errorMessage);
            DataTable dt_bill = null;
            if (maxId < 0)
            {
                return dt_bill;
            }
            else
            {
                string sql = "insert into [" + getExcelSheetNameById(TableId.BillForExcel) + "](id,商品名称,商品价格 ,商品类别,商场,购买时间,备注) values(" + maxId + "," + goods.goodsName + "," + goods.goodsPrice + "," + goods.goodsType + "," + goods.mall + "," + goods.createDate + "," + goods.goodsMark + ")";
                int execCount = ExcelDataAccess.ExecuteCommand(sql, connectionString,out errorMessage);
                if (execCount < 1)
                {
                    //errorMessage = "增加失败！请检查excel";
                    return dt_bill;
                }
                sql = "select * from [" + getExcelSheetNameById(TableId.BillForExcel) + "] ";
                DataSet ds = ExcelDataAccess.GetReader(sql, connectionString);
                if (ds != null)
                {
                    dt_bill = ds.Tables[0];
                }
                return dt_bill;
            }
        }
        /// <summary>
        /// 修改账单
        /// </summary>
        /// <param name="goods"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool updateBills(Goods goods, out string errorMessage)
        {
            string sql= "update ["+getExcelSheetNameById(TableId.BillForExcel)+"] set 商品名称 = "+goods.goodsName+ ",商品价格="+goods.goodsPrice+",商品类别="+goods.goodsType+",商场="+goods.mall+",购买时间="+goods.createDate+",备注="+goods.goodsMark+" where id= "+goods.id;
            int execCount = ExcelDataAccess.ExecuteCommand(sql, connectionString,out errorMessage);
            if (execCount<1)
            {
                //errorMessage = "修改失败";
                return false;
                
            }
            return true;
        }
        /// <summary>
        /// 查询所有账单
        /// </summary>
        /// <returns></returns>
        public DataTable searchAllBillDesc()
        {
            string sql = "select id as 序号,* from [" + getExcelSheetNameById(TableId.BillForExcel) + "]";
            DataTable dt_bill = new DataTable();
            dt_bill = ExcelDataAccess.GetReader(sql, connectionString).Tables[0];
            return dt_bill;
        }
        /// <summary>
        /// 删除账单
        /// </summary>
        /// <param name="goods"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool deleteBill(Goods goods, out string errorMessage)
        {
            string sql = "delete from [" + getExcelSheetNameById(TableId.BillForExcel) + "] where id =" + goods.id;
            int execCount = ExcelDataAccess.ExecuteCommand(sql, connectionString,out errorMessage);
            if (execCount<1)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 组合账单查询条件
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public string combineBillCondition(Goods goods)
        {
            StringBuilder condition = new StringBuilder(" where ");
            if (goods.goodsPriceMax > 0 && goods.goodsPriceMin >= 0)
            {
                condition.Append("  商品价格 between " + goods.goodsPriceMax+ " and " + goods.goodsPriceMin);
            }
            //if ()
            //{
            //    condition.Append(" and " + goods.goodsPriceMin);
            //}
            if (goods.createDateBegin != null)
            {
                condition.Append(" and 购买时间 >" + goods.createDateBegin);
            }
            if (goods.createDateEnd != null)
            {
                condition.Append(" and 购买时间 <" + goods.createDateEnd);
            }
            if (goods.mall!=null && goods.mall!="")
            {
                condition.Append(" and 商场 =" + goods.mall);
            }
            if (goods.goodsType != null && goods.goodsType != "")
            {
                condition.Append(" and 商品类别 in(" + goods.goodsType+")");
            }
            if (goods.goodsName != null && goods.goodsName != "")
            {
                condition.Append(" and 商品名称 =" + goods.goodsName);
            }
            
            if (goods.goodsMark != null && goods.goodsMark != "")
            {
                condition.Append(" and 备注 =" + goods.goodsMark);
            }
            return condition.ToString();
        }
        #endregion
    }
}
