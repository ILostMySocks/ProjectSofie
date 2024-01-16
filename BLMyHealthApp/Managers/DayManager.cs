using BLMyHealthApp.Managers.Interfaces;
using EFDALMyHealthApp.Repositories.Interfaces;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLMyHealthApp.Managers
{
    public class DayManager : IDayManager
    {
        private readonly ICalendarRepository _calendarRepository;

        public DayManager(ICalendarRepository calendarRepository)
        {
            _calendarRepository = calendarRepository;
        }

        public void AddFoodToDay(int calendarId, int dayId, Food food)
        {
            _calendarRepository.AddFoodToDay(calendarId, dayId, food);
        }

        public void AddWorkoutToDay(int calendarId, int dayId, Workout workout)
        {
            _calendarRepository.AddWorkoutToDay(calendarId, dayId, workout);
        }
    }
}
