namespace GiaoDien
{
    partial class fSuaThongTinXe
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNgayVao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBienSoXe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbLoaiXe = new System.Windows.Forms.ComboBox();
            this.cbbKhuXe = new System.Windows.Forms.ComboBox();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.cbbIdThe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Location = new System.Drawing.Point(287, 304);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(178, 64);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNgayVao
            // 
            this.txtNgayVao.Location = new System.Drawing.Point(151, 185);
            this.txtNgayVao.Name = "txtNgayVao";
            this.txtNgayVao.Size = new System.Drawing.Size(225, 30);
            this.txtNgayVao.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày vào:";
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Location = new System.Drawing.Point(153, 226);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.Size = new System.Drawing.Size(225, 30);
            this.txtBienSoXe.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại xe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khu xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Biển số xe:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbIdThe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbLoaiXe);
            this.groupBox1.Controls.Add(this.cbbKhuXe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBienSoXe);
            this.groupBox1.Controls.Add(this.txtNgayVao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(24, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 271);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe ra";
            // 
            // cbbLoaiXe
            // 
            this.cbbLoaiXe.FormattingEnabled = true;
            this.cbbLoaiXe.Location = new System.Drawing.Point(151, 89);
            this.cbbLoaiXe.Name = "cbbLoaiXe";
            this.cbbLoaiXe.Size = new System.Drawing.Size(225, 32);
            this.cbbLoaiXe.TabIndex = 23;
            // 
            // cbbKhuXe
            // 
            this.cbbKhuXe.FormattingEnabled = true;
            this.cbbKhuXe.Location = new System.Drawing.Point(153, 43);
            this.cbbKhuXe.Name = "cbbKhuXe";
            this.cbbKhuXe.Size = new System.Drawing.Size(225, 32);
            this.cbbKhuXe.TabIndex = 22;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhap.Location = new System.Drawing.Point(21, 304);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(178, 64);
            this.btnCapNhap.TabIndex = 12;
            this.btnCapNhap.Text = "Cập Nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // cbbIdThe
            // 
            this.cbbIdThe.FormattingEnabled = true;
            this.cbbIdThe.Location = new System.Drawing.Point(151, 133);
            this.cbbIdThe.Name = "cbbIdThe";
            this.cbbIdThe.Size = new System.Drawing.Size(225, 32);
            this.cbbIdThe.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Thẻ xe:";
            // 
            // fSuaThongTinXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 395);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhap);
            this.Name = "fSuaThongTinXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaThongTinXe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnThoat;
        private TextBox txtNgayVao;
        private Label label1;
        private TextBox txtBienSoXe;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnCapNhap;
        private ComboBox cbbLoaiXe;
        private ComboBox cbbKhuXe;
        private ComboBox cbbIdThe;
        private Label label6;
    }
}