using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformance.Models;
using LivePerformance.Data;

namespace LivePerformance.Logic
{
    public class IngredientRepository
    {
        private readonly IIngredientContext _ingredientcontext;

        public IngredientRepository(IIngredientContext ingredientcontext)
        {
            this._ingredientcontext = ingredientcontext;
        }

        public List<Ingredient> GetAllIngredienten()
        {
            return _ingredientcontext.GetAllIngredienten();
        }

        public List<Ingredient> GetAllBodem()
        {
            return _ingredientcontext.GetAllBodem();
        }

        public void AddIngredient(string naam, decimal inkoopprijs, decimal verkoopprijs, bool halal, bool veganistisch, bool glutenvrij, bool bodem)
        {
            _ingredientcontext.AddIngredient(naam, inkoopprijs, verkoopprijs, halal, veganistisch, glutenvrij, bodem);
        }

        public void DeleteIngredient(int id)
        {
            _ingredientcontext.DeleteIngredient(id);
        }

        public void UpdateIngredient(int id, string naam, decimal inkoopprijs, decimal verkoopprijs, bool halal, bool veganistisch, bool glutenvrij, bool bodem)
        {
            _ingredientcontext.UpdateIngredient(id, naam, inkoopprijs, verkoopprijs, halal, veganistisch, glutenvrij, bodem);
        }
    }
}
