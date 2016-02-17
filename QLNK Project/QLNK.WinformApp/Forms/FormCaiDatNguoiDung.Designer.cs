namespace QLNK.WinformApp.Forms
{
    partial class FormCaiDatNguoiDung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbBCH = new System.Windows.Forms.RadioButton();
            this.rbNCTD = new System.Windows.Forms.RadioButton();
            this.rbCSKV = new System.Windows.Forms.RadioButton();
            this.dgrvNguoiDung = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnXoaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXemItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvNguoiDung)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(135, 20);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(231, 22);
            this.txtTenNguoiDung.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(136, 58);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(231, 22);
            this.txtTenDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(136, 101);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(231, 22);
            this.txtMatKhau.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(416, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quyền sử dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "- CSKV: Tìm kiểm, xem danh sách, thống kê.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "- NCTD: Nhập liệu, tìm kiểm, xem danh sách, thống kê.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "- BCH: Thiết lập hệ thống, chỉnh sửa nội dung dữ liệu; tìm kiểm, xem danh sách, t" +
    "hống kê.";
            // 
            // rbBCH
            // 
            this.rbBCH.AutoSize = true;
            this.rbBCH.ForeColor = System.Drawing.Color.Black;
            this.rbBCH.Location = new System.Drawing.Point(135, 130);
            this.rbBCH.Name = "rbBCH";
            this.rbBCH.Size = new System.Drawing.Size(54, 20);
            this.rbBCH.TabIndex = 7;
            this.rbBCH.TabStop = true;
            this.rbBCH.Text = "BCH";
            this.rbBCH.UseVisualStyleBackColor = false;
            // 
            // rbNCTD
            // 
            this.rbNCTD.AutoSize = true;
            this.rbNCTD.ForeColor = System.Drawing.Color.Black;
            this.rbNCTD.Location = new System.Drawing.Point(220, 129);
            this.rbNCTD.Name = "rbNCTD";
            this.rbNCTD.Size = new System.Drawing.Size(64, 20);
            this.rbNCTD.TabIndex = 8;
            this.rbNCTD.TabStop = true;
            this.rbNCTD.Text = "NCTD";
            this.rbNCTD.UseVisualStyleBackColor = false;
            // 
            // rbCSKV
            // 
            this.rbCSKV.AutoSize = true;
            this.rbCSKV.ForeColor = System.Drawing.Color.Black;
            this.rbCSKV.Location = new System.Drawing.Point(306, 130);
            this.rbCSKV.Name = "rbCSKV";
            this.rbCSKV.Size = new System.Drawing.Size(61, 20);
            this.rbCSKV.TabIndex = 9;
            this.rbCSKV.TabStop = true;
            this.rbCSKV.Text = "CSKV";
            this.rbCSKV.UseVisualStyleBackColor = false;
            // 
            // dgrvNguoiDung
            // 
            this.dgrvNguoiDung.AllowUserToAddRows = false;
            this.dgrvNguoiDung.AllowUserToOrderColumns = true;
            this.dgrvNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvNguoiDung.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgrvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvNguoiDung.Location = new System.Drawing.Point(3, 210);
            this.dgrvNguoiDung.Name = "dgrvNguoiDung";
            this.dgrvNguoiDung.ReadOnly = true;
            this.dgrvNguoiDung.RowHeadersVisible = false;
            this.dgrvNguoiDung.Size = new System.Drawing.Size(955, 381);
            this.dgrvNguoiDung.TabIndex = 10;
            this.dgrvNguoiDung.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvNguoiDung_CellMouseUp);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(135, 157);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 37);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(256, 157);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 37);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoaItem,
            this.btnSuaItem,
            this.btnXemItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 70);
            // 
            // btnXoaItem
            // 
            this.btnXoaItem.Name = "btnXoaItem";
            this.btnXoaItem.Size = new System.Drawing.Size(137, 22);
            this.btnXoaItem.Text = "Xóa";
            this.btnXoaItem.Click += new System.EventHandler(this.btnXoaItem_Click);
            // 
            // btnSuaItem
            // 
            this.btnSuaItem.Name = "btnSuaItem";
            this.btnSuaItem.Size = new System.Drawing.Size(137, 22);
            this.btnSuaItem.Text = "Sửa";
            // 
            // btnXemItem
            // 
            this.btnXemItem.Name = "btnXemItem";
            this.btnXemItem.Size = new System.Drawing.Size(137, 22);
            this.btnXemItem.Text = "Xem chi tiết";
            // 
            // FormCaiDatNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 592);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgrvNguoiDung);
            this.Controls.Add(this.rbCSKV);
            this.Controls.Add(this.rbNCTD);
            this.Controls.Add(this.rbBCH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtTenNguoiDung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCaiDatNguoiDung";
            this.Text = "Cài đặt người dùng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvNguoiDung)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbBCH;
        private System.Windows.Forms.RadioButton rbNCTD;
        private System.Windows.Forms.RadioButton rbCSKV;
        private System.Windows.Forms.DataGridView dgrvNguoiDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnXoaItem;
        private System.Windows.Forms.ToolStripMenuItem btnSuaItem;
        private System.Windows.Forms.ToolStripMenuItem btnXemItem;
    }
}