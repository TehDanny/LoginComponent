using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    public class User : IUser
    {
        public string Email { get; set; }
        public int HashedPassword { get; set; }
        public User(string email, int hashedPassword)
        {
            Email = email;
            HashedPassword = hashedPassword;
        }
    }
}
