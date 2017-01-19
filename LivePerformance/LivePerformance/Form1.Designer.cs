namespace LivePerformance
{
    partial class Form1
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
            this.btnBestel = new System.Windows.Forms.Button();
            this.btnArtikelen = new System.Windows.Forms.Button();
            this.btnOmzet = new System.Windows.Forms.Button();
            this.btnKlanten = new System.Windows.Forms.Button();
            this.btnAlleBestellingen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBestel
            // 
            this.btnBestel.Location = new System.Drawing.Point(81, 67);
            this.btnBestel.Name = "btnBestel";
            this.btnBestel.Size = new System.Drawing.Size(115, 64);
            this.btnBestel.TabIndex = 0;
            this.btnBestel.Text = "Bestel";
            this.btnBestel.UseVisualStyleBackColor = true;
            this.btnBestel.Click += new System.EventHandler(this.btnBestel_Click);
            // 
            // btnArtikelen
            // 
            this.btnArtikelen.Location = new System.Drawing.Point(81, 167);
            this.btnArtikelen.Name = "btnArtikelen";
            this.btnArtikelen.Size = new System.Drawing.Size(115, 68);
            this.btnArtikelen.TabIndex = 1;
            this.btnArtikelen.Text = "Artikelen";
            this.btnArtikelen.UseVisualStyleBackColor = true;
            this.btnArtikelen.Click += new System.EventHandler(this.btnArtikelen_Click);
            // 
            // btnOmzet
            // 
            this.btnOmzet.Location = new System.Drawing.Point(81, 265);
            this.btnOmzet.Name = "btnOmzet";
            this.btnOmzet.Size = new System.Drawing.Size(115, 64);
            this.btnOmzet.TabIndex = 2;
            this.btnOmzet.Text = "Omzet/winst";
            this.btnOmzet.UseVisualStyleBackColor = true;
            // 
            // btnKlanten
            // 
            this.btnKlanten.Location = new System.Drawing.Point(321, 67);
            this.btnKlanten.Name = "btnKlanten";
            this.btnKlanten.Size = new System.Drawing.Size(115, 64);
            this.btnKlanten.TabIndex = 3;
            this.btnKlanten.Text = "Klanten";
            this.btnKlanten.UseVisualStyleBackColor = true;
            // 
            // btnAlleBestellingen
            // 
            this.btnAlleBestellingen.Location = new System.Drawing.Point(321, 167);
            this.btnAlleBestellingen.Name = "btnAlleBestellingen";
            this.btnAlleBestellingen.Size = new System.Drawing.Size(115, 68);
            this.btnAlleBestellingen.TabIndex = 4;
            this.btnAlleBestellingen.Text = "Alle Bestellingen";
            this.btnAlleBestellingen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 404);
            this.Controls.Add(this.btnAlleBestellingen);
            this.Controls.Add(this.btnKlanten);
            this.Controls.Add(this.btnOmzet);
            this.Controls.Add(this.btnArtikelen);
            this.Controls.Add(this.btnBestel);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBestel;
        private System.Windows.Forms.Button btnArtikelen;
        private System.Windows.Forms.Button btnOmzet;
        private System.Windows.Forms.Button btnKlanten;
        private System.Windows.Forms.Button btnAlleBestellingen;
    }
}

