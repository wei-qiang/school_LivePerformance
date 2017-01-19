using System;
using System.Windows.Forms;
using LivePerformance.Logic;
using LivePerformance.Data;
using LivePerformance.Models;

namespace LivePerformance
{
    public partial class ArtikelenForm : Form
    {
        private readonly ArtikelRepository _artikelrepository;
        private readonly IngredientRepository _ingredientrepository;
        private readonly PizzaRepository _pizzarepository;
        private readonly ProductRepository _productrepository;
        public ArtikelenForm()
        {
            InitializeComponent();

            _artikelrepository = new ArtikelRepository(new MssqlIngredientContext(), new MssqlProductContext(), new MssqlPizzaContext());
            _ingredientrepository = new IngredientRepository(new MssqlIngredientContext());
            _pizzarepository = new PizzaRepository(new MssqlIngredientContext(), new MssqlPizzaContext());
            _productrepository = new ProductRepository(new MssqlProductContext());

            ReloadList();
        }

        private void btnProducten_Click(object sender, EventArgs e)
        {
            lbArtikelen.Items.Clear();
            foreach (Product product in _productrepository.GetAllProduct())
            {
                lbArtikelen.Items.Add(product);
            }
        }

        private void btnProductToevoegen_Click(object sender, EventArgs e)
        {
            ProductForm productform = new ProductForm(this);
            productform.Show();
        }

        public void ReloadList()
        {
            lbArtikelen.Items.Clear();
            foreach (Artikel artikel in _artikelrepository.GetAllArtikel())
            {
                lbArtikelen.Items.Add(artikel);
            }
        }

        private void btnArtikelVerwijderen_Click(object sender, EventArgs e)
        {
            if (lbArtikelen.SelectedItem is Product)
            {
                Product product = (Product)lbArtikelen.SelectedItem;
                _productrepository.DeleteProduct(product.Id);
            }
            else if (lbArtikelen.SelectedItem is Ingredient)
            {
                Ingredient ingredient = (Ingredient)lbArtikelen.SelectedItem;
                _ingredientrepository.DeleteIngredient(ingredient.Id);
            }
            else if (lbArtikelen.SelectedItem is Pizza)
            {
                Pizza pizza = (Pizza)lbArtikelen.SelectedItem;
            }
            ReloadList();
        }

        private void btnArtikelWijzigen_Click(object sender, EventArgs e)
        {
            if (lbArtikelen.SelectedItem is Product)
            {
                Product product = (Product)lbArtikelen.SelectedItem;
                ProductForm productform = new ProductForm(this, product);
                productform.Show();
            }
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            lbArtikelen.Items.Clear();
            foreach (Pizza pizza in _pizzarepository.GetAllPizza())
            {
                lbArtikelen.Items.Add(pizza);
            }
        }

        private void btnIngredienten_Click(object sender, EventArgs e)
        {
            lbArtikelen.Items.Clear();
            foreach (Ingredient ingredient in _ingredientrepository.GetAllIngredienten())
            {
                lbArtikelen.Items.Add(ingredient);
            }
        }

        private void btnPizzaToevoegen_Click(object sender, EventArgs e)
        {
            PizzaForm pizzaform = new PizzaForm();
            pizzaform.Show();
        }
    }
}
