using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gui_dos.Models
{
    [Table("changes")]
    public class Change
    {
        [Key]
        public int ChangeId { get; set; }
        public DateTime Date { get; set; }
        public string ChangeMade { get; set; }
        public Employee Employee { get; set; }
        // TODO: Implement ToString for Change
        public override string ToString()
        {

            return base.ToString();
        }
    }
}
