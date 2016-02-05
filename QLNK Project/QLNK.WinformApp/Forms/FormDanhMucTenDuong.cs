using System;
using System.Linq;
using System.Windows.Forms;
using QLNK.Common.Utilities;
using QLNK.EF;
using QLNK.Repositories.Interfaces;
using QLNK.Services;

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
            dgrvDanhMucDuong.DataSource = _danhMucDuongService.GetAll().Where(t=>t.TrangThai == false);
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
            var id = (int) dgrvDanhMucDuong.Rows[_rowIndex].Cells[0].Value;
            var danhMucDuong = _danhMucDuongService.SingleOrDefault(id);
            danhMucDuong.TrangThai = false;
            _danhMucDuongService.Update(danhMucDuong);
        }
    }
}
