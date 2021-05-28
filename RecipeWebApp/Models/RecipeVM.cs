using Models;
using System;

public class RecipeVM
{
	public int ID { get; set; }

	public string Name { get; set; }

	public string Origin { get; set; }

	public double CalorieCount { get; set; }

	public int Servings { get; set; }
	public RecipeVM(Recipe recipe)
	{
		this.ID = recipe.ID;
		this.Name = recipe.Name;
		this.Origin = recipe.Origin;
		this.CalorieCount = recipe.CalorieCount;
		this.Servings = recipe.Servings;


	}
}

