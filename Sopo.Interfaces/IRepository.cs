using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sopo.Interfaces
{
    public interface IRepository<T> where T : class , new()
    {
        T Fetch(int id);

        IEnumerable<T> Set();

        void Save(T entity);

        void Delete(int id);

        void Delete(T entity);
    }
}
