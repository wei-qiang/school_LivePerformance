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
        private readonly IIngredientContext _ingredientcontext;
        private readonly IPizzaContext _pizzacontext;
        private readonly IProductContext _productcontext;

        public ArtikelRepository(IIngredientContext ingredientcontext, IProductContext productcontext, IPizzaContext pizzacontext)
        {
            this._ingredientcontext = ingredientcontext;
            this._pizzacontext = pizzacontext;
            this._productcontext = productcontext;
        }
        public List<Artikel> GetAllArtikel()
        {
            List<Artikel> artikelen = new List<Artikel>();
            artikelen.AddRange(_ingredientcontext.GetAllIngredienten());
            artikelen.AddRange(_pizzacontext.GetAllPizzas());
            artikelen.AddRange(_productcontext.GetAllProducts());

            return artikelen;
        }
    }
}
