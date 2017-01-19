using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;
using LivePerformance.Data;

namespace LivePerformance.Logic
{
    public class PizzaRepository
    {
        private readonly IIngredientContext _ingredientcontext;
        private readonly IPizzaContext _pizzacontext;

        public PizzaRepository(IIngredientContext ingredientcontext, IPizzaContext pizzacontext)
        {
            this._ingredientcontext = ingredientcontext;
            this._pizzacontext = pizzacontext;
        }

        public List<Pizza> GetAllPizza()
        {
            return _pizzacontext.GetAllPizzas();
        }

        public void AddPizza(int vormid, string naam, int oppervlakte, bool standaardpizza, int korting, int formaat1, int formaat2 = 0, int formaat3 = 0)
        {
            _pizzacontext.AddPizza(vormid, naam, oppervlakte, standaardpizza, korting, formaat1, formaat2, formaat3);
        }

        /// <summary>
        /// dit zet de bit voor "standaardpizza" op 0 voor een pizza in plaats van dat je het verwijderd
        /// </summary>
        /// <param name="id"></param>
        public void InactivateStandaardPizza(int id)
        {
            _pizzacontext.InactivateStandaardPizza(id);
        }

        public void AddIngredientPizza(int pizzaid, List<Ingredient> ingredienten)
        {
            foreach (Ingredient ingredient in ingredienten)
            {
                _pizzacontext.AddIngredientPizza(pizzaid, ingredient.Id);
            }
        }

        public int GetPizzaId(int vormid, string naam, int oppervlakte, bool standaardpizza)
        {
            return _pizzacontext.GetPizzaId(vormid, naam, oppervlakte, standaardpizza);
        }
    }
}
