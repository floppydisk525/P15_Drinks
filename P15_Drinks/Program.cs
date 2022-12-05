// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Text.Json;

namespace P15_Drinks
{
    class Program 
    {
        static void Main()
        {
            UserInput userInput = new();

        }
    }
}






/*  ----This was from the WebapiClient Microsoft exmaple.  keeping text for now :-(  
           //Console.WriteLine("Hello, World!");
           using HttpClient client = new();
           client.DefaultRequestHeaders.Accept.Clear();
           client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
           client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

           var categories = await ProcessRepositoriesAsync(client);
           foreach (var cat in categories)
           {
               Console.WriteLine($"CategoryName: {cat.CategoryName}");
           }

           static async Task<List<Category>> ProcessRepositoriesAsync(HttpClient client)
           {
               await using Stream stream =
                   await client.GetStreamAsync("https://www.thecocktaildb.com/api/json/v1/1/");
               //await client.GetStreamAsync("https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");
               var repositories =
                   await JsonSerializer.DeserializeAsync<List<Category>>(stream);
               return repositories ?? new();
           }
           */