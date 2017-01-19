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
        private readonly IIngredientContext ingredientcontext;

        public IngredientRepository(IIngredientContext ingredientcontext)
        {
            this.ingredientcontext = ingredientcontext;
        }

        public List<Ingredient> GetAllPizza()
        {
            return ingredientcontext.GetAllIngredienten();
        }
    }
}
