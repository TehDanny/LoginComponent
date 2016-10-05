using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("NameOfTestAssembly")]
namespace LoginComponent
{
    class Verify : IVerify // Helper class
    {
        public void CheckEmail()
        {
            throw new NotImplementedException();
        }

        public void CheckPassword()
        {
            throw new NotImplementedException();
        }

        public void ConfirmPassword()
        {
            throw new NotImplementedException();
        }
    }
}
