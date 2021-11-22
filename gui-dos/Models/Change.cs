using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gui_dos.Models
{
    ///<summary>The 'Change' class models a change made to an order or product. </summary>
    [Table("changes")]
    public class Change
    {
        [Key]
        public int ChangeId { get; set; }

        ///<summary>Gets the DateTime object of the comitted change. </summary>
        public string Date { get; set; }

        ///<summary>Gets or sets the string description of the comitted change. </summary>
        public string ChangeString { get; set; }

        ///<summary>Gets the Employee who comitted the change. </summary>
        public string Name { get; set; }

        /// there should be a constructor as ef core implicitly uses them
        /// this creates a bug where the Date is always updated because we used
        /// DateTime.Now in the constructor

        ///<summary>Converts the Change object to a string. </summary>
        public override string ToString()
        {
            return $"{ChangeString}. At {Date} by {Name}";
        }
    }
}
