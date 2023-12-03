using Microsoft.EntityFrameworkCore;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories
{
    public class GenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            return _dbSet.FirstOrDefault(db => db.Id == id); // dit lukt dankzij : BaseEntity constraint
        }

        public virtual List<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public virtual int Add(TEntity entity)
        {
            entity.LastUpdate = DateTime.Now;
            _dbSet.Add(entity);
            _dbContext.SaveChangesAsync();

            return entity.Id;
        }

        public virtual void Update(TEntity entity)
        {
            entity.LastUpdate = DateTime.Now;
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            _dbSet.Where(x => x.Id == id).ExecuteDelete();
        }

        public virtual void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
