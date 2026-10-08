using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal interface IRepository<T> where T : IDomainObject
    {
        void Create(T obj);

        void Delete(T obj);

        IEnumerable<T> ReadAll();

        T ReadById(int id);

        void Update(T obj);
    }
}
