using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance.Models
{
    public class Klant
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public int Klantnummer { get; set; }

        public Klant(int id, string naam, string adres, int klantnummer)
        {
            Id = id;
            Naam = naam;
            Adres = adres;
            Klantnummer = klantnummer;
        }
    }
}
