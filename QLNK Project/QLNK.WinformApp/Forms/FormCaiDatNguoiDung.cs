using System.Linq;
using System.Windows.Forms;
using QLNK.Services;
using QLNK.Common.Enums;
using QLNK.Common.Utilities;
using QLNK.EF;
using QLNK.Repositories.Interfaces;

namespace QLNK.WinformApp.Forms
{
    public partial class FormCaiDatNguoiDung : DevComponents.DotNetBar.Metro.MetroForm
    {
        private readonly CauHinhNguoiDungService _cauHinhNguoiDungService;
        public FormCaiDatNguoiDung(IUnitOfWork unitOfWork)
        {
            _cauHinhNguoiDungService = new CauHinhNguoiDungService(unitOfWork);
            InitializeComponent();
            LoadDuLieu();
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            NguoiDung nguoiDung = new NguoiDung
            {
                TenNguoiDung = txtTenDangNhap.Text,
                TenDangNhap = txtTenDangNhap.Text,
                ChucVu = rbLoaiNguoiDung.Text,
                MatKhau = txtMatKhau.Text,
                QuyenHan = "Admin",
                TrangThai = true
            };
            MessageBox.Show(_cauHinhNguoiDungService.Insert(nguoiDung) > 0
                ? @"Thêm mới thành công"
                : @"Thêm mới không thành công");
        }

        private void LoadDuLieu()
        {
            dgrvNguoiDung.DataSource = _cauHinhNguoiDungService.GetAll();
        }
    }
}
