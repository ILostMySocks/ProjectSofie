using BLMyHealthApp.Managers.Interfaces;
using MyHealthApp.Entities;
using MyHealthApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLMyHealthApp.Managers
{
    public class PersonManager : GenericManager<Person>, IPersonManager
    {
        private IPersonRepository _personRepository;
        public PersonManager(IPersonRepository personRepository) : base(personRepository)
        {
        }

        public int Test(int a, int b)
        { 
            return a * b;
        }

        public override int Add(Person person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            if(person.BirthDate < new DateTime(1900,1,1))
                throw new ArgumentOutOfRangeException(nameof(person.BirthDate));

            return base.Add(person);
            
        }

    }
}
