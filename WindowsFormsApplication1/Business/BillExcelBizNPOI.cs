using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using bill.Common.Const;
using bill.Common.ExcelTool;
using bill.DataAccess.Common;
using bill.Entity;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace bill.Business
{
    public class BillExcelBizNPOI : IBillBusiness
    {
        #region 底层变量
        //1. 首先判断文件目录是否存在 不存在则创建
        //2. 判断文件是否存在 不存在则创建
        //3. 判断账单（bill）sheet是否存在 不存在则创建
        //4. 判断商品类型（goodsType）sheet是否存在 不存在则创建

        /// <summary>
        /// 文件名
        /// </summary>
        private string fileName = ApplicationConfig.fileName;
        /// <summary>
        /// 文件地址
        /// </summary>
        private string filePath = ApplicationConfig.filePath;
        /// <summary>
        /// 账单反射列
        /// </summary>
        //private ReflectEntityProp<BillForExcel> goodsReflect;
        /// <summary>
        /// 商品类型反射列
        /// </summary>
        //ReflectEntityProp<GoodsTypeForExcel> goodsTypeReflect;
        #endregion

        #region 实例化
        /// <summary>
        /// 判断账单是否存在，不存在则创建
        /// </summary>
        public void init()
        {
            //goodsReflect = new ReflectEntityProp<BillForExcel>();
            //goodsTypeReflect = new ReflectEntityProp<GoodsTypeForExcel>();
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
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                IFont font = wb.CreateFont();
                font.IsBold = true;
                font.FontHeightInPoints = 12;
                style.SetFont(font);

                if (ExcelTool.getSheetDataAt(ExcelTool.getWorkBook(filePath+fileName),TableId.BillForExcel.ToString())==null)
                {
                    ExcelTool.createExcelColumns<BillForExcel>(ref wb, style);
                }
                if (ExcelTool.getSheetDataAt(ExcelTool.getWorkBook(filePath + fileName), TableId.GoodsTypeForExcel.ToString()) == null)
                {
                    ExcelTool.createExcelColumns<GoodsTypeForExcel>(ref wb, style);
                }
                FileStream fs = new FileStream(fileFullPath, FileMode.Create);
                wb.Write(fs);
                fs.Close();
            }
        }
        #endregion
        /// <summary>
        /// 增加一行账单
        /// </summary>
        /// <param name="goods"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public DataTable addBills(Goods goods, out string errorMessage)
        {
            errorMessage = "";
            ISheet sheet = ExcelTool.getWorkBook(filePath + fileName).GetSheetAt((int)TableId.GoodsTypeForExcel);
            ExcelTool.createRow<Goods>(ref sheet, goods);
            return new DataTable();

        }

        public DataTable addGoodsType(GoodsType goodsType, out string errorMessage)
        {
            throw new NotImplementedException();
        }

        public bool deleteBill(Goods goods, out string errorMessage)
        {
            throw new NotImplementedException();
        }

        public bool deleteGoodsType(GoodsType goodsType, out string errorMessage)
        {
            throw new NotImplementedException();
        }

        public DataTable searchAllBillDesc()
        {
            throw new NotImplementedException();
        }

        public DataTable searchBillByCondition(Goods goods)
        {
            throw new NotImplementedException();
        }

        public DataTable searchGoodsType()
        {
            DataTable dt_goodsType = ExcelTool.getSheetDataAt(ExcelTool.getWorkBook(filePath+fileName), (int)TableId.GoodsTypeForExcel);
            return dt_goodsType;
        }

        public bool updateBills(Goods goods, out string errorMessage)
        {
            throw new NotImplementedException();
        }

        public bool updateGoodsType(GoodsType goodsType, out string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
}
