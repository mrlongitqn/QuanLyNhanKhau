using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNK.WinformApp.Forms
{
    public partial class FormWaitScreen : Form
    {
        private Action Worker { get; set; }

        public FormWaitScreen(Action worker)
        {
            InitializeComponent();

            if (worker == null)
                throw new ArgumentNullException();

            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
