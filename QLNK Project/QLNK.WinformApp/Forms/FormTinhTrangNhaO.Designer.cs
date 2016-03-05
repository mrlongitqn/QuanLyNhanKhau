namespace QLNK.WinformApp.Forms
{
    partial class FormTinhTrangNhaO
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
            this.btnThem = new System.Windows.Forms.Button();
            this.dgrvTTNhaO = new System.Windows.Forms.DataGridView();
            this.txtTenTinhTrang = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSuaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTTNhaO)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(390, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 25);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgrvTTNhaO
            // 
            this.dgrvTTNhaO.AllowUserToAddRows = false;
            this.dgrvTTNhaO.AllowUserToDeleteRows = false;
            this.dgrvTTNhaO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrvTTNhaO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvTTNhaO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvTTNhaO.Location = new System.Drawing.Point(2, 76);
            this.dgrvTTNhaO.Name = "dgrvTTNhaO";
            this.dgrvTTNhaO.ReadOnly = true;
            this.dgrvTTNhaO.RowHeadersVisible = false;
            this.dgrvTTNhaO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvTTNhaO.Size = new System.Drawing.Size(491, 295);
            this.dgrvTTNhaO.TabIndex = 6;
            this.dgrvTTNhaO.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvTTNhaO_CellMouseUp);
            // 
            // txtTenTinhTrang
            // 
            this.txtTenTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTinhTrang.Location = new System.Drawing.Point(12, 20);
            this.txtTenTinhTrang.Name = "txtTenTinhTrang";
            this.txtTenTinhTrang.Size = new System.Drawing.Size(372, 26);
            this.txtTenTinhTrang.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(259, 377);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 48);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(104, 377);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 48);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSuaItem,
            this.btnXoaItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // btnSuaItem
            // 
            this.btnSuaItem.Name = "btnSuaItem";
            this.btnSuaItem.Size = new System.Drawing.Size(94, 22);
            this.btnSuaItem.Text = "Sửa";
            this.btnSuaItem.Click += new System.EventHandler(this.btnSuaItem_Click);
            // 
            // btnXoaItem
            // 
            this.btnXoaItem.Name = "btnXoaItem";
            this.btnXoaItem.Size = new System.Drawing.Size(94, 22);
            this.btnXoaItem.Text = "Xóa";
            this.btnXoaItem.Click += new System.EventHandler(this.btnXoaItem_Click);
            // 
            // FormTinhTrangNhaO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 433);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgrvTTNhaO);
            this.Controls.Add(this.txtTenTinhTrang);
            this.DoubleBuffered = true;
            this.Name = "FormTinhTrangNhaO";
            this.Text = "Tình trạng nhà ở";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTTNhaO)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgrvTTNhaO;
        private System.Windows.Forms.TextBox txtTenTinhTrang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSuaItem;
        private System.Windows.Forms.ToolStripMenuItem btnXoaItem;
    }
}