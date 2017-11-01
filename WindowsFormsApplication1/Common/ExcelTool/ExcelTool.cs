using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bill.Common.Const;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace bill.Common.ExcelTool
{
    public class ExcelTool
    {
        /// <summary>
        /// 为workbook创建带表头的sheet
        /// </summary>
        /// <param name="wb"></param>
        /// <param name="tableName">sheet名</param>
        /// <param name="columns">表头</param>
        /// <param name="style">cellStyle can null</param>
        public static void createExcelColumns(ref HSSFWorkbook wb, string tableName,string[] columns, ICellStyle style)
        {
            if (columns.Length>0)
            {
                ISheet sheet = wb.CreateSheet(tableName);
                sheet.CreateRow(0);
                for (int i = 0; i < columns.Length; i++)
                {
                    sheet.GetRow(0).CreateCell(i, CellType.String).SetCellValue(columns[i]);
                }
                if (style != null)
                {
                    changeCellType(ref sheet, style);
                }
            }
        }
        /// <summary>
        /// 在sheet现有内容后，创建一行
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="rows"></param>
        public static void createRow(ref HSSFSheet sheet,List<ExcelColumn> rows)
        {
            int lastRowNum = sheet.LastRowNum+1;
            if (lastRowNum>0 && rows.Count>0)
            {
                sheet.CreateRow(lastRowNum);
                for (int i = 0 ; i < rows.Count; i++)
                {
                    if (rows[i].ColumnContent!=null && rows[i].ColumnContent !="")
                    {
                        sheet.GetRow(lastRowNum).CreateCell(rows[i].ColumnOrder, rows[i].ExcelColumnType).SetCellValue(rows[i].ColumnContent);
                    }
                    
                }
            }
        }
        /// <summary>
        /// 设置sheet第一行单元格格式
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="style"></param>
        private static void changeCellType(ref ISheet sheet, ICellStyle style)
        {
            if (sheet.GetRow(0).PhysicalNumberOfCells > 0)
            {
                foreach (ICell cell in sheet.GetRow(0).Cells)
                {
                    cell.CellStyle = style;
                }
            }
        }
    }
}
