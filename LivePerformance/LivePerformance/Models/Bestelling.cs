using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Models
{
    public class Bestelling
    {
        public decimal Btwbedrag { get; set; }
        public decimal Totaalbedrag { get; set; }
        public Klant Klant { get; set; }
        public List<Artikel> Artikelen { get; set; }

        public Bestelling(decimal btwbedrag, decimal totaalbedrag, Klant klant, List<Artikel> artikelen)
        {
            Btwbedrag = btwbedrag;
            Totaalbedrag = totaalbedrag;
            Klant = klant;
            Artikelen = artikelen;
        }
    }
}
