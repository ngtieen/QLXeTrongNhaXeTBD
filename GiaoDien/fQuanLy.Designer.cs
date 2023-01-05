namespace GiaoDien
{
    partial class fQuanLy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbIDThe = new System.Windows.Forms.ComboBox();
            this.cbbKhuXe = new System.Windows.Forms.ComboBox();
            this.btnXoaXe = new System.Windows.Forms.Button();
            this.btnSuaXe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXeRa = new System.Windows.Forms.Button();
            this.btnThemXe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBSX = new System.Windows.Forms.TextBox();
            this.cbbLoaiXe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaGui = new System.Windows.Forms.TextBox();
            this.dtgvThemXe = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTiemKiem = new System.Windows.Forms.TextBox();
            this.btnTiemKiem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemXe)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbbIDThe);
            this.groupBox1.Controls.Add(this.cbbKhuXe);
            this.groupBox1.Controls.Add(this.btnXoaXe);
            this.groupBox1.Controls.Add(this.btnSuaXe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnXeRa);
            this.groupBox1.Controls.Add(this.btnThemXe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBSX);
            this.groupBox1.Controls.Add(this.cbbLoaiXe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGiaGui);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(730, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 550);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // cbbIDThe
            // 
            this.cbbIDThe.DropDownHeight = 265;
            this.cbbIDThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIDThe.DropDownWidth = 151;
            this.cbbIDThe.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cbbIDThe, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.cbbIDThe.IntegralHeight = false;
            this.cbbIDThe.ItemHeight = 21;
            this.cbbIDThe.Items.AddRange(new object[] {
            "1",
            "2",
            "2",
            "3",
            "3",
            "4",
            "45",
            "5"});
            this.cbbIDThe.Location = new System.Drawing.Point(151, 211);
            this.cbbIDThe.Name = "cbbIDThe";
            this.cbbIDThe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbIDThe.Size = new System.Drawing.Size(151, 29);
            this.cbbIDThe.TabIndex = 6;
            this.cbbIDThe.TabStop = false;
            // 
            // cbbKhuXe
            // 
            this.cbbKhuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhuXe.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbKhuXe.FormattingEnabled = true;
            this.cbbKhuXe.Location = new System.Drawing.Point(151, 46);
            this.cbbKhuXe.Name = "cbbKhuXe";
            this.cbbKhuXe.Size = new System.Drawing.Size(224, 28);
            this.cbbKhuXe.TabIndex = 15;
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.Location = new System.Drawing.Point(263, 478);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(218, 58);
            this.btnXoaXe.TabIndex = 13;
            this.btnXoaXe.Text = "Xoá";
            this.btnXoaXe.UseVisualStyleBackColor = true;
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.Location = new System.Drawing.Point(29, 478);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(228, 58);
            this.btnSuaXe.TabIndex = 12;
            this.btnSuaXe.Text = "Sửa";
            this.btnSuaXe.UseVisualStyleBackColor = true;
            this.btnSuaXe.Click += new System.EventHandler(this.btnSuaXe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "ID thẻ:";
            // 
            // btnXeRa
            // 
            this.btnXeRa.Location = new System.Drawing.Point(85, 407);
            this.btnXeRa.Name = "btnXeRa";
            this.btnXeRa.Size = new System.Drawing.Size(334, 65);
            this.btnXeRa.TabIndex = 9;
            this.btnXeRa.Text = "Xe ra";
            this.btnXeRa.UseVisualStyleBackColor = true;
            this.btnXeRa.Click += new System.EventHandler(this.btnXeRa_Click_1);
            // 
            // btnThemXe
            // 
            this.btnThemXe.Location = new System.Drawing.Point(85, 336);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(334, 65);
            this.btnThemXe.TabIndex = 8;
            this.btnThemXe.Text = "Thêm xe";
            this.btnThemXe.UseVisualStyleBackColor = true;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(275, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "ngàn đồng";
            // 
            // txtBSX
            // 
            this.txtBSX.Location = new System.Drawing.Point(151, 159);
            this.txtBSX.Name = "txtBSX";
            this.txtBSX.Size = new System.Drawing.Size(225, 29);
            this.txtBSX.TabIndex = 6;
            // 
            // cbbLoaiXe
            // 
            this.cbbLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiXe.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbLoaiXe.FormattingEnabled = true;
            this.cbbLoaiXe.Location = new System.Drawing.Point(152, 102);
            this.cbbLoaiXe.Name = "cbbLoaiXe";
            this.cbbLoaiXe.Size = new System.Drawing.Size(224, 28);
            this.cbbLoaiXe.TabIndex = 5;
            this.cbbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiXe_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá gửi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại xe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khu xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Biển số xe:";
            // 
            // txtGiaGui
            // 
            this.txtGiaGui.Location = new System.Drawing.Point(152, 265);
            this.txtGiaGui.Name = "txtGiaGui";
            this.txtGiaGui.ReadOnly = true;
            this.txtGiaGui.Size = new System.Drawing.Size(118, 29);
            this.txtGiaGui.TabIndex = 14;
            // 
            // dtgvThemXe
            // 
            this.dtgvThemXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvThemXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThemXe.ColumnHeadersHeight = 29;
            this.dtgvThemXe.Location = new System.Drawing.Point(12, 27);
            this.dtgvThemXe.Name = "dtgvThemXe";
            this.dtgvThemXe.RowHeadersWidth = 51;
            this.dtgvThemXe.RowTemplate.Height = 29;
            this.dtgvThemXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThemXe.ShowRowErrors = false;
            this.dtgvThemXe.Size = new System.Drawing.Size(700, 640);
            this.dtgvThemXe.TabIndex = 8;
            this.dtgvThemXe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThemXe_RowEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aminToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1239, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aminToolStripMenuItem
            // 
            this.aminToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aminToolStripMenuItem.Name = "aminToolStripMenuItem";
            this.aminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.aminToolStripMenuItem.Text = "Admin";
            this.aminToolStripMenuItem.Click += new System.EventHandler(this.Open);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.txtTiemKiem);
            this.groupBox2.Controls.Add(this.btnTiemKiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(730, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 84);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Theo ID Thẻ";
            // 
            // txtTiemKiem
            // 
            this.txtTiemKiem.Location = new System.Drawing.Point(29, 33);
            this.txtTiemKiem.Name = "txtTiemKiem";
            this.txtTiemKiem.Size = new System.Drawing.Size(344, 29);
            this.txtTiemKiem.TabIndex = 16;
            // 
            // btnTiemKiem
            // 
            this.btnTiemKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTiemKiem.Location = new System.Drawing.Point(379, 33);
            this.btnTiemKiem.Name = "btnTiemKiem";
            this.btnTiemKiem.Size = new System.Drawing.Size(112, 37);
            this.btnTiemKiem.TabIndex = 17;
            this.btnTiemKiem.Text = "Tìm kiếm";
            this.btnTiemKiem.UseVisualStyleBackColor = true;
            this.btnTiemKiem.Click += new System.EventHandler(this.btnTiemKiem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1239, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvThemXe);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Xe Trong Nhà Xe Trường Đại Học Thái Bình Dương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fQuanLy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemXe)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnXeRa;
        private Button btnThemXe;
        private Label label6;
        private TextBox txtBSX;
        private ComboBox cbbLoaiXe;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dtgvThemXe;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aminToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label label7;
        private Button btnSuaXe;
        private Button btnXoaXe;
        private GroupBox groupBox2;
        private TextBox txtGiaGui;
        private ComboBox cbbKhuXe;
        private ErrorProvider errorProvider1;
        private ComboBox cbbIDThe;
        private Button btnTiemKiem;
        private TextBox txtTiemKiem;
    }
}