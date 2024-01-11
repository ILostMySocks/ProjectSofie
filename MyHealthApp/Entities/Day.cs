using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Entities
{
    public class Day : BaseEntity
    {
        public DateTime Today { get; set; }
        public List<Food> Foods { get; set; }
        public List<Workout> Workouts { get; set; }
        public Calendar Calendar { get; set; }

    }
}
