using System.Text.Json.Serialization;

namespace aspClientApp.Models
{
    
    public class ProductDTO
    {
        [JsonPropertyName("productId")]
        public int ProductId { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }

}