using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using bill.Entity;

namespace bill.Business
{
    interface IBillBusiness
    {
        void init();
        DataTable searchGoodsType(); 

        DataTable addGoodsType(GoodsType goodsType, out string errorMessage);

        bool deleteGoodsType(GoodsType goodsType, out string errorMessage);

        bool updateGoodsType(GoodsType goodsType, out string errorMessage);

        DataTable searchBillByCondition(Goods goods);

        DataTable addBills(Goods goods, out string errorMessage);

        bool updateBills(Goods goods, out string errorMessage);

        DataTable searchAllBillDesc();

        bool deleteBill(Goods goods, out string errorMessage);


    }
}
