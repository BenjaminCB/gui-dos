using System;
using System.ComponentModel.DataAnnotations;

namespace gui_dos.Forms 
{
    public class OrderForm
    {
        [Required]
        [StringLength(50, ErrorMessage = "Fornavn m� ikke v�re l�ngere end 50 krakterer")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Efternavn m� ikke v�re l�ngere end 50 krakterer")]
        public string LastName { get; set; }

        [Required]
        // [\w.-]+ capture atleast one letter number or .-_
        // ([^\W-])+ capture at least one letter or number
        // (\.([^\W_]|[.-])+)+ capture at least one . followed by atleast one
        [RegularExpression((@"^[\w.-]+@([^\W_])+-*(\.([^\W_]|[.-])+)+([^\W_])+$"), ErrorMessage = "Skal v�re en gyldig Email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression((@"^\d{8}?"), ErrorMessage = "Skal v�re et gyldigt Telefon nr.")]
        public string PhoneNumber { get; set; }

        [Required] public DateTime? Date { get; set; }

        public string Comment { get; set; }
    }
}