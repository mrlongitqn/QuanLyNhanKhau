using QLNK.Repositories.Interfaces;
using QLNK.WinformApp.Forms;
using System;

namespace QLNK.WinformApp
{
    public partial class MainForm : DevComponents.DotNetBar.RibbonForm
    {
        private readonly IUnitOfWork _unitOfWork;
        public MainForm()
        {
            _unitOfWork = new UnitOfWork();
            InitializeComponent();
        }

        private void btnCaiDatChung_Click(object sender, EventArgs e)
        {
            FormCaiDatChung formCaiDatChung = new FormCaiDatChung(_unitOfWork) { MdiParent = this };
            formCaiDatChung.Show();
        }

        private void btnCaiDatNguoiDung_Click(object sender, EventArgs e)
        {
            FormCaiDatNguoiDung formCaiDatNguoiDung = new FormCaiDatNguoiDung(_unitOfWork) { MdiParent = this };
            formCaiDatNguoiDung.Show();
        }

        private void btnDanhMucTenDuong_Click(object sender, EventArgs e)
        {
            FormDanhMucTenDuong formDanhMucTenDuong = new FormDanhMucTenDuong(_unitOfWork) { MdiParent = this };
            formDanhMucTenDuong.Show();
        }

        private void btnTinhTrangNhaO_Click(object sender, EventArgs e)
        {

            FormTinhTrangNhaO formDanhMucTrangThaiNhaO = new FormTinhTrangNhaO(_unitOfWork) { MdiParent = this };
            formDanhMucTrangThaiNhaO.Show();
        }

        private void btnTinhTrangCuTru_Click(object sender, EventArgs e)
        {
            FormTinhTrangCuTru formTinhTrangCuTru = new FormTinhTrangCuTru(_unitOfWork) { MdiParent = this };
            formTinhTrangCuTru.Show();
        }

        private void btnDanhMucKhuPho_Click(object sender, EventArgs e)
        {
            FormDanhMucKhuPho formDanhMucKhuPho = new FormDanhMucKhuPho(_unitOfWork) { MdiParent = this };
            formDanhMucKhuPho.Show();
        }

        private void btnOKhuVuc_Click(object sender, EventArgs e)
        {
            FormDanhMucKhuVuc formDanhMucKhuVuc = new FormDanhMucKhuVuc(_unitOfWork) { MdiParent = this };
            formDanhMucKhuVuc.Show();
        }
    }
}
