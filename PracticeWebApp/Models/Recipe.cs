namespace PracticeWebApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string ingredients{ get; set; }

        public string cookingInstructions { get; set; }

        public string dishName { get; set; }

        public Recipe()
        {
                
        }
    }
}
