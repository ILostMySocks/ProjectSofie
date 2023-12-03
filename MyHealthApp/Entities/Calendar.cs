using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Entities
{
    public class Calendar : BaseEntity
    {
        public List<Day> Days { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }



    }
}
