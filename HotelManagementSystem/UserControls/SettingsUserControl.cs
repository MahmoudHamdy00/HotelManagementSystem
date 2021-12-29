using HotelManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.UserControls
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.registerNewUser(ssnTextBox, nameTextBox, mobileNumberTextBox, genderComboBox, emailTextBox, usernameTextBox, passwordTextBox, userTypeComboBox, errorProvider1);
        }



        private void getUsersBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.showAllUsers(dataGridView1);

        }

        private void getUsersBtn_userDetails_Click(object sender, EventArgs e)
        {
            HotelDbContext.showAllUsers(dataGridView2);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.deleteUser(ssnToDeleteTextBox, errorProvider1);
        }
    }
}
