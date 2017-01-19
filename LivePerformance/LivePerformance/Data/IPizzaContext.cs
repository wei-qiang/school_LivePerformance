using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;

namespace LivePerformance.Data
{
    public interface IPizzaContext
    {
        List<Pizza> GetAllPizzas();
        void AddPizza(int vormid, string naam, int oppervlakte, bool standaardpizza, int korting, int formaat1, int formaat2 = 0, int formaat3 = 0);
        void InactivateStandaardPizza(int id);
        void AddIngredientPizza(int pizzaid, int ingredientid);
    }
}
