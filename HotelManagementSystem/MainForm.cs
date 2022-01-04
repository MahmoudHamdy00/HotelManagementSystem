using HotelManagementSystem.UserControls;
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
    public partial class MainForm : Form
    {
        Panel chooseIndicatorPanel;
        GuestUserControl guestUserControl1;
        PaymentUserControl paymentUserControl;
        RoomUserControl roomUserControl;
        ReservationUserControl reservationUserControl;
        SettingsUserControl settingsUserControl;
        public MainForm()
        {
            InitializeComponent();
            chooseIndicatorPanel = new Panel();
            this.Controls.Add(chooseIndicatorPanel);
            chooseIndicatorPanel.BackColor = Color.Green;
            chooseIndicatorPanel.BringToFront();
            chooseIndicatorPanel.Width = 5;
            chooseIndicatorPanel.Visible = false;

            guestUserControl1 = new GuestUserControl();
            guestUserControl1.Dock = DockStyle.Fill;
            guestUserControl1.Visible = false;
            panel2.Controls.Add(guestUserControl1);

            paymentUserControl = new PaymentUserControl();
            paymentUserControl.Dock = DockStyle.Fill;
            paymentUserControl.Visible = false;
            panel2.Controls.Add(paymentUserControl);

            roomUserControl = new RoomUserControl();
            roomUserControl.Dock = DockStyle.Fill;
            roomUserControl.Visible = false;
            panel2.Controls.Add(roomUserControl);

            reservationUserControl = new ReservationUserControl();
            reservationUserControl.Dock = DockStyle.Fill;
            reservationUserControl.Visible = false;
            panel2.Controls.Add(reservationUserControl);

            settingsUserControl = new SettingsUserControl();
            settingsUserControl.Dock = DockStyle.Fill;
            settingsUserControl.Visible = false;
            panel2.Controls.Add(settingsUserControl);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Do you really want to exit the app...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult != DialogResult.Yes) e.Cancel = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void changeChooseIndicatorPanelPosition(Button button)
        {
            chooseIndicatorPanel.Top = button.Top + button.Height / 10;
            chooseIndicatorPanel.Height = button.Height - button.Height / 5;
            chooseIndicatorPanel.Left = button.Left - chooseIndicatorPanel.Width - 2;
            chooseIndicatorPanel.Visible = true;

        }
        private void changeUserControl(Button button)
        {
            if (button.Text == "Guest")
                guestUserControl1.Visible = true;
            else guestUserControl1.Visible = false;

            if (button.Text == "Reservation")
                reservationUserControl.Visible = true;
            else reservationUserControl.Visible = false;

            if (button.Text == "Room")
                roomUserControl.Visible = true;
            else roomUserControl.Visible = false;

            if (button.Text == "Payment")
                paymentUserControl.Visible = true;
            else paymentUserControl.Visible = false;

            if (button.Text == "Settings")
                settingsUserControl.Visible = true;
            else settingsUserControl.Visible = false;

        }
        private void guestBtn_Click(object sender, EventArgs e)
        {
            changeChooseIndicatorPanelPosition((Button)sender);
            changeUserControl((Button)sender);
        }

        private void ReservationBtn_Click(object sender, EventArgs e)
        {
            changeChooseIndicatorPanelPosition((Button)sender);
            changeUserControl((Button)sender);
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            changeChooseIndicatorPanelPosition((Button)sender);
            changeUserControl((Button)sender);

        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            changeChooseIndicatorPanelPosition((Button)sender);
            changeUserControl((Button)sender);

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            changeChooseIndicatorPanelPosition((Button)sender);
            changeUserControl((Button)sender);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            guestBtn.PerformClick();
        }
    }
}
