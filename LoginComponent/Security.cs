using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    static class Security // Helper class
    {
        public static int HashPassword(string password)
        {
            return password.GetHashCode();
        }
    }
}
