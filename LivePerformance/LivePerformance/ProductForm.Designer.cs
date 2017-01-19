namespace LivePerformance
{
    partial class ProductForm
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.nudInkoop = new System.Windows.Forms.NumericUpDown();
            this.nudVerkoop = new System.Windows.Forms.NumericUpDown();
            this.nudAlcohol = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudInkoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerkoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlcohol)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(130, 40);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inkoopprijs (in euros):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Verkoopprijs (iin euros):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alcoholpercentage:";
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(114, 285);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(116, 23);
            this.btnProduct.TabIndex = 8;
            this.btnProduct.Text = "Voeg Product Toe";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // nudInkoop
            // 
            this.nudInkoop.DecimalPlaces = 4;
            this.nudInkoop.Location = new System.Drawing.Point(131, 102);
            this.nudInkoop.Name = "nudInkoop";
            this.nudInkoop.Size = new System.Drawing.Size(120, 20);
            this.nudInkoop.TabIndex = 9;
            // 
            // nudVerkoop
            // 
            this.nudVerkoop.DecimalPlaces = 4;
            this.nudVerkoop.Location = new System.Drawing.Point(131, 159);
            this.nudVerkoop.Name = "nudVerkoop";
            this.nudVerkoop.Size = new System.Drawing.Size(120, 20);
            this.nudVerkoop.TabIndex = 10;
            // 
            // nudAlcohol
            // 
            this.nudAlcohol.Location = new System.Drawing.Point(130, 225);
            this.nudAlcohol.Name = "nudAlcohol";
            this.nudAlcohol.Size = new System.Drawing.Size(120, 20);
            this.nudAlcohol.TabIndex = 11;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 377);
            this.Controls.Add(this.nudAlcohol);
            this.Controls.Add(this.nudVerkoop);
            this.Controls.Add(this.nudInkoop);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNaam);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInkoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerkoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlcohol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.NumericUpDown nudInkoop;
        private System.Windows.Forms.NumericUpDown nudVerkoop;
        private System.Windows.Forms.NumericUpDown nudAlcohol;
    }
}