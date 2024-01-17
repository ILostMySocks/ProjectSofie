using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLMyHealthApp.Dtos
{
    public class DayResultDto
    {
        public int Id { get; set; }
        public DateTime Today { get; set; }
        public int NumberOfFoods { get; set; }
        public int NumberOfWorkouts { get; set; }
        
    }
}
