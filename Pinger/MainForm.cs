using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Pinger
{
    public partial class MainForm : Form
    {
        private BindingList<Attempt> _attempts;
        private bool _shouldContinue; 

        public MainForm()
        {
            InitializeComponent();
            this._shouldContinue = false;
            this._attempts = new BindingList<Attempt>();
            this.DataGridSetup();
        }

        private void DataGridSetup()
        {
            dgvResults.DataSource = this._attempts;
            dgvResults.Columns[0].HeaderText = "Destino";
            dgvResults.Columns[2].HeaderText = "Horário";
        }

        private async void BtnTransmit_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSucceed;
                this.ToggleContinuePinging();

                do
                {
                    var attempt = new Attempt();

                    isSucceed = await attempt.Send(txtDestination.Text);
                    this.ShowSuccessMessage(isSucceed, attempt);
                    this._attempts.Add(attempt);
                }
                while (!isSucceed && this._shouldContinue);
            }
            catch (Exception)
            {
                this.ShowFailureMessage();
            }
        }

        private void ShowSuccessMessage(bool isSucceed, Attempt attempt)
        {
            if (isSucceed)
            {
                this.ToggleContinuePinging();

                MessageBox.Show(
                    $"Transmissão ao host {attempt.Destination} foi bem sucedida.",
                    "Sucesso!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ShowFailureMessage()
        {
            this.ToggleContinuePinging();

            MessageBox.Show(
                "Verifique o preenchimento do endereço desejado e tente novamente.",
                "Erro ao transmitir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            this.ToggleContinuePinging();
        }

        private void ToggleContinuePinging()
        {
            bool isEnabled = this._shouldContinue == true
                && btnStop.Enabled == true;

            if (isEnabled)
            {
                this._shouldContinue = false;
                btnStop.Enabled = false;
                prbIsPinging.Style = ProgressBarStyle.Continuous;
            }
            else
            {
                this._shouldContinue = true;
                btnStop.Enabled = true;
                prbIsPinging.Style = ProgressBarStyle.Marquee;
            }
        }
    }
}
