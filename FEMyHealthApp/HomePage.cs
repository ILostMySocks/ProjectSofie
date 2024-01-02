using Microsoft.Extensions.DependencyInjection;

namespace FEMyHealthApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        //private void toolStripMenuItemPersons_Click(object sender, EventArgs e)
        //{
        //    var personSearch = Program.ServiceProvider.GetService<PersonSearchForm>();
        //    personSearch.WindowState = FormWindowState.Maximized;
        //    personSearch.Show();
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}