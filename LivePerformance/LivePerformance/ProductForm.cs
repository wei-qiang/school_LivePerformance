using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance.Logic;
using LivePerformance.Data;
using LivePerformance.Models;

namespace LivePerformance
{
    public partial class ProductForm : Form
    {
        private readonly ProductRepository _productrepository;
        private readonly ArtikelenForm _artikelform;
        private readonly Product _product;

        /// <summary>
        /// deze constructor is voor als je een product wilt aanmaken
        /// </summary>
        /// <param name="artikelform"></param>
        public ProductForm(ArtikelenForm artikelform)
        {
            InitializeComponent();
            _productrepository = new ProductRepository(new MssqlProductContext());
            this._artikelform = artikelform;
        }

        /// <summary>
        /// deze constructor is voor als je een product wilt wijzigen
        /// </summary>
        /// <param name="artikelform"></param>
        /// <param name="product"></param>
        public ProductForm(ArtikelenForm artikelform, Product product)
        {
            InitializeComponent();
            _productrepository = new ProductRepository(new MssqlProductContext());
            this._artikelform = artikelform;
            this._product = product;
            tbNaam.Text = product.Naam;
            nudInkoop.Value = product.Inkoopprijs;
            nudVerkoop.Value = product.Verkoopprijs;
            nudAlcohol.Value = product.Alcoholpercentage;
            btnProduct.Text = "Wijzig Product";
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            try
            {
                //gebruik de update query
                if (_product != null)
                {
                    _productrepository.UpdateProduct(_product.Id, tbNaam.Text, nudInkoop.Value, nudVerkoop.Value, (int)nudAlcohol.Value);
                }
                //gebruik de add query
                else
                {
                    if (tbNaam.Text == "")
                    {
                        MessageBox.Show("Voer een naam in");
                    }
                    _productrepository.AddProduct(tbNaam.Text, nudInkoop.Value, nudVerkoop.Value, (int)nudAlcohol.Value);
                }
                _artikelform.ReloadList();
            }
            catch
            {

            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
