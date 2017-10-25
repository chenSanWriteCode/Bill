using System;
using System.Data;
using System.IO;
using bill.DataAccess.Common;
using bill.Entity;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

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
                
                HSSFWorkbook wb = new HSSFWorkbook();
                //格式
                ICellStyle style = wb.CreateCellStyle();
                style.Alignment = HorizontalAlignment.Center;
                IFont font = wb.CreateFont();
                font.IsBold = true;
                font.FontHeightInPoints = 12;
                style.SetFont(font);

                ISheet sheet = wb.CreateSheet("bill$");
                sheet.CreateRow(0).CreateCell(0, CellType.Numeric).SetCellValue("id");
                sheet.GetRow(0).CreateCell(1, CellType.String).SetCellValue("商品名称");
                sheet.GetRow(0).CreateCell(2, CellType.Numeric).SetCellValue("商品价格");
                sheet.GetRow(0).CreateCell(3, CellType.String).SetCellValue("商品类别");
                sheet.GetRow(0).CreateCell(4, CellType.String).SetCellValue("商场");
                sheet.GetRow(0).CreateCell(5, CellType.String).SetCellValue("购买时间");
                sheet.GetRow(0).CreateCell(6, CellType.String).SetCellValue("备注");
                changeCellType(ref sheet, style);


                ISheet sheet1 = wb.CreateSheet("goodsType$");
                sheet1.CreateRow(0).CreateCell(0, CellType.Numeric).SetCellValue("id");
                sheet1.GetRow(0).CreateCell(1, CellType.String).SetCellValue("类别代码");
                sheet1.GetRow(0).CreateCell(2, CellType.String).SetCellValue("商品类别");
                changeCellType(ref sheet1, style);

                FileStream fs = new FileStream(fileFullPath, FileMode.Create);
                wb.Write(fs);
                fs.Close();
            }
        }
        /// <summary>
        /// 设置sheet第一行单元格格式
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="style"></param>
        private void changeCellType(ref ISheet sheet,ICellStyle style)
        {
            if (sheet.GetRow(0).PhysicalNumberOfCells>0)
            {
                foreach(ICell cell in sheet.GetRow(0).Cells)
                {
                    cell.CellStyle = style;
                }
            }
        }

        public DataTable searchGoodsType()
        {
            string sheetName = ExcelDataAccess.getExcelSheetNameById(connectionString, 1);
            string sql = "SELECT * FROM [goodsType$] ";
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
