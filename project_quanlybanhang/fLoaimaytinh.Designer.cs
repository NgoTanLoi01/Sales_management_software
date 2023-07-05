namespace project_quanlybanhang
{
    partial class fLoaimaytinh
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
            System.Windows.Forms.Label maLMTLabel;
            System.Windows.Forms.Label tenLMTLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new project_quanlybanhang.QUANLY_CUAHANGMAYTINHDataSetTableAdapters.TableAdapterManager();
            this.lOAIMAYTINHTableAdapter = new project_quanlybanhang.QUANLY_CUAHANGMAYTINHDataSetTableAdapters.LOAIMAYTINHTableAdapter();
            this.lOAIMAYTINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLY_CUAHANGMAYTINHDataSet = new project_quanlybanhang.QUANLY_CUAHANGMAYTINHDataSet();
            this.lOAIMAYTINHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maLMTTextBox = new System.Windows.Forms.TextBox();
            this.tenLMTTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lOAIMAYTINHBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lOAIMAYTINHBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            maLMTLabel = new System.Windows.Forms.Label();
            tenLMTLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMAYTINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_CUAHANGMAYTINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMAYTINHDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMAYTINHBindingNavigator)).BeginInit();
            this.lOAIMAYTINHBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // maLMTLabel
            // 
            maLMTLabel.AutoSize = true;
            maLMTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maLMTLabel.Location = new System.Drawing.Point(11, 49);
            maLMTLabel.Name = "maLMTLabel";
            maLMTLabel.Size = new System.Drawing.Size(91, 29);
            maLMTLabel.TabIndex = 1;
            maLMTLabel.Text = "Mã loại";
            // 
            // tenLMTLabel
            // 
            tenLMTLabel.AutoSize = true;
            tenLMTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenLMTLabel.Location = new System.Drawing.Point(11, 169);
            tenLMTLabel.Name = "tenLMTLabel";
            tenLMTLabel.Size = new System.Drawing.Size(101, 29);
            tenLMTLabel.TabIndex = 3;
            tenLMTLabel.Text = "Tên loại";
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
            this.panel1.Size = new System.Drawing.Size(1253, 52);
            this.panel1.TabIndex = 17;
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
            "Mã loại",
            "Tên loại"});
            this.comboBox1.Location = new System.Drawing.Point(266, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 33);
            this.comboBox1.TabIndex = 2;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietHDBTableAdapter = null;
            this.tableAdapterManager.ChiTietNhapTableAdapter = null;
            this.tableAdapterManager.HOADONBANHANGTableAdapter = null;
            this.tableAdapterManager.HOADONNHAPHANGTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LOAIMAYTINHTableAdapter = this.lOAIMAYTINHTableAdapter;
            this.tableAdapterManager.MAYTINHTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOHANHTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project_quanlybanhang.QUANLY_CUAHANGMAYTINHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOAIMAYTINHTableAdapter
            // 
            this.lOAIMAYTINHTableAdapter.ClearBeforeFill = true;
            // 
            // lOAIMAYTINHBindingSource
            // 
            this.lOAIMAYTINHBindingSource.DataMember = "LOAIMAYTINH";
            this.lOAIMAYTINHBindingSource.DataSource = this.qUANLY_CUAHANGMAYTINHDataSet;
            // 
            // qUANLY_CUAHANGMAYTINHDataSet
            // 
            this.qUANLY_CUAHANGMAYTINHDataSet.DataSetName = "QUANLY_CUAHANGMAYTINHDataSet";
            this.qUANLY_CUAHANGMAYTINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIMAYTINHDataGridView
            // 
            this.lOAIMAYTINHDataGridView.AutoGenerateColumns = false;
            this.lOAIMAYTINHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOAIMAYTINHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lOAIMAYTINHDataGridView.DataSource = this.lOAIMAYTINHBindingSource;
            this.lOAIMAYTINHDataGridView.Location = new System.Drawing.Point(37, 36);
            this.lOAIMAYTINHDataGridView.Name = "lOAIMAYTINHDataGridView";
            this.lOAIMAYTINHDataGridView.RowTemplate.Height = 24;
            this.lOAIMAYTINHDataGridView.Size = new System.Drawing.Size(723, 387);
            this.lOAIMAYTINHDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLMT";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã loại";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLMT";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên loại";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lOAIMAYTINHDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(467, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 429);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // maLMTTextBox
            // 
            this.maLMTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAIMAYTINHBindingSource, "MaLMT", true));
            this.maLMTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maLMTTextBox.Location = new System.Drawing.Point(16, 94);
            this.maLMTTextBox.Name = "maLMTTextBox";
            this.maLMTTextBox.Size = new System.Drawing.Size(358, 34);
            this.maLMTTextBox.TabIndex = 2;
            // 
            // tenLMTTextBox
            // 
            this.tenLMTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAIMAYTINHBindingSource, "TenLMT", true));
            this.tenLMTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenLMTTextBox.Location = new System.Drawing.Point(16, 212);
            this.tenLMTTextBox.Name = "tenLMTTextBox";
            this.tenLMTTextBox.Size = new System.Drawing.Size(358, 34);
            this.tenLMTTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(tenLMTLabel);
            this.groupBox2.Controls.Add(this.tenLMTTextBox);
            this.groupBox2.Controls.Add(maLMTLabel);
            this.groupBox2.Controls.Add(this.maLMTTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(43, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 288);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ";
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
            // lOAIMAYTINHBindingNavigatorSaveItem
            // 
            this.lOAIMAYTINHBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lOAIMAYTINHBindingNavigatorSaveItem.Image = global::project_quanlybanhang.Properties.Resources.Save;
            this.lOAIMAYTINHBindingNavigatorSaveItem.Name = "lOAIMAYTINHBindingNavigatorSaveItem";
            this.lOAIMAYTINHBindingNavigatorSaveItem.Size = new System.Drawing.Size(91, 42);
            this.lOAIMAYTINHBindingNavigatorSaveItem.Text = "Lưu";
            this.lOAIMAYTINHBindingNavigatorSaveItem.Click += new System.EventHandler(this.lOAIMAYTINHBindingNavigatorSaveItem_Click);
            // 
            // lOAIMAYTINHBindingNavigator
            // 
            this.lOAIMAYTINHBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lOAIMAYTINHBindingNavigator.BindingSource = this.lOAIMAYTINHBindingSource;
            this.lOAIMAYTINHBindingNavigator.CountItem = null;
            this.lOAIMAYTINHBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lOAIMAYTINHBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.lOAIMAYTINHBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.lOAIMAYTINHBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lOAIMAYTINHBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripLabel3,
            this.lOAIMAYTINHBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.bindingNavigatorDeleteItem,
            this.toolStripLabel2,
            this.toolStripButton1});
            this.lOAIMAYTINHBindingNavigator.Location = new System.Drawing.Point(187, 582);
            this.lOAIMAYTINHBindingNavigator.MoveFirstItem = null;
            this.lOAIMAYTINHBindingNavigator.MoveLastItem = null;
            this.lOAIMAYTINHBindingNavigator.MoveNextItem = null;
            this.lOAIMAYTINHBindingNavigator.MovePreviousItem = null;
            this.lOAIMAYTINHBindingNavigator.Name = "lOAIMAYTINHBindingNavigator";
            this.lOAIMAYTINHBindingNavigator.PositionItem = null;
            this.lOAIMAYTINHBindingNavigator.Size = new System.Drawing.Size(640, 45);
            this.lOAIMAYTINHBindingNavigator.TabIndex = 0;
            this.lOAIMAYTINHBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(69, 42);
            this.toolStripLabel3.Text = "               ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 42);
            this.toolStripLabel1.Text = "               ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(69, 42);
            this.toolStripLabel2.Text = "               ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripButton1.Image = global::project_quanlybanhang.Properties.Resources.stop;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(94, 42);
            this.toolStripButton1.Text = "Hủy";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // fLoaimaytinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1253, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lOAIMAYTINHBindingNavigator);
            this.Name = "fLoaimaytinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLoaimaytinh";
            this.Load += new System.EventHandler(this.fLoaimaytinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMAYTINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLY_CUAHANGMAYTINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMAYTINHDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIMAYTINHBindingNavigator)).EndInit();
            this.lOAIMAYTINHBindingNavigator.ResumeLayout(false);
            this.lOAIMAYTINHBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QUANLY_CUAHANGMAYTINHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QUANLY_CUAHANGMAYTINHDataSetTableAdapters.LOAIMAYTINHTableAdapter lOAIMAYTINHTableAdapter;
        private System.Windows.Forms.BindingSource lOAIMAYTINHBindingSource;
        private QUANLY_CUAHANGMAYTINHDataSet qUANLY_CUAHANGMAYTINHDataSet;
        private System.Windows.Forms.DataGridView lOAIMAYTINHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maLMTTextBox;
        private System.Windows.Forms.TextBox tenLMTTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton lOAIMAYTINHBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator lOAIMAYTINHBindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}