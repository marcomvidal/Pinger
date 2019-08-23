namespace Pinger.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.tlpAllInputs = new System.Windows.Forms.TableLayoutPanel();
            this.flpActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTransmit = new System.Windows.Forms.Button();
            this.tlpDestinationIP = new System.Windows.Forms.TableLayoutPanel();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.tlpResults = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMaster = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.prbIsPinging = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.grpDestination.SuspendLayout();
            this.tlpAllInputs.SuspendLayout();
            this.flpActionButtons.SuspendLayout();
            this.tlpDestinationIP.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.tlpResults.SuspendLayout();
            this.tlpMaster.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(3, 3);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.ShowCellErrors = false;
            this.dgvResults.ShowCellToolTips = false;
            this.dgvResults.ShowEditingIcon = false;
            this.dgvResults.ShowRowErrors = false;
            this.dgvResults.Size = new System.Drawing.Size(666, 281);
            this.dgvResults.TabIndex = 1;
            // 
            // grpDestination
            // 
            this.grpDestination.Controls.Add(this.tlpAllInputs);
            this.grpDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDestination.Location = new System.Drawing.Point(3, 3);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(678, 54);
            this.grpDestination.TabIndex = 1;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Endereço IP de destino";
            // 
            // tlpAllInputs
            // 
            this.tlpAllInputs.ColumnCount = 2;
            this.tlpAllInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAllInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tlpAllInputs.Controls.Add(this.flpActionButtons, 1, 0);
            this.tlpAllInputs.Controls.Add(this.tlpDestinationIP, 0, 0);
            this.tlpAllInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAllInputs.Location = new System.Drawing.Point(3, 16);
            this.tlpAllInputs.Name = "tlpAllInputs";
            this.tlpAllInputs.RowCount = 1;
            this.tlpAllInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAllInputs.Size = new System.Drawing.Size(672, 35);
            this.tlpAllInputs.TabIndex = 4;
            // 
            // flpActionButtons
            // 
            this.flpActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpActionButtons.Controls.Add(this.btnStop);
            this.flpActionButtons.Controls.Add(this.btnTransmit);
            this.flpActionButtons.Location = new System.Drawing.Point(521, 3);
            this.flpActionButtons.Name = "flpActionButtons";
            this.flpActionButtons.Size = new System.Drawing.Size(148, 29);
            this.flpActionButtons.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(3, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(58, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "&Parar";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnTransmit
            // 
            this.btnTransmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransmit.Image = ((System.Drawing.Image)(resources.GetObject("btnTransmit.Image")));
            this.btnTransmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransmit.Location = new System.Drawing.Point(67, 3);
            this.btnTransmit.Name = "btnTransmit";
            this.btnTransmit.Size = new System.Drawing.Size(78, 23);
            this.btnTransmit.TabIndex = 2;
            this.btnTransmit.Text = "&Transmitir";
            this.btnTransmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransmit.UseVisualStyleBackColor = true;
            this.btnTransmit.Click += new System.EventHandler(this.BtnTransmit_Click);
            // 
            // tlpDestinationIP
            // 
            this.tlpDestinationIP.ColumnCount = 1;
            this.tlpDestinationIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDestinationIP.Controls.Add(this.txtDestination, 0, 0);
            this.tlpDestinationIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDestinationIP.Location = new System.Drawing.Point(3, 3);
            this.tlpDestinationIP.Name = "tlpDestinationIP";
            this.tlpDestinationIP.RowCount = 1;
            this.tlpDestinationIP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDestinationIP.Size = new System.Drawing.Size(512, 29);
            this.tlpDestinationIP.TabIndex = 1;
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.Location = new System.Drawing.Point(3, 4);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(506, 20);
            this.txtDestination.TabIndex = 1;
            this.txtDestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDestination_KeyDown);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.tlpResults);
            this.grpResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResults.Location = new System.Drawing.Point(3, 63);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(678, 346);
            this.grpResults.TabIndex = 2;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Resultados";
            // 
            // tlpResults
            // 
            this.tlpResults.ColumnCount = 1;
            this.tlpResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResults.Controls.Add(this.dgvResults, 0, 0);
            this.tlpResults.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResults.Location = new System.Drawing.Point(3, 16);
            this.tlpResults.Name = "tlpResults";
            this.tlpResults.RowCount = 2;
            this.tlpResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpResults.Size = new System.Drawing.Size(672, 327);
            this.tlpResults.TabIndex = 3;
            // 
            // tlpMaster
            // 
            this.tlpMaster.ColumnCount = 1;
            this.tlpMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaster.Controls.Add(this.grpDestination, 0, 0);
            this.tlpMaster.Controls.Add(this.grpResults, 0, 1);
            this.tlpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaster.Location = new System.Drawing.Point(0, 0);
            this.tlpMaster.Name = "tlpMaster";
            this.tlpMaster.RowCount = 2;
            this.tlpMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaster.Size = new System.Drawing.Size(684, 412);
            this.tlpMaster.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.prbIsPinging, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 290);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 34);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // prbIsPinging
            // 
            this.prbIsPinging.Dock = System.Windows.Forms.DockStyle.Top;
            this.prbIsPinging.Location = new System.Drawing.Point(3, 3);
            this.prbIsPinging.MarqueeAnimationSpeed = 50;
            this.prbIsPinging.Name = "prbIsPinging";
            this.prbIsPinging.Size = new System.Drawing.Size(660, 24);
            this.prbIsPinging.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbIsPinging.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.tlpMaster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinger";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.grpDestination.ResumeLayout(false);
            this.tlpAllInputs.ResumeLayout(false);
            this.flpActionButtons.ResumeLayout(false);
            this.tlpDestinationIP.ResumeLayout(false);
            this.tlpDestinationIP.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.tlpResults.ResumeLayout(false);
            this.tlpMaster.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.GroupBox grpResults;
        public System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TableLayoutPanel tlpResults;
        private System.Windows.Forms.TableLayoutPanel tlpMaster;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Button btnTransmit;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TableLayoutPanel tlpAllInputs;
        private System.Windows.Forms.FlowLayoutPanel flpActionButtons;
        private System.Windows.Forms.TableLayoutPanel tlpDestinationIP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ProgressBar prbIsPinging;
    }
}

