namespace LivePerformance
{
    partial class ArtikelenForm
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
            this.btnProductToevoegen = new System.Windows.Forms.Button();
            this.btnIngredientToeveogen = new System.Windows.Forms.Button();
            this.btnPizzaToevoegen = new System.Windows.Forms.Button();
            this.btnArtikelWijzigen = new System.Windows.Forms.Button();
            this.btnArtikelVerwijderen = new System.Windows.Forms.Button();
            this.btnProducten = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnIngredienten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbArtikelen
            // 
            this.lbArtikelen.FormattingEnabled = true;
            this.lbArtikelen.Location = new System.Drawing.Point(12, 67);
            this.lbArtikelen.Name = "lbArtikelen";
            this.lbArtikelen.Size = new System.Drawing.Size(366, 381);
            this.lbArtikelen.TabIndex = 0;
            // 
            // btnProductToevoegen
            // 
            this.btnProductToevoegen.Location = new System.Drawing.Point(410, 67);
            this.btnProductToevoegen.Name = "btnProductToevoegen";
            this.btnProductToevoegen.Size = new System.Drawing.Size(133, 23);
            this.btnProductToevoegen.TabIndex = 1;
            this.btnProductToevoegen.Text = "Product Toevoegen";
            this.btnProductToevoegen.UseVisualStyleBackColor = true;
            this.btnProductToevoegen.Click += new System.EventHandler(this.btnProductToevoegen_Click);
            // 
            // btnIngredientToeveogen
            // 
            this.btnIngredientToeveogen.Location = new System.Drawing.Point(410, 97);
            this.btnIngredientToeveogen.Name = "btnIngredientToeveogen";
            this.btnIngredientToeveogen.Size = new System.Drawing.Size(133, 23);
            this.btnIngredientToeveogen.TabIndex = 2;
            this.btnIngredientToeveogen.Text = "Ingredient Toevoegen";
            this.btnIngredientToeveogen.UseVisualStyleBackColor = true;
            // 
            // btnPizzaToevoegen
            // 
            this.btnPizzaToevoegen.Location = new System.Drawing.Point(410, 127);
            this.btnPizzaToevoegen.Name = "btnPizzaToevoegen";
            this.btnPizzaToevoegen.Size = new System.Drawing.Size(133, 23);
            this.btnPizzaToevoegen.TabIndex = 3;
            this.btnPizzaToevoegen.Text = "Pizza Toevoegen";
            this.btnPizzaToevoegen.UseVisualStyleBackColor = true;
            this.btnPizzaToevoegen.Click += new System.EventHandler(this.btnPizzaToevoegen_Click);
            // 
            // btnArtikelWijzigen
            // 
            this.btnArtikelWijzigen.Location = new System.Drawing.Point(410, 190);
            this.btnArtikelWijzigen.Name = "btnArtikelWijzigen";
            this.btnArtikelWijzigen.Size = new System.Drawing.Size(133, 23);
            this.btnArtikelWijzigen.TabIndex = 4;
            this.btnArtikelWijzigen.Text = "Artikel Wijzigen";
            this.btnArtikelWijzigen.UseVisualStyleBackColor = true;
            this.btnArtikelWijzigen.Click += new System.EventHandler(this.btnArtikelWijzigen_Click);
            // 
            // btnArtikelVerwijderen
            // 
            this.btnArtikelVerwijderen.Location = new System.Drawing.Point(410, 242);
            this.btnArtikelVerwijderen.Name = "btnArtikelVerwijderen";
            this.btnArtikelVerwijderen.Size = new System.Drawing.Size(133, 23);
            this.btnArtikelVerwijderen.TabIndex = 5;
            this.btnArtikelVerwijderen.Text = "Artikel Verwijderen";
            this.btnArtikelVerwijderen.UseVisualStyleBackColor = true;
            this.btnArtikelVerwijderen.Click += new System.EventHandler(this.btnArtikelVerwijderen_Click);
            // 
            // btnProducten
            // 
            this.btnProducten.Location = new System.Drawing.Point(13, 38);
            this.btnProducten.Name = "btnProducten";
            this.btnProducten.Size = new System.Drawing.Size(75, 23);
            this.btnProducten.TabIndex = 6;
            this.btnProducten.Text = "Producten";
            this.btnProducten.UseVisualStyleBackColor = true;
            this.btnProducten.Click += new System.EventHandler(this.btnProducten_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(107, 38);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(75, 23);
            this.btnPizza.TabIndex = 7;
            this.btnPizza.Text = "Pizzas";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnIngredienten
            // 
            this.btnIngredienten.Location = new System.Drawing.Point(212, 38);
            this.btnIngredienten.Name = "btnIngredienten";
            this.btnIngredienten.Size = new System.Drawing.Size(75, 23);
            this.btnIngredienten.TabIndex = 8;
            this.btnIngredienten.Text = "Ingredienten";
            this.btnIngredienten.UseVisualStyleBackColor = true;
            this.btnIngredienten.Click += new System.EventHandler(this.btnIngredienten_Click);
            // 
            // ArtikelenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 460);
            this.Controls.Add(this.btnIngredienten);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.btnProducten);
            this.Controls.Add(this.btnArtikelVerwijderen);
            this.Controls.Add(this.btnArtikelWijzigen);
            this.Controls.Add(this.btnPizzaToevoegen);
            this.Controls.Add(this.btnIngredientToeveogen);
            this.Controls.Add(this.btnProductToevoegen);
            this.Controls.Add(this.lbArtikelen);
            this.Name = "ArtikelenForm";
            this.Text = "ArtikelenForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbArtikelen;
        private System.Windows.Forms.Button btnProductToevoegen;
        private System.Windows.Forms.Button btnIngredientToeveogen;
        private System.Windows.Forms.Button btnPizzaToevoegen;
        private System.Windows.Forms.Button btnArtikelWijzigen;
        private System.Windows.Forms.Button btnArtikelVerwijderen;
        private System.Windows.Forms.Button btnProducten;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnIngredienten;
    }
}