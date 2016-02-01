using System.Linq;
using System.Windows.Forms;
using QLNK.Services;
using QLNK.Common.Enums;
using QLNK.Common.Utilities;
using QLNK.EF;
namespace QLNK.WinformApp.Forms
{
    public partial class FormCaiDatNguoiDung : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FormCaiDatNguoiDung()
        {
            InitializeComponent();
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
            
        }
    }
}
