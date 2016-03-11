namespace QLNK.WinformApp.Forms
{
    partial class FormDanhMucKhuPho
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgrvDMKhuPho = new System.Windows.Forms.DataGridView();
            this.txtTenKhuPho = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSuaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDMKhuPho)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(269, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 39);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(114, 400);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 39);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(400, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 26);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgrvDMKhuPho
            // 
            this.dgrvDMKhuPho.AllowUserToAddRows = false;
            this.dgrvDMKhuPho.AllowUserToDeleteRows = false;
            this.dgrvDMKhuPho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrvDMKhuPho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvDMKhuPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDMKhuPho.Location = new System.Drawing.Point(3, 83);
            this.dgrvDMKhuPho.Name = "dgrvDMKhuPho";
            this.dgrvDMKhuPho.ReadOnly = true;
            this.dgrvDMKhuPho.RowHeadersVisible = false;
            this.dgrvDMKhuPho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvDMKhuPho.Size = new System.Drawing.Size(508, 295);
            this.dgrvDMKhuPho.TabIndex = 11;
            this.dgrvDMKhuPho.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvDMKhuPho_CellMouseUp);
            // 
            // txtTenKhuPho
            // 
            this.txtTenKhuPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhuPho.Location = new System.Drawing.Point(3, 27);
            this.txtTenKhuPho.Name = "txtTenKhuPho";
            this.txtTenKhuPho.Size = new System.Drawing.Size(391, 26);
            this.txtTenKhuPho.TabIndex = 10;
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
            this.btnSuaItem.Size = new System.Drawing.Size(152, 22);
            this.btnSuaItem.Text = "Sửa";
            this.btnSuaItem.Click += new System.EventHandler(this.btnSuaItem_Click);
            // 
            // btnXoaItem
            // 
            this.btnXoaItem.Name = "btnXoaItem";
            this.btnXoaItem.Size = new System.Drawing.Size(152, 22);
            this.btnXoaItem.Text = "Xóa";
            this.btnXoaItem.Click += new System.EventHandler(this.btnXoaItem_Click);
            // 
            // FormDanhMucKhuPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 451);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgrvDMKhuPho);
            this.Controls.Add(this.txtTenKhuPho);
            this.DoubleBuffered = true;
            this.Name = "FormDanhMucKhuPho";
            this.Text = "FormDanhMucKhuPho";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDMKhuPho)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgrvDMKhuPho;
        private System.Windows.Forms.TextBox txtTenKhuPho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSuaItem;
        private System.Windows.Forms.ToolStripMenuItem btnXoaItem;
    }
}