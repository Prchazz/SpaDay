using System;
namespace SpaDay.Models
{
    public class User
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        
        public User(string username, string password, string email)
        {
            this.UserName = username;
            this.Password = password;
            this.Email = email;
        }

        public User()
        {

        }
    }
}
