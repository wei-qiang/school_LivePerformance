using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Models
{
    public abstract class Artikel
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public int BTW { get; set; }

        public Artikel(int id, string naam, decimal prijs, int btw)
        {
            ID = id;
            Naam = naam;
            Prijs = prijs;
            BTW = btw;
        }
    }
}
