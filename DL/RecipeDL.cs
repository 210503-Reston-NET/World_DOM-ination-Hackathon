using System.Collections.Generic;
using Models;
namespace DL
{
    public class RecipeDL : IRecipeDL
    {
        //To DO: Implement methods pulling from DB
          public List<Recipe> GetAllRecipies()
        {
            return new List<Recipe>();
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            return new Recipe();
        }
        
        public Recipe GetRecipe(Recipe recipe)
        {
            return new Recipe();
        }
        public Recipe GetRecipeByName(string recipe)
        {
            return new Recipe();
        }
        public Recipe GetRecipeByTag()
        {
            return new Recipe();
        }

        public List<Recipe> GetRecipeByAuthor(AppUser author)
        {
            return new List<Recipe>();
        }
    }
}