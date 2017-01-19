using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance.Models;

namespace LivePerformance
{
    public partial class BestellingForm : Form
    {
        public BestellingForm(List<Artikel> artikelen)
        {
            InitializeComponent();

            foreach (Artikel artikel in artikelen)
            {
                lbBestelling.Items.Add(artikel);
            }
        }
    }
}
