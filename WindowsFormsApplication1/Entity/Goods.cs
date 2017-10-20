using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bill.Entity
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Goods
    {
        public int id { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string goodsName { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public double goodsPrice { get; set; }
        public double goodsPriceMin { get; set; }
        public double goodsPriceMax { get; set; }
        /// <summary>
        /// 商品类别
        /// </summary>
        public string goodsType { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string goodsMark { get; set; }
        /// <summary>
        /// 商场
        /// </summary>
        public string mall { get; set; }
        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime createDate { get; set; }
        public DateTime createDateBegin { get; set; }
        public DateTime createDateEnd { get; set; }

    }
}
