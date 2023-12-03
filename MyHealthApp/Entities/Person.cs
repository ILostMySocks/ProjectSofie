using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Entities
{
    public class Person : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderIdentity GenderIdentity { get; set; }
        public string Email {  get; set; }
        public Calendar Calendar { get; set; }
    }

    public enum GenderIdentity
    {
        Male,
        Female,
        X,
        Unspecified
    }
}
