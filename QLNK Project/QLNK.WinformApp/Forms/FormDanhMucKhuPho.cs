using QLNK.Common.Utilities;
using QLNK.EF;
using QLNK.Repositories.Interfaces;
using QLNK.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNK.WinformApp.Forms
{
    public partial class FormDanhMucKhuPho : DevComponents.DotNetBar.Office2007Form
    {
        private int _rowIndex = -1;
        private readonly DanhMucKhuPhoService _danhMucKhuPhoService;
        public FormDanhMucKhuPho(IUnitOfWork unitOfWork)
        {
            _danhMucKhuPhoService = new DanhMucKhuPhoService(unitOfWork);
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var danhmuckhuphos = _danhMucKhuPhoService.GetAll().Where(t => t.TrangThai).ToList();
            _danhMucKhuPhoService.SapXepThuTu(danhmuckhuphos);
            dgrvDMKhuPho.DataSource = danhmuckhuphos;
            dgrvDMKhuPho.Columns[0].Visible = false;
            dgrvDMKhuPho.Columns[4].Visible = false;
            dgrvDMKhuPho.Columns[5].Visible = false;
            dgrvDMKhuPho.Columns[6].Visible = false;
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            try
            {
                DanhMucKhuPho khuPho = new DanhMucKhuPho
                {
                    TenVietTat = Helpers.GetShortName(txtTenKhuPho.Text),
                    TenDayDu = txtTenKhuPho.Text,
                    TrangThai = true
                };
                if (_danhMucKhuPhoService.Insert(khuPho) > 0)
                {
                    LoadData();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgrvDMKhuPho_CellMouseUp(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    dgrvDMKhuPho.Rows[e.RowIndex].Selected = true;
                    _rowIndex = e.RowIndex;
                    dgrvDMKhuPho.CurrentCell = dgrvDMKhuPho.Rows[e.RowIndex].Cells[1];
                    contextMenuStrip1.Show(dgrvDMKhuPho, e.Location);
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
            txtTenKhuPho.Text = dgrvDMKhuPho.Rows[_rowIndex].Cells[2].Value.ToString();
        }

        private void btnSuaItem_Click(object sender, EventArgs e)
        {
            txtTenKhuPho.Focus();
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Bạn có muốn xóa khu vực này?", @"Xóa khu vực", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            var id = (int)dgrvDMKhuPho.Rows[_rowIndex].Cells[0].Value;
            var danhMucKhuPho = _danhMucKhuPhoService.SingleOrDefault(id);
            danhMucKhuPho.TrangThai = false;
            if (_danhMucKhuPhoService.Update(danhMucKhuPho) > 0)
            {
                LoadData();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Bạn có muốn lưu thay đổi?", @"Cập nhật tên khu vực", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            var id = (int)dgrvDMKhuPho.Rows[_rowIndex].Cells[0].Value;
            var danhMucKhuPho = _danhMucKhuPhoService.SingleOrDefault(id);
            danhMucKhuPho.TenVietTat = Helpers.GetShortName(txtTenKhuPho.Text);
            danhMucKhuPho.TenDayDu = txtTenKhuPho.Text;
            if (_danhMucKhuPhoService.Update(danhMucKhuPho) > 0)
            {
                LoadData();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
