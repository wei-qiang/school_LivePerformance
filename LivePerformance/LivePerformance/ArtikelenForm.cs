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
    public partial class ArtikelenForm : Form
    {
        private readonly ArtikelRepository artikelrepository;
        public ArtikelenForm()
        {
            InitializeComponent();
            artikelrepository = new ArtikelRepository(new MssqlIngredientContext(), new MssqlProductContext(), new MssqlPizzaContext());
            foreach (Artikel artikel in artikelrepository.GetAllArtikel())
            {
                lbArtikelen.Items.Add(artikel);
            }
            
        }

        private void btnProducten_Click(object sender, EventArgs e)
        {

        }
    }
}
