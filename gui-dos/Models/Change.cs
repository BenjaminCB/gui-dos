using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gui_dos.Models
{
    public class Change
    {
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
