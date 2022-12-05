using System.Text.Json.Serialization;

namespace P15_Drinks
{
    public record class Category(
        [property: JsonPropertyName("strCategory")] string CategoryName);
}