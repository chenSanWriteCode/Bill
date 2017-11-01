using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.SS.UserModel;

namespace bill.Common.ExcelTool
{
    public class ExcelColumn
    {
        
        private int _columnOrder;
        
        private string _columnContent;
        
        private string _columnType;

        private CellType _excelColumnType;
        /// <summary>
        /// 字段序号
        /// </summary>
        public int ColumnOrder
        {
            get
            {
                return _columnOrder;
            }

            set
            {
                _columnOrder = value;
            }
        }
        /// <summary>
        /// 字段内容
        /// </summary>
        public string ColumnContent
        {
            get
            {
                return _columnContent;
            }

            set
            {
                _columnContent = value;
            }
        }
        /// <summary>
        /// 字段类型
        /// </summary>
        public string ColumnType
        {
            get
            {
                return _columnType;
            }

            set
            {
                _columnType = value;
                switch(value)
                {
                    case "Int32":
                        _excelColumnType = CellType.Numeric;
                        break;
                    case "String":
                        _excelColumnType = CellType.String;
                        break;
                    case "DateTime":
                        _excelColumnType = CellType.String;
                        break;
                    case "Double":
                        _excelColumnType = CellType.Numeric;
                        break;
                    default:
                        _excelColumnType = CellType.String;
                        break;
                }
            }
        }
        /// <summary>
        /// excel字段类型
        /// </summary>
        public CellType ExcelColumnType
        {
            get
            {
                return _excelColumnType;
            }
        }
    }
}
