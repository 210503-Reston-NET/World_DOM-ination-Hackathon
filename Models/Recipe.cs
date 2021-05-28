namespace Models
{
    public class Recipe
    {
    public int ID { get; set; }

	public string Name { get; set; }

	public string Origin { get; set; }

	public double CalorieCount { get; set; }

	public int Servings { get; set; }
		public Recipe() { }
		public Recipe(int id, string name, string origin, double calorieCount, int serving)
		{
			this.ID = ID;
			this.Name = name;
			this.Origin = origin;
			this.CalorieCount = calorieCount;
			this.Servings = serving;


		}
	}
}