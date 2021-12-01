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

        ///<summary>Gets the string description of the comitted change. </summary>
        public string ChangeString { get; set; }

        ///<summary>Gets the Employee name who comitted the change. </summary>
        public string Name { get; set; }

        public Change(string date, string changeString, string name)
        {
            Date = date;
            ChangeString = changeString;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ChangeString} den {Date} af {Name}";
        }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType()) {
                return false;
            }
            Change c = (obj as Change);
            return (ChangeId == c.ChangeId && Date == c.Date && ChangeString == c.ChangeString && Name == c.Name);
        }

        public override int GetHashCode()
        {
            return ChangeId.GetHashCode() ^ Date.GetHashCode() ^ ChangeString.GetHashCode() ^ Name.GetHashCode();
        }
    }
}
