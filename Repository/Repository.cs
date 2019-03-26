using GenericRepostiory.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepostiory.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DataContext _context;
        private IDbSet<T> dbEntity;

        public Repository()
        {
            _context = new DataContext();
            dbEntity = _context.Set<T>();   
        }

        public IEnumerable<T> Get()
        {
            return dbEntity.ToList();
        }

        public void Delete(int id)
        {
            T data = dbEntity.Find(id);
            dbEntity.Remove(data);
        }

       
        public T GetByID(int id)
        {
            return dbEntity.Find(id);
        }

        public void Insert(T data)
        {
            dbEntity.Remove(data);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T data)
        {
            _context.Entry(data).State = EntityState.Modified;
        }
    }
}
