using System.Text.Json;

namespace BlazorApp.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
