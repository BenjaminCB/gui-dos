using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace gui_dos.Models
{
    [Table("giftbaskets")]
    public class GiftBasket
    {
        [Key]
        public int GiftBasketId { get; set; }
        public GiftBasketStatus Status { get; set; }
        public string Comment { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }
    }
}
