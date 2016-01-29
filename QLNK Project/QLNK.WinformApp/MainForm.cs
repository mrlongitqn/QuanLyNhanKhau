using System;
using QLNK.WinformApp.Forms;

namespace QLNK.WinformApp
{
    public partial class MainForm : DevComponents.DotNetBar.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCaiDatChung_Click(object sender, EventArgs e)
        {
            FormCaiDatChung formCaiDatChung = new FormCaiDatChung { MdiParent = this};
            formCaiDatChung.Show();
        }
    }
}
