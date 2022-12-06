using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace P15_Drinks.Models
{
    //public record class Category(
    //    [property: JsonPropertyName("strCategory")] string CategoryName);
    public class Category
    {
        public string strCategory { get; set; }
    }

    public class Categories
    {
        [JsonProperty("drinks")]
        public List<Category> CategoriesList { get; set; }
    }
}