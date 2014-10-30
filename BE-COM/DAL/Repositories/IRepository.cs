using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByName(string pnombre);
        IEnumerable<T> GetAllInactive();
        T GetById(int id);
        void Save();
        void Clear();



    }
}
