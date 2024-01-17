using BLMyHealthApp.Dtos;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLMyHealthApp.Managers.Interfaces
{
    public interface ICalendarManager
    {
        Calendar GetCalendarByPersonId(int personId);
        Calendar GetCalendarById(int calendarId);
        Day AddDayToCalendar(int calendarId, DateTime day);
        List<DayResultDto> GetDayResult(List<Day> dayQuery);
        void AddFoodToDay(int calendarId, int dayId, Food food);
        void AddWorkoutToDay(int calendarId, int dayId, Workout workout);

    }
}
