namespace myWebApp.Models
{
    public class Employee
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public bool isOwner { get; set; }

        // TODO
        public bool CheckPassword(string password)
        {
            return true;
        }
    }
}
