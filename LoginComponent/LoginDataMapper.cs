﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    public class LoginDataMapper : ILoginDataMapper
    {
        private string connectionString;

        public LoginDataMapper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(User obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public User Read(int key)
        {
            throw new NotImplementedException();
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
