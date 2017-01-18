using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Models
{
    public class Pizza: Artikel
    {
        public int Oppervlakte { get; set; }
        public bool Standaardpizza { get; set; }
        public int Korting { get; set; }
        public Vorm Vorm { get; set; }
        public List<Ingredient> Ingredienten { get; set; }

        public Pizza(int id, string naam, decimal prijs, int btw, int oppervlakte, bool standaardpizza, int korting, Vorm vorm, List<Ingredient> ingredienten)
            : base(id, naam, prijs, btw)
        {
            Oppervlakte = oppervlakte;
            Standaardpizza = standaardpizza;
            Korting = korting;
            Vorm = vorm;
            Ingredienten = ingredienten;
        }
    }
}
