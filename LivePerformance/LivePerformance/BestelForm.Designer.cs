namespace LivePerformance
{
    partial class BestelForm
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
            this.lbArtikelen = new System.Windows.Forms.ListBox();
            this.lbBestelling = new System.Windows.Forms.ListBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnPizzasamenstellen = new System.Windows.Forms.Button();
            this.btnKoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbArtikelen
            // 
            this.lbArtikelen.FormattingEnabled = true;
            this.lbArtikelen.Location = new System.Drawing.Point(12, 97);
            this.lbArtikelen.Name = "lbArtikelen";
            this.lbArtikelen.Size = new System.Drawing.Size(246, 459);
            this.lbArtikelen.TabIndex = 0;
            // 
            // lbBestelling
            // 
            this.lbBestelling.FormattingEnabled = true;
            this.lbBestelling.Location = new System.Drawing.Point(468, 97);
            this.lbBestelling.Name = "lbBestelling";
            this.lbBestelling.Size = new System.Drawing.Size(269, 459);
            this.lbBestelling.TabIndex = 1;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(305, 204);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(120, 23);
            this.btnVoegToe.TabIndex = 2;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(305, 248);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(120, 23);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnPizzasamenstellen
            // 
            this.btnPizzasamenstellen.Location = new System.Drawing.Point(305, 164);
            this.btnPizzasamenstellen.Name = "btnPizzasamenstellen";
            this.btnPizzasamenstellen.Size = new System.Drawing.Size(120, 23);
            this.btnPizzasamenstellen.TabIndex = 4;
            this.btnPizzasamenstellen.Text = "Pizza samenstellen";
            this.btnPizzasamenstellen.UseVisualStyleBackColor = true;
            this.btnPizzasamenstellen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKoop
            // 
            this.btnKoop.Location = new System.Drawing.Point(305, 334);
            this.btnKoop.Name = "btnKoop";
            this.btnKoop.Size = new System.Drawing.Size(120, 53);
            this.btnKoop.TabIndex = 5;
            this.btnKoop.Text = "Koop";
            this.btnKoop.UseVisualStyleBackColor = true;
            this.btnKoop.Click += new System.EventHandler(this.btnKoop_Click);
            // 
            // BestelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 583);
            this.Controls.Add(this.btnKoop);
            this.Controls.Add(this.btnPizzasamenstellen);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.lbBestelling);
            this.Controls.Add(this.lbArtikelen);
            this.Name = "BestelForm";
            this.Text = "BestelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbArtikelen;
        private System.Windows.Forms.ListBox lbBestelling;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnPizzasamenstellen;
        private System.Windows.Forms.Button btnKoop;
    }
}