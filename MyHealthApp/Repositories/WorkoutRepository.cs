using Microsoft.EntityFrameworkCore;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories
{
    public class WorkoutRepository
    {
        private readonly MyHealthAppContext _dbContext;
        private readonly DbSet<Workout> _dbSet;


        public WorkoutRepository(MyHealthAppContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Workout>();
        }

        public List<Workout> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual Workout GetById(int id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public virtual int Create(Workout workout)
        {
            _dbSet.Add(workout);
            SaveChanges();
            return workout.Id;
        }

        

        public virtual void Update(Workout workout)
        {
            _dbContext.Update(workout);
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
