using EFDALMyHealthApp.Repositories.Interfaces;
using MyHealthApp.Entities;
using MyHealthApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDALMyHealthApp.Repositories
{
    public class CalendarRepository : GenericRepository<Calendar>, ICalendarRepository
    {
        public CalendarRepository(MyHealthAppContext context) : base(context)
        {
        }

        // Implement the method to get calendars by person id
        public IQueryable<Calendar> GetCalendarByPersonId(int personId)
        {
            return _dbSet.Where(c => c.PersonId == personId);
        }
        public void AddDayToCalendar(int calendarId, Day day)
        {
            var calendar = _dbSet.Find(calendarId);
            if (calendar != null)
            {
                var existingDay = calendar.Days.FirstOrDefault(d => d.Today.Date == day.Today.Date);

                if (existingDay == null)
                {
                    calendar.Days.Add(day);
                }
            }
        }
        public void AddFoodToDay(int calendarId, int dayId, Food food)
        {
            var calendar = _dbSet.Find(calendarId);
            var day = calendar?.Days.FirstOrDefault(d => d.Id == dayId);

            if (day != null)
            {
                day.Foods.Add(food);
            }
        }

        public void AddWorkoutToDay(int calendarId, int dayId, Workout workout)
        {
            var calendar = _dbSet.Find(calendarId);
            var day = calendar?.Days.FirstOrDefault(d => d.Id == dayId);

            if (day != null)
            {
                day.Workouts.Add(workout);
            }
        }
    }
}
