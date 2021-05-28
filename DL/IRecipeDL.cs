using System.Collections.Generic;
using Models;
namespace DL
{
    public interface IRecipeDL
    {
         List<Recipe> GetAllRecipies();

        Recipe AddRecipe(Recipe recipe);

        Recipe GetRecipe(Recipe recipe);
        Recipe GetRecipeByName(string recipe);
        Recipe GetRecipeByTag();

        List<Recipe> GetRecipeByAuthor(AppUser author);
    }
}