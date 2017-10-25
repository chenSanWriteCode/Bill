using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using bill.Entity;
using bill.DataAccess;
using System.Data.SqlClient;

namespace bill.Business
{
    public class BillBiz : IBillBusiness
    {
        #region 账单相关的增删改查

        /// <summary>
        /// 根据条件查询账单
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public DataTable searchBillByCondition(Goods goods)
        {
            DataTable bill_dt = new DataTable();
            string procedureName = "账单_查询";
            string errorMessage;
            SqlParameter[] thisParams = new SqlParameter[8];
            thisParams[0] = new SqlParameter("@商品名称", goods.goodsName);
            thisParams[1] = new SqlParameter("@商场", goods.mall);
            thisParams[2] = new SqlParameter("@商品类别", goods.goodsType);
            thisParams[3] = new SqlParameter("@备注", goods.goodsMark);
            thisParams[4] = new SqlParameter("@商品价格min", goods.goodsPriceMin);
            thisParams[5] = new SqlParameter("@商品价格max", goods.goodsPriceMax);
            thisParams[6] = new SqlParameter("@购买时间begin", goods.createDateBegin);
            thisParams[7] = new SqlParameter("@购买时间end", goods.createDateEnd);
            BillDataAccess.ExecuteStoredProcedure(procedureName, ref thisParams, out bill_dt, out errorMessage);
            return bill_dt;
        }

        /// <summary>
        /// 增加记录并按倒序查询记录
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public DataTable addBills(Goods goods, out string errorMessage)
        {
            DataTable bill_dt = new DataTable();
            string procedureName = "账单_增加";

            SqlParameter[] thisParams = new SqlParameter[6];
            thisParams[0] = new SqlParameter("@商品名称", goods.goodsName);
            thisParams[1] = new SqlParameter("@商场", goods.mall);
            thisParams[2] = new SqlParameter("@商品类别", goods.goodsType);
            thisParams[3] = new SqlParameter("@备注", goods.goodsMark);
            thisParams[4] = new SqlParameter("@商品价格", goods.goodsPrice);
            thisParams[5] = new SqlParameter("@购买时间", goods.createDate);
            BillDataAccess.ExecuteStoredProcedure(procedureName, ref thisParams, out bill_dt, out errorMessage);
            return bill_dt;
        }
        /// <summary>
        /// 修改账单
        /// </summary>
        /// <param name="goods"></param>
        public bool updateBills(Goods goods, out string errorMessage)
        {
            string procedureName = "账单_修改";

            SqlParameter[] thisParams = new SqlParameter[7];
            thisParams[0] = new SqlParameter("@商品名称", goods.goodsName);
            thisParams[1] = new SqlParameter("@商场", goods.mall);
            thisParams[2] = new SqlParameter("@商品类别", goods.goodsType);
            thisParams[3] = new SqlParameter("@备注", goods.goodsMark);
            thisParams[4] = new SqlParameter("@商品价格", goods.goodsPrice);
            thisParams[5] = new SqlParameter("@购买时间", goods.createDate);
            thisParams[6] = new SqlParameter("@id", goods.id);
            return BillDataAccess.ExecuteStoredProcedure(procedureName, ref thisParams, out errorMessage);
        }
        /// <summary>
        /// 查询所有账单
        /// </summary>
        /// <returns></returns>
        public DataTable searchAllBillDesc()
        {
            DataTable bill_dt = new DataTable();
            string procedureName = "账单_查询_All";

            BillDataAccess.ExecuteStoredProcedure(procedureName, out bill_dt);
            return bill_dt;
        }
        /// <summary>
        /// 删除账单
        /// </summary>
        /// <param name="goods">通过goods.id</param>
        public bool deleteBill(Goods goods, out string errorMessage)
        {
            string procedureName = "账单_删除_ById";

            SqlParameter[] thisParams = new SqlParameter[1];
            thisParams[0] = new SqlParameter("@id", goods.id);
            return BillDataAccess.ExecuteStoredProcedure(procedureName, ref thisParams, out errorMessage);
        }
        #endregion

        #region 商品类型相关的增删改查
        /// <summary>
        /// 查询商品品类
        /// </summary>
        /// <returns></returns>
        public DataTable searchGoodsType() 
        {
            DataTable type_dt = new DataTable();
            string procedureName = "商品类别_查询";

            BillDataAccess.ExecuteStoredProcedure(procedureName, out type_dt);
            return type_dt;

        }
        /// <summary>
        /// 增加商品类别并查询记录
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public DataTable addGoodsType(GoodsType goodsType, out string errorMessage)
        {
            DataTable goodsType_dt = new DataTable();
            string procedureName = "商品类别_增加";

            SqlParameter[] thisParams = new SqlParameter[2];
            thisParams[0] = new SqlParameter("@类别代码", goodsType.goodsTypeCode);
            thisParams[1] = new SqlParameter("@商品类别", goodsType.goodsTypeName);
            BillDataAccess.ExecuteStoredProcedure(procedureName, ref thisParams, out goodsType_dt, out errorMessage);
            return goodsType_dt;
        }
        /// <summary>
        /// 删除商品类别
        /// </summary>
        /// <param name="goods">通过goodsType.id</param>
        public bool deleteGoodsType(GoodsType goodsType, out string errorMessage)
        {
            string procedureName = "商品类别_删除_ById";

            SqlParameter[] thisParams = new SqlParameter[1];
            thisParams[0] = new SqlParameter("@id", goodsType.goodsTypeCode);
            return BillDataAccess.ExecuteStoredProcedure(procedureName, ref thisParams, out errorMessage);
        }
        /// <summary>
        /// 修改商品类别
        /// </summary>
        /// <param name="goods"></param>
        public bool updateGoodsType(GoodsType goodsType, out string errorMessage)
        {
            string procedureName = "商品类别_修改";

            SqlParameter[] thisParams = new SqlParameter[2];
            thisParams[0] = new SqlParameter("@类别代码", goodsType.goodsTypeCode);
            thisParams[1] = new SqlParameter("@商品类别", goodsType.goodsTypeName);
            return BillDataAccess.ExecuteStoredProcedure(procedureName, ref thisParams, out errorMessage);
        }

        public void init()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
