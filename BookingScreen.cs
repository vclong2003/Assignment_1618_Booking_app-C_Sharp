using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_1618_Mark3
{
    public partial class BookingScreen : Form
    {
        public BookingScreen()
        {
            InitializeComponent();
            Room.RoomTypes().ForEach(element =>
            {
                roomTypeComboBox.Items.Add(element);
            });
            timer1.Start();
        }
        protected override void OnClosed(EventArgs e)
        {
            Environment.Exit(0);
            base.OnClosed(e);
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.comfirmPopup.Visible = true;
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> availableRooms = Room.FindAvailableRoom(roomTypeComboBox.Text);
            roomNumberComboBox.Items.Clear();
            if (availableRooms.Count <= 1)
            {
                MessageBox.Show("Sorry, this type of room has out of room, please choose another type!");
            }
            else
            {
                for (int i = 1; i < availableRooms.Count; i++)
                {
                    roomNumberComboBox.Items.Add(availableRooms[i]);
                }
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (customerName.Text != "" && customerAge.Text != "" && customerAddress.Text != "" && customerIdCard.Text != "" && roomTypeComboBox.Text != "" && roomNumberComboBox.Text != "" && durationTextBox.Text != "")
            {
                bookButton.Visible = true;
            }
        }

        private void roomNumberComboBox_Click(object sender, EventArgs e)
        {

        }

        private void managerLoginButton_Click(object sender, EventArgs e)
        {
            LoginPopup.Visible = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoginPopup.Visible = false;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            App.customers.Add(new Customer(customerName.Text, customerIdCard.Text, customerAge.Text, customerAddress.Text, roomTypeComboBox.Text, Convert.ToInt32(roomNumberComboBox.Text), Convert.ToInt32(durationTextBox.Text)));
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.comfirmPopup.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (App.CheckPassword(usernameTextBox.Text, passwordTextBox.Text))
            {
                // this.managerConsole.Show();
                App.managerConsole.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }
    }
}
