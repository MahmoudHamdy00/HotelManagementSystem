using HotelManagementSystem.Database;
using HotelManagementSystem.Models;
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

    public partial class ReservationUserControl : UserControl
    {
        public ReservationUserControl()
        {
            InitializeComponent();
        }

            private void roomIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void addReservBtn_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            if (Helpper.isNullOrEmpty(SSNTextBox.Text))
            {
                Helpper.setError(errorProvider1, SSNTextBox, "Please enter your SSN");
                isOk = false;
            }
            if (Helpper.isNullOrEmpty(roomIdComboBox.Text))
            {
                Helpper.setError(errorProvider1, roomIdComboBox, "Please enter the room id.");
                isOk = false;
            }
            if (Helpper.isNullOrEmpty(roomTypeComboBox.Text))
            {
                Helpper.setError(errorProvider1, roomTypeComboBox, "Please enter the type of the room.");
                isOk = false;
            }
            if (isOk)
                HotelDbContext.AddReservation(SSNTextBox.Text, Convert.ToInt32(roomIdComboBox.Text), checkInDateTimePicker.Value);
            clearTab1();
        }

        private void ReservationUserControl_Load(object sender, EventArgs e)
        {
            checkInDateTimePicker.MinDate = DateTime.Now;
            HotelDbContext.fillRoomType(roomTypeComboBox);

        }


        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomTypeComboBox.Text != "")
                HotelDbContext.fillRoomId(roomIdComboBox, roomTypeComboBox.Text);
        }



        private void SSNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            Guest guset = HotelDbContext.getGuestInfo(SSNTextBox.Text);
            if (guset == null)
            {
                Helpper.showError("There isn't exist any guest with this SSN", "Guest Not Found");
                return;
            }
            firstNameTextBox.Text = guset.firstName;
            lastNameTextBox.Text = guset.lastName;
            addressTextBox.Text = guset.address;
            genderComboBox.Text = guset.gender;
            mobileNumberTextBox.Text = guset.mobileNumber;
            birthDateDateTimePicker.Value = guset.birthOfDate;
            nationalityTextBox.Text = guset.nationality;

        }
        private void clearTab1()
        {
            SSNTextBox.Text = "";
            roomTypeComboBox.Items.Clear();
            roomIdComboBox.Items.Clear();
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            genderComboBox.Items.Clear();
            mobileNumberTextBox.Text = "";
            birthDateDateTimePicker.Value = DateTime.Now;
            nationalityTextBox.Text = "";

        }
        private void clearTab2()
        {
            tab2checkInDateTimeLabel.Text = "?";
            tab2RoomIdLabel.Text = "?";
            tab2ReservationLabel.Text = "?";
        }

        private void tab2SSNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            HotelDbContext.ShowReservations(tab2SSNTextBox.Text, dataGridView1);
            clearTab2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tab2ReservationLabel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tab2RoomIdLabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tab2checkInDateTimeLabel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tab2checkOutDateTimePicker.MinDate = Convert.ToDateTime(tab2checkInDateTimeLabel.Text);
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            if (Helpper.isNullOrEmpty(tab2SSNTextBox.Text))
            {
                Helpper.setError(errorProvider1, tab2SSNTextBox, "Please enter an SSN");
                isOk = false;
            }
            if (Helpper.isNullOrEmpty(tab2ReservationLabel.Text) || tab2ReservationLabel.Text == "?")
            {
                Helpper.setError(errorProvider1, tab2ReservationLabel, "Please select a reservation.");
                isOk = false;
            }
            if (isOk)
            {
                HotelDbContext.checkoutReservation(tab2SSNTextBox.Text, tab2ReservationLabel.Text,Convert.ToDateTime(tab2checkInDateTimeLabel.Text), tab2checkOutDateTimePicker.Value,tab2RoomIdLabel.Text);
            }
            tab2SSNTextBox_KeyPress(tab2SSNTextBox, new KeyPressEventArgs((char)Keys.Enter));
        }

        private void roomTypeLabel_Click(object sender, EventArgs e)
        {
            HotelDbContext.fillRoomType(roomTypeComboBox);
        }
    }
}
