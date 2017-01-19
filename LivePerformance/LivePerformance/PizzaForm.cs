using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance.Data;
using LivePerformance.Logic;
using LivePerformance.Models;

namespace LivePerformance
{
    public partial class PizzaForm : Form
    {
        private readonly PizzaRepository _pizzarepository;
        private readonly IngredientRepository _ingredientrepository;

        public PizzaForm()
        {
            InitializeComponent();
            _pizzarepository = new PizzaRepository(new MssqlIngredientContext(), new MssqlPizzaContext());
            _ingredientrepository = new IngredientRepository(new MssqlIngredientContext());

            foreach (Ingredient bodem in _ingredientrepository.GetAllBodem())
            {
                cbBodem.Items.Add(bodem);
            }
            foreach (Ingredient ingredienten in _ingredientrepository.GetAllIngredienten())
            {
                lbIngredienten.Items.Add(ingredienten);
            }
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            lbPizza.Items.Add(lbIngredienten.SelectedItem);
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            lbPizza.Items.Remove(lbPizza.SelectedItem);
        }

        private void btnMaak_Click(object sender, EventArgs e)
        {
            //Pizza pizza = new Pizza()
            //_pizzarepository.AddPizza()
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
