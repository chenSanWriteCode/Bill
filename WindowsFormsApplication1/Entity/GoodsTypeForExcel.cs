using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bill.Entity
{
    public class GoodsTypeForExcel
    {
        private int _id;
        private string _类别代码;
        private string _商品类别;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string 类别代码
        {
            get { return _类别代码; }
            set { _类别代码 = value; }
        }
        public string 商品类别
        {
            get { return _商品类别; }
            set { _商品类别 = value; }
        }
    }
}
