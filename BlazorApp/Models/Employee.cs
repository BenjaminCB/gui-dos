using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public bool IsOwner { get; set; }

        // TODO
        public bool CheckPassword(string password)
        {
            return true;
        }
    }
}
