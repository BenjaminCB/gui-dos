using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gui_dos.Models
{
    ///<summary>The 'Employee' class models an employee of IsVaerftet. </summary>
    [Table("employees")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        ///<summary>Gets or sets the first name of the employee. </summary>
        public string FirstName { get; set; }

        ///<summary>Gets or sets the last name of the employee. </summary>
        public string LastName { get; set; }

        ///<summary>Gets or sets the username of the employee. </summary>
        public string Username { get; set; }

        ///<summary>Gets or sets the password hash of the employee. </summary>
        public string PasswordHash { get; set; }

        ///<summary>Gets or sets the ownership status of the employee. </summary>
        public bool IsOwner { get; set; }

        ///<summary>Constructs an employee object.
        ///</summary>
        public Employee()
        {
            IsOwner = false;
        }
    }
}
