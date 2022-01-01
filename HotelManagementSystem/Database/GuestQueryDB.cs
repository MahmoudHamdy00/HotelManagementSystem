using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace HotelManagementSystem.Database
{
    internal class GuestQueryDB
    {
        readonly string connectionString;
        private  MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel;Convert Zero Datetime=True;");
        //private readonly MySqlConnection coon;
        public GuestQueryDB()
        {
            // connectionString = Environment.GetEnvironmentVariable("hotelmanagmentsystemdpConnectionString");
            //conn = new MySqlConnection(connectionString);
        }
        public bool insertGuest(string GID, string fName, string lName, string Phone, string country, string addres, DateTime DateG, string gend)
        {
            // conn.Open();
            string timeToString_ = DateG.Year.ToString() + "-" + DateG.Month.ToString() + "-" + DateG.Day.ToString();
            string insertQuery = $"INSERT INTO Guests VALUES('{GID}','{fName}','{lName}','{Phone}','{country}','{addres}','{timeToString_}','{gend}');";
           
            MySqlCommand command = new MySqlCommand(insertQuery, conn); 
            try {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataBases", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
            return false;
        }
        public DataTable GetGuests()
        {
            MySqlCommand command = new MySqlCommand("SELECT * From Guests", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable guestTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(guestTable);
            return guestTable;
        }
        public DataTable GetOnlyGuest(string IDD)
        {
            MySqlCommand command = new MySqlCommand($"SELECT * From Guests where SSN='{IDD}';", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable guestTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(guestTable);
            return guestTable;
        }
        // Edit
        public bool editGuest(string GID, string fName, string lName, string Phone, string country, string addres, DateTime DateG, string gend)
        {
            string timeToString_ = DateG.Year.ToString() + "-" + DateG.Month.ToString() + "-" + DateG.Day.ToString();
            string updateQuery = $"UPDATE Guests SET SSN = '{GID}', first_Name = '{fName}', last_Name = '{lName}', Phone = '{Phone}', Nationality = '{country}', Address = '{addres}', dateOfBirth = '{timeToString_}', Gender = '{gend}' where SSN = '{GID}'; ";
            MySqlCommand command = new MySqlCommand(updateQuery, conn);
            try
            {
           
          
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
            return false;
        }
        //Search
        public bool removeGuest(string IDD)
        {//delete from Guest where id=@IDD
            string DeleteQyery = "DELETE FROM Guests where SSN=@Gid";
            MySqlCommand command = new MySqlCommand(DeleteQyery, conn);
            command.Parameters.Add("@Gid", MySqlDbType.VarChar).Value = IDD;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
    }
}
