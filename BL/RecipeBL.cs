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
                throw new Exception("Restaurant already exists :<");
            }
            else
            return _database.AddRecipe(recipe);
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