using Microsoft.EntityFrameworkCore;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories
{
    public class FoodRepository
    {
        private readonly MyHealthAppContext _dbContext;
        private readonly DbSet<Food> _dbSet;


        public FoodRepository(MyHealthAppContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Food>();
        }

        public List<Food> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual Food GetById(int id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public virtual int Create(Food food)
        {
            _dbSet.Add(food);
            SaveChanges();
            return food.Id;
        }

        

        public virtual void Update(Food food)
        {
            _dbContext.Update(food);
            SaveChanges();
        }

        public void Delete(int id)
        {
            _dbSet.Where(x => x.Id == id).ExecuteDelete();
        }

        public void SaveChanges()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
