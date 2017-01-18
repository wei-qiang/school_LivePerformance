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

        public Product(int id, string naam, decimal prijs, int btw, int alcoholpercentage)
            : base(id, naam, prijs, btw)
        {
            Alcoholpercentage = alcoholpercentage;
        }
    }
}
