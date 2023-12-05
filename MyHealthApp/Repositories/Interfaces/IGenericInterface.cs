using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        int Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        void SaveChanges();
    }
}
