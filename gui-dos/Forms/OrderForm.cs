using System;
using System.ComponentModel.DataAnnotations;

namespace gui_dos.Forms 
{
    public class OrderForm
    {
        [Required]
        [StringLength(50, ErrorMessage = "Fornavn må ikke være længere end 50 krakterer")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Efternavn må ikke være længere end 50 krakterer")]
        public string LastName { get; set; }

        [Required]
        // [\w.-]+ capture atleast one letter number or .-_
        // ([^\W-])+ capture at least one letter or number
        // (\.([^\W_]|[.-])+)+ capture at least one . followed by atleast one
        [RegularExpression((@"^[\w.-]+@([^\W_])+-*(\.([^\W_]|[.-])+)+([^\W_])+$"), ErrorMessage = "Skal være en gyldig Email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression((@"^\d{8}?"), ErrorMessage = "Skal være et gyldigt Telefon nr.")]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime? Date { get; set; } = DateTime.Now;

        [StringLength(500, ErrorMessage = "Din kommentar må ikke være over 500 tegn")]
        public string Comment { get; set; }
    }
}