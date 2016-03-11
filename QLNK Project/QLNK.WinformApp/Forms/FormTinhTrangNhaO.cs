using QLNK.Common.Utilities;
using QLNK.EF;
using QLNK.Repositories.Interfaces;
using QLNK.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNK.WinformApp.Forms
{
    public partial class FormTinhTrangNhaO : DevComponents.DotNetBar.Office2007Form
    {
        private int _rowIndex = -1;
        private readonly TinhTrangNhaOService _tinhTrangNhaOService;
        public FormTinhTrangNhaO(IUnitOfWork unitOfWork)
        {
            _tinhTrangNhaOService = new TinhTrangNhaOService(unitOfWork);
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var datas = _tinhTrangNhaOService.GetAll().Where(t => t.TrangThai).ToList();
            _tinhTrangNhaOService.SapXepThuTu(datas);
            dgrvTTNhaO.DataSource = datas;

            dgrvTTNhaO.Columns[0].Visible = false;
            dgrvTTNhaO.Columns[3].Visible = false;
            dgrvTTNhaO.Columns[4].Visible = false;
            txtTenTinhTrang.Text = string.Empty;
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            var danhMucDuong = new TinhTrangNhaO
            {
                ChiTietTinhTrangNhaO = Helpers.GetShortName(txtTenTinhTrang.Text),
                TrangThai = true
            };
            if (_tinhTrangNhaOService.Insert(danhMucDuong) > 0)
            {
                LoadData();
            }
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Bạn có muốn xóa danh mục này?", @"Xóa danh mục tình trạng nhà ở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            var id = (int)dgrvTTNhaO.Rows[_rowIndex].Cells[0].Value;
            var danhMucDuong = _tinhTrangNhaOService.SingleOrDefault(id);
            danhMucDuong.TrangThai = false;
            _tinhTrangNhaOService.Update(danhMucDuong);
            MessageBox.Show(@"Xóa dữ liệu thành công.");
            LoadData();
        }

        private void btnSuaItem_Click(object sender, EventArgs e)
        {
            if (_rowIndex != -1)
            {
                txtTenTinhTrang.Text = dgrvTTNhaO.Rows[_rowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_rowIndex != -1)
            {
                var id = (int)dgrvTTNhaO.Rows[_rowIndex].Cells[0].Value;
                var danhMucDuong = _tinhTrangNhaOService.SingleOrDefault(id);
                danhMucDuong.ChiTietTinhTrangNhaO = txtTenTinhTrang.Text;
                _tinhTrangNhaOService.Update(danhMucDuong);
                MessageBox.Show(@"Cập nhật dữ liệu thành công.");
                LoadData();

            }
        }

        private void dgrvTTNhaO_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    dgrvTTNhaO.Rows[e.RowIndex].Selected = true;
                    _rowIndex = e.RowIndex;
                    dgrvTTNhaO.CurrentCell = dgrvTTNhaO.Rows[e.RowIndex].Cells[1];
                    contextMenuStrip1.Show(dgrvTTNhaO, e.Location);
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
            txtTenTinhTrang.Text = dgrvTTNhaO.Rows[_rowIndex].Cells[2].Value.ToString();
        }
    }

}
