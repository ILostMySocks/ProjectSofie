using BLMyHealthApp.Dtos;
using BLMyHealthApp.Managers.Interfaces;
using EFDALMyHealthApp.Repositories.Interfaces;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public Calendar GetCalendarByPersonId(int personId)
        {
            return _calendarRepository.GetCalendarByPersonId(personId);
        }
        public Calendar GetCalendarById(int calendarId)
        {
            return _calendarRepository.GetCalendarById(calendarId);
        }
        public Day AddDayToCalendar(int calendarId, DateTime day)
        {
            return _calendarRepository.AddDayToCalendar(calendarId, day);
        }

        public List<DayResultDto> GetDayResult(List<Day> dayQuery)
        {
            if (dayQuery == null)
            {
                return new List<DayResultDto>();
            }
            return dayQuery.Select(d => new DayResultDto()
            {
                Id = d.Id,
                Today = d.Today,
                NumberOfFoods = d.Foods != null ? d.Foods.Count : 0,
                NumberOfWorkouts = d.Workouts != null ? d.Workouts.Count : 0
            }).ToList();
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
