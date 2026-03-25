using ShelfSpace.Data;
using ShelfSpace.Forms;

namespace ShelfSpace
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            LoadWelcomeMessage();
        }

        private void LoadWelcomeMessage()
        {
            string? userName = DatabaseHelper.GetUserName();

            if (string.IsNullOrWhiteSpace(userName))
            {
                lblWelcome.Text = "Willkommen, was möchtest du heute tun?";
            }
            else
            {
                lblWelcome.Text = $"Willkommen {userName}, was möchtest du heute tun?";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenLibrary_Click(object sender, EventArgs e)
        {
            LibraryForm libraryForm = new LibraryForm();
            libraryForm.Show();

            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddEditBookForm addEditBookForm = new AddEditBookForm();
            addEditBookForm.Show();

            this.Close();
        }
    }
}
