namespace QLNK.WinformApp.Forms
{
    partial class FormDanhMucTrangThaiNhaO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTenDuong = new System.Windows.Forms.TextBox();
            this.dgrvDanhTinhTrangNhaO = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnXoaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDanhTinhTrangNhaO)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenDuong
            // 
            this.txtTenDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDuong.Location = new System.Drawing.Point(4, 33);
            this.txtTenDuong.Name = "txtTenDuong";
            this.txtTenDuong.Size = new System.Drawing.Size(507, 26);
            this.txtTenDuong.TabIndex = 1;
            // 
            // dgrvDanhTinhTrangNhaO
            // 
            this.dgrvDanhTinhTrangNhaO.AllowUserToAddRows = false;
            this.dgrvDanhTinhTrangNhaO.AllowUserToDeleteRows = false;
            this.dgrvDanhTinhTrangNhaO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrvDanhTinhTrangNhaO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvDanhTinhTrangNhaO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvDanhTinhTrangNhaO.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvDanhTinhTrangNhaO.Location = new System.Drawing.Point(4, 89);
            this.dgrvDanhTinhTrangNhaO.Name = "dgrvDanhTinhTrangNhaO";
            this.dgrvDanhTinhTrangNhaO.ReadOnly = true;
            this.dgrvDanhTinhTrangNhaO.RowHeadersVisible = false;
            this.dgrvDanhTinhTrangNhaO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvDanhTinhTrangNhaO.Size = new System.Drawing.Size(588, 487);
            this.dgrvDanhTinhTrangNhaO.TabIndex = 2;
            this.dgrvDanhTinhTrangNhaO.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvDanhMucDuong_CellMouseUp);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(517, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 26);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(117, 611);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 48);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(284, 611);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 48);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSuaItem,
            this.btnXoaItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // btnXoaItem
            // 
            this.btnXoaItem.Name = "btnXoaItem";
            this.btnXoaItem.Size = new System.Drawing.Size(124, 22);
            this.btnXoaItem.Text = "Xóa";
            this.btnXoaItem.Click += new System.EventHandler(this.btnXoaItem_Click);
            // 
            // btnSuaItem
            // 
            this.btnSuaItem.Name = "btnSuaItem";
            this.btnSuaItem.Size = new System.Drawing.Size(124, 22);
            this.btnSuaItem.Text = "Chọn sửa";
            this.btnSuaItem.Click += new System.EventHandler(this.btnSuaItem_Click);
            // 
            // FormDanhMucTrangThaiNhaO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 691);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgrvDanhTinhTrangNhaO);
            this.Controls.Add(this.txtTenDuong);
            this.DoubleBuffered = true;
            this.Name = "FormDanhMucTrangThaiNhaO";
            this.Text = "Danh mục tình trạng nhà ở";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDanhTinhTrangNhaO)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenDuong;
        private System.Windows.Forms.DataGridView dgrvDanhTinhTrangNhaO;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnXoaItem;
        private System.Windows.Forms.ToolStripMenuItem btnSuaItem;
    }
}