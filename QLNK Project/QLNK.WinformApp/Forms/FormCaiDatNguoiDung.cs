using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLNK.Services;
using QLNK.Common.Enums;
using QLNK.Common.Utilities;
using QLNK.EF;
using QLNK.Repositories.Interfaces;

namespace QLNK.WinformApp.Forms
{
    public partial class FormCaiDatNguoiDung : DevComponents.DotNetBar.Office2007Form
    {
        private readonly CauHinhNguoiDungService _cauHinhNguoiDungService;
        private List<NguoiDung> _nguoiDungs = new List<NguoiDung>(); 
        private int _rowIndex = -1;
        public FormCaiDatNguoiDung(IUnitOfWork unitOfWork)
        {
            _cauHinhNguoiDungService = new CauHinhNguoiDungService(unitOfWork);
            InitializeComponent();
            LoadDuLieu();
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            var chucVu = string.Empty;
            if (rbBCH.Checked)
                chucVu = QuyenSuDung.Bch.DescriptionAttr();
            if (rbNCTD.Checked)
                chucVu = QuyenSuDung.Nctd.DescriptionAttr();
            if (rbCSKV.Checked)
                chucVu = QuyenSuDung.Cskv.DescriptionAttr();
            NguoiDung nguoiDung = new NguoiDung
            {
                TenNguoiDung = txtTenDangNhap.Text,
                TenDangNhap = txtTenDangNhap.Text,
                ChucVu = chucVu,
                MatKhau = txtMatKhau.Text,
                QuyenHan = LoaiNguoiDungEnum.Admin.DescriptionAttr(),
                TrangThai = true
            };
            MessageBox.Show(_cauHinhNguoiDungService.Insert(nguoiDung) > 0
                ? @"Thêm mới thành công"
                : @"Thêm mới không thành công");
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            _nguoiDungs = _cauHinhNguoiDungService.GetAll().Where(t=>t.TrangThai).ToList();
            _cauHinhNguoiDungService.SapXepThuTu(_nguoiDungs);
            dgrvNguoiDung.DataSource = _nguoiDungs;
            dgrvNguoiDung.Columns[0].Visible = false;
            dgrvNguoiDung.Columns[4].Visible = false;
            dgrvNguoiDung.Columns[5].Visible = false;
            dgrvNguoiDung.Columns[6].Visible = false;
            dgrvNguoiDung.Columns[7].Visible = false;
        }

        private void dgrvNguoiDung_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    dgrvNguoiDung.Rows[e.RowIndex].Selected = true;
                    _rowIndex = e.RowIndex;
                    dgrvNguoiDung.CurrentCell = dgrvNguoiDung.Rows[e.RowIndex].Cells[1];
                    contextMenuStrip1.Show(dgrvNguoiDung, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                    break;
                case MouseButtons.Left:
                    _rowIndex = e.RowIndex;
                    SetTextForEdit();
                    break;
            }
        }

        private void btnXoaItem_Click(object sender, System.EventArgs e)
        {
            var dr = MessageBox.Show(@"Bạn có muốn xóa người dùng này ?", @"Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;
            if (dgrvNguoiDung.Rows[_rowIndex].IsNewRow) return;
            var id = (int)dgrvNguoiDung.Rows[_rowIndex].Cells[0].Value;
            var nguoidung = _nguoiDungs.SingleOrDefault(t => t.Id == id);
            if (nguoidung == null) return;
            nguoidung.TrangThai = false;
            if (_cauHinhNguoiDungService.Update(nguoidung) > 0)
            {
                LoadDuLieu();
            }
        }

        private void SetTextForEdit()
        {
            txtTenNguoiDung.Text = (string) dgrvNguoiDung.Rows[_rowIndex].Cells[2].Value;
            txtTenDangNhap.Text = (string)dgrvNguoiDung.Rows[_rowIndex].Cells[3].Value;
            switch ((string)dgrvNguoiDung.Rows[_rowIndex].Cells[3].Value)
            {
                case "BCH":
                    rbBCH.Select();
                    break;
                case "NCTD":
                    rbNCTD.Select();
                    break;
                case "CSKV":
                    rbCSKV.Select();
                    break;
                default:
                    rbBCH.Select();
                    break;
            }
        }
    }
}
