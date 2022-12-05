// See https://aka.ms/new-console-template for more information
namespace P15_Drinks
{
    public class UserInput
    {
        DrinksService drinksService = new();

        internal void GetCategoriesInput()
        {
            drinksService.GetCategories();
            Console.WriteLine("Choose Category:");
            string category = Console.ReadLine();

            while(!Validator.IsStringValid(category))
            {
                Console.WriteLine("\nInvalid Category");
                category= Console.ReadLine();
            }

            GetDrinksInput(category);

        }

        private void GetDrinksInput(string category)
        {
            drinksService.GetDrinksByCategory(category);
        }
    }
}

//finished at 11:33.  
//https://www.youtube.com/watch?v=fc7peZ-FHs4 