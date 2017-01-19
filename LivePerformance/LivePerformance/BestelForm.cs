using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LivePerformance.Data;
using LivePerformance.Logic;
using LivePerformance.Models;

namespace LivePerformance
{
    public partial class BestelForm : Form
    { 

        private readonly PizzaRepository _pizzarepository;
        private readonly ProductRepository _productrepository;
        public BestelForm()
        {
            InitializeComponent();
            _pizzarepository = new PizzaRepository(new MssqlIngredientContext(), new MssqlPizzaContext());
            _productrepository = new ProductRepository(new MssqlProductContext());
            ReloadList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PizzaForm pizzaform = new PizzaForm();
            pizzaform.Show();
        }

        public void ReloadList()
        {
            lbArtikelen.Items.Clear();
            foreach (Pizza pizza in _pizzarepository.GetAllPizza())
            {
                lbArtikelen.Items.Add(pizza);
            }
            foreach (Product product in _productrepository.GetAllProduct())
            {
                lbArtikelen.Items.Add(product);
            }
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            lbBestelling.Items.Add(lbArtikelen.SelectedItem);
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            lbBestelling.Items.Remove(lbBestelling.SelectedItem);
        }

        private void btnKoop_Click(object sender, EventArgs e)
        {
            List<Artikel> bestelling = new List<Artikel>();
            foreach (Artikel artikel in lbBestelling.Items)
            {
                bestelling.Add(artikel);
            }
            BestellingForm bestellingform = new BestellingForm(bestelling);
            bestellingform.Show();
        }
    }
}
