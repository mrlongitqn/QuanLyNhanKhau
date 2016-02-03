using System.Linq;
using System.Windows.Forms;
using QLNK.Services;
using  QLNK.Common.Enums;
using QLNK.Common.Utilities;
using QLNK.Repositories.Interfaces;

namespace QLNK.WinformApp.Forms
{
    public partial class FormCaiDatChung : DevComponents.DotNetBar.Office2007Form
    {
        private readonly CauHinhHeThongService _xuLiCauHinhHeThong;
        public FormCaiDatChung(IUnitOfWork unitOfWork)
        {
            this._xuLiCauHinhHeThong = new CauHinhHeThongService(unitOfWork);
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
                txtTinhThanhPho.Tag = singleOrDefault.Id;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.QuanHuyen.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtQuanHuyen.Text = singleOrDefault.GiaTri;
                txtQuanHuyen.Tag = singleOrDefault.Id;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.PhuongXa.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtPhuongXa.Text = singleOrDefault.GiaTri;
                txtPhuongXa.Tag = singleOrDefault.Id;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.CanCu.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtCanBo.Text = singleOrDefault.GiaTri;
                txtCanBo.Tag = singleOrDefault.Id;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.ChucVu.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtCapBac.Text = singleOrDefault.GiaTri;
                txtCapBac.Tag = singleOrDefault.Id;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.ChucVu.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtChucVu.Text = singleOrDefault.GiaTri;
                txtChucVu.Tag = singleOrDefault.Id;
            }
            singleOrDefault = duLieuCauHinh.SingleOrDefault(t => t.TuKhoa.Equals(CaiDatChungEnum.CanCu.DescriptionAttr()));
            if (singleOrDefault != null)
            {
                txtCanCu.Text = singleOrDefault.GiaTri;
                txtCanCu.Tag = singleOrDefault.Id;
            }
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            var id = int.Parse(txtTinhThanhPho.Tag.ToString());
            var caiDatItem = _xuLiCauHinhHeThong.SingleOrDefault(id);
            caiDatItem.GiaTri = txtTinhThanhPho.Text;
            _xuLiCauHinhHeThong.Update(caiDatItem);

            id = int.Parse(txtQuanHuyen.Tag.ToString());
            caiDatItem = _xuLiCauHinhHeThong.SingleOrDefault(id);
            caiDatItem.GiaTri = txtQuanHuyen.Text;
            _xuLiCauHinhHeThong.Update(caiDatItem);

            id = int.Parse(txtPhuongXa.Tag.ToString());
            caiDatItem = _xuLiCauHinhHeThong.SingleOrDefault(id);
            caiDatItem.GiaTri = txtPhuongXa.Text;
            _xuLiCauHinhHeThong.Update(caiDatItem);

            id = int.Parse(txtCanBo.Tag.ToString());
            caiDatItem = _xuLiCauHinhHeThong.SingleOrDefault(id);
            caiDatItem.GiaTri = txtCanBo.Text;
            _xuLiCauHinhHeThong.Update(caiDatItem);

            id = int.Parse(txtChucVu.Tag.ToString());
            caiDatItem = _xuLiCauHinhHeThong.SingleOrDefault(id);
            caiDatItem.GiaTri = txtChucVu.Text;
            _xuLiCauHinhHeThong.Update(caiDatItem);

            id = int.Parse(txtCapBac.Tag.ToString());
            caiDatItem = _xuLiCauHinhHeThong.SingleOrDefault(id);
            caiDatItem.GiaTri = txtCapBac.Text;
            _xuLiCauHinhHeThong.Update(caiDatItem);

            id = int.Parse(txtCanCu.Tag.ToString());
            caiDatItem = _xuLiCauHinhHeThong.SingleOrDefault(id);
            caiDatItem.GiaTri = txtCanCu.Text;
            _xuLiCauHinhHeThong.Update(caiDatItem);

            MessageBox.Show(@"Cập nhật thành công");
        }
    }
}
