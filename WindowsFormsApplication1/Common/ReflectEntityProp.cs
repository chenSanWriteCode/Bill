using System;
using System.Collections.Generic;
using System.Reflection;

namespace bill.Common
{
    /// <summary>
    /// 反射entity，获取类名与属性名
    /// </summary>
    public class ReflectEntityProp<T>
    {
        public Table table;
        /// <summary>
        /// 通过反射，获取类的类名与属性名集合
        /// </summary>
        public ReflectEntityProp()
        {
            Type type = typeof(T);
            PropertyInfo[] propertyinfos = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if(propertyinfos.Length>0)
            {
                table.name = propertyinfos[0].ReflectedType.Name;
                table.columns = new string[propertyinfos.Length];
                for (int i = 0; i < propertyinfos.Length; i++)
                {
                    table.columns[i] = propertyinfos[i].Name;
                }
            }
        }
        /// <summary>
        /// 根据字段名反射实体类字段的字段值与字段类型
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="k"></param>
        /// <param name="columns">字段名</param>
        /// <returns></returns>
        public static  List<Column> reflectEntityValue(T t, string[] columns)
        {
            List<Column> columnList =new List<Column>();
            Type type = typeof(T);
            for (int i = 0; i < columns.Length; i++)
            {
                Column column = new Column();
                column.name = columns[i];
                column.content = type.GetProperty(column.name).GetValue(t, null).ToString();
                column.type = type.GetProperty(column.name).PropertyType.Name;
            }
            return columnList;
        }

    }

    
    /// <summary>
    /// 类的属性
    /// </summary>
    public struct Table
    {   
        /// <summary>
        /// 类名
        /// </summary>
        public string name;
        /// <summary>
        /// 字段名
        /// </summary>
        public string[] columns;
    }
    /// <summary>
    /// 字段属性
    /// </summary>
    public struct Column
    {
        public string name;

        public string content;

        public string type;
    }
}
