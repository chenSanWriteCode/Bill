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
        /// 为workbook创建第一行
        /// </summary>
        /// <param name="wb">HSSFWorkbook</param>
        /// <param name="table">strut table</param>
        /// <param name="style">cellStyle can null</param>
        public static void createExcelColumns(ref HSSFWorkbook wb, string tableName,string[] columns, ICellStyle style)
        {
            if (columns.Length>0)
            {
                ISheet sheet = wb.CreateSheet(tableName);
                sheet.CreateRow(0).CreateCell(0, CellType.Numeric).SetCellValue(columns[0]);
                for (int i = 1; i < columns.Length; i++)
                {
                    sheet.GetRow(0).CreateCell(i, CellType.Numeric).SetCellValue(columns[i]);
                }
                if (style != null)
                {
                    changeCellType(ref sheet, style);
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
