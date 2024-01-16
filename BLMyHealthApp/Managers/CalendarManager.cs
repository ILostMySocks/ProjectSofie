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
    public class CalendarManager : ICalendarManager
    {
        private readonly ICalendarRepository _calendarRepository;

        public CalendarManager(ICalendarRepository calendarRepository)
        {
            _calendarRepository = calendarRepository;
        }

        public IQueryable<Calendar> GetCalendarByPersonId(int personId)
        {
            return _calendarRepository.GetCalendarByPersonId(personId);
        }
        public void AddDayToCalendar(int calendarId, Day day)
        {
            _calendarRepository.AddDayToCalendar(calendarId, day);
        }
    }
}
