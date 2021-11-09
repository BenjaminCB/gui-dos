using System.Collections.Generic;
using gui_dos.Models;

namespace gui_dos.Data
{
    public class ShoppingCart
    {
        public List<GiftBasket> GiftBaskets { get; set; }

        public ShoppingCart()
        {
            GiftBaskets = new List<GiftBasket>();
        }
    }
}
