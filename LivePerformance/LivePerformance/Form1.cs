using System;
using System.Windows.Forms;

namespace LivePerformance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArtikelen_Click(object sender, EventArgs e)
        {
            ArtikelenForm artikelform = new ArtikelenForm();
            artikelform.Show();
        }

        private void btnBestel_Click(object sender, EventArgs e)
        {
            BestelForm bestelform = new BestelForm();
            bestelform.Show();
        }
    }
}
