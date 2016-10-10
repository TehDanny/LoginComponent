using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    interface ILogin
    {
        void LoginUser(string email, string password);
        void CreateUser(string email, string password, string confirmPassword);
        void DeleteUser(string email);
        void ChangeEmail(string email);
        void ChangePassword(string email);
    }
}
