namespace LivePerformance
{
    partial class PizzaForm
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
            this.lbIngredienten = new System.Windows.Forms.ListBox();
            this.cbBodem = new System.Windows.Forms.ComboBox();
            this.lbPizza = new System.Windows.Forms.ListBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnMaak = new System.Windows.Forms.Button();
            this.cbVorm = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIngredienten
            // 
            this.lbIngredienten.FormattingEnabled = true;
            this.lbIngredienten.Location = new System.Drawing.Point(34, 39);
            this.lbIngredienten.Name = "lbIngredienten";
            this.lbIngredienten.Size = new System.Drawing.Size(246, 394);
            this.lbIngredienten.TabIndex = 0;
            // 
            // cbBodem
            // 
            this.cbBodem.FormattingEnabled = true;
            this.cbBodem.Location = new System.Drawing.Point(313, 65);
            this.cbBodem.Name = "cbBodem";
            this.cbBodem.Size = new System.Drawing.Size(121, 21);
            this.cbBodem.TabIndex = 1;
            // 
            // lbPizza
            // 
            this.lbPizza.FormattingEnabled = true;
            this.lbPizza.Location = new System.Drawing.Point(499, 39);
            this.lbPizza.Name = "lbPizza";
            this.lbPizza.Size = new System.Drawing.Size(231, 381);
            this.lbPizza.TabIndex = 2;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(313, 230);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(75, 23);
            this.btnVoegToe.TabIndex = 3;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(313, 277);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnMaak
            // 
            this.btnMaak.Location = new System.Drawing.Point(313, 334);
            this.btnMaak.Name = "btnMaak";
            this.btnMaak.Size = new System.Drawing.Size(75, 23);
            this.btnMaak.TabIndex = 5;
            this.btnMaak.Text = "Maak";
            this.btnMaak.UseVisualStyleBackColor = true;
            this.btnMaak.Click += new System.EventHandler(this.btnMaak_Click);
            // 
            // cbVorm
            // 
            this.cbVorm.FormattingEnabled = true;
            this.cbVorm.Items.AddRange(new object[] {
            "Rond",
            "Driehoek",
            "Rechthoek"});
            this.cbVorm.Location = new System.Drawing.Point(313, 115);
            this.cbVorm.Name = "cbVorm";
            this.cbVorm.Size = new System.Drawing.Size(121, 21);
            this.cbVorm.TabIndex = 6;
            this.cbVorm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(314, 171);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bodem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vorm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grootte (cm2):";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbVorm);
            this.Controls.Add(this.btnMaak);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.lbPizza);
            this.Controls.Add(this.cbBodem);
            this.Controls.Add(this.lbIngredienten);
            this.Name = "PizzaForm";
            this.Text = "PizzaForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbIngredienten;
        private System.Windows.Forms.ComboBox cbBodem;
        private System.Windows.Forms.ListBox lbPizza;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnMaak;
        private System.Windows.Forms.ComboBox cbVorm;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}