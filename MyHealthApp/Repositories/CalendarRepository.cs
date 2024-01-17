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
        public Calendar GetCalendarByPersonId(int personId)
        {
            return _dbSet.FirstOrDefault(c => c.PersonId == personId);
        }

        public Calendar GetCalendarById(int calendarId)
        {
            return _dbSet.Find(calendarId);
        }
        public Day AddDayToCalendar(int calendarId, DateTime day)
        {
            var calendar = _dbSet.Find(calendarId);

            if (calendar.Days == null)
            {
                calendar.Days = new List<Day>();
            }

            var existingDay = calendar.Days.FirstOrDefault(d => d.Today.Date == day.Date);

            if (existingDay == null)
            {
                Day newDay = new Day()
                {
                    Today = day
                };

                calendar.Days.Add(newDay);
                SaveChanges();
                return newDay;

            } else return existingDay;


        }
        public void AddFoodToDay(int calendarId, int dayId, Food food)
        {
            var calendar = _dbSet.Find(calendarId);
            var day = calendar?.Days.FirstOrDefault(d => d.Id == dayId);

            if (day != null)
            {
                if (day.Foods == null)
                    day.Foods = new List<Food>();
                day.Foods.Add(food);
            }
            SaveChanges();
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
