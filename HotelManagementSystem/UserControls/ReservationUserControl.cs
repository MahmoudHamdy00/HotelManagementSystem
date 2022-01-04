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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void addReservBtn_Click(object sender, EventArgs e)
        {
            bool isOk = true;
            if (Helpper.isNullOrEmpty(checkInSSNComboBox.Text))
            {
                Helpper.setError(errorProvider1, checkInSSNComboBox, "Please enter your SSN");
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
                HotelDbContext.AddReservation(checkInSSNComboBox.Text, Convert.ToInt32(roomIdComboBox.Text), checkInDateTimePicker.Value);
            clearTab1();
        }

        private void ReservationUserControl_Load(object sender, EventArgs e)
        {
            checkInDateTimePicker.MinDate = DateTime.Now;
            HotelDbContext.fillRoomType(roomTypeComboBox);
            HotelDbContext.fillSSN(tab2SSNComboBox);
            HotelDbContext.fillSSN(checkInSSNComboBox);

        }


        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomTypeComboBox.Text != "")
                HotelDbContext.fillRoomId(roomIdComboBox, roomTypeComboBox.Text);
        }



        private void SSNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Guest guset = HotelDbContext.getGuestInfo(checkInSSNComboBox.Text);
                if (guset == null)
                {
                    Helpper.showError("There isn't exist any guest with this SSN", "Guest Not Found");
                    return;
                }
                firstNameTextBox.Text = guset.firstName;
                lastNameTextBox.Text = guset.lastName;
                addressTextBox.Text = guset.address;
                genderComboBox.Items.Add(guset.gender);
                genderComboBox.Text = guset.gender;
                mobileNumberTextBox.Text = guset.mobileNumber;
                birthDateDateTimePicker.Value = guset.birthOfDate;
                nationalityTextBox.Text = guset.nationality;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

        }
        private void clearTab1()
        {
            checkInSSNComboBox.Text = "";
            HotelDbContext.fillRoomId(roomIdComboBox, roomTypeComboBox.Text);
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
            if (Helpper.isNullOrEmpty(tab2SSNComboBox.Text))
            {
                Helpper.setError(errorProvider1, tab2SSNComboBox, "Please enter an SSN");
                isOk = false;
            }
            if (Helpper.isNullOrEmpty(tab2ReservationLabel.Text) || tab2ReservationLabel.Text == "?")
            {
                Helpper.setError(errorProvider1, tab2ReservationLabel, "Please select a reservation.");
                isOk = false;
            }
            if (isOk)
            {
                HotelDbContext.checkoutReservation(tab2SSNComboBox.Text, tab2ReservationLabel.Text, Convert.ToDateTime(tab2checkInDateTimeLabel.Text), tab2checkOutDateTimePicker.Value, tab2RoomIdLabel.Text);
            }
            tab2SSNComboBox_KeyPress(tab2SSNComboBox, new KeyPressEventArgs((char)Keys.Enter));
            HotelDbContext.fillRoomId(roomIdComboBox, roomTypeComboBox.Text);
        }

        private void roomTypeLabel_Click(object sender, EventArgs e)
        {
            HotelDbContext.fillRoomType(roomTypeComboBox);
        }

        private void tab2SSNComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            HotelDbContext.ShowReservations(tab2SSNComboBox.Text, dataGridView1);
            clearTab2();
        }

        private void tab2SSNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotelDbContext.ShowReservations(tab2SSNComboBox.Text, dataGridView1);
            clearTab2();
        }

        private void checkInSSNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotelDbContext.ShowReservations(tab2SSNComboBox.Text, dataGridView1);

            Guest guset = HotelDbContext.getGuestInfo(checkInSSNComboBox.Text);
            if (guset == null)
            {
                Helpper.showError("There isn't exist any guest with this SSN", "Guest Not Found");
                return;
            }
            firstNameTextBox.Text = guset.firstName;
            lastNameTextBox.Text = guset.lastName;
            addressTextBox.Text = guset.address;
            genderComboBox.Items.Add(guset.gender);
            genderComboBox.Text = guset.gender;
            mobileNumberTextBox.Text = guset.mobileNumber;
            birthDateDateTimePicker.Value = guset.birthOfDate;
            nationalityTextBox.Text = guset.nationality;
            // clearTab1();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HotelDbContext.fillSSN(tab2SSNComboBox);
        }

        private void SSNLabel_Click(object sender, EventArgs e)
        {
            HotelDbContext.fillSSN(checkInSSNComboBox);


        }
    }



}
