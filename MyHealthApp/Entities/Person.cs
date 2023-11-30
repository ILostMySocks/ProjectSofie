using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderIdentity GenderIdentity { get; set; }
        public Calendar MyHealthCalendar { get; set; }
    }

    public enum GenderIdentity
    {
        Male,
        Female,
        X,
        Unspecified
    }
}
