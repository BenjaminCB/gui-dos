using System.Collections.Generic;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gui_dos.Models
{
    ///<summary>The 'Product' class models a product for sale by IsVaerftet. </summary>
    [Table("products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        ///<summary>Gets or sets the title of the product. </summary>
        public string Title { get; set; }

        ///<summary>Gets or sets the description of the product. </summary>
        public string Description { get; set; }

        ///<summary>Gets or sets the price of the product. </summary>
        public double Price { get; set; }

        ///<summary>Gets or sets the image of the product. </summary>
        public string Image { get; set; }

        ///<summary>Gets or sets the list of all changes made to the product. </summary>
        public List<Change> Changelog { get; set; }

        ///<summary>Construct a product object.
        ///<param name="title"> the title of the product. </param>
        ///<param name="description"> the description of the product. </param>
        ///<param name="image"> the image of the product. </param>
        ///</summary>
        public Product(string title, string description, double price, string image)
        {
            Title = title;
            Description = description;
            Price = price;
            Image = image;
            Changelog = new List<Change>();
        }
    }
}
