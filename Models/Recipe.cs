namespace Models
{
    public class Recipe
    {
    public int ID { get; set; }

	public string Name { get; set; }

	public string Origin { get; set; }

	public double CalorieCount { get; set; }

	public int Servings { get; set; }

    public bool Vegetarian {get; set;}
    public bool Vegan {get; set;}

    public int AuthorID{ get; set; }
    }
}