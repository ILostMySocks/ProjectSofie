using BLMyHealthApp.Managers.Interfaces;
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
    public partial class AddWorkoutForm : Form
    {
        private PersonalCalendarForm _personalCalendarForm;
        private ICalendarManager _calendarManager;

        public int CalendarId { get; set; }
        public AddWorkoutForm(ICalendarManager calendarManager, PersonalCalendarForm personalCalendarForm)
        {
            InitializeComponent();

            _personalCalendarForm = personalCalendarForm;
            _calendarManager = calendarManager;

            this.TopLevel = false;
            this.Parent = _personalCalendarForm;

        }

        private void buttonSaveWorkout_Click(object sender, EventArgs e)
        {

        }
    }
}
