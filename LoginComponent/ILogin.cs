using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    interface ILogin
    {
        void LoginUser();
        void CreateUser();
        void DeleteUser();
        void ChangeEmail();
        void ChangePassword();
    }
}
