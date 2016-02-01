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
            XuLiCauHinhHeThong xuLiCauHinhHeThong = new XuLiCauHinhHeThong(_unitOfWork);
            FormCaiDatChung formCaiDatChung = new FormCaiDatChung(xuLiCauHinhHeThong) { MdiParent = this};
            formCaiDatChung.Show();
        }

        private void btnCaiDatNguoiDung_Click(object sender, EventArgs e)
        {

            FormCaiDatNguoiDung formCaiDatNguoiDung = new FormCaiDatNguoiDung {MdiParent = this};
            formCaiDatNguoiDung.Show();
        }
    }
}
