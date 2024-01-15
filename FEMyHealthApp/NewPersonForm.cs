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
    public partial class NewPersonForm : Form
    {
        private HomePageForm _homePageForm;
        private IPersonManager _personManager;

        public NewPersonForm(IPersonManager personManager, HomePageForm homePageForm)
        {
            InitializeComponent();

            _homePageForm = homePageForm;
            _personManager = personManager;

            this.TopLevel = false;
            this.Parent = _homePageForm;
        }

        private void ButtonSaveNewPerson_Click(object sender, EventArgs e)
        {
            GenderIdentity genderIdentity;
            if (radioButtonMale.Checked)
                genderIdentity = GenderIdentity.Male;
            else if (radioButtonFemale.Checked)
                genderIdentity = GenderIdentity.Female;
            else if (radioButtonX.Checked)
                genderIdentity = GenderIdentity.X;
            else
                genderIdentity = GenderIdentity.Unspecified;
            //if no gender identity is mentioned than they automatically get last option, "rather not say"


            Person person = new Person()
            {
                FirstName = textBoxSaveFirstName.Text,
                LastName = textBoxSaveLastName.Text,
                Email = textBoxSaveEmail.Text,
                BirthDate = dateTimePickerBirthdate.Value,
                GenderIdentity = genderIdentity,
                Calendar = new Calendar()
            };

            _personManager.Add(person);

            this.Close();
            _homePageForm.Show();
            _homePageForm.BringToFront();


        }
    }
}
