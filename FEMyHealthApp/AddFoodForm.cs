using BLMyHealthApp.Managers.Interfaces;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEMyHealthApp
{
    public partial class AddFoodForm : Form
    {
        private PersonalCalendarForm _personalCalendarForm;
        private ICalendarManager _calendarManager;

        public int CalendarId { get; set; }
        public AddFoodForm(ICalendarManager calendarManager, PersonalCalendarForm personalCalendarForm)
        {
            InitializeComponent();

            _personalCalendarForm = personalCalendarForm;
            _calendarManager = calendarManager;


        }

        private void buttonSaveFood_Click(object sender, EventArgs e)
        {
            MyHealthApp.Entities.Day today = _calendarManager.AddDayToCalendar(CalendarId, DateTime.Now);
            
            Food food = new Food()
            {
                FoodName = textBoxFoodName.Text,
                CalorieCount = int.Parse(textBoxCalorieCount.Text)
            };

            _calendarManager.AddFoodToDay(CalendarId, today.Id, food);


        }
    }
}
