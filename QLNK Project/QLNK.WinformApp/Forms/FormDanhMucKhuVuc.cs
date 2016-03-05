using QLNK.Common.Utilities;
using QLNK.EF;
using QLNK.Repositories.Interfaces;
using QLNK.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNK.WinformApp.Forms
{
    public partial class FormDanhMucKhuVuc : DevComponents.DotNetBar.Office2007Form
    {
        private int _rowIndex = -1;
        private readonly DanhMucKhuPhoService _danhMucKhuPhoService;
        private readonly DanhMucKhuVucService _danhMucKhuVucService;
        public FormDanhMucKhuVuc(IUnitOfWork unitOfWork)
        {
            _danhMucKhuVucService = new DanhMucKhuVucService(unitOfWork);
            _danhMucKhuPhoService = new DanhMucKhuPhoService(unitOfWork);
            InitializeComponent();

            LoadDataDropDownKhuPho();
            //dgvKhuVuc.AutoGenerateColumns = false;
            LoadData();

        }

        private void LoadData()
        {
            var khuvucs = _danhMucKhuVucService.GetAll().Select(t => new { t.Id, t.TenDayDu, TenKhuPho = t.DanhMucKhuPho.TenDayDu }).ToList();
            dgvKhuVuc.DataSource = khuvucs;
        }

        private void LoadDataDropDownKhuPho()
        {
            var khuPhos = _danhMucKhuPhoService.GetAll().Where(_ => _.TrangThai).OrderBy(t => t.TenDayDu).Select(t => new { t.Id, t.TenDayDu }).ToList();
            cboKhuPho.DataSource = khuPhos;
            cboKhuPho.ValueMember = "Id";
            cboKhuPho.DisplayMember = "TenDayDu";
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            var khuvuc = new DanhMucKhuVuc
            {
                TenVietTat = Helpers.GetShortName(txtTenKhuVuc.Text),
                TenDayDu = txtTenKhuVuc.Text,
                MaKhuPho = (int)cboKhuPho.SelectedValue
            };
            if (_danhMucKhuVucService.Insert(khuvuc) > 0)
            {
                LoadData();
            }
        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dgvKhuVuc[column, row];
            DataGridViewCell cell2 = dgvKhuVuc[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            if (cell1.Value.ToString() == cell2.Value.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsRepeatedCellValue(int p1, int p2)
        {
            throw new NotImplementedException();
        }

        private void dgvKhuVuc_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            }
            else
            {
                e.AdvancedBorderStyle.Top = dgvKhuVuc.AdvancedCellBorderStyle.Top;
            }
        }

        private void dgvKhuVuc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
    }
}
