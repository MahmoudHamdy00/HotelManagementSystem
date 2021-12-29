using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.UserControls;
namespace HotelManagementSystem
{
    public partial class GuestUserControl : UserControl
    {
       GuestQueryDB guest = new GuestQueryDB();
        public GuestUserControl()
        {
            InitializeComponent();
        }

      
        private void GuestUserControl_Load(object sender, EventArgs e)
        {

            dataGridViewGuestInfo.DataSource = guest.GetGuests();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int idGuist;
            long Phh;
            try
            {
                idGuist = Convert.ToInt32(textBoxID.Text);
                Phh = Convert.ToInt64(textBoxPhone.Text);
                string fname = textBoxFirstName.Text;
                string lname = textBoxLastName.Text;
                string phone = textBoxPhone.Text;
                string contry = textBoxCountry.Text;
                DateTime dateG = dateTimePickerBirthDay.Value.Date;
                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
                {
                    MessageBox.Show("Reuried fields First& Last Name + Phone Num", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool insertGuest = guest.insertGuest(idGuist, fname, lname, phone, contry, dateG);
                    if (insertGuest)
                    {
                        dataGridViewGuestInfo.DataSource = guest.GetGuests();
                        MessageBox.Show("NEW Guest was Inserted Successfuly ", "Guest Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Error  Guest was'nt Inserted  ", "Guest Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID or Phone Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(textBoxID.Text);
                bool DeleteGuest = guest.removeGuest(id);
                if (DeleteGuest)
                {
                    dataGridViewGuestInfo.DataSource = guest.GetGuests();
                    MessageBox.Show(" Guest was deleted Successfuly ", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Error  Guest was'nt Deleted  ", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            long Phh;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            string phone = textBoxPhone.Text;
            string contry = textBoxCountry.Text;
            DateTime dateG = dateTimePickerBirthDay.Value.Date;

            try
            {
                id = Convert.ToInt32(textBoxID.Text);
                Phh = Convert.ToInt64(textBoxPhone.Text);
                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
                {
                    MessageBox.Show("Reuried fields First& Last Name + Phone Num", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool editGuest = guest.editGuest(id, fname, lname, phone, contry, dateG);
                    if (editGuest)
                    {
                        dataGridViewGuestInfo.DataSource = guest.GetGuests();
                        MessageBox.Show("NEW Guest was Edited Successfuly ", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Error  Guest was'nt Edited  ", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID or Phone Error  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = textBoxFirstName.Text = textBoxLastName.Text = textBoxPhone.Text = textBoxCountry.Text = textBoxSearch.Text = "";
            dataGridViewGuestInfo.DataSource = guest.GetGuests();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(textBoxSearch.Text);
                dataGridViewGuestInfo.DataSource = guest.GetOnlyGuest(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewGuestInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewGuestInfo.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridViewGuestInfo.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewGuestInfo.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewGuestInfo.CurrentRow.Cells[3].Value.ToString();
            textBoxCountry.Text = dataGridViewGuestInfo.CurrentRow.Cells[4].Value.ToString();
            try { dateTimePickerBirthDay.Value = Convert.ToDateTime(dataGridViewGuestInfo.CurrentRow.Cells[5].Value.ToString()); }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Format Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
        }
    }
}
