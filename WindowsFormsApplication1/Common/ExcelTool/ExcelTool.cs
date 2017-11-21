using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bill.Common.Const;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace bill.Common.ExcelTool
{
    /// <summary>
    /// 根据NPOI拓展的增删改查方法
    /// </summary>
    public class ExcelTool
    {
        #region 增加 表头 一行数据 
        /// <summary>
        /// 根据类 创建表头
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="wb"></param>
        /// <param name="style">表头单元格格式</param>
        public static void createExcelColumns<T>(ref HSSFWorkbook wb, ICellStyle style)
        {
            ReflectEntityProp<T> reflectT = new ReflectEntityProp<T>();
            createExcelColumns(ref wb, reflectT.table.name, reflectT.table.columns, style);
        }
        /// <summary>
        /// 在sheet现有内容后，创建一行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sheet"></param>
        /// <param name="t"></param>
        public static void createRow<T>(ref ISheet sheet, T t)
        {
            createRow(ref sheet, entityToExcelRow<T>(t));
        }
        /// <summary>
        /// 为workbook创建带表头的sheet
        /// </summary>
        /// <param name="wb"></param>
        /// <param name="tableName">sheet名</param>
        /// <param name="columns">表头</param>
        /// <param name="style">cellStyle can null</param>
        private static void createExcelColumns(ref HSSFWorkbook wb, string tableName, string[] columns, ICellStyle style)
        {
            if (columns.Length > 0)
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
        /// <param name="row"></param>
        private static void createRow(ref ISheet sheet, List<ExcelColumn> row)
        {
            int lastRowNum = sheet.LastRowNum + 1;
            if (!isSheetEmpty(sheet) && row.Count > 0)
            {
                sheet.CreateRow(lastRowNum);
                for (int i = 0; i < row.Count; i++)
                {
                    if (row[i].ColumnContent != null && row[i].ColumnContent != "")
                    {
                        sheet.GetRow(lastRowNum).CreateCell(row[i].ColumnOrder, row[i].ExcelColumnType).SetCellValue(row[i].ColumnContent);
                    }

                }
            }
        }
        #endregion

        #region 查询
        /// <summary>
        /// 根据sheet的index查询
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static DataTable getSheetDataAt(IWorkbook workbook, int index)
        {
            ISheet sheet = null;
            DataTable dt_sheet = null;
            if (index < workbook.NumberOfSheets)
            {
                sheet = workbook.GetSheetAt(index);
                dt_sheet = excelToDataTable(sheet);
            }
            return dt_sheet;
        }
        /// <summary>
        /// 根据sheet名查询
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable getSheetDataAt(IWorkbook workbook, string name)
        {
            ISheet sheet = workbook.GetSheet(name);
            DataTable dt_sheet = excelToDataTable(sheet);
            return dt_sheet;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除sheet中的第index行,并且将index+1 到maxIndex 的行号均减一（上移一行）
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="index"></param>
        /// <param name="upRowIndex">是否上调行序号</param>
        /// <returns></returns>
        public static bool deleteSheetRow(ref ISheet sheet, int index, bool upRowIndex)
        {
            bool flag = true;
            try
            {
                if (upRowIndex)
                {
                    sheet.ShiftRows(index + 1, sheet.LastRowNum, -1);
                }
                else
                {
                    deleteSheetRow(ref sheet, index);
                }

            }
            catch
            {
                flag = false;
            }
            return flag;
        }
        /// <summary>
        /// 删除sheet中的第index行，保留本行空格
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool deleteSheetRow(ref ISheet sheet, int index)
        {
            bool flag = true;
            try
            {
                IRow row = sheet.GetRow(index);
                sheet.RemoveRow(row);
            }
            catch
            {
                flag = false;
            }
            return flag;
        }

        #endregion

        #region 修改
        /// <summary>
        /// 修改sheet某一行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sheet"></param>
        /// <param name="t"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public static bool updateSheetRow<T>(ISheet sheet, T t, int rowIndex)
        {
            return updateSheetRow(sheet, entityToExcelRow<T>(t), rowIndex);
        }
        /// <summary>
        /// 修改sheet某一行
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        private static bool updateSheetRow(ISheet sheet, List<ExcelColumn> row, int rowIndex)
        {
            bool flag = true;
            try
            {
                for (int i = 0; i < row.Count; i++)
                {
                    sheet.GetRow(rowIndex).GetCell(row[i].ColumnOrder).SetCellValue(row[i].ColumnContent);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                flag = false;
            }

            return flag;
        }

        #endregion

        /// <summary>
        /// 将泛型数据转换为excel的row
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        private static List<ExcelColumn> entityToExcelRow<T>(T t)
        {
            ReflectEntityProp<T> reflectT = new ReflectEntityProp<T>();
            List<Column> columnList = ReflectEntityProp<T>.reflectEntityValue(t, reflectT.table.columns);
            List<ExcelColumn> row = new List<ExcelColumn>();
            for (int i = 0; i < columnList.Count; i++)
            {
                ExcelColumn excelColumn = new ExcelColumn();
                excelColumn.ColumnOrder = i;
                excelColumn.ColumnContent = columnList[i].content;
                excelColumn.ColumnType = columnList[i].type;
                row.Add(excelColumn);
            }
            return row;
        }
        /// <summary>
        /// 将sheet数据转换为datatable
        /// 以sheet第一行为表头，采集每列对应的数据(在表头基础上加一列excel_id，记录在excel中位置)，
        /// 不在列对应的单元格内的数据，不予采集
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        private static DataTable excelToDataTable(ISheet sheet)
        {
            DataTable dt_sheet = null;
            if (!isSheetEmpty(sheet))
            {
                dt_sheet = new DataTable();
                //读取从firstrownum以下的数据
                int firstRowNum = sheet.FirstRowNum;

                IRow headerRow = sheet.GetRow(firstRowNum);
                IEnumerator rowEnumerate = sheet.GetRowEnumerator();

                //key 第N个列，value 第N列对应的columnIndex
                //Dictionary<int, int> dic = new Dictionary<int, int>();
                int columnNum = 1;
                int[] columnIndexs = new int[headerRow.Cells.Count + 1];
                dt_sheet.Columns.Add("excel_id");
                columnIndexs[0] = -1;
                //字段名
                foreach (ICell cell in headerRow.Cells)
                {
                    dt_sheet.Columns.Add(cell.StringCellValue);
                    columnIndexs[columnNum] = cell.ColumnIndex;
                    columnNum++;
                }
                while (rowEnumerate.MoveNext())
                {
                    IRow row = (IRow)rowEnumerate.Current;
                    //从第二行开始取数
                    //遍历columnIndex，获取列序号
                    //通过列序号获取  currentrow在某列的内容
                    //判断内容格式 给dr【i】 正确赋值
                    //dr为null  则删除
                    if (row.RowNum > firstRowNum)
                    {
                        DataRow dr = dt_sheet.NewRow();
                        for (int i = 0; i < columnIndexs.Length; i++)
                        {
                            ICell cell = row.GetCell(columnIndexs[i]);
                            if (cell != null)
                            {
                                switch (cell.CellType)
                                {
                                    case CellType.Numeric:
                                        short format = cell.CellStyle.DataFormat;
                                        if (format == 14 || format == 31 || format == 57 || format == 58)
                                        {
                                            dr[i] = cell.DateCellValue;
                                        }
                                        else
                                        {
                                            dr[i] = cell.NumericCellValue;
                                        }
                                        break;
                                    case CellType.String:
                                        dr[i] = cell.StringCellValue;
                                        break;
                                    case CellType.Formula:
                                        dr[i] = "=" + cell.CellFormula;
                                        break;
                                    case CellType.Boolean:
                                        dr[i] = cell.BooleanCellValue;
                                        break;
                                    case CellType.Error:
                                        dr[i] = cell.ErrorCellValue;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        if (!IsDataRowNull(dr))
                        {
                            dr[0] = row.RowNum;
                            dt_sheet.Rows.Add(dr);
                        }

                    }
                }
            }
            return dt_sheet;
        }
        /// <summary>
        /// 根据地址获取workbook
        /// </summary>
        /// <param name="path">带文件名的地址</param>
        /// <returns></returns>
        public static IWorkbook getWorkBook(string path)
        {
            IWorkbook workBook = null;
            if (path != "")
            {
                workBook = WorkbookFactory.Create(path);
            }
            return workBook;
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
        /// <summary>
        /// 判断sheet是否为空
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        public static bool isSheetEmpty(ISheet sheet)
        {
            if (sheet == null || sheet.PhysicalNumberOfRows < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 判断datarow是否为空
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private static bool IsDataRowNull(DataRow dr)
        {
            bool flag = true;
            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {
                if (!dr.IsNull(i))
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}
