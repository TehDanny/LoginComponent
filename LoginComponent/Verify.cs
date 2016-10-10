using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("NameOfTestAssembly")]
namespace LoginComponent
{
    class Verify // Helper class
    {
        public static void CheckEmail(string email)
        {
            throw new NotImplementedException();
        }

        public static void CheckPassword(string password)
        {
            if (password.Length == 0)
                throw new Exception("Password is null.");

            if (password.Length<8)
                throw new Exception("Password is too short.");

            int capitalLetters = 0;
            int numbers = 0;
            foreach (char character in password)
            {
                if (char.IsUpper(character))
                    capitalLetters++;
                if (char.IsNumber(character))
                    numbers++;
            }
            if (capitalLetters == 0)
                throw new Exception("Password doesn't have at least one capital letter.");
            if (numbers == 0)
                throw new Exception("Password doesn't have at least one number.");
        }

        public static void ConfirmPassword(string password, string confirmPassword)
        {
            if (password != confirmPassword)
                throw new Exception("Password doesn't match with confirm password.");
        }
    }
}
