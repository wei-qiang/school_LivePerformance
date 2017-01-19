using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;
using LivePerformance.Data;

namespace LivePerformance.Logic
{
    public class ArtikelRepository
    {
        private readonly IIngredientContext ingredientcontext;
        private readonly IPizzaContext pizzacontext;
        private readonly IProductContext productcontext;

        public ArtikelRepository(IIngredientContext ingredientcontext, IProductContext productcontext, IPizzaContext pizzacontext)
        {
            this.ingredientcontext = ingredientcontext;
            this.pizzacontext = pizzacontext;
            this.productcontext = productcontext;
        }
        public List<Artikel> GetAllArtikel()
        {
            List<Artikel> artikelen = new List<Artikel>();
            artikelen.AddRange(ingredientcontext.GetAllIngredienten());
            artikelen.AddRange(pizzacontext.GetAllPizzas());
            artikelen.AddRange(productcontext.GetAllProducts());

            return artikelen;
        }
    }
}
