using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.UserControls;
using System.Data;

namespace HotelManagementSystem.Database
{
    static internal class HotelDbContext
    {
        static string connectionString = Environment.GetEnvironmentVariable("hotelmanagmentsystemdpConnectionString");
        private static readonly MySqlConnection connection = new MySqlConnection(connectionString);
        static string _username;
        static bool _isAdmin = false;

        public static bool registerNewUser(TextBox ssn, TextBox firstName, TextBox lastName, TextBox address, ComboBox gender, TextBox mobileNumber, DateTimePicker birthOfDate, TextBox email, TextBox username, TextBox password, ComboBox userTypeComboBox, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            ssn.Text = ssn.Text.Trim();
            firstName.Text = firstName.Text.Trim();
            lastName.Text = lastName.Text.Trim();
            address.Text = address.Text.Trim();
            mobileNumber.Text = mobileNumber.Text.Trim();
            gender.Text = gender.Text.Trim();
            email.Text = email.Text.Trim();
            username.Text = username.Text.Trim();
            password.Text = password.Text.Trim();
            int age = Math.Abs((birthOfDate.Value - DateTime.Now).Days / 30 / 12);
            bool isAdmin = false;
            bool isOk = true;
            if (isNullOrEmpty(ssn.Text))
            {
                isOk = false;
                setError(errorProvider, ssn, "You must enter your SSn");
            }
            if (isNullOrEmpty(firstName.Text))
            {
                isOk = false;
                setError(errorProvider, firstName, "You must enter your first name");

            }
            if (isNullOrEmpty(lastName.Text))
            {
                isOk = false;
                setError(errorProvider, lastName, "You must enter your last name");

            }
            if (isNullOrEmpty(address.Text))
            {
                isOk = false;
                setError(errorProvider, address, "You must enter your address");
            }
            if (isNullOrEmpty(mobileNumber.Text))
            {
                isOk = false;
                setError(errorProvider, mobileNumber, "You must enter your mobile number");
            }
            if (isNullOrEmpty(gender.Text))
            {
                isOk = false;
                setError(errorProvider, gender, "You must enter your gender");
            }
            if (isNullOrEmpty(email.Text))
            {
                isOk = false;
                setError(errorProvider, email, "You must enter your email");
            }
            if (isNullOrEmpty(username.Text))
            {
                isOk = false;
                setError(errorProvider, username, "You must enter a username");
            }
            if (isNullOrEmpty(password.Text))
            {
                isOk = false;
                setError(errorProvider, password, "You must enter a password");
            }
            if (isNullOrEmpty(userTypeComboBox.Text))
            {
                isOk = false;
                setError(errorProvider, userTypeComboBox, "You must enter a type");
            }

            if (age < 18)
            {
                isOk = false;
                setError(errorProvider, birthOfDate, $"You are to young baby,{age} years.\nYou must be older than 18 years.");
            }
            if (isOk != true) return false;
            if (userTypeComboBox.Text == "Admin") isAdmin = true;
            try
            {
                connection.Open();
                string insertQuery = $"insert into users(`SSN`, `firstName` ,`lastName`,  `address`, `gender` , `mobileNumber` ,`birthOfDate` , `email` , `username` ,  `password` , `isAdmin`) values ('{ssn.Text}','{firstName.Text}','{lastName.Text}','{address.Text}','{gender.Text}','{mobileNumber.Text}','{birthOfDate.Value.Date.ToString("yyyy-MM-dd")}','{email.Text}','{username.Text}','{password.Text}',{isAdmin});";
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show("Successfully Registerd");
                else
                    throw new Exception("Not Registered");
            }
            catch (Exception e)
            {
                showError(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public static bool changePassword(TextBox oldPasswordTextBox, TextBox newPasswordTextBox, TextBox confirmNewPasswordTextBox, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            oldPasswordTextBox.Text = oldPasswordTextBox.Text.Trim();
            newPasswordTextBox.Text = newPasswordTextBox.Text.Trim();
            confirmNewPasswordTextBox.Text = confirmNewPasswordTextBox.Text.Trim();

            bool isOk = true;
            if (isNullOrEmpty(oldPasswordTextBox.Text))
            {
                isOk = false;
                setError(errorProvider, oldPasswordTextBox, "You must enter your SSn");
            }
            if (isNullOrEmpty(newPasswordTextBox.Text))
            {
                isOk = false;
                setError(errorProvider, newPasswordTextBox, "You must enter your name");

            }
            if (isNullOrEmpty(confirmNewPasswordTextBox.Text))
            {
                isOk = false;
                setError(errorProvider, confirmNewPasswordTextBox, "You must enter your mobile number");
            }

            if (isOk != true) return false;
            try
            {
                if (newPasswordTextBox.Text != confirmNewPasswordTextBox.Text) throw new Exception("The password and confirmation didn't match");
                connection.Open();
                string insertQuery = $"UPDATE users SET password='{newPasswordTextBox.Text}' WHERE username='{LoginInfo._username}' and password='{oldPasswordTextBox.Text}';";
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show("Successfully Changed");
                else
                    throw new Exception("Not Changed");
            }
            catch (Exception e)
            {
                showError(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public static bool deleteUser(TextBox ssn, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            ssn.Text = ssn.Text.Trim();

            bool isOk = true;
            if (isNullOrEmpty(ssn.Text))
            {
                isOk = false;
                setError(errorProvider, ssn, "You must enter your SSn");
            }
            if (isOk != true) return false;
            try
            {
                connection.Open();
                string insertQuery = $"DELETE FROM users WHERE employees.ssn='{ssn.Text}';";
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show("Successfully Deleted");
                else
                    throw new Exception("Not Deleted");
            }
            catch (Exception e)
            {
                showError(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public static bool showAllUsers(DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                string insertQuery = $"SELECT * FROM users;";
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null && reader.HasRows)
                {

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView.DataSource = dataTable;
                }
                else throw new Exception("NO Result");

            }
            catch (Exception e)
            {
                showError(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public static bool showUserWithSSN(TextBox ssn, DataGridView dataGridView, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            ssn.Text = ssn.Text.Trim();
            if (isNullOrEmpty(ssn.Text))
            {
                setError(errorProvider, ssn, "You must enter an SSN");
                return false;
            }

            try
            {
                connection.Open();

                string query = $"SELECT * FROM users WHERE ssn='{ssn.Text}';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null && reader.HasRows)
                {

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView.DataSource = dataTable;
                }
                else
                {
                    dataGridView.DataSource = null;
                    MessageBox.Show("There is no user with this ssn.", "NO User");
                }

            }
            catch (Exception e)
            {
                showError(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public static bool isNullOrEmpty(string text)
        {
            return text == null || text.Length == 0;
        }
        public static void showError(string errorMessage, string title = "Error")
        {
            MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void setError(ErrorProvider errorProvider, Control control, string value, bool clearPrevious = false)
        {
            if (clearPrevious) errorProvider.Clear();
            errorProvider.SetError(control, value);
        }
    }
}
