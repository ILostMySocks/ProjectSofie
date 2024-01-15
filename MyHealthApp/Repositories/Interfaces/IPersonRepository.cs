using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories.Interfaces
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        void Add (Person person);
    }
}
