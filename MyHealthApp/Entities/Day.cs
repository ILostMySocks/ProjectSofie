using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDal.Entities
{
    public class Day
    {
        public int Id { get; set; }
        public DateTime Today { get; set; }
        public List<Food> MyFoodToday { get; set; }
        public List<Workout> MyWorkoutsToday { get; set; }


    }
}
