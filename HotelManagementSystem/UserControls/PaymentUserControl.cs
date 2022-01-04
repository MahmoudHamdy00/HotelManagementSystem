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
    public partial class PaymentUserControl : UserControl
    {
        public PaymentUserControl()
        {
            InitializeComponent();
        }

        private void tab2SSNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                HotelDbContext.ShowPayments(SSNTextBox.Text, dataGridView1);
                reservationLabel.Text = "";
                totalPriceLabel.Text = "";
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar !=(char) Keys.Back)
                e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reservationLabel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            totalPriceLabel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
