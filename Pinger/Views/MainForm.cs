using Pinger.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Pinger.Views
{
    public partial class MainForm : Form
    {
        private BindingList<Attempt> _attempts;
        public bool ShouldContinue { get; set; } = false;
        private MainPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            _attempts = new BindingList<Attempt>();
            _presenter = new MainPresenter(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvResults.DataSource = _attempts;
            _presenter.DataGridSetup();
        }

        private void TxtDestination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { BtnTransmit_Click(sender, e); }
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
                    _attempts.Add(attempt);
                    _presenter.ColorizeResultCell(attempt);
                    _presenter.ShowSuccessMessage(isSucceed, attempt);
                    _presenter.AutoScrollDataGridView();
                }
                while (!isSucceed && ShouldContinue);
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
