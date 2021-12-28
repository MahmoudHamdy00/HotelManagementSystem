using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace HotelManagementSystem.UserControls
{
    internal class GuestQueryDB
    {
        private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel");
        public bool insertGuest(int GID, string fName, string lName, string Phone, string country, DateTime DateG)
        {
            // conn.Open();
            string insertQuery = "INSERT INTO Guest(ID,first_Name,last_Name,Phone,Country,DOB)  VALUES(@Gid,@fnm,@lnm,@phn,@cnt,@dt);";
            MySqlCommand command = new MySqlCommand(insertQuery, conn);
            command.Parameters.Add("@Gid", MySqlDbType.Int32).Value = GID;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lName;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;
            command.Parameters.Add("@dt", MySqlDbType.DateTime).Value = DateG;
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
        public DataTable GetGuests()
        {
            MySqlCommand command = new MySqlCommand("SELECT * From Guest", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable guestTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(guestTable);
            return guestTable;
        }
        public DataTable GetOnlyGuest(int IDD)
        {
            MySqlCommand command = new MySqlCommand("SELECT * From Guest where id=@Gid", conn);
            command.Parameters.Add("@Gid", MySqlDbType.Int32).Value = IDD;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable guestTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(guestTable);
            return guestTable;
        }
        // Edit
        public bool editGuest(int IDD, string fName, string lName, string Phone, string country, DateTime DateG)
        {
            string updateQuery = "UPDATE Guest SET ID=@Gid,first_Name=@fnm,last_Name=@lnm,Phone=@phn,Country=@cnt,DOB=@dt where ID=@Gid";
            MySqlCommand command = new MySqlCommand(updateQuery, conn);
            command.Parameters.Add("@Gid", MySqlDbType.Int32).Value = IDD;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lName;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;
            command.Parameters.Add("@dt", MySqlDbType.DateTime).Value = DateG;
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
        //Search
        public bool removeGuest(int IDD)
        {//delete from Guest where id=@IDD
            string DeleteQyery = "DELETE FROM Guest where id=@Gid";
            MySqlCommand command = new MySqlCommand(DeleteQyery, conn);
            command.Parameters.Add("@Gid", MySqlDbType.Int32).Value = IDD;
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
