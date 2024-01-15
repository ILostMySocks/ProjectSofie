using BLMyHealthApp.Dtos;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLMyHealthApp.Managers.Interfaces
{
    public interface IPersonManager
    {
        List<PersonSearchResultDto> GetPersonSearch(PersonSearchValuesDto personQuery);
        void Add(Person Person);
    
    }

}
