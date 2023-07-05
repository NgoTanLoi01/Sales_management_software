namespace project_quanlybanhang
{
    partial class fKhachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label tenKHLabel;
            System.Windows.Forms.Label diaChiKHLabel;
            System.Windows.Forms.Label sDT_KHLabel;
            System.Windows.Forms.Label gioiTinhKHLabel;
            this.qUANLY_CUAHANGMAYTINHDataSet = new project_quanlybanhang.QUANLY_CUAHANGMAYTINHDataSet();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new project_quanlybanhang.QUANLY_CUAHANGMAYTINHDataSetTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new project_quanlybanhang.QUANLY_CUAHANGMAYTINHDataSetTableAdapters.TableAdapterManager();
            this.kHACHHANGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.kHACHHANGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.maKHTextBox = new System.Windows.Forms.TextBox();
            this.tenKHTextBox = new System.Windows.Forms.TextBox();
            this.diaChiKHTextBox = new System.Windows.Forms.TextBox();
            this.sDT_KHTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhKHComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kHACHHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            maKHLabel = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            diaChiKHLabel = new System.Windows.Forms.Label();
            sDT_KHLabel = new System.Windows.Forms.Label();
            gioiTinhKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_CUAHANGMAYTINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingNavigator)).BeginInit();
            this.kHACHHANGBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maKHLabel.Location = new System.Drawing.Point(6, 41);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(147, 25);
            maKHLabel.TabIndex = 1;
            maKHLabel.Text = "Mã khách hàng";
            maKHLabel.Click += new System.EventHandler(this.maKHLabel_Click);
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenKHLabel.Location = new System.Drawing.Point(6, 134);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(154, 25);
            tenKHLabel.TabIndex = 3;
            tenKHLabel.Text = "Tên khách hàng";
            // 
            // diaChiKHLabel
            // 
            diaChiKHLabel.AutoSize = true;
            diaChiKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            diaChiKHLabel.Location = new System.Drawing.Point(6, 224);
            diaChiKHLabel.Name = "diaChiKHLabel";
            diaChiKHLabel.Size = new System.Drawing.Size(71, 25);
            diaChiKHLabel.TabIndex = 5;
            diaChiKHLabel.Text = "Địa chỉ";
            // 
            // sDT_KHLabel
            // 
            sDT_KHLabel.AutoSize = true;
            sDT_KHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            sDT_KHLabel.Location = new System.Drawing.Point(6, 311);
            sDT_KHLabel.Name = "sDT_KHLabel";
            sDT_KHLabel.Size = new System.Drawing.Size(126, 25);
            sDT_KHLabel.TabIndex = 7;
            sDT_KHLabel.Text = "Số điện thoại";
            // 
            // gioiTinhKHLabel
            // 
            gioiTinhKHLabel.AutoSize = true;
            gioiTinhKHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            gioiTinhKHLabel.Location = new System.Drawing.Point(6, 400);
            gioiTinhKHLabel.Name = "gioiTinhKHLabel";
            gioiTinhKHLabel.Size = new System.Drawing.Size(82, 25);
            gioiTinhKHLabel.TabIndex = 9;
            gioiTinhKHLabel.Text = "Giới tính";
            // 
            // qUANLY_CUAHANGMAYTINHDataSet
            // 
            this.qUANLY_CUAHANGMAYTINHDataSet.DataSetName = "QUANLY_CUAHANGMAYTINHDataSet";
            this.qUANLY_CUAHANGMAYTINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qUANLY_CUAHANGMAYTINHDataSet;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietHDBTableAdapter = null;
            this.tableAdapterManager.ChiTietNhapTableAdapter = null;
            this.tableAdapterManager.HOADONBANHANGTableAdapter = null;
            this.tableAdapterManager.HOADONNHAPHANGTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.LOAIMAYTINHTableAdapter = null;
            this.tableAdapterManager.MAYTINHTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOHANHTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project_quanlybanhang.QUANLY_CUAHANGMAYTINHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHACHHANGBindingNavigator
            // 
            this.kHACHHANGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kHACHHANGBindingNavigator.BindingSource = this.kHACHHANGBindingSource;
            this.kHACHHANGBindingNavigator.CountItem = null;
            this.kHACHHANGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kHACHHANGBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.kHACHHANGBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.kHACHHANGBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kHACHHANGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripLabel2,
            this.kHACHHANGBindingNavigatorSaveItem,
            this.toolStripLabel3,
            this.bindingNavigatorDeleteItem,
            this.toolStripLabel4,
            this.toolStripButton1,
            this.toolStripLabel5,
            this.toolStripButton2});
            this.kHACHHANGBindingNavigator.Location = new System.Drawing.Point(76, 618);
            this.kHACHHANGBindingNavigator.MoveFirstItem = null;
            this.kHACHHANGBindingNavigator.MoveLastItem = null;
            this.kHACHHANGBindingNavigator.MoveNextItem = null;
            this.kHACHHANGBindingNavigator.MovePreviousItem = null;
            this.kHACHHANGBindingNavigator.Name = "kHACHHANGBindingNavigator";
            this.kHACHHANGBindingNavigator.PositionItem = null;
            this.kHACHHANGBindingNavigator.Size = new System.Drawing.Size(811, 45);
            this.kHACHHANGBindingNavigator.TabIndex = 0;
            this.kHACHHANGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bindingNavigatorAddNewItem.Image = global::project_quanlybanhang.Properties.Resources.Thêm_1;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(115, 42);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bindingNavigatorDeleteItem.Image = global::project_quanlybanhang.Properties.Resources.xóa;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(91, 42);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Wheat;
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Wheat;
            this.toolStripLabel2.ImageTransparentColor = System.Drawing.Color.Wheat;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(69, 42);
            this.toolStripLabel2.Text = "               ";
            // 
            // kHACHHANGBindingNavigatorSaveItem
            // 
            this.kHACHHANGBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.kHACHHANGBindingNavigatorSaveItem.Image = global::project_quanlybanhang.Properties.Resources.Save;
            this.kHACHHANGBindingNavigatorSaveItem.Name = "kHACHHANGBindingNavigatorSaveItem";
            this.kHACHHANGBindingNavigatorSaveItem.Size = new System.Drawing.Size(91, 42);
            this.kHACHHANGBindingNavigatorSaveItem.Text = "Lưu";
            this.kHACHHANGBindingNavigatorSaveItem.Click += new System.EventHandler(this.kHACHHANGBindingNavigatorSaveItem_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ImageTransparentColor = System.Drawing.Color.Wheat;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(69, 42);
            this.toolStripLabel3.Text = "               ";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(69, 42);
            this.toolStripLabel4.Text = "               ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripButton1.Image = global::project_quanlybanhang.Properties.Resources.anhexcel_removebg_preview;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(102, 42);
            this.toolStripButton1.Text = "Xuất";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(69, 42);
            this.toolStripLabel5.Text = "               ";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripButton2.Image = global::project_quanlybanhang.Properties.Resources.stop;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(94, 42);
            this.toolStripButton2.Text = "Hủy";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // maKHTextBox
            // 
            this.maKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MaKH", true));
            this.maKHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maKHTextBox.Location = new System.Drawing.Point(11, 81);
            this.maKHTextBox.Name = "maKHTextBox";
            this.maKHTextBox.Size = new System.Drawing.Size(343, 30);
            this.maKHTextBox.TabIndex = 2;
            // 
            // tenKHTextBox
            // 
            this.tenKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "TenKH", true));
            this.tenKHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenKHTextBox.Location = new System.Drawing.Point(11, 172);
            this.tenKHTextBox.Name = "tenKHTextBox";
            this.tenKHTextBox.Size = new System.Drawing.Size(343, 30);
            this.tenKHTextBox.TabIndex = 4;
            // 
            // diaChiKHTextBox
            // 
            this.diaChiKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "DiaChiKH", true));
            this.diaChiKHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diaChiKHTextBox.Location = new System.Drawing.Point(11, 261);
            this.diaChiKHTextBox.Name = "diaChiKHTextBox";
            this.diaChiKHTextBox.Size = new System.Drawing.Size(343, 30);
            this.diaChiKHTextBox.TabIndex = 6;
            // 
            // sDT_KHTextBox
            // 
            this.sDT_KHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "SDT_KH", true));
            this.sDT_KHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sDT_KHTextBox.Location = new System.Drawing.Point(11, 349);
            this.sDT_KHTextBox.Name = "sDT_KHTextBox";
            this.sDT_KHTextBox.Size = new System.Drawing.Size(343, 30);
            this.sDT_KHTextBox.TabIndex = 8;
            // 
            // gioiTinhKHComboBox
            // 
            this.gioiTinhKHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "GioiTinhKH", true));
            this.gioiTinhKHComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gioiTinhKHComboBox.FormattingEnabled = true;
            this.gioiTinhKHComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioiTinhKHComboBox.Location = new System.Drawing.Point(11, 437);
            this.gioiTinhKHComboBox.Name = "gioiTinhKHComboBox";
            this.gioiTinhKHComboBox.Size = new System.Drawing.Size(343, 33);
            this.gioiTinhKHComboBox.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 52);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1013, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng"});
            this.comboBox1.Location = new System.Drawing.Point(266, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(686, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 37);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // kHACHHANGDataGridView
            // 
            this.kHACHHANGDataGridView.AutoGenerateColumns = false;
            this.kHACHHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHACHHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kHACHHANGDataGridView.DataSource = this.kHACHHANGBindingSource;
            this.kHACHHANGDataGridView.Location = new System.Drawing.Point(26, 81);
            this.kHACHHANGDataGridView.Name = "kHACHHANGDataGridView";
            this.kHACHHANGDataGridView.RowTemplate.Height = 24;
            this.kHACHHANGDataGridView.Size = new System.Drawing.Size(823, 389);
            this.kHACHHANGDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiaChiKH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SDT_KH";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GioiTinhKH";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(gioiTinhKHLabel);
            this.groupBox1.Controls.Add(this.gioiTinhKHComboBox);
            this.groupBox1.Controls.Add(sDT_KHLabel);
            this.groupBox1.Controls.Add(this.sDT_KHTextBox);
            this.groupBox1.Controls.Add(diaChiKHLabel);
            this.groupBox1.Controls.Add(this.diaChiKHTextBox);
            this.groupBox1.Controls.Add(tenKHLabel);
            this.groupBox1.Controls.Add(this.tenKHTextBox);
            this.groupBox1.Controls.Add(maKHLabel);
            this.groupBox1.Controls.Add(this.maKHTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 491);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kHACHHANGDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(398, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 491);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // fKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1193, 712);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kHACHHANGBindingNavigator);
            this.Name = "fKhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fKhachhang";
            this.Load += new System.EventHandler(this.fKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_CUAHANGMAYTINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingNavigator)).EndInit();
            this.kHACHHANGBindingNavigator.ResumeLayout(false);
            this.kHACHHANGBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QUANLY_CUAHANGMAYTINHDataSet qUANLY_CUAHANGMAYTINHDataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QUANLY_CUAHANGMAYTINHDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private QUANLY_CUAHANGMAYTINHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kHACHHANGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton kHACHHANGBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maKHTextBox;
        private System.Windows.Forms.TextBox tenKHTextBox;
        private System.Windows.Forms.TextBox diaChiKHTextBox;
        private System.Windows.Forms.TextBox sDT_KHTextBox;
        private System.Windows.Forms.ComboBox gioiTinhKHComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView kHACHHANGDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}