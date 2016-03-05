using QLNK.Common.Utilities;
using QLNK.EF;
using QLNK.Repositories.Interfaces;
using QLNK.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNK.WinformApp.Forms
{
    public partial class FormDanhMucTenDuong : DevComponents.DotNetBar.Office2007Form
    {
        private int _rowIndex = -1;
        private readonly DanhMucDuongService _danhMucDuongService;
        public FormDanhMucTenDuong(IUnitOfWork unitOfWork)
        {
            _danhMucDuongService = new DanhMucDuongService(unitOfWork);
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgrvDanhMucDuong.DataSource = _danhMucDuongService.GetAll().Where(t => t.TrangThai).ToList();
            dgrvDanhMucDuong.Columns[0].Visible = false;
            dgrvDanhMucDuong.Columns[3].Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var danhMucDuong = new DanhMucDuong
            {
                TenVietTat = Helpers.GetShortName(txtTenDuong.Text),
                TenDayDu = txtTenDuong.Text,
                TrangThai = true
            };
            if (_danhMucDuongService.Insert(danhMucDuong) > 0)
            {
                LoadData();
            }
        }

        private void dgrvDanhMucDuong_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    dgrvDanhMucDuong.Rows[e.RowIndex].Selected = true;
                    _rowIndex = e.RowIndex;
                    dgrvDanhMucDuong.CurrentCell = dgrvDanhMucDuong.Rows[e.RowIndex].Cells[1];
                    contextMenuStrip1.Show(dgrvDanhMucDuong, e.Location);
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
            txtTenDuong.Text = dgrvDanhMucDuong.Rows[_rowIndex].Cells[2].Value.ToString();
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Bạn có muốn xóa tên đường này?", @"Xóa tên đường", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            var id = (int)dgrvDanhMucDuong.Rows[_rowIndex].Cells[0].Value;
            var danhMucDuong = _danhMucDuongService.SingleOrDefault(id);
            danhMucDuong.TrangThai = false;
            if (_danhMucDuongService.Update(danhMucDuong) > 0)
            {
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Bạn có muốn lưu thay đổi tên đường?", @"Cập nhật tên đường", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            var id = (int)dgrvDanhMucDuong.Rows[_rowIndex].Cells[0].Value;
            var danhMucDuong = _danhMucDuongService.SingleOrDefault(id);
            danhMucDuong.TenVietTat = Helpers.GetShortName(txtTenDuong.Text);
            danhMucDuong.TenDayDu = txtTenDuong.Text;
            if (_danhMucDuongService.Update(danhMucDuong) > 0)
            {
                LoadData();
            }
        }

        private void btnSuaItem_Click(object sender, EventArgs e)
        {
            txtTenDuong.Focus();
        }
    }
}
