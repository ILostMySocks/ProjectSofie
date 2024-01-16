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
                calendar.Days.Add(day);
            }
        }
    }
}
