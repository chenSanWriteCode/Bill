using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bill.Entity
{
    public class BillForExcel
    {
        private int _id;
        private string _商品名称;
        private float _商品价格;
        private string _商品类别;
        private string _商场;
        private DateTime _购买时间;
        private string _备注;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string 商品名称
        {
            get { return _商品名称; }
            set { _商品名称 = value; }
        }
        public float 商品价格
        {
            get { return _商品价格; }
            set { _商品价格 = value; }
        }
        public string 商品类别
        {
            get { return _商品类别; }
            set { _商品类别 = value; }
        }
        public string 商场
        {
            get { return _商场; }
            set { _商场 = value; }
        }
        public DateTime 购买时间
        {
            get { return _购买时间; }
            set { _购买时间 = value; }
        }
        public string 备注
        {
            get { return _备注; }
            set { _备注 = value; }
        }
    }
}
