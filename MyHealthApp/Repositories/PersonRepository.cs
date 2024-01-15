using EFDALMyHealthApp;
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

        public void Add(Person person)
        {
            _dbContext.Add(person);
        }

        
    }
}
