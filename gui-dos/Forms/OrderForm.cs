using System;
using System.ComponentModel.DataAnnotations;

namespace gui_dos.Forms 
{
    public class OrderForm 
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        public string Comment { get; set; }
    }
}