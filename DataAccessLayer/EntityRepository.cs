using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class EntityRepository<T> : IRepository<T> where T : class, IDomainObject
    {
        private DBContext _context;
        public void Create(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();

        }

        public void Update(T obj)
        {
            var oldFigure = _context.Set<T>().FirstOrDefault(i => i.Id ==  obj.Id);
            _context.Entry(oldFigure).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }

        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<T> ReadAll() { return _context.Set<T>(); }

        public T ReadById(int id) { return _context.Set<T>().FirstOrDefault(i => i.Id == id); }

        public EntityRepository()
        {
            _context = new DBContext();
        } 
    }
}
