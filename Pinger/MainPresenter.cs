using System.Windows.Forms;

namespace Pinger
{
    class MainPresenter
    {
        private MainForm _form;

        public MainPresenter(MainForm form)
        {
            this._form = form;
        }

        public void DataGridSetup()
        {

            _form.dgvResults.Columns[0].HeaderText = "Destino";
            _form.dgvResults.Columns[2].HeaderText = "Horário";
        }

        public void ShowSuccessMessage(bool isSucceed, Attempt attempt)
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

        public void ShowFailureMessage()
        {
            this.ToggleContinuePinging();

            MessageBox.Show(
                "Verifique o preenchimento do endereço desejado e tente novamente.",
                "Erro ao transmitir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public void ToggleContinuePinging()
        {
            bool isEnabled = _form.ShouldContinue == true
                && _form.btnStop.Enabled == true;

            if (isEnabled)
            {
                _form.ShouldContinue = false;
                _form.btnStop.Enabled = false;
                _form.prbIsPinging.Style = ProgressBarStyle.Continuous;
            }
            else
            {
                _form.ShouldContinue = true;
                _form.btnStop.Enabled = true;
                _form.prbIsPinging.Style = ProgressBarStyle.Marquee;
            }
        }
    }
}
