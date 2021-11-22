using System.Collections.Generic;
using System.Linq;
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

        public double Total 
        {
            get
            {
                return GiftBaskets.Aggregate(0d, (acc, gb) => acc + gb.Price);
            }
        }

        public ShoppingCart()
        {
            GiftBaskets = new List<GiftBasket>();
        }
    }
}
