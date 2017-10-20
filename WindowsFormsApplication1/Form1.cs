using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bill.Entity;
using bill.Business;
using bill.DataAccess.Common;

namespace Bill
{
    public partial class Form1 : Form
    {
        private  IBillBusiness billBuzz;
        public Form1()
        {
            InitializeComponent();
            // 检查excle是否存在，不存在则创建
            if (ApplicationConfig.isUseSqlServer != "1")
            {
                billBuzz = new BillExcleBiz();
                billBuzz.init();
            }
            else
            {
                billBuzz = new BillBiz();
            }
            initControl();
            
            
            
        }
       
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void initControl()
        {
            
            DataTable type_dt = billBuzz.searchGoodsType();
            combo_goods_type.DataSource = type_dt;
            combo_goods_type.DisplayMember = "商品类别";
            combo_goods_type.ValueMember = "类别代码";
            combo_goods_type.SelectedIndex = -1;


            combo_goods_type_insert.DataSource = type_dt;
            combo_goods_type_insert.DisplayMember = "商品类别";
            combo_goods_type_insert.ValueMember = "类别代码";
            combo_goods_type_insert.SelectedIndex = -1;

            //设置不自动显示数据库中未绑定的列
            this.dgv_bill_search.AutoGenerateColumns = false;
            //设置隔行背景色
            this.dgv_bill_search.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgv_bill_search.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            //设置不自动显示数据库中未绑定的列
            this.dgv_bill_insert.AutoGenerateColumns = false;
            //设置隔行背景色
            this.dgv_bill_insert.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgv_bill_insert.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            DataTable type_dgv_dt = billBuzz.searchGoodsType();
            this.goods_type_insert_dgv.DataSource = type_dgv_dt;
            this.goods_type_insert_dgv.DisplayMember = "商品类别";
            this.goods_type_insert_dgv.ValueMember = "类别代码";

            //开始日期为一个月前
            this.dtp_date_begin.Value = System.DateTime.Now.Date.AddMonths(-1);

            //设置不自动显示数据库中未绑定的列
            this.dgv_goodsType.AutoGenerateColumns = false;
            //设置隔行背景色
            this.dgv_goodsType.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgv_goodsType.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            //商品类别第一列不允许修改
            this.dgv_goodsType.Columns[0].ReadOnly = true;

        }

        /// <summary>
        /// 刷新 还原控件默认值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refresh_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "查询")
            {
                tb_goods_mark.Clear();
                tb_goods_mall.Clear();
                tb_goods_name.Clear();
                tb_goods_price_max.Clear();
                tb_goods_price_min.Clear();
                initControl();
                dgv_bill_search.DataSource = null;
            }
            else if (tabControl1.SelectedTab.Text == "记账")
            {
                tb_goods_mark_insert.Clear();
                tb_goods_mall_insert.Clear();
                tb_goods_name_insert.Clear();
                tb_goods_price_insert.Clear();
                initControl();
                dgv_bill_insert.DataSource = null;
            }
            else
            {
                tb_goodsType_code.Clear();
                tb_goodsType_name.Clear();
            }

        }

        #region 查询页面
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            
            Goods goods = new Goods();
            goodsInit(ref goods);
            DataTable bill_dt = billBuzz.searchBillByCondition(goods);
            recombineTable(ref bill_dt);
            dgv_bill_search.DataSource = bill_dt;

        }
        /// <summary>
        /// 重组dt  加汇总
        /// </summary>
        /// <param name="dt"></param>
        private void recombineTable(ref DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr["商品名称"] = "汇总";
            dr["商品价格"] = dt.Compute("sum(商品价格)", "");
            dt.Rows.Add(dr);
        }
        /// <summary>
        /// 将form中的变量赋值到goods类中
        /// </summary>
        /// <param name="goods"></param>
        public void goodsInit(ref Goods goods)
        {
            goods.goodsName = tb_goods_name.Text == "" ? null : tb_goods_name.Text;

            goods.goodsMark = tb_goods_mark.Text == "" ? null : tb_goods_mark.Text;
            if (combo_goods_type.SelectedIndex != -1)
            {
                goods.goodsType = combo_goods_type.SelectedValue.ToString() == "" ? null : combo_goods_type.SelectedValue.ToString();
            }
            double price;
            //判断价格值是否有效
            if (tb_goods_price_min.Text != "")
            {
                if (double.TryParse(tb_goods_price_min.Text, out price))
                {
                    goods.goodsPriceMin = price;
                }
                else
                {
                    MessageBox.Show("价格最小值不是有效值，请重新输入");
                }
            }
            if (tb_goods_price_max.Text != "")
            {
                if (double.TryParse(tb_goods_price_max.Text, out price))
                {
                    goods.goodsPriceMax = price;
                }
                else
                {
                    MessageBox.Show("价格最大值不是有效值，请重新输入");
                }
            }
            else
            {
                goods.goodsPriceMax = 99999;
            }
            goods.createDateBegin = dtp_date_begin.Value.Date;
            goods.createDateEnd = dtp_date_end.Value.Date;
            goods.mall = tb_goods_mall.Text == "" ? null : tb_goods_mall.Text;
        }
        #endregion

        #region 记账tab
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_insert_Click(object sender, EventArgs e)
        {
            
            DataTable dt_bill_insert;
            Goods goods = new Goods();
            string errorMessage;
            goods.goodsName = tb_goods_name_insert.Text;
            if(combo_goods_type_insert.SelectedIndex==-1)
            {
                MessageBox.Show("品类不能为空");
                return;
            }
            goods.goodsType = combo_goods_type_insert.SelectedValue.ToString();
            goods.goodsMark = tb_goods_mark_insert.Text;
            double price;
            //判断价格值是否有效
            if (tb_goods_price_insert.Text == "")
            {
                MessageBox.Show("价格不能为空");
                return;
            }
            else
            {
                if (double.TryParse(tb_goods_price_insert.Text, out price))
                {
                    goods.goodsPrice = price;
                }
                else
                {
                    MessageBox.Show("价格不是有效值，请重新输入");
                }
            }
            goods.createDate = dtp_goods_date_insert.Value.Date;
            goods.mall = tb_goods_mall_insert.Text;
            dt_bill_insert = billBuzz.addBills(goods, out errorMessage);
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
                return;
            }
            dgv_bill_insert.DataSource = dt_bill_insert;
        }

        /// <summary>
        /// 通过修改datagridrow 方式，修改账单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_bill_insert_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            string errorMessage;
            if (dgv_bill_insert.DataSource != null)
            {
                DataGridViewRow dgvr = dgv_bill_insert.Rows[e.RowIndex];
                Goods goods = new Goods();
                //判断价格是否有效
                if (dgv_bill_insert.Columns[e.ColumnIndex].Name == "goods_price_insert")
                {
                    double price;
                    if (!double.TryParse(dgvr.Cells["goods_price_insert"].Value.ToString(), out price))
                    {
                        MessageBox.Show("价格值无效");
                        return;
                    }
                }
                //判断时间是否有效
                if (dgv_bill_insert.Columns[e.ColumnIndex].Name == "date_insert")
                {
                    DateTime dateTime;
                    if (!DateTime.TryParse(dgvr.Cells["date_insert"].Value.ToString(), out dateTime))
                    {
                        MessageBox.Show("时间无效");
                        return;
                    }
                }
                goods.id = (int)dgvr.Cells["id"].Value;
                goods.mall = dgvr.Cells["mall_insert"].Value.ToString();
                goods.goodsType = dgvr.Cells["goods_type_insert_dgv"].Value.ToString();
                goods.goodsPrice = double.Parse(dgvr.Cells["goods_price_insert"].Value.ToString());
                goods.goodsName = dgvr.Cells["goods_name_insert"].Value.ToString();
                goods.goodsMark = dgvr.Cells["mark_insert"].Value.ToString();
                goods.createDate = DateTime.Parse(dgvr.Cells["date_insert"].Value.ToString());
                if (billBuzz.updateBills(goods, out errorMessage))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
        }
        /// <summary>
        /// 将datagridview中的值赋值到条件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_bill_insert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            combo_goods_type_insert.SelectedValue = dgv_bill_insert.Rows[e.RowIndex].Cells["goods_type_insert_dgv"].Value.ToString();
            tb_goods_name_insert.Text = dgv_bill_insert.Rows[e.RowIndex].Cells["goods_name_insert"].Value.ToString();
            tb_goods_mall_insert.Text = dgv_bill_insert.Rows[e.RowIndex].Cells["mall_insert"].Value.ToString();
            tb_goods_price_insert.Text = dgv_bill_insert.Rows[e.RowIndex].Cells["goods_price_insert"].Value.ToString();
            tb_goods_mark_insert.Text = dgv_bill_insert.Rows[e.RowIndex].Cells["mark_insert"].Value.ToString();
            //foreach (DataRowView drv in combo_goods_type_insert.Items)
            //{
            //    if (drv["类别代码"].ToString() == typeName)
            //    {
            //        combo_goods_type_insert.SelectedItem = drv;
            //    }
            //}
        }
        /// <summary>
        /// 无条件倒序查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_insert_Click(object sender, EventArgs e)
        {
            
            DataTable dt_bill_all = new DataTable();
            dt_bill_all = billBuzz.searchAllBillDesc();
            dgv_bill_insert.DataSource = dt_bill_all;
        }
        /// <summary>
        /// 删除某一行 通过id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_bill_insert_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
            Goods goods = new Goods();
            string errorMessage;
            goods.id = Convert.ToInt32(e.Row.Cells["id"].Value.ToString());
            if (billBuzz.deleteBill(goods, out errorMessage))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        #endregion

        #region 基础数据
        /// <summary>
        /// 增加商品类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_goodsType_insert_Click(object sender, EventArgs e)
        {
            
            if (tb_goodsType_code.Text=="")
            {
                MessageBox.Show("品类代码不能为空");
            }
            if(tb_goodsType_name.Text=="")
            {
                MessageBox.Show("品类名称不能为空");
            }
            GoodsType goodsType = new GoodsType();
            string errorMessage;
            goodsType.goodsTypeCode = tb_goodsType_code.Text;
            goodsType.goodsTypeName = tb_goodsType_name.Text;
            dgv_goodsType.DataSource = billBuzz.addGoodsType(goodsType, out errorMessage);
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
            }
        }


        /// <summary>
        /// 修改 商品类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_goodsType_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgv_goodsType.DataSource != null)
            {
                GoodsType goodsType = new GoodsType();
                string errorMessage;

                goodsType.goodsTypeCode = dgv_goodsType.Rows[e.RowIndex].Cells["goods_type_code"].Value.ToString();
                goodsType.goodsTypeName = dgv_goodsType.Rows[e.RowIndex].Cells["goods_type_name"].Value.ToString();
                if (billBuzz.updateGoodsType(goodsType, out errorMessage))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }

        }
        /// <summary>
        /// 将表格中数据赋值到条件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_goodsType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_goodsType_code.Text = dgv_goodsType.Rows[e.RowIndex].Cells["goods_type_code"].Value.ToString();
            tb_goodsType_name.Text = dgv_goodsType.Rows[e.RowIndex].Cells["goods_type_name"].Value.ToString();
        }
        /// <summary>
        /// 删除 商品类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_goodsType_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
            GoodsType goodsType = new GoodsType();
            string errorMessage;
            goodsType.goodsTypeCode = e.Row.Cells["goods_type_code"].Value.ToString();
            goodsType.goodsTypeName = e.Row.Cells["goods_type_name"].Value.ToString();
            if (billBuzz.deleteGoodsType(goodsType, out errorMessage))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }
        /// <summary>
        /// 基础数据tab被选中时，自动加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable type_dt = billBuzz.searchGoodsType();
            dgv_goodsType.DataSource = type_dt;
        }



        #endregion


    }
}
