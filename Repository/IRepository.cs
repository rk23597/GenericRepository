using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepostiory.Repository
{
    public interface IRepository<T> where T : class
    {

        IEnumerable<T> Get();

        T GetByID(int id);

        void Insert(T data);

        void Delete(int id);

        void Update(T data);

        void Save();




    }
}
