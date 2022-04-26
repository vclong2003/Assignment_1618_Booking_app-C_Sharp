using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ASM_1618_Mark3
{
    public partial class BookingScreen : Form
    {
        public BookingScreen()
        {
            InitializeComponent();
            ClearInput();
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
            confirmationNameValue.Text = customerName.Text;
            confirmationAgeValue.Text = customerAge.Text;
            confirmationAddressValue.Text = customerAddress.Text;
            confirmationPhoneValue.Text = customerPhoneNumber.Text;
            roomTypeConfirmation.Text = roomTypeComboBox.Text;
            roomNumConfirmation.Text= roomNumberComboBox.Text;
            durationConfirmation.Text = durationTextBox.Text;
            priceConfirmation.Text = $"Price {Room.GetPricePerDay(roomTypeComboBox.Text) * Convert.ToInt32(durationTextBox.Text)}$";
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
            pricePerDayBox.Text = Room.GetPricePerDay(roomTypeComboBox.Text).ToString();

            if (availableRooms.Count <= 0)
            {
                MessageBox.Show("Sorry, this type of room has out of room, please choose another type!");
            }
            else
            {
                for (int i = 0; i < availableRooms.Count; i++)
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
            if (customerName.Text != "" && customerAge.Text != "" && customerAddress.Text != "" && customerPhoneNumber.Text != "" && roomTypeComboBox.Text != "" && roomNumberComboBox.Text != "" && durationTextBox.Text != "")
            {
                bookButton.Visible = true;
            } else
            {
                bookButton.Visible = false;
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
            App.customers.Add(new Customer(customerName.Text, customerPhoneNumber.Text, customerAge.Text, customerAddress.Text, roomTypeComboBox.Text, Convert.ToInt32(roomNumberComboBox.Text), Convert.ToInt32(durationTextBox.Text)));
            ClearInput();
            comfirmPopup.Visible = false;
            MessageBox.Show("Your room has been booked, thank you for choosing our service!");
            App.WriteDataToMemory();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.comfirmPopup.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (App.CheckPassword(usernameTextBox.Text, passwordTextBox.Text))
            {
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
                App.managerConsole.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong usenamr or password!");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void pricePerDayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookingScreen_Load(object sender, EventArgs e)
        {

        }
        private void ClearInput()
        {
            customerName.Clear();
            customerPhoneNumber.Clear();
            customerAge.Clear();
            customerAddress.Clear();
            pricePerDayBox.Clear();
            roomTypeComboBox.Items.Clear();
            Room.RoomTypes().ForEach(element =>
            {
                roomTypeComboBox.Items.Add(element);
            });
            roomNumberComboBox.Items.Clear();
            durationTextBox.Clear();
        }
    }
}
