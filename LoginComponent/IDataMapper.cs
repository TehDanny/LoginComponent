using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginComponent
{
    public interface IDataMapper<T>
    {
        void Create(T obj);
        T Read(int key);
        void Update(T obj);
        void Delete(T obj);
    }
}
