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
        private readonly IIngredientContext ingredientcontext;
        private readonly IPizzaContext pizzacontext;

        public PizzaRepository(IIngredientContext ingredientcontext, IPizzaContext pizzacontext)
        {
            this.ingredientcontext = ingredientcontext;
            this.pizzacontext = pizzacontext;
        }

        public List<Pizza> GetAllPizza()
        {
            return pizzacontext.GetAllPizzas();
        }
    }
}
