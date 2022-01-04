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
    public partial class RoomUserControl : UserControl
    {
        public RoomUserControl()
        {
            InitializeComponent();
        }


        private void RoomUserControl_Load(object sender, EventArgs e)
        {
            HotelDbContext.fillRoomType(roomTypeComboBox);
            HotelDbContext.ShowRoomTypes(roomTypeDataGridView);
            HotelDbContext.ShowRoomIds(RoomsDataGridView);

        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            if (HotelDbContext.AddRoomType(roomTypeTextBox, roomPriceTextBox, errorProvider1))
            {
                HotelDbContext.fillRoomType(roomTypeComboBox);
                HotelDbContext.ShowRoomTypes(roomTypeDataGridView);
                HotelDbContext.ShowRoomIds(RoomsDataGridView);

                clearFieldsBtn.PerformClick();
            }

        }

        private void roomTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomTypeTextBox.Text = roomTypeDataGridView.CurrentRow.Cells[0].Value.ToString();
            roomPriceTextBox.Text = roomTypeDataGridView.CurrentRow.Cells[1].Value.ToString();
            roomTypeTextBox.Enabled = false;
        }

        private void clearFieldsBtn_Click(object sender, EventArgs e)
        {
            roomTypeTextBox.Text = "";
            roomTypeTextBox.Enabled = true;
            roomPriceTextBox.Text = "";
            errorProvider1.Clear();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.EditRoomType(roomTypeTextBox, roomPriceTextBox, errorProvider1);
            HotelDbContext.ShowRoomTypes(roomTypeDataGridView);
            HotelDbContext.ShowRoomIds(RoomsDataGridView);

            clearFieldsBtn.PerformClick();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.DeleteRoomType(roomTypeTextBox, errorProvider1);
            HotelDbContext.ShowRoomTypes(roomTypeDataGridView);
            HotelDbContext.ShowRoomIds(RoomsDataGridView);

            clearFieldsBtn.PerformClick();
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomPriceLabel.Text = HotelDbContext.getRoomPrice(roomTypeComboBox.Text).ToString();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            if (HotelDbContext.AddRoomId(roomTypeComboBox, errorProvider1))
            {
                HotelDbContext.ShowRoomIds(RoomsDataGridView);
                clearFieldRoomsBtn.PerformClick();

            }
        }
        private void editRoomBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.EditRoomId(roomIdLabel, roomTypeComboBox, errorProvider1);
            HotelDbContext.ShowRoomIds(RoomsDataGridView);
            clearFieldRoomsBtn.PerformClick();
        }

        private void deleteRoomBtn_Click(object sender, EventArgs e)
        {
            HotelDbContext.DeleteRoomId(roomIdLabel, errorProvider1);
            HotelDbContext.ShowRoomIds(RoomsDataGridView);
            clearFieldRoomsBtn.PerformClick();
        }

        private void RoomsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomIdLabel.Visible = roomIdKeyLabel.Visible = true;
            roomIdLabel.Text = RoomsDataGridView.CurrentRow.Cells[0].Value.ToString();
            roomTypeComboBox.Text = RoomsDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void clearFieldRoomsBtn_Click(object sender, EventArgs e)
        {
            roomIdLabel.Text = "";
            roomTypeComboBox.Text = "";
            roomPriceLabel.Text = "";
            roomIdLabel.Visible = roomIdKeyLabel.Visible = false;
            errorProvider1.Clear();
        }

        private void roomIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void roomPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void roomTypeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
