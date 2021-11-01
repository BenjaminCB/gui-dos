using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Forms
{
    public class ProductForm
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name too long max length is 10")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
