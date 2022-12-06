// See https://aka.ms/new-console-template for more information
namespace P15_Drinks
{
    public class UserInput
    {
        DrinksService drinksService = new();

        internal void GetCategoriesInput()
        {
            var categories = drinksService.GetCategories();
            Console.WriteLine("Choose Category:");
            string category = Console.ReadLine();

            while(!Validator.IsStringValid(category))
            {
                Console.WriteLine("\nInvalid Category");
                category= Console.ReadLine();
            }
            if (!categories.Any(x => x.strCategory == category))   //linq to check if a category entered matches the list (whoa!!!)
            {
                Console.WriteLine("Category doesn't exist.");
                GetCategoriesInput();
            }
            GetDrinksInput(category);
        }

        private void GetDrinksInput(string category)
        {
            var drinks = drinksService.GetDrinksByCategory(category);
            Console.WriteLine("Choose a drink or go back to catagory menu by typing 0:");
            string drink = Console.ReadLine();

            if (drink == "0") GetCategoriesInput();

            while (!Validator.IsIdValid(drink))
            {
                Console.WriteLine("\nInvalid Drink");
                drink = Console.ReadLine();
            }
            if (!drinks.Any(x => x.idDrink == drink))   //linq to check if a drink entered matches the list (whoa!!!)
            {
                Console.WriteLine("Drink doesn't exist.");
                GetDrinksInput(category);
            }
            drinksService.GetDrink(drink);

            Console.WriteLine("Press any key to go back to categories menu");
            Console.ReadKey();
            if (!Console.KeyAvailable) GetCategoriesInput();
        }
    }
}

//finished at 11:33.  
//https://www.youtube.com/watch?v=fc7peZ-FHs4 