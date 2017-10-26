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

namespace bill.Business
{

    public class BillExcleBiz : IBillBusiness
    {
        //1. 首先判断文件目录是否存在 不存在则创建
        //2. 判断文件是否存在 不存在则创建
        //3. 判断账单（bill）sheet是否存在 不存在则创建
        //4. 判断商品类型（goodsType）sheet是否存在 不存在则创建


        private string fileName = ApplicationConfig.fileName;

        private string filePath = ApplicationConfig.filePath;

        private string connectionString = ApplicationConfig.ExcleConnectionString;
        
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
                style.Alignment = HorizontalAlignment.Center;
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
        /// <summary>
        /// 查询商品类别
        /// </summary>
        /// <returns></returns>
        public DataTable searchGoodsType()
        {
            string sheetName = ExcelDataAccess.getExcelSheetNameById(connectionString, (int)TableId.GoodsTypeForExcel);
            string sql = "SELECT * FROM [" + sheetName + "] ";
            DataSet dt = new DataSet();
            dt = ExcelDataAccess.GetReader(sql, connectionString);
            return dt.Tables[0];
        }

        public DataTable addGoodsType(GoodsType goodsType, out string errorMessage)
        {
            errorMessage = ""; return null;
        }

        public bool deleteGoodsType(GoodsType goodsType, out string errorMessage)
        {
            errorMessage = ""; return true;
        }

        public bool updateGoodsType(GoodsType goodsType, out string errorMessage)
        {
            errorMessage = ""; return true;
        }

        public DataTable searchBillByCondition(Goods goods)
        {
            return null;
        }

        public DataTable addBills(Goods goods, out string errorMessage)
        {
            errorMessage = ""; return null;
        }

        public bool updateBills(Goods goods, out string errorMessage)
        {
            errorMessage = ""; return true;
        }

        public DataTable searchAllBillDesc()
        {
            return null;
        }

        public bool deleteBill(Goods goods, out string errorMessage)
        {
            errorMessage = ""; return true;
        }
    }
}
