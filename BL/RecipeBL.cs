using System;
using System.Collections.Generic;
using Models;
using DL;
namespace BL
{
    public class RecipeBL : IRecipeBL
    {
        private IRecipeDL _database;
        //To DO: implement calls to data layer
        public List<Recipe> GetAllRecipies()
        {
            return _database.GetAllRecipies();
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            if(_database.GetRecipe(recipe) != null)
            {
                throw new Exception("Recipe already exists. :<");
            }
            else
            return _database.AddRecipe(recipe);
        }
        public List<Recipe> GetRecipesByName(string recipe)
        {
            return _database.GetRecipesByName(recipe);
        }
       /* public Recipe GetRecipeByTag(int tagKey)
        {
            return _database.GetRecipeByTag(tagKey);
        }*/

        /*public List<Recipe> GetRecipeByAuthor(AppUser author)
        {
            return _database.GetRecipeByAuthor(author);
        }*/
    }
}