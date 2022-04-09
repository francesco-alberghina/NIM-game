
namespace NIM
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblBiglie2 = new System.Windows.Forms.Label();
            this.nudNumeroBiglie = new System.Windows.Forms.NumericUpDown();
            this.btnGenera = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblBiglie = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.flpNim = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGico = new System.Windows.Forms.Label();
            this.stpInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.iNFOCREATORIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.comeGiocareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpBigliettini = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroBiglie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.stpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBiglie2
            // 
            this.lblBiglie2.AutoSize = true;
            this.lblBiglie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiglie2.Location = new System.Drawing.Point(29, 27);
            this.lblBiglie2.Name = "lblBiglie2";
            this.lblBiglie2.Size = new System.Drawing.Size(125, 20);
            this.lblBiglie2.TabIndex = 0;
            this.lblBiglie2.Text = "Numero Biglie:";
            // 
            // nudNumeroBiglie
            // 
            this.nudNumeroBiglie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nudNumeroBiglie.Location = new System.Drawing.Point(196, 27);
            this.nudNumeroBiglie.Name = "nudNumeroBiglie";
            this.nudNumeroBiglie.Size = new System.Drawing.Size(120, 26);
            this.nudNumeroBiglie.TabIndex = 1;
            // 
            // btnGenera
            // 
            this.btnGenera.Location = new System.Drawing.Point(531, 33);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(87, 55);
            this.btnGenera.TabIndex = 3;
            this.btnGenera.Text = "GENERA";
            this.btnGenera.UseVisualStyleBackColor = true;
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(644, 31);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(115, 58);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblBiglie
            // 
            this.lblBiglie.AutoSize = true;
            this.lblBiglie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiglie.Location = new System.Drawing.Point(29, 71);
            this.lblBiglie.Name = "lblBiglie";
            this.lblBiglie.Size = new System.Drawing.Size(303, 20);
            this.lblBiglie.TabIndex = 6;
            this.lblBiglie.Text = "Numero Biglie da togliere per mossa:";
            // 
            // nudMax
            // 
            this.nudMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudMax.Location = new System.Drawing.Point(367, 68);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 26);
            this.nudMax.TabIndex = 7;
            // 
            // flpNim
            // 
            this.flpNim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpNim.Location = new System.Drawing.Point(33, 452);
            this.flpNim.Name = "flpNim";
            this.flpNim.Size = new System.Drawing.Size(700, 109);
            this.flpNim.TabIndex = 8;
            // 
            // lblGico
            // 
            this.lblGico.AutoSize = true;
            this.lblGico.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGico.ForeColor = System.Drawing.Color.Gray;
            this.lblGico.Location = new System.Drawing.Point(29, 123);
            this.lblGico.Name = "lblGico";
            this.lblGico.Size = new System.Drawing.Size(118, 19);
            this.lblGico.TabIndex = 9;
            this.lblGico.Text = "Tavola da Gioco";
            // 
            // stpInfo
            // 
            this.stpInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.stpInfo.Location = new System.Drawing.Point(0, 578);
            this.stpInfo.Name = "stpInfo";
            this.stpInfo.Size = new System.Drawing.Size(774, 22);
            this.stpInfo.TabIndex = 10;
            this.stpInfo.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFOCREATORIToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // iNFOCREATORIToolStripMenuItem
            // 
            this.iNFOCREATORIToolStripMenuItem.Name = "iNFOCREATORIToolStripMenuItem";
            this.iNFOCREATORIToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.iNFOCREATORIToolStripMenuItem.Text = "INFO CREATORI";
            this.iNFOCREATORIToolStripMenuItem.Click += new System.EventHandler(this.iNFOCREATORIToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comeGiocareToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // comeGiocareToolStripMenuItem
            // 
            this.comeGiocareToolStripMenuItem.Name = "comeGiocareToolStripMenuItem";
            this.comeGiocareToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.comeGiocareToolStripMenuItem.Text = "Come giocare";
            this.comeGiocareToolStripMenuItem.Click += new System.EventHandler(this.comeGiocareToolStripMenuItem_Click);
            // 
            // flpBigliettini
            // 
            this.flpBigliettini.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBigliettini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBigliettini.Enabled = false;
            this.flpBigliettini.Location = new System.Drawing.Point(33, 160);
            this.flpBigliettini.Name = "flpBigliettini";
            this.flpBigliettini.Size = new System.Drawing.Size(700, 268);
            this.flpBigliettini.TabIndex = 11;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 600);
            this.Controls.Add(this.flpBigliettini);
            this.Controls.Add(this.stpInfo);
            this.Controls.Add(this.lblGico);
            this.Controls.Add(this.flpNim);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.lblBiglie);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnGenera);
            this.Controls.Add(this.nudNumeroBiglie);
            this.Controls.Add(this.lblBiglie2);
            this.MaximumSize = new System.Drawing.Size(790, 639);
            this.MinimumSize = new System.Drawing.Size(790, 639);
            this.Name = "FrmMain";
            this.Text = "NIM";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroBiglie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.stpInfo.ResumeLayout(false);
            this.stpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBiglie2;
        private System.Windows.Forms.NumericUpDown nudNumeroBiglie;
        private System.Windows.Forms.Button btnGenera;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblBiglie;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.FlowLayoutPanel flpNim;
        private System.Windows.Forms.Label lblGico;
        private System.Windows.Forms.StatusStrip stpInfo;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem iNFOCREATORIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comeGiocareToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpBigliettini;
    }
}

