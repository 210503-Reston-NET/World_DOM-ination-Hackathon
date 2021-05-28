using System.Collections.Generic;
using Models;
namespace DL
{
    public interface IRecipeDL
    {
        List<Recipe> GetAllRecipies();

        Recipe AddRecipe(Recipe recipe);

        Recipe GetRecipe(Recipe recipe);
        List<Recipe> GetRecipesByName(string recipe);
        //Recipe GetRecipesByTag(int tagKey);

        //List<Recipe> GetRecipeByAuthor(AppUser author);
    }
}