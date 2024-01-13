using BLMyHealthApp.Dtos;
using BLMyHealthApp.Managers;
using BLMyHealthApp.Managers.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FEMyHealthApp
{
    public partial class HomePageForm : Form
    {
        private IPersonManager _personManager;
        public HomePageForm(IPersonManager personManager)
        {
            this.IsMdiContainer = true;
            InitializeComponent();

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

        }
    }
}