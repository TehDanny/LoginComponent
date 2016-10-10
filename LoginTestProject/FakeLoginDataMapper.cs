using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginComponent;

namespace LoginTestProject
{
    class FakeLoginDataMapper : LoginComponent.ILoginDataMapper
    {
        public void Create(User obj)
        {
        }

        public void Delete(User obj)
        {
        }

        public User Read(int key)
        {
            throw new NotImplementedException();
        }

        public void Update(User obj)
        {
        }
    }
}
