using MyHealthApp.Entities;
using MyHealthApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDALMyHealthApp.Repositories.Interfaces
{
    public interface ICalendarRepository : IGenericRepository<Calendar>
    {
        Calendar GetCalendarByPersonId(int personId);
        Calendar GetCalendarById(int calendarId);
        Day AddDayToCalendar(int calendarId, DateTime today);
        void AddFoodToDay(int calendarId, int dayId, Food food);
        void AddWorkoutToDay(int calendarId, int dayId, Workout workout);
    }
}
