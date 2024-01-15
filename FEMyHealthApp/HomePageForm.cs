using BLMyHealthApp.Dtos;
using BLMyHealthApp.Managers;
using BLMyHealthApp.Managers.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace FEMyHealthApp
{
    public partial class HomePageForm : Form
    {
        private IPersonManager _personManager;
        public HomePageForm(IPersonManager personManager)
        {
            this.IsMdiContainer = true;
            InitializeComponent();

            dataGridViewSearchResults.CellDoubleClick += dataGridViewSearchResults_CellDoubleClick;
            dataGridViewSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSearchResults.ReadOnly = true;

            _personManager = personManager;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var personQuery = new PersonSearchValuesDto();

            personQuery.FirstName = textBoxFirstName.Text;
            personQuery.LastName = textBoxLastName.Text;
            personQuery.Email = textBoxEmail.Text;
            List<PersonSearchResultDto> searchResults = _personManager.GetPersonSearch(personQuery);
            dataGridViewSearchResults.DataSource = searchResults;


        }

        private void buttonAddNewPerson_Click(object sender, EventArgs e)
        {
            var personAdd = Program.ServiceProvider.GetService<NewPersonForm>();
            personAdd.WindowState = FormWindowState.Maximized;
            personAdd.Show();
        }

        private void dataGridViewSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSearchResults.SelectedRows.Count > 0)
            {
                // Get id from selected row
                int selectedId = Convert.ToInt32(dataGridViewSearchResults.SelectedRows[0].Cells["Id"].Value);

                PersonalCalendarForm personalCalendarForm = new PersonalCalendarForm(selectedId);

                personalCalendarForm.Show();
            }
        }
    }
}