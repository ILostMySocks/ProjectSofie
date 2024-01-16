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
        IQueryable<Calendar> GetCalendarByPersonId(int personId);
        void AddDayToCalendar(int calendarId, Day day);
    }
}
