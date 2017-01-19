using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;

namespace LivePerformance.Data
{
    public interface IIngredientContext
    {
        List<Ingredient> GetAllIngredienten();
        List<Ingredient> GetAllBodem();
        void AddIngredient(string naam, decimal inkoopprijs, decimal verkoopprijs, bool halal, bool veganistisch, bool glutenvrij, bool bodem);
        void DeleteIngredient(int id);
        void UpdateIngredient(int id, string naam, decimal inkoopprijs, decimal verkoopprijs, bool halal, bool veganistisch, bool glutenvrij, bool bodem);
    }
}
