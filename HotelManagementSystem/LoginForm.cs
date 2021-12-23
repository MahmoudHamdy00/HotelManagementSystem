using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class LoginForm : Form
    {
        private readonly MySqlConnection connection;
        readonly string connectionString;
        string _username;
        bool _isAdmin;
        public LoginForm()
        {
            InitializeComponent();
            connectionString = Environment.GetEnvironmentVariable("hotelmanagmentsystemdpConnectionString");
            if (isNullOrEmpty(connectionString))
                showError("The ConnectionString isn't valid", "Connection string error");
            connection = new MySqlConnection(connectionString);
            _isAdmin = false;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            clearErrors();
            string username = usernameTextBox.Text.Trim().ToLower();
            string password = passwordTextBox.Text.Trim().ToLower();
            bool isEmpty = false;
            if (isNullOrEmpty(username))
            {
                setError(usernameErrorProvider, usernameTextBox, "Please type your username");
                isEmpty = true;
            }
            if (isNullOrEmpty(password))
            {
                setError(passwordErrorProvider, passwordTextBox, "Please type your password");
                isEmpty = true;
            }
            if (isEmpty) return;
            if (isValidCredentials(username, password))
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                showError("Wrong username or password.", "Invalid Credentials");
            }

        }
        private bool isNullOrEmpty(string text)
        {
            return text == null || text.Length == 0;
        }
        private bool getPassword(string username, ref string password)
        {
            bool isOk = false;
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"select employeePassowrd from employees where employees.employeeUserName='{username}';", connection);
                object ret = cmd.ExecuteScalar();
                if (ret != null)
                {
                    password = ret.ToString();
                    isOk = true;
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
                isOk = false;

            }
            finally
            {
                connection.Close();
            }
            return isOk;
        }
        private bool isValidCredentials(string username, string password)
        {
            bool isOk = false;

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"select isAdmin from employees where employees.employeeUserName='{username}' and employees.employeePassowrd='{password}';", connection);
                object ret = cmd.ExecuteScalar();
                if (ret != null)
                {
                    if (Convert.ToBoolean(ret) == true)//is admin=true
                    {
                        _isAdmin = true;
                    }
                    _username = username;
                    isOk = true;
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
                isOk = false;
            }
            finally
            {
                connection.Close();
            }
            return isOk;

        }
        private void showError(string errorMessage, string title = "Error")
        {
            MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void setError(ErrorProvider errorProvider, Control control, string value, bool clearPrevious = true)
        {
            if (clearPrevious) errorProvider.Clear();
            errorProvider.SetError(control, value);
        }

        void clearErrors()
        {
            usernameErrorProvider.Clear();
            passwordErrorProvider.Clear();
        }

        private void forgetPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = usernameTextBox.Text.Trim().ToLower();
            string password = null;
            if (isNullOrEmpty(username))
            {
                string message = "We can't get your password without a username.\nSo please type in your username.";
                showError(message, "Invalid Username");
                setError(usernameErrorProvider, usernameTextBox, message);
                return;
            }
            if (getPassword(username, ref password))
            {
                passwordTextBox.Text = password;
            }
            else showError("Can't find a username.", "Invalid Username");
        }
    }
}
