using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace gui_dos.Models
{
    ///<summary>The 'GiftBasket' class models a gift-basket for an order. </summary>
    [Table("giftbaskets")]
    public class GiftBasket
    {
        [Key]
        public int GiftBasketId { get; set; }

        public string Title { get; set; }

        ///<summary>Gets or sets the status of the gift-basket. </summary>
        public GiftBasketStatus Status { get; set; }

        ///<summary>Gets or sets the comment on the gift-basket. </summary>
        public string Comment { get; set; }

        ///<summary>Gets or sets the price on the gift-basket. </summary>
        public int Price { get; set; }

        ///<summary> Constructs a gift-basket object.
        ///<param name="comment"> the comment for the particular gift-basket. </param>
        ///<param name="price"> the price of the gift basket in danske oere. </param>
        ///</summary>
        public GiftBasket(string title, string comment, int price)
        {
            Title = title;
            Comment = comment;
            Price = price;
            Status = GiftBasketStatus.Pending;
        }
    }
}
