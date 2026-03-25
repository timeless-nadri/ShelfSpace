using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShelfSpace.Data;
using ShelfSpace.Forms;

namespace ShelfSpace.Forms
{
    public partial class FirstRunForm : Form
    {
        public FirstRunForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show(
                    "Bitte gib einen Namen ein.",
                    "Hinweis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DatabaseHelper.CreateUser(userName);

            StartForm startForm = new StartForm();
            startForm.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
