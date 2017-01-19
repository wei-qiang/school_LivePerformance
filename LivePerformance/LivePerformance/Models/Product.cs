using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Models
{
    public class Product: Artikel
    {
        public int Alcoholpercentage { get; set; }

        public Product(int id, string naam, decimal inkoopprijs, decimal verkoopprijs, int alcoholpercentage)
            : base(id, naam, inkoopprijs, verkoopprijs)
        {
            Alcoholpercentage = alcoholpercentage;
        }

        public override decimal BerekenPrijs()
        {
            if (Alcoholpercentage > 0)
            {
                return Verkoopprijs * (decimal)0.21 + Verkoopprijs;
            }
            return base.BerekenPrijs();
        }

        public override string ToString()
        {
            if (Alcoholpercentage > 0)
            {
                return string.Format("Product: {0} bevat {1}% alcohol | Prijs: {2}", Naam, Alcoholpercentage, BerekenPrijs());
            }
            return string.Format("Product: {0} | Prijs: {1}", Naam, BerekenPrijs());
        }
    }
}
