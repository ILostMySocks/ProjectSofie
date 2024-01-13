using BLMyHealthApp.Dtos;
using BLMyHealthApp.Managers.Interfaces;
using MyHealthApp.Entities;
using MyHealthApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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


        public override int Add(Person person)
        {
            if (person == null)
                throw new ArgumentNullException(nameof(person));

            if(person.BirthDate < new DateTime(1900,1,1))
                throw new ArgumentOutOfRangeException(nameof(person.BirthDate));

            return base.Add(person);
            
        }

        public List<PersonSearchResultDto> GetPersonSearch(PersonSearchValuesDto personQuery)
        {
            List<Expression<Func<Person, bool>>> searchExpression = new();

            if (personQuery?.FirstName != null)
                searchExpression.Add(p => p.FirstName == personQuery.FirstName);

            if (personQuery?.LastName != null)
                searchExpression.Add(p => p.LastName == personQuery.LastName);

            if (personQuery?.Email != null)
                searchExpression.Add(p => p.Email == personQuery.Email);



            var searchResults = _repository.Search(searchExpression, p => p.LastName);

            var result = searchResults.Select(ps => new PersonSearchResultDto()
            {
                Name = $"{ps.LastName} {ps.FirstName}",
                Id = ps.Id,
                Email = $"{ps.Email}"
            }).ToList();

            return result;
        }

    }
}
