using System;
using QLNK.Repositories.Interfaces;
using QLNK.Services;
using QLNK.WinformApp.Forms;

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
            FormCaiDatChung formCaiDatChung = new FormCaiDatChung(_unitOfWork) { MdiParent = this};
            formCaiDatChung.Show();
        }

        private void btnCaiDatNguoiDung_Click(object sender, EventArgs e)
        {
            FormCaiDatNguoiDung formCaiDatNguoiDung = new FormCaiDatNguoiDung(_unitOfWork) {MdiParent = this};
            formCaiDatNguoiDung.Show();
        }

        private void btnDanhMucTenDuong_Click(object sender, EventArgs e)
        {
            FormDanhMucTenDuong formDanhMucTenDuong = new FormDanhMucTenDuong(_unitOfWork) { MdiParent = this};
            formDanhMucTenDuong.Show();
        }
    }
}
