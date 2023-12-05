using MyHealthApp;
using MyHealthApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHealthApp.Repositories.Interfaces;

namespace MyHealthApp.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        

         
        public PersonRepository(MyHealthAppContext context) : base(context)
        {
        }

        public Person SpecialGet(int id)
        {
            //Zoekt persoon EN zijn/haar calendar
            var result = _dbSet.Where(p => p.Id == id).Include(p => p.Calendar).FirstOrDefault();
            return result;
        }
        
    }
}
