using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace gui_dos.Models
{
    ///<summary>The 'Change' class models a change made to an order or product. </summary>
    [Table("changes")]
    public class Change
    {
        public Change(string changeString, Employee employee)
        {
            Date = DateTime.Now;
            ChangeMade = changeString;
            Employee = employee;
        }

        ///<summary>Converts the Change object to a string. </summary>
        public override string ToString()
        {
            return $"{ChangeMade} was changed at {Date.ToShortDateString()} by {Employee.Username}";
        }
    }
}
