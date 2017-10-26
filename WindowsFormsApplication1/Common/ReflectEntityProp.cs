using System;
using System.Reflection;
using bill.Common.Const;

namespace bill.Common
{
    /// <summary>
    /// 反射entity，获取类名与属性名
    /// </summary>
    public class ReflectEntityProp<T>
    {
        public Table table;
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
       
    }
    public struct Table
    {
        public string name;
        public string[] columns;
    }
}
