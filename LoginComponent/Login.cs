using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    public class Login : ILogin
    {
        private ILoginDataMapper ldm;

        public Login(ILoginDataMapper ldm)
        {
            this.ldm = ldm;
        }

        public void ChangeEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(string email)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(string email, string password, string confirmPassword)
        {
            Verify.CheckEmail(email);
            Verify.CheckPassword(password);
            Verify.ConfirmPassword(password, confirmPassword);
            int hashedPassword = Security.HashPassword(password);
            User u = new User(email, hashedPassword);
        }

        public void DeleteUser(string email)
        {
            throw new NotImplementedException();
        }

        public void LoginUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
