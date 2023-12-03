using Microsoft.EntityFrameworkCore;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories
{
    public class CalendarRepository
    {
        private readonly MyHealthAppContext _dbContext;
        private readonly DbSet<Calendar> _dbSet;


        public CalendarRepository(MyHealthAppContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Calendar>();
        }

        public List<Calendar> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual Calendar GetById(int id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public virtual int Create(Calendar calendar)
        {
            _dbSet.Add(calendar);
            SaveChanges();
            return calendar.Id;
        }

        

        public virtual void Update(Calendar calendar)
        {
            _dbContext.Update(calendar);
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
