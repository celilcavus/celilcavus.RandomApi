using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T item);
        void Del(int? id);
        void Update(T item);
        List<T> All();
        T Get(int? id);
    }
}
