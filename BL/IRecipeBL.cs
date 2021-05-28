using System;
using System.Collections.Generic;
using Models;
namespace BL
{
    public interface IRecipeBL
    {
        List<Recipe> GetAllRecipies();

        Recipe AddRecipe(Recipe recipe);

        Recipe GetRecipeByName(string recipe);
        Recipe GetRecipeByTag();

        List<Recipe> GetRecipeByAuthor(AppUser author);
    }
}