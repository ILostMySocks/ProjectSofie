using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDal.Entities
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderIdentity GenderIdentity { get; set; }

        public Calendar HealthCalendar { get; set; }

    }

    public enum GenderIdentity
    {
        Male,
        Female,
        X,
        Unspecified
    }
}
