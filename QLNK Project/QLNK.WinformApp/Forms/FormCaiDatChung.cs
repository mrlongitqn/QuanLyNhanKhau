using System.Linq;
using System.Windows.Forms;
using QLNK.Services;
using  QLNK.Common.Enums;
using QLNK.Common.Utilities;
using QLNK.EF;

namespace QLNK.WinformApp.Forms
{
    public partial class FormCaiDatChung : DevComponents.DotNetBar.Metro.MetroForm
    {
        private readonly XuLiCauHinhHeThong _xuLiCauHinhHeThong;
        public FormCaiDatChung(XuLiCauHinhHeThong xuLiCauHinhHeThong)
        {
            this._xuLiCauHinhHeThong = xuLiCauHinhHeThong;
            InitializeComponent();
            LoadDuLieu();
        }

       

        private void LoadDuLieu()
        {
            var duLieuCauHinh = _xuLiCauHinhHeThong.GetAll().ToArray();
            var singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.TinhThanhPho.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtTinhThanhPho.Text = singleOrDefault.GiaTri;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.QuanHuyen.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtQuanHuyen.Text = singleOrDefault.GiaTri;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.PhuongXa.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtPhuongXa.Text = singleOrDefault.GiaTri;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.CanCu.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtCanBo.Text = singleOrDefault.GiaTri;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.ChucVu.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtChucVu.Text = singleOrDefault.GiaTri;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.CanCu.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtCanCu.Text = singleOrDefault.GiaTri;
            }
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}
