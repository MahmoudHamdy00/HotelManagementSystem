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
            updateGridView();
        }



        private void getUsersBtn_Click(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void updateGridView()
        {
            HotelDbContext.showAllUsers(dataGridView1);
            HotelDbContext.showAllUsers(dataGridView2);
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.deleteUser(ssnToDeleteTextBox, errorProvider1);
            updateGridView();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.changePassword(oldPasswordTextBox, newPasswordTextBox, confirmNewPasswordTextBox, errorProvider1);
            updateGridView();
        }

        private void SettingsUserControl_Load(object sender, EventArgs e)
        {

            updateGridView();
            if (!LoginInfo._isAdmin)
            {
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
            }
            usernameLabel.Text = usernameLabel.Text.Replace("?", LoginInfo._username);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.showUserWithSSN(ssn_SearchTextBox, dataGridView2, errorProvider1);
        }

     
        //     MessageBox.Show("username " + LoginInfo._username + "\n" + "password " + LoginInfo._password + "\n" + "isAdmin " + LoginInfo._isAdmin + "\n");

    }
}
