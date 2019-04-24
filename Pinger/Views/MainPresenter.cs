using Pinger.Models;
using System.Drawing;
using System.Media;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinger.Views
{
    class MainPresenter
    {
        private MainForm _form;

        public MainPresenter(MainForm form)
        {
            _form = form;
        }

        public void DataGridSetup()
        {
            _form.dgvResults.Columns[0].HeaderText = "Destino";
            _form.dgvResults.Columns[2].HeaderText = "Horário";
        }

        public void ShowSuccessMessage(bool isSucceed, Attempt attempt)
        {
            if (!isSucceed) { return; }
            ToggleContinuePinging();
            SystemSounds.Exclamation.Play();
            Task.Run(() => ShowTrayNotification(attempt));
        }

        public void ShowFailureMessage()
        {
            ToggleContinuePinging();

            MessageBox.Show(
                "Verifique o preenchimento do endereço desejado e tente novamente.",
                "Erro ao transmitir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public async Task ShowTrayNotification(Attempt attempt)
        {
            const int timeShown = 5000;

            var notification = new NotifyIcon()
            {
                Visible = true,
                Icon = SystemIcons.Information,
                BalloonTipIcon = ToolTipIcon.Info,
                BalloonTipTitle = "Sucesso!",
                BalloonTipText = $"Transmissão ao host {attempt.Destination} foi bem sucedida.",
            };

            notification.ShowBalloonTip(timeShown);
            await Task.Delay(timeShown);
            notification.Dispose();
        }

        public void ColorizeResultCell(Attempt attempt)
        {
            var colorizedCell = new DataGridViewCellStyle()
            {
                ForeColor = Color.White
            };

            colorizedCell.BackColor = attempt.Status == IPStatus.Success ?
                Color.Green : Color.Red;

            _form.dgvResults
                .Rows[_form.dgvResults.RowCount - 1]
                .Cells[1]
                .Style = colorizedCell;
        }

        public void AutoScrollDataGridView()
        {
            _form.dgvResults.CurrentCell = _form.dgvResults
                .Rows[_form.dgvResults.Rows.Count - 1]
                .Cells[0];
        }

        public void ToggleContinuePinging()
        {
            bool itsPinging = _form.ShouldContinue == true
                && _form.btnStop.Enabled == true;

            if (itsPinging)
            {
                _form.ShouldContinue = false;
                _form.btnStop.Enabled = false;
                _form.btnTransmit.Enabled = true;
                _form.prbIsPinging.Style = ProgressBarStyle.Continuous;
            }
            else
            {
                _form.ShouldContinue = true;
                _form.btnStop.Enabled = true;
                _form.btnTransmit.Enabled = false;
                _form.prbIsPinging.Style = ProgressBarStyle.Marquee;
            }
        }
    }
}
