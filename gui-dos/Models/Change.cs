using System;
using System.Collections.Generic;

namespace gui_dos.Models
{
    ///<summary>The Change class models a change made to an order or product. </summary>
    public class Change
    {
        ///<summary>Gets the DateTime object of the comitted change. </summary>
        public DateTime Date { get; }

        ///<summary>Gets or sets the string description of the comitted change. </summary>
        public string ChangeMade { get; set; }

        ///<summary>Gets the Employee who comitted the change. </summary>
        public Employee Employee { get; }

        ///<summary>Constructs a Change object.
        ///<param name="changeString"> the string description of the comitted change. </param>
        ///</summary>
        public Change(string changeString)
        {
            Date = DateTime.Now;
            ChangeMade = changeString;
            //Find ud af om employee skal føres over som parameter,
            //eller om der er en global variable der holder current employee
        }

        ///<summary>Converts the Change object to a string. </summary>
        public override string ToString()
        {
            return $"{ChangeMade} was changed at {Date.ToShortDateString()} by {Employee.Username}";
        }
    }
}