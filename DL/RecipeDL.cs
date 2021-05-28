using System.Collections.Generic;
using Models;
using System.Linq;
namespace DL
{
    public class RecipeDL : IRecipeDL
    {
        private RecipeBookDBContext _context;

        public RecipeDL(RecipeBookDBContext context)
        {
            _context = context;
        }
        public List<Recipe> GetAllRecipies()
        {
            List<Recipe> recipes = new List<Recipe>();
            foreach (Recipe r in _context.Recipes)
            {
                recipes.Add(r);
            }
            return recipes;
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            return recipe;
        }
        
        public Recipe GetRecipe(Recipe recipe)
        {
            int wantedId = recipe.ID;
            List<Recipe> recipes = new List<Recipe>();
            foreach (Recipe r in _context.Recipes)
            {
                recipes.Add(r);
            }
            Recipe wantedRecipe = (from r in recipes
                                   where r.ID == recipe.ID
                                   select r).FirstOrDefault();
            return wantedRecipe;
        }
        public List<Recipe> GetRecipesByName(string recipe)
        {
            List<Recipe> recipes = new List<Recipe>();
            foreach (Recipe r in _context.Recipes)
            {
                if (r.Name == recipe)
                    recipes.Add(r);
            }
            return recipes;
        }
        /*public List<Recipe> GetRecipeByTag(int tagKey)

        {
            return new Recipe();
        }*/

        /*public List<Recipe> GetRecipeByAuthor(AppUser author)
        {
            return new List<Recipe>();
        }*/
    }
}