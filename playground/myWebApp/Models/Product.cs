using System.Text.Json;
using System.Text.Json.Serialization;

namespace myWebApp.Models
{
    public class Product
    {
        [JsonPropertyName("Img")]
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
