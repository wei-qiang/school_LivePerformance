using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Models
{
    public abstract class Artikel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public decimal Inkoopprijs { get; set; }
        public decimal Verkoopprijs { get; set; }

        protected Artikel(int id, string naam, decimal inkoopprijs, decimal verkoopprijs)
        {
            Id = id;
            Naam = naam;
            Inkoopprijs = inkoopprijs;
            Verkoopprijs = verkoopprijs;
        }

        /// <summary>
        /// deze constructor is voor de pizza omdat de prijs van een pizza lokaal wordt berekend
        /// </summary>
        /// <param name="id"></param>
        /// <param name="naam"></param>
        protected Artikel(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }

        public virtual decimal BerekenPrijs()
        {
            return Verkoopprijs * (decimal)0.06 + Verkoopprijs;
        }
    }
}
