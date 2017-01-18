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

        public Ingredient(int id, string naam, decimal prijs, int btw, bool halal, bool veganistisch, bool glutenvrij)
            : base(id, naam, prijs, btw)
        {
            Halal = halal;
            Veganistisch = veganistisch;
            Glutenvrij = glutenvrij;
        }

    }
}
