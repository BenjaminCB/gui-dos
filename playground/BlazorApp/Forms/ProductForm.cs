using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Forms
{
    public class ProductForm
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name is too long (max is 50)")]
        public string Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Description is too long (max is 500)")]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
