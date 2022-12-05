// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using P15_Drinks.Models;
using RestSharp;

namespace P15_Drinks
{
    public class DrinksService
    {
        public void GetCategories() 
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/");
            var request = new RestRequest("list.php?c=list");
            var response = client.ExecuteAsync(request);

            if(response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Result.Content;
                var serialize = JsonConvert.DeserializeObject<Categories>(rawResponse);

                List<Category> returnedList = serialize.CategoriesList;

                Console.Clear();
                TableVisualizationEngine.ShowTable(returnedList, "Categories Menu");
            }
        }
    }
}