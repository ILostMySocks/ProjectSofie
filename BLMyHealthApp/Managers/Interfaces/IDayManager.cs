using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLMyHealthApp.Managers.Interfaces
{
    public interface IDayManager
    {
        void AddFoodToDay(int calendarId, int dayId, Food food);
        void AddWorkoutToDay(int calendarId, int dayId, Workout workout);
    }
}
