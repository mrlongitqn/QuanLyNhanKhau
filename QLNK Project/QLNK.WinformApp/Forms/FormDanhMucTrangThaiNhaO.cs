using QLNK.Common.Utilities;
using QLNK.EF;
using QLNK.Repositories.Interfaces;
using QLNK.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNK.WinformApp.Forms
{
    public partial class FormDanhMucTrangThaiNhaO : DevComponents.DotNetBar.Office2007Form
    {
        private int _rowIndex = -1;
        private readonly TinhTrangNhaOService _tinhTrangNhaOService;
        public FormDanhMucTrangThaiNhaO(IUnitOfWork unitOfWork)
        {
            _tinhTrangNhaOService = new TinhTrangNhaOService(unitOfWork);
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var tinhTrangNhoOs = _tinhTrangNhaOService.GetAll().Where(t => t.TrangThai).ToList();
            _tinhTrangNhaOService.SapXepThuTu(tinhTrangNhoOs);
            dgrvDanhTinhTrangNhaO.DataSource = tinhTrangNhoOs;
            dgrvDanhTinhTrangNhaO.Columns[0].Visible = false;
            dgrvDanhTinhTrangNhaO.Columns[3].Visible = false;
            dgrvDanhTinhTrangNhaO.Columns[4].Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tinhTrangNhaO = new TinhTrangNhaO
            {
                ChiTietTinhTrangNhaO = Helpers.GetShortName(txtTenDuong.Text),
                TrangThai = true
            };
            if (_tinhTrangNhaOService.Insert(tinhTrangNhaO) > 0)
            {
                LoadData();
            }
        }

        private void dgrvDanhMucDuong_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    dgrvDanhTinhTrangNhaO.Rows[e.RowIndex].Selected = true;
                    _rowIndex = e.RowIndex;
                    dgrvDanhTinhTrangNhaO.CurrentCell = dgrvDanhTinhTrangNhaO.Rows[e.RowIndex].Cells[1];
                    contextMenuStrip1.Show(dgrvDanhTinhTrangNhaO, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                    break;
                case MouseButtons.Left:
                    _rowIndex = e.RowIndex;
                    SetTextForEdit();
                    break;
            }
        }

        private void SetTextForEdit()
        {
            if (_rowIndex != -1)
            {
                txtTenDuong.Text = dgrvDanhTinhTrangNhaO.Rows[_rowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Bạn có muốn xóa danh mục này?", @"Xóa danh mục nhà ở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            var id = (int)dgrvDanhTinhTrangNhaO.Rows[_rowIndex].Cells[0].Value;
            var tinhTrangNhaO = _tinhTrangNhaOService.SingleOrDefault(id);
            tinhTrangNhaO.TrangThai = false;
            _tinhTrangNhaOService.Update(tinhTrangNhaO);
            LoadData();
        }

        private void btnSuaItem_Click(object sender, EventArgs e)
        {
            this.txtTenDuong.Text = dgrvDanhTinhTrangNhaO.Rows[_rowIndex].Cells[2].Value.ToString();
            txtTenDuong.Focus();
        }
    }
}
