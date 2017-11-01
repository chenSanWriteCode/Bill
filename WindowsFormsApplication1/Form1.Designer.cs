namespace Bill
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_bill_search = new System.Windows.Forms.DataGridView();
            this.rowNum_select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gooddsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buy_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_goods_name = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_search = new System.Windows.Forms.Button();
            this.combo_goods_type = new System.Windows.Forms.ComboBox();
            this.dtp_date_end = new System.Windows.Forms.DateTimePicker();
            this.tb_goods_mark = new System.Windows.Forms.TextBox();
            this.tb_goods_price_max = new System.Windows.Forms.TextBox();
            this.tb_goods_mall = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_date_begin = new System.Windows.Forms.DateTimePicker();
            this.tb_goods_price_min = new System.Windows.Forms.TextBox();
            this.panel_condition_search = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_search_insert = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_goods_date_insert = new System.Windows.Forms.DateTimePicker();
            this.combo_goods_type_insert = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_goods_mark_insert = new System.Windows.Forms.TextBox();
            this.tb_goods_price_insert = new System.Windows.Forms.TextBox();
            this.tb_goods_mall_insert = new System.Windows.Forms.TextBox();
            this.tb_goods_name_insert = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_bill_insert = new System.Windows.Forms.DataGridView();
            this.rowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name_insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price_insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type_insert_dgv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mall_insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark_insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_condition_insert = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_goodsType_insert = new System.Windows.Forms.Button();
            this.tb_goodsType_code = new System.Windows.Forms.TextBox();
            this.tb_goodsType_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_goodsType = new System.Windows.Forms.DataGridView();
            this.goods_type_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_condition_base = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill_search)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_condition_search.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill_insert)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goodsType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bill_search
            // 
            this.dgv_bill_search.AllowUserToAddRows = false;
            this.dgv_bill_search.AllowUserToDeleteRows = false;
            this.dgv_bill_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bill_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bill_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNum_select,
            this.gooddsName,
            this.goodsPrice,
            this.buy_date,
            this.goods_type,
            this.mall,
            this.goodsMark});
            this.dgv_bill_search.Location = new System.Drawing.Point(3, 87);
            this.dgv_bill_search.Name = "dgv_bill_search";
            this.dgv_bill_search.ReadOnly = true;
            this.dgv_bill_search.RowTemplate.Height = 23;
            this.dgv_bill_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bill_search.Size = new System.Drawing.Size(989, 344);
            this.dgv_bill_search.TabIndex = 0;
            // 
            // rowNum_select
            // 
            this.rowNum_select.DataPropertyName = "序号";
            this.rowNum_select.HeaderText = "序号";
            this.rowNum_select.Name = "rowNum_select";
            this.rowNum_select.ReadOnly = true;
            // 
            // gooddsName
            // 
            this.gooddsName.DataPropertyName = "商品名称";
            this.gooddsName.HeaderText = "商品名称";
            this.gooddsName.Name = "gooddsName";
            this.gooddsName.ReadOnly = true;
            // 
            // goodsPrice
            // 
            this.goodsPrice.DataPropertyName = "商品价格";
            this.goodsPrice.HeaderText = "商品价格";
            this.goodsPrice.Name = "goodsPrice";
            this.goodsPrice.ReadOnly = true;
            // 
            // buy_date
            // 
            this.buy_date.DataPropertyName = "购买时间";
            this.buy_date.HeaderText = "支出时间";
            this.buy_date.Name = "buy_date";
            this.buy_date.ReadOnly = true;
            // 
            // goods_type
            // 
            this.goods_type.DataPropertyName = "商品类别";
            this.goods_type.HeaderText = "品类";
            this.goods_type.Name = "goods_type";
            this.goods_type.ReadOnly = true;
            // 
            // mall
            // 
            this.mall.DataPropertyName = "商场";
            this.mall.HeaderText = "商场";
            this.mall.Name = "mall";
            this.mall.ReadOnly = true;
            // 
            // goodsMark
            // 
            this.goodsMark.DataPropertyName = "备注";
            this.goodsMark.HeaderText = "备注";
            this.goodsMark.Name = "goodsMark";
            this.goodsMark.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(404, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称";
            // 
            // tb_goods_name
            // 
            this.tb_goods_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goods_name.Location = new System.Drawing.Point(442, 7);
            this.tb_goods_name.Name = "tb_goods_name";
            this.tb_goods_name.Size = new System.Drawing.Size(100, 26);
            this.tb_goods_name.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 469);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.Menu;
            this.refresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(100, 22);
            this.refresh.Text = "刷新";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.combo_goods_type);
            this.tabPage1.Controls.Add(this.dtp_date_end);
            this.tabPage1.Controls.Add(this.dgv_bill_search);
            this.tabPage1.Controls.Add(this.tb_goods_mark);
            this.tabPage1.Controls.Add(this.tb_goods_price_max);
            this.tabPage1.Controls.Add(this.tb_goods_mall);
            this.tabPage1.Controls.Add(this.tb_goods_name);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtp_date_begin);
            this.tabPage1.Controls.Add(this.tb_goods_price_min);
            this.tabPage1.Controls.Add(this.panel_condition_search);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(594, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 30);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // combo_goods_type
            // 
            this.combo_goods_type.BackColor = System.Drawing.SystemColors.Window;
            this.combo_goods_type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combo_goods_type.FormattingEnabled = true;
            this.combo_goods_type.Location = new System.Drawing.Point(594, 6);
            this.combo_goods_type.Name = "combo_goods_type";
            this.combo_goods_type.Size = new System.Drawing.Size(121, 28);
            this.combo_goods_type.TabIndex = 2;
            // 
            // dtp_date_end
            // 
            this.dtp_date_end.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_date_end.Location = new System.Drawing.Point(233, 7);
            this.dtp_date_end.Name = "dtp_date_end";
            this.dtp_date_end.Size = new System.Drawing.Size(152, 26);
            this.dtp_date_end.TabIndex = 9;
            // 
            // tb_goods_mark
            // 
            this.tb_goods_mark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goods_mark.Location = new System.Drawing.Point(780, 6);
            this.tb_goods_mark.Name = "tb_goods_mark";
            this.tb_goods_mark.Size = new System.Drawing.Size(189, 26);
            this.tb_goods_mark.TabIndex = 3;
            // 
            // tb_goods_price_max
            // 
            this.tb_goods_price_max.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goods_price_max.Location = new System.Drawing.Point(233, 44);
            this.tb_goods_price_max.Name = "tb_goods_price_max";
            this.tb_goods_price_max.Size = new System.Drawing.Size(152, 26);
            this.tb_goods_price_max.TabIndex = 5;
            // 
            // tb_goods_mall
            // 
            this.tb_goods_mall.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goods_mall.Location = new System.Drawing.Point(442, 41);
            this.tb_goods_mall.Name = "tb_goods_mall";
            this.tb_goods_mall.Size = new System.Drawing.Size(100, 26);
            this.tb_goods_mall.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(202, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(203, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(558, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "品类";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(742, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "备注";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "价格";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(404, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "商场";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "日期";
            // 
            // dtp_date_begin
            // 
            this.dtp_date_begin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_date_begin.Location = new System.Drawing.Point(41, 6);
            this.dtp_date_begin.Name = "dtp_date_begin";
            this.dtp_date_begin.Size = new System.Drawing.Size(152, 26);
            this.dtp_date_begin.TabIndex = 8;
            // 
            // tb_goods_price_min
            // 
            this.tb_goods_price_min.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goods_price_min.Location = new System.Drawing.Point(41, 44);
            this.tb_goods_price_min.Name = "tb_goods_price_min";
            this.tb_goods_price_min.Size = new System.Drawing.Size(152, 26);
            this.tb_goods_price_min.TabIndex = 4;
            // 
            // panel_condition_search
            // 
            this.panel_condition_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_condition_search.BackColor = System.Drawing.Color.Transparent;
            this.panel_condition_search.Controls.Add(this.button1);
            this.panel_condition_search.Location = new System.Drawing.Point(3, 3);
            this.panel_condition_search.Name = "panel_condition_search";
            this.panel_condition_search.Size = new System.Drawing.Size(989, 78);
            this.panel_condition_search.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_search_insert);
            this.tabPage2.Controls.Add(this.btn_insert);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.dtp_goods_date_insert);
            this.tabPage2.Controls.Add(this.combo_goods_type_insert);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tb_goods_mark_insert);
            this.tabPage2.Controls.Add(this.tb_goods_price_insert);
            this.tabPage2.Controls.Add(this.tb_goods_mall_insert);
            this.tabPage2.Controls.Add(this.tb_goods_name_insert);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dgv_bill_insert);
            this.tabPage2.Controls.Add(this.panel_condition_insert);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "记账";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_search_insert
            // 
            this.btn_search_insert.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search_insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_search_insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_search_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_insert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search_insert.Location = new System.Drawing.Point(560, 45);
            this.btn_search_insert.Name = "btn_search_insert";
            this.btn_search_insert.Size = new System.Drawing.Size(100, 30);
            this.btn_search_insert.TabIndex = 8;
            this.btn_search_insert.Text = "查询";
            this.btn_search_insert.UseVisualStyleBackColor = true;
            this.btn_search_insert.Click += new System.EventHandler(this.btn_search_insert_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_insert.Location = new System.Drawing.Point(396, 45);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 30);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "增加";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(680, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "日期";
            // 
            // dtp_goods_date_insert
            // 
            this.dtp_goods_date_insert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_goods_date_insert.Location = new System.Drawing.Point(717, 5);
            this.dtp_goods_date_insert.Name = "dtp_goods_date_insert";
            this.dtp_goods_date_insert.Size = new System.Drawing.Size(168, 26);
            this.dtp_goods_date_insert.TabIndex = 5;
            // 
            // combo_goods_type_insert
            // 
            this.combo_goods_type_insert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combo_goods_type_insert.FormattingEnabled = true;
            this.combo_goods_type_insert.Location = new System.Drawing.Point(210, 4);
            this.combo_goods_type_insert.Name = "combo_goods_type_insert";
            this.combo_goods_type_insert.Size = new System.Drawing.Size(121, 28);
            this.combo_goods_type_insert.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(174, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "品类";
            // 
            // tb_goods_mark_insert
            // 
            this.tb_goods_mark_insert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goods_mark_insert.Location = new System.Drawing.Point(45, 47);
            this.tb_goods_mark_insert.Name = "tb_goods_mark_insert";
            this.tb_goods_mark_insert.Size = new System.Drawing.Size(286, 26);
            this.tb_goods_mark_insert.TabIndex = 6;
            // 
            // tb_goods_price_insert
            // 
            this.tb_goods_price_insert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goods_price_insert.Location = new System.Drawing.Point(560, 6);
            this.tb_goods_price_insert.Name = "tb_goods_price_insert";
            this.tb_goods_price_insert.Size = new System.Drawing.Size(100, 26);
            this.tb_goods_price_insert.TabIndex = 4;
            // 
            // tb_goods_mall_insert
            // 
            this.tb_goods_mall_insert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goods_mall_insert.Location = new System.Drawing.Point(396, 6);
            this.tb_goods_mall_insert.Name = "tb_goods_mall_insert";
            this.tb_goods_mall_insert.Size = new System.Drawing.Size(100, 26);
            this.tb_goods_mall_insert.TabIndex = 3;
            // 
            // tb_goods_name_insert
            // 
            this.tb_goods_name_insert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goods_name_insert.Location = new System.Drawing.Point(45, 3);
            this.tb_goods_name_insert.Name = "tb_goods_name_insert";
            this.tb_goods_name_insert.Size = new System.Drawing.Size(100, 26);
            this.tb_goods_name_insert.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(522, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "价格";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(7, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "备注";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(358, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "商场";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(7, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "名称";
            // 
            // dgv_bill_insert
            // 
            this.dgv_bill_insert.AllowUserToAddRows = false;
            this.dgv_bill_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bill_insert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bill_insert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill_insert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNum,
            this.id,
            this.goods_name_insert,
            this.goods_price_insert,
            this.date_insert,
            this.goods_type_insert_dgv,
            this.mall_insert,
            this.mark_insert});
            this.dgv_bill_insert.Location = new System.Drawing.Point(3, 89);
            this.dgv_bill_insert.Name = "dgv_bill_insert";
            this.dgv_bill_insert.RowTemplate.Height = 23;
            this.dgv_bill_insert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bill_insert.Size = new System.Drawing.Size(991, 344);
            this.dgv_bill_insert.TabIndex = 0;
            this.dgv_bill_insert.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bill_insert_CellClick);
            this.dgv_bill_insert.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bill_insert_CellValueChanged);
            this.dgv_bill_insert.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_bill_insert_UserDeletingRow);
            // 
            // rowNum
            // 
            this.rowNum.DataPropertyName = "序号";
            this.rowNum.HeaderText = "序号";
            this.rowNum.Name = "rowNum";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // goods_name_insert
            // 
            this.goods_name_insert.DataPropertyName = "商品名称";
            this.goods_name_insert.HeaderText = "商品名称";
            this.goods_name_insert.Name = "goods_name_insert";
            // 
            // goods_price_insert
            // 
            this.goods_price_insert.DataPropertyName = "商品价格";
            this.goods_price_insert.HeaderText = "商品价格";
            this.goods_price_insert.Name = "goods_price_insert";
            // 
            // date_insert
            // 
            this.date_insert.DataPropertyName = "购买时间";
            this.date_insert.HeaderText = "支出时间";
            this.date_insert.Name = "date_insert";
            // 
            // goods_type_insert_dgv
            // 
            this.goods_type_insert_dgv.DataPropertyName = "类别代码";
            this.goods_type_insert_dgv.HeaderText = "品类";
            this.goods_type_insert_dgv.Name = "goods_type_insert_dgv";
            this.goods_type_insert_dgv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.goods_type_insert_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mall_insert
            // 
            this.mall_insert.DataPropertyName = "商场";
            this.mall_insert.HeaderText = "商场";
            this.mall_insert.Name = "mall_insert";
            // 
            // mark_insert
            // 
            this.mark_insert.DataPropertyName = "备注";
            this.mark_insert.HeaderText = "备注";
            this.mark_insert.Name = "mark_insert";
            // 
            // panel_condition_insert
            // 
            this.panel_condition_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_condition_insert.Location = new System.Drawing.Point(4, 3);
            this.panel_condition_insert.Name = "panel_condition_insert";
            this.panel_condition_insert.Size = new System.Drawing.Size(989, 78);
            this.panel_condition_insert.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_goodsType_insert);
            this.tabPage3.Controls.Add(this.tb_goodsType_code);
            this.tabPage3.Controls.Add(this.tb_goodsType_name);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.dgv_goodsType);
            this.tabPage3.Controls.Add(this.panel_condition_base);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(997, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "基础数据";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_goodsType_insert
            // 
            this.btn_goodsType_insert.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_goodsType_insert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_goodsType_insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_goodsType_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goodsType_insert.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_goodsType_insert.Location = new System.Drawing.Point(436, 7);
            this.btn_goodsType_insert.Name = "btn_goodsType_insert";
            this.btn_goodsType_insert.Size = new System.Drawing.Size(100, 30);
            this.btn_goodsType_insert.TabIndex = 3;
            this.btn_goodsType_insert.Text = "增加";
            this.btn_goodsType_insert.UseVisualStyleBackColor = true;
            this.btn_goodsType_insert.Click += new System.EventHandler(this.btn_goodsType_insert_Click);
            // 
            // tb_goodsType_code
            // 
            this.tb_goodsType_code.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goodsType_code.Location = new System.Drawing.Point(88, 9);
            this.tb_goodsType_code.Name = "tb_goodsType_code";
            this.tb_goodsType_code.Size = new System.Drawing.Size(100, 26);
            this.tb_goodsType_code.TabIndex = 1;
            // 
            // tb_goodsType_name
            // 
            this.tb_goodsType_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_goodsType_name.Location = new System.Drawing.Point(312, 9);
            this.tb_goodsType_name.Name = "tb_goodsType_name";
            this.tb_goodsType_name.Size = new System.Drawing.Size(100, 26);
            this.tb_goodsType_name.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(7, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "类别代码";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(224, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "商品类别";
            // 
            // dgv_goodsType
            // 
            this.dgv_goodsType.AllowUserToAddRows = false;
            this.dgv_goodsType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_goodsType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_goodsType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_goodsType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goods_type_code,
            this.goods_type_name});
            this.dgv_goodsType.Location = new System.Drawing.Point(3, 54);
            this.dgv_goodsType.Name = "dgv_goodsType";
            this.dgv_goodsType.RowTemplate.Height = 23;
            this.dgv_goodsType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_goodsType.Size = new System.Drawing.Size(991, 379);
            this.dgv_goodsType.TabIndex = 0;
            this.dgv_goodsType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_goodsType_CellClick);
            this.dgv_goodsType.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_goodsType_CellValueChanged);
            this.dgv_goodsType.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_goodsType_UserDeletingRow);
            // 
            // goods_type_code
            // 
            this.goods_type_code.DataPropertyName = "类别代码";
            this.goods_type_code.HeaderText = "类别代码";
            this.goods_type_code.Name = "goods_type_code";
            // 
            // goods_type_name
            // 
            this.goods_type_name.DataPropertyName = "商品类别";
            this.goods_type_name.HeaderText = "商品类别";
            this.goods_type_name.Name = "goods_type_name";
            // 
            // panel_condition_base
            // 
            this.panel_condition_base.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_condition_base.Location = new System.Drawing.Point(2, 3);
            this.panel_condition_base.Name = "panel_condition_base";
            this.panel_condition_base.Size = new System.Drawing.Size(989, 45);
            this.panel_condition_base.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(708, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 469);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "账单";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill_search)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel_condition_search.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill_insert)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goodsType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bill_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_goods_name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox combo_goods_type;
        private System.Windows.Forms.DateTimePicker dtp_date_end;
        private System.Windows.Forms.DateTimePicker dtp_date_begin;
        private System.Windows.Forms.TextBox tb_goods_mark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_goods_price_min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_goods_price_max;
        private System.Windows.Forms.TextBox tb_goods_mall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_goods_date_insert;
        private System.Windows.Forms.ComboBox combo_goods_type_insert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_goods_mark_insert;
        private System.Windows.Forms.TextBox tb_goods_price_insert;
        private System.Windows.Forms.TextBox tb_goods_mall_insert;
        private System.Windows.Forms.TextBox tb_goods_name_insert;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_bill_insert;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_search_insert;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_goodsType_insert;
        private System.Windows.Forms.TextBox tb_goodsType_code;
        private System.Windows.Forms.TextBox tb_goodsType_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv_goodsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refresh;
        private System.Windows.Forms.Panel panel_condition_search;
        private System.Windows.Forms.Panel panel_condition_insert;
        private System.Windows.Forms.Panel panel_condition_base;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNum_select;
        private System.Windows.Forms.DataGridViewTextBoxColumn gooddsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn buy_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn mall;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name_insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price_insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_insert;
        private System.Windows.Forms.DataGridViewComboBoxColumn goods_type_insert_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mall_insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark_insert;
        private System.Windows.Forms.Button button1;
    }
}

