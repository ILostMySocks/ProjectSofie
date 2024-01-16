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
        IQueryable<Calendar> GetCalendarByPersonId(int personId);
        void AddDayToCalendar(int calendarId, Day day);
    }
}
