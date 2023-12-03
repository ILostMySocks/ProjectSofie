using Microsoft.EntityFrameworkCore;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories
{
    public class DayRepository
    {
        private readonly MyHealthAppContext _dbContext;
        private readonly DbSet<Day> _dbSet;


        public DayRepository(MyHealthAppContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Day>();
        }

        public List<Day> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual Day GetById(int id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public virtual int Create(Day day)
        {
            _dbSet.Add(day);
            SaveChanges();
            return day.Id;
        }

        

        public virtual void Update(Day day)
        {
            _dbContext.Update(day);
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
