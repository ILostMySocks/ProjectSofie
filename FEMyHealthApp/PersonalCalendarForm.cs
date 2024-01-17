using BLMyHealthApp.Dtos;
using BLMyHealthApp.Managers;
using BLMyHealthApp.Managers.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using MyHealthApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEMyHealthApp
{
    public partial class PersonalCalendarForm : Form
    {
        private HomePageForm _homePageForm;
        private ICalendarManager _calendarManager;

        public int CalendarId { get; set; }
        public PersonalCalendarForm(ICalendarManager calendarManager, HomePageForm homePageForm)
        {
            InitializeComponent();

            _homePageForm = homePageForm;
            _calendarManager = calendarManager;

            this.TopLevel = false;
            this.Parent = _homePageForm;

            this.Load += PersonalCalendarForm_Load;
        }

        private void PersonalCalendarForm_Load(object sender, EventArgs e)
        {
            setDataGridView(CalendarId);
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            var addFood = Program.ServiceProvider.GetService<AddFoodForm>();
            addFood.CalendarId = this.CalendarId;
            addFood.WindowState = FormWindowState.Maximized;
            addFood.Show();
            addFood.ShowInTaskbar = true;
        }

        private void buttonAddWorkout_Click(object sender, EventArgs e)
        {
            var addWorkout = Program.ServiceProvider.GetService<AddWorkoutForm>();
            addWorkout.CalendarId = this.CalendarId;
            addWorkout.WindowState = FormWindowState.Maximized;
            addWorkout.Show();
        }

        private void setDataGridView(int calendarId)
        {
            Calendar calendar = _calendarManager.GetCalendarById(calendarId);
            List<MyHealthApp.Entities.Day> calendarDays = calendar.Days;
            List<DayResultDto> dayResults = _calendarManager.GetDayResult(calendarDays);

            if (dayResults != null)
                dataGridViewHealthCalendar.DataSource = dayResults;
        }
    }
}
