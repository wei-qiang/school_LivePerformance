namespace LivePerformance
{
    partial class BestellingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBestelling = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrijdExclusiefBtw = new System.Windows.Forms.Label();
            this.PrijsBtw = new System.Windows.Forms.Label();
            this.PrijsTebetalenBedrag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBestelling
            // 
            this.lbBestelling.FormattingEnabled = true;
            this.lbBestelling.Location = new System.Drawing.Point(48, 62);
            this.lbBestelling.Name = "lbBestelling";
            this.lbBestelling.Size = new System.Drawing.Size(285, 420);
            this.lbBestelling.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prijs exclusief BTW:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prijs BTW:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Te betalen bedrag:";
            // 
            // lblPrijdExclusiefBtw
            // 
            this.lblPrijdExclusiefBtw.AutoSize = true;
            this.lblPrijdExclusiefBtw.Location = new System.Drawing.Point(183, 505);
            this.lblPrijdExclusiefBtw.Name = "lblPrijdExclusiefBtw";
            this.lblPrijdExclusiefBtw.Size = new System.Drawing.Size(35, 13);
            this.lblPrijdExclusiefBtw.TabIndex = 4;
            this.lblPrijdExclusiefBtw.Text = "label4";
            // 
            // PrijsBtw
            // 
            this.PrijsBtw.AutoSize = true;
            this.PrijsBtw.Location = new System.Drawing.Point(186, 522);
            this.PrijsBtw.Name = "PrijsBtw";
            this.PrijsBtw.Size = new System.Drawing.Size(35, 13);
            this.PrijsBtw.TabIndex = 5;
            this.PrijsBtw.Text = "label5";
            // 
            // PrijsTebetalenBedrag
            // 
            this.PrijsTebetalenBedrag.AutoSize = true;
            this.PrijsTebetalenBedrag.Location = new System.Drawing.Point(186, 539);
            this.PrijsTebetalenBedrag.Name = "PrijsTebetalenBedrag";
            this.PrijsTebetalenBedrag.Size = new System.Drawing.Size(35, 13);
            this.PrijsTebetalenBedrag.TabIndex = 6;
            this.PrijsTebetalenBedrag.Text = "label6";
            // 
            // BestellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 582);
            this.Controls.Add(this.PrijsTebetalenBedrag);
            this.Controls.Add(this.PrijsBtw);
            this.Controls.Add(this.lblPrijdExclusiefBtw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBestelling);
            this.Name = "BestellingForm";
            this.Text = "BestellingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBestelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrijdExclusiefBtw;
        private System.Windows.Forms.Label PrijsBtw;
        private System.Windows.Forms.Label PrijsTebetalenBedrag;
    }
}