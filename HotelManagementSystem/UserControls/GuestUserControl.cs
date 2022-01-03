using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.Database;
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

            try
            {
                clear_();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataBases", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string idGuist;
            long Phh;
            try
            {
                idGuist = textBoxID.Text;
                string fname = textBoxFirstName.Text;
                string lname = textBoxLastName.Text;
                string phone = textBoxPhone.Text;
                string contry = textBoxCountry.Text;
                string addres = textBoxAddress.Text;
                string gender = comboBoxGender.Text;
                DateTime dateG = dateTimePickerBirthDay.Value.Date;
                bool Valid = true;
                if (isNullOrEmpty(idGuist))
                {
                    HotelDbContext.setError(errorProvider1, textBoxID, "Enter SSN");
                    Valid = false;
                }
                if (isNullOrEmpty(fname))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxFirstName, "Enter First Name");
                }
                if (isNullOrEmpty(lname))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxLastName, "Enter Last Name");
                }
                if (isNullOrEmpty(phone))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxPhone, "Enter Phone Num");
                }
                if (isNullOrEmpty(contry))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxCountry, "Enter Nationality Name");
                }
                if (isNullOrEmpty(addres))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxAddress, "Enter Address");

                }
                if (isNullOrEmpty(gender))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, comboBoxGender, "Enter Gender ");

                }
                if (Valid)
                {
                    try
                    {
                        bool insertGuest = guest.insertGuest(idGuist, fname, lname, phone, contry, addres, dateG, gender);
                        if (insertGuest)
                        {
                            clear_();
                            MessageBox.Show("NEW Guest was Inserted Successfuly ", "Guest Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Error  Guest was'nt Inserted  ", "Guest Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID  Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        { 
            string idGuist;
            try
            {
                idGuist = (textBoxID.Text);
                bool Valid = true;
                if (isNullOrEmpty(idGuist))
                {
                    HotelDbContext.setError(errorProvider1, textBoxID, "Enter SSN");
                    Valid = false;
                }
                if(Valid)
                {
                    bool DeleteGuest = guest.removeGuest(idGuist);
                    if (DeleteGuest)
                    {
                        clear_();
                        MessageBox.Show(" Guest was deleted Successfuly ", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Error  Guest was'nt Deleted  ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string idGuist;
            try
            {
                idGuist = textBoxID.Text;
                string fname = textBoxFirstName.Text;
                string lname = textBoxLastName.Text;
                string phone = textBoxPhone.Text;
                string contry = textBoxCountry.Text;
                string addres = textBoxAddress.Text;
                string gender = comboBoxGender.Text;
                DateTime dateG = dateTimePickerBirthDay.Value.Date;
                bool Valid = true;
                if (isNullOrEmpty(idGuist))
                {
                    HotelDbContext.setError(errorProvider1, textBoxID, "Enter SSN");
                    Valid = false;
                }
                if (isNullOrEmpty(fname))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxFirstName, "Enter First Name");
                }
                if (isNullOrEmpty(lname))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxLastName, "Enter Last Name");
                }
                if (isNullOrEmpty(phone))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxPhone, "Enter Phone Num");
                }
                if (isNullOrEmpty(contry))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxCountry, "Enter Nationality Name");
                }
                if (isNullOrEmpty(addres))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, textBoxAddress, "Enter Address");

                }
                if (isNullOrEmpty(gender))
                {
                    Valid = false;
                    HotelDbContext.setError(errorProvider1, comboBoxGender, "Enter Gender ");

                }
                if (Valid)
                {
                    bool editGuest = guest.editGuest(idGuist, fname, lname, phone, contry, addres, dateG, gender);
                    if (editGuest)
                    {
                        clear_();
                        MessageBox.Show("NEW Guest was Edited Successfuly ", "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("there is't any Guest has Guest Id="+idGuist + " or duplicate Phone "+ phone, "Edit Guest", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID  Error  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            clear_();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string idGuist=textBoxSearch.Text;
            try
            {
                bool Valid = true;
                if (isNullOrEmpty(idGuist))
                {
                    HotelDbContext.setError(errorProvider1, textBoxSearch, "Enter SSN");
                    Valid = false;
                }
                if (Valid)
                {
                    clear_();
                    dataGridViewGuestInfo.DataSource = guest.GetOnlyGuest(idGuist);
                }
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
            errorProvider1.Clear();

        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
               errorProvider1.Clear();
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
            errorProvider1.Clear();
        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewGuestInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewGuestInfo.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridViewGuestInfo.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewGuestInfo.CurrentRow.Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridViewGuestInfo.CurrentRow.Cells[3].Value.ToString();
            comboBoxGender.Text = dataGridViewGuestInfo.CurrentRow.Cells[4].Value.ToString();
            textBoxPhone.Text = dataGridViewGuestInfo.CurrentRow.Cells[5].Value.ToString();
            textBoxCountry.Text = dataGridViewGuestInfo.CurrentRow.Cells[7].Value.ToString();
            try { dateTimePickerBirthDay.Value = Convert.ToDateTime(dataGridViewGuestInfo.CurrentRow.Cells[6].Value.ToString()); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Format Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public static bool isNullOrEmpty(string text)
        {
            return text == null || text.Length == 0;
        }
        private void clear_()
        {
            errorProvider1.Clear();

            textBoxID.Text = textBoxFirstName.Text = textBoxLastName.Text = textBoxPhone.Text = textBoxCountry.Text = textBoxSearch.Text = "";
            textBoxAddress.Text = comboBoxGender.Text =default;
            dataGridViewGuestInfo.DataSource = guest.GetGuests();
        }

        private void pictureBoxGuestLogo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar))
                e.Handled = true;
            errorProvider1.Clear();
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar)) 
            e.Handled = true;
            errorProvider1.Clear();
        }

        private void textBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar)) 
            e.Handled = true;
            errorProvider1.Clear();
        }

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar)) 
            e.Handled = true;
            errorProvider1.Clear();
        }

        private void comboBoxGender_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
