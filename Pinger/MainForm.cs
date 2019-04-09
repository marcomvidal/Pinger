using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Pinger
{
    public partial class MainForm : Form
    {
        private BindingList<Attempt> _attempts;
        public bool ShouldContinue { get; set; } = false;
        private MainPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            this._attempts = new BindingList<Attempt>();
            this._presenter = new MainPresenter(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvResults.DataSource = this._attempts;
            _presenter.DataGridSetup();
        }

        private async void BtnTransmit_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSucceed;
                _presenter.ToggleContinuePinging();

                do
                {
                    var attempt = new Attempt();

                    isSucceed = await attempt.Send(txtDestination.Text);
                    _presenter.ShowSuccessMessage(isSucceed, attempt);
                    this._attempts.Add(attempt);
                }
                while (!isSucceed && this.ShouldContinue);
            }
            catch (Exception)
            {
                _presenter.ShowFailureMessage();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            _presenter.ToggleContinuePinging();
        }
    }
}
