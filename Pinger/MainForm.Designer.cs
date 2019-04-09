namespace Pinger
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.btnTransmit = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.grpDestination.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(6, 19);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.ShowCellErrors = false;
            this.dgvResults.ShowCellToolTips = false;
            this.dgvResults.ShowEditingIcon = false;
            this.dgvResults.ShowRowErrors = false;
            this.dgvResults.Size = new System.Drawing.Size(358, 308);
            this.dgvResults.TabIndex = 1;
            // 
            // grpDestination
            // 
            this.grpDestination.Controls.Add(this.btnTransmit);
            this.grpDestination.Controls.Add(this.txtDestination);
            this.grpDestination.Location = new System.Drawing.Point(10, 12);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(370, 49);
            this.grpDestination.TabIndex = 1;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Endereço IP de destino";
            // 
            // btnTransmit
            // 
            this.btnTransmit.Location = new System.Drawing.Point(289, 16);
            this.btnTransmit.Name = "btnTransmit";
            this.btnTransmit.Size = new System.Drawing.Size(75, 23);
            this.btnTransmit.TabIndex = 2;
            this.btnTransmit.Text = "&Transmitir";
            this.btnTransmit.UseVisualStyleBackColor = true;
            this.btnTransmit.Click += new System.EventHandler(this.BtnTransmit_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(7, 18);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(276, 20);
            this.txtDestination.TabIndex = 1;
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.dgvResults);
            this.grpResults.Location = new System.Drawing.Point(10, 67);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(370, 333);
            this.grpResults.TabIndex = 2;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Resultados";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 410);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpDestination);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinger";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Button btnTransmit;
        private System.Windows.Forms.TextBox txtDestination;
    }
}

