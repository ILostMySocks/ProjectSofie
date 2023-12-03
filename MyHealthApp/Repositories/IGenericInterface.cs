using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories
{
    public interface IGenericRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        int Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void SaveChanges();
    }
}
