using System.Collections.Generic;
using gui_dos.Models;

namespace gui_dos.Data
{
    public class ShoppingCart
    {
        public List<GiftBasket> GiftBaskets { get; set; }
        public double TotalPrice
        {
            get
            {
                double res = 0;
                foreach (var item in GiftBaskets)
                {
                    res += item.Price;
                }
                return res;
            }
        }

        public ShoppingCart()
        {
            GiftBaskets = new List<GiftBasket>();
        }
    }
}
