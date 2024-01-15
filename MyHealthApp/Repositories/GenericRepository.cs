using Microsoft.EntityFrameworkCore;
using MyHealthApp.Entities;
using MyHealthApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        internal readonly DbContext _dbContext;
        internal readonly DbSet<TEntity> _dbSet;

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

        public virtual void Add(TEntity entity)
        {
            entity.LastUpdate = DateTime.Now;
            _dbSet.Add(entity);
            _dbContext.SaveChangesAsync();
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

        public virtual List<TEntity> Search(List<Expression<Func<TEntity, bool>>> filters, Expression<Func<TEntity, object>> orderExpression, bool orderAsc = true)
        {
            var queryAble = _dbSet.AsQueryable();

            filters ??= new();

            foreach (var filter in filters)
            {
                if (filter == null) continue;
                queryAble = queryAble.Where(filter);
            }

            queryAble = orderAsc ? queryAble.OrderBy(orderExpression) : queryAble.OrderByDescending(orderExpression);

            var result = queryAble.ToList();

            return result;
        }
    }
}
