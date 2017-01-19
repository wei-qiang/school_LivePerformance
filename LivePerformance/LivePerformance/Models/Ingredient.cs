using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Models
{
    public class Ingredient: Artikel
    {
        public bool Halal { get; set; }
        public bool Veganistisch { get; set; }
        public bool Glutenvrij { get; set; }
        public bool Bodem { get; set; }

        public Ingredient(int id, string naam, decimal inkoopprijs, decimal verkoopprijs, bool halal, bool veganistisch, bool glutenvrij, bool bodem)
            : base(id, naam, inkoopprijs, verkoopprijs)
        {
            Halal = halal;
            Veganistisch = veganistisch;
            Glutenvrij = glutenvrij;
            Bodem = bodem;
        }

        public override string ToString()
        {
            string halal = "";
            string veganistisch = "";
            string glutenvrij = "";
            if (Halal)
            {
                halal = "halal";
            }
            if (Veganistisch)
            {
                veganistisch = "veganistisch";
            }
            if (Glutenvrij)
            {
                glutenvrij = "glutenvrij";
            }
            return string.Format("Ingredient: {0} {1} {2} {3} | Prijs: {4}", Naam, halal, veganistisch, glutenvrij, BerekenPrijs());
        }

    }
}
