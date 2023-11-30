using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Entities
{
    public class Calendar
    {
        public int Id { get; set; }
        public List<Day> MyHealthyDays { get; set; }
        public Person MyHealthyPerson { get; set; }
        public int MyHealthyPersonId { get; set; }



    }
}
