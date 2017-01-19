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

        public Pizza(int id, string naam, int oppervlakte, bool standaardpizza, int korting, Vorm vorm)
            : base(id, naam)
        {
            Oppervlakte = oppervlakte;
            Standaardpizza = standaardpizza;
            Korting = korting;
            Vorm = vorm;
           // Ingredienten = repo.get;
        }

        public override string ToString()
        {
            return string.Format("Standaard Pizza: {0} {1} {2}", Naam, Vorm, Oppervlakte);
        }
    }
}
