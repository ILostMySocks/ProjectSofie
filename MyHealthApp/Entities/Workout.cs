using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Entities
{
    public class Workout
    {
        public int Id { get; set; }
        public string WorkoutName { get; set; }

        public int CaloriesBurnt { get; set; }
    }
}
