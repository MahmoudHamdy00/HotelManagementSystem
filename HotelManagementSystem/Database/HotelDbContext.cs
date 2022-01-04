using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.UserControls;
using System.Data;
using HotelManagementSystem.Models;

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
                setError(errorProvider, ssn, "You must enter your SSN");
            }
            if (isOk != true) return false;
            try
            {
                connection.Open();
                string insertQuery = $"DELETE FROM users WHERE users.ssn='{ssn.Text}';";
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
        public static void fillRoomType(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            try
            {
                connection.Open();
                string selectQuery = $"SELECT roomType FROM RoomTypes;";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader.GetString(0));
                    }
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
        }
        public static void fillSSN(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            try
            {
                connection.Open();
                string selectQuery = $"select ssn from guests;";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader.GetString(0));
                    }
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
        }
       
        public static void fillRoomId(ComboBox comboBox, string roomType)
        {
            comboBox.Items.Clear();
            try
            {
                connection.Open();
                string selectQuery = $"SELECT id FROM Rooms WHERE roomType = '{roomType}' AND isReserved = false;";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {

                        comboBox.Items.Add(reader.GetInt32(0).ToString());
                    }
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
        }
        public static bool isNullOrEmpty(string text)
        {
            return text == null || text.Trim().Length == 0;
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
        public static bool AddReservation(string ssn, int roomId, DateTime checkInDate)
        {
            bool isOk = true;
            try
            {
                connection.Open();
                string insertQuery = $"insert into Reservations(`SSN`, `roomId` ,`checkin`) values ('{ssn}',{roomId},'{checkInDate.Date.ToString("yyyy-MM-dd")}');";
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                    MessageBox.Show("Successfully Reservation");
                else
                    throw new Exception("Not Registered");
            }
            catch (Exception e)
            {
                showError(e.Message);
                isOk = false;
            }
            finally
            {
                connection.Close();
            }
            return isOk;
        }


        public static Guest getGuestInfo(string ssn)
        {
            Guest guest = null;
            try
            {
                connection.Open();
                string selectQuery = $"SELECT * FROM guests WHERE ssn = '{ssn}' LIMIT 1;";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        guest = new Guest();
                        guest.firstName = reader.GetString("firstName");

                        guest.lastName = reader.GetString("lastName");

                        guest.address = reader.GetString("address");

                        guest.gender = reader.GetString("gender");

                        guest.mobileNumber = reader.GetString("mobileNumber");

                        guest.birthOfDate = reader.GetDateTime("birthOfDate");
                        /*                        MessageBox.Show("= " + reader.GetString("birthOfDate"));
                                                MessageBox.Show("= " + reader.GetDateTime("birthOfDate"));*/
                        guest.nationality = reader.GetString("nationality");

                    }
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
            return guest;
        }
        public static void ShowReservations(string ssn, DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                string selectQuery = $"SELECT * FROM reservations where SSN='{ssn}' and checkout is null;";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridView.DataSource = dataTable;
                    dataGridView.Columns[0].HeaderText = "Id";
                    dataGridView.Columns[1].HeaderText = "Guest SSN";
                    dataGridView.Columns[2].HeaderText = "Room Id";
                    dataGridView.Columns[3].HeaderText = "Check-In Date";
                    dataGridView.Columns[5].HeaderText = "Created at";
                    dataGridView.Columns[6].HeaderText = "Updated At";
                    dataGridView.Columns.Remove(dataGridView.Columns[4]);
                }
                else
                {
                    dataGridView.DataSource = null;
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

        }
        public static bool checkoutReservation(string ssn, string reservationId, DateTime checkInDate, DateTime checkOutDate, string roomId)
        {
            bool isOk = true;
            try
            {
                connection.Open();
                string insertQuery = $"UPDATE reservations SET checkout='{checkOutDate.Date.ToString("yyyy-MM-dd")}' WHERE id='{reservationId}';";
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Successfully checked out");
                    int totalDays = (checkOutDate.Date - checkInDate.Date).Days + 1;
                    AddPayment(ssn, reservationId, roomId, totalDays);
                }
                else
                    throw new Exception("Not Changed");
            }
            catch (Exception e)
            {
                showError(e.Message);
                isOk = false;
            }
            finally
            {
                connection.Close();
            }
            return isOk;
        }
        public static string getRoomType(string roomId)
        {

            string roomType = "";
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                string selectQuery = $"SELECT roomType FROM rooms where id='{roomId}';";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                var reader = cmd.ExecuteScalar();
                if (reader == null)
                    throw new Exception("Couldn't find room type");
                roomType = reader.ToString();

            }
            catch (Exception e)
            {
                showError(e.Message);
                // throw e;
            }
            finally
            {
                connection.Close();
            }
            return roomType;
        }
        public static double getRoomPrice(string roomType)
        {

            double price = -1;
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                string selectQuery = $"SELECT pricePerDay FROM roomtypes where roomtype='{roomType}';";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                var reader = cmd.ExecuteScalar();
                if (reader == null)
                    throw new Exception("Couldn't find room price");
                price = Convert.ToDouble(reader);
            }
            catch (Exception e)
            {
                showError(e.Message);
                // throw e;
            }
            finally
            {
                connection.Close();
            }
            return price;
        }
        public static void AddPayment(string ssn, string reservationId, string roomId, int totalDays)
        {
            try
            {
                double totalPrice = -1;
                string procedure = $"GetTotalPrice";
                MySqlCommand cmd = new MySqlCommand(procedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@reservationId", MySqlDbType.Int32).Value = reservationId;
                cmd.Parameters["@reservationId"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add(new MySqlParameter("?totalPrice", MySqlDbType.Double));
                cmd.Parameters["?totalPrice"].Direction = ParameterDirection.Output;
                int ret = cmd.ExecuteNonQuery();
                totalPrice = Convert.ToDouble(cmd.Parameters["?totalPrice"].Value);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                string insertQuery = $"insert into payments (`SSN`,`reservationId`,`totalPrice`) values('{ssn}','{reservationId}',{totalPrice});";
                cmd = new MySqlCommand(insertQuery, connection);
                ret = cmd.ExecuteNonQuery();
                if (ret != 1)
                    throw new Exception("Not Registered");



            }
            catch (Exception e)
            {
                Helpper.showError(e.Message);
            }
            finally { connection.Close(); }

        }
        public static void ShowPayments(string ssn, DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                string selectQuery = $"SELECT * FROM payments where SSN='{ssn}';";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridView.DataSource = dataTable;
                    dataGridView.Columns[0].HeaderText = "Guest SSN";
                    dataGridView.Columns[1].HeaderText = "Reservation Id";
                    dataGridView.Columns[2].HeaderText = "Total Price";

                    // dataGridView.Columns.Remove(dataGridView.Columns[4]);
                }
                else
                {
                    dataGridView.DataSource = null;
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

        }
        public static void ShowRoomTypes(DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                string selectQuery = $"SELECT * FROM roomtypes;";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridView.DataSource = dataTable;
                    dataGridView.Columns[0].HeaderText = "Room Type";
                    dataGridView.Columns[1].HeaderText = "Room Price";

                    // dataGridView.Columns.Remove(dataGridView.Columns[4]);
                }
                else
                {
                    dataGridView.DataSource = null;
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

        }
        public static void ShowRoomIds(DataGridView dataGridView)
        {
            try
            {
                connection.Open();
                string selectQuery = $"SELECT * FROM rooms;";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView.DataSource = dataTable;
                    dataGridView.Columns[0].HeaderText = "Room Id";
                    dataGridView.Columns[1].HeaderText = "Room Type";
                    dataGridView.Columns[2].HeaderText = "Reserved";
                    dataGridView.Columns[3].HeaderText = "Created At";
                    dataGridView.Columns[4].HeaderText = "Updated At";

                    // dataGridView.Columns.Remove(dataGridView.Columns[4]);
                }
                else
                {
                    dataGridView.DataSource = null;
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

        }
        public static bool AddRoomType(TextBox roomType, TextBox roomPrice, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            bool isOk = true;
            if (Helpper.isNullOrEmpty(roomType.Text))
            {
                isOk = false;
                setError(errorProvider, roomType, "You must enter a room type.");
            }
            if (Helpper.isNullOrEmpty(roomPrice.Text))
            {
                isOk = false;
                setError(errorProvider, roomPrice, "You must enter a room price.");
            }
            if (isOk != true) return false;
            try
            {
                connection.Open();
                string insertQuery = $"insert into RoomTypes values ('{roomType.Text}',{roomPrice.Text});";
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Added Successfully");
                }
                else
                    throw new Exception("Not Added");
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
        public static bool EditRoomType(TextBox roomType, TextBox roomPrice, ErrorProvider errorProvider)
        {
            bool isOk = true;
            if (Helpper.isNullOrEmpty(roomType.Text))
            {
                Helpper.setError(errorProvider, roomType, "Please select a room from the data grid");
                return false;
            }
            errorProvider.Clear();
            if (Helpper.isNullOrEmpty(roomType.Text))
            {
                isOk = false;
                setError(errorProvider, roomType, "You must select a room type(check on the grid).");
            }
            if (Helpper.isNullOrEmpty(roomPrice.Text))
            {
                isOk = false;
                setError(errorProvider, roomPrice, "You must enter a room price.");
            }
            if (isOk != true) return false;
            try
            {
                connection.Open();
                string updateQuery = $"update RoomTypes set pricePerDay={roomPrice.Text} where roomType='{roomType.Text}';";
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                    throw new Exception("Not updated");
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
        public static bool DeleteRoomType(TextBox roomType, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            bool isOk = true;
            if (Helpper.isNullOrEmpty(roomType.Text))
            {
                isOk = false;
                setError(errorProvider, roomType, "You must select a room type(check on the grid).");
            }
            if (isOk != true) return false;
            try
            {
                connection.Open();
                string deleteQuery = $"delete from RoomTypes where roomType='{roomType.Text}';";
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Deleted Successfully");
                }
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
        public static bool getAndUpdateRoomId(Label roomIdTextBox)
        {

            try
            {
                connection.Open();
                string selectQuery = $"SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'HotelManagmentSystemDP' AND TABLE_NAME = 'rooms';";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                var reader = cmd.ExecuteScalar();
                if (reader == null)
                    throw new Exception("Couldn't get room id");
                roomIdTextBox.Text = reader.ToString();
                MessageBox.Show(roomIdTextBox.Text);
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
        public static bool AddRoomId(ComboBox roomType, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            bool isOk = true;
            if (Helpper.isNullOrEmpty(roomType.Text))
            {
                isOk = false;
                setError(errorProvider, roomType, "You must enter a room type.");
            }
            if (isOk != true) return false;
            try
            {
                connection.Open();
                string insertQuery = $"insert into rooms (roomType) values ('{roomType.Text}');";
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Added Successfully");
                }
                else
                    throw new Exception("Not Added");
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
        public static bool EditRoomId(Label roomId, ComboBox roomType, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            bool isOk = true;
            if (Helpper.isNullOrEmpty(roomId.Text))
            {
                isOk = false;
                setError(errorProvider, roomId, "You must select a room(check on the grid).");
            }

            if (Helpper.isNullOrEmpty(roomType.Text))
            {
                isOk = false;
                setError(errorProvider, roomType, "You must select a room type");
            }

            if (isOk != true) return false;
            try
            {
                connection.Open();
                string updateQuery = $"update rooms set roomtype='{roomType.Text}' where id='{roomId.Text}';";
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                    throw new Exception("Not updated");
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
        public static bool DeleteRoomId(Label roomId, ErrorProvider errorProvider)
        {
            errorProvider.Clear();
            bool isOk = true;
            if (Helpper.isNullOrEmpty(roomId.Text))
            {
                isOk = false;
                setError(errorProvider, roomId, "You must select a room(check on the grid).");
            }
            if (isOk != true) return false;
            try
            {
                connection.Open();
                string deleteQuery = $"delete from rooms where id='{roomId.Text}';";
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                int ret = cmd.ExecuteNonQuery();
                if (ret == 1)
                {
                    MessageBox.Show("Deleted Successfully");
                }
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
    }

}
