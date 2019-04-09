using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Pinger
{
    public partial class MainForm : Form
    {
        private BindingList<Attempt> _attempts;

        public MainForm()
        {
            InitializeComponent();
            this._attempts = new BindingList<Attempt>();
            dgvResults.DataSource = this._attempts;
        }

        private void BtnTransmit_Click(object sender, EventArgs e)
        {
            var attempt = new Attempt();

            try
            {
                bool succeed = attempt.Send(txtDestination.Text);

                if (succeed)
                {
                    MessageBox.Show(
                        $"Transmissão ao host {attempt.Destination} foi bem sucedida.",
                        "Sucesso!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                this._attempts.Add(attempt);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Verifique o preenchimento do endereço desejado e tente novamente.",
                    "Erro ao transmitir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
