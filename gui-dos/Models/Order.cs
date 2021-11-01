using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace gui_dos.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public int Price { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime Deadline { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<GiftBasket> GiftBaskets { get; set; }
        public List<Change> Changelog { get; set; }
    }
}
