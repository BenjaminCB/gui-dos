using System.ComponentModel.DataAnnotations;

namespace gui_dos.Forms
{
    public class ProductForm
    {
        [Required]
        [StringLength(50, ErrorMessage = "Title is too long max length is 50")]
        public string Title { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Description is too long max length is 300")]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        public string Tags { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
