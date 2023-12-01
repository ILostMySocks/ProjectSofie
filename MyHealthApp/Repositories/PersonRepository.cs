using MyHealthApp;
using MyHealthApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories
{
    public class PersonRepository
    {
        private readonly MyHealthAppContext _dbContext;
        private readonly DbSet<Person> _dbSet;


        public PersonRepository(MyHealthAppContext context)
        {
           _dbContext = context;
            _dbSet = _dbContext.Set<Person>();
        }

        public List<Person> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual Person GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public virtual int Create (Person person)
        {
            _dbSet.Add(person);
            SaveChanges();
            return person.Id;
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

        public virtual void Update(Person person)
        {
            _dbContext.Update(person);
            SaveChanges();
        }

    }
}
