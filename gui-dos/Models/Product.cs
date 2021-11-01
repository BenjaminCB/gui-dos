using System.Collections.Generic;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gui_dos.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<Change> Changelog { get; set; }
        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
