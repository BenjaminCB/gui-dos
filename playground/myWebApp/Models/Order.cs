namespace myWebApp.Models
{
    public class Order
    {
        public int Price { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public static int Id { get; set; }
    }
}
