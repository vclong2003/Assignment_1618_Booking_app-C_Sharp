using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ASM_1618_Mark3
{
    public partial class ManagerConsole : Form
    {
        List<Customer> currentCustomerList;// = new List<Customer>();
        string searchMode = "name"; // name, phoneNumber, roomType
        public ManagerConsole()
        {
            InitializeComponent();
            timer1.Start();
        }
        protected override void OnClosed(EventArgs e)
        {
            Environment.Exit(0);
            base.OnClosed(e);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            App.bookingScreen.Show();
        }
        private void ManagerConsole_Load(object sender, EventArgs e)
        {

        }

        private void viewAllCustomerBtn_Click(object sender, EventArgs e)
        {
            searchMode = "";
            ClearPanel();
            roomPanel.Visible = false;
            allCustmerPanel.Visible = true;
            currentCustomerList = new List<Customer>();
            currentCustomerList = App.customers;
            App.customers.ForEach(element =>
            {
                listBoxCustomer.Items.Add(element.Name);
            });
        }

        private void listBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInformation(currentCustomerList[listBoxCustomer.SelectedIndex]);
        }
        private void ClearPanel()
        {
            listBoxCustomer.Items.Clear();
            gunaLabel1.Visible = false;
            gunaLabel6.Visible = false;
            gunaLabel5.Visible = false;
            gunaLabel7.Visible = false;
            gunaLabel4.Visible = false;
            gunaLabel2.Visible = false;
            durationLabel.Visible = false;
            gunaLabel3.Visible = false;
            nameBox.Text = "";
            ageBox.Text = "";
            phoneNumberBox.Text = "";
            addressBox.Text = "";
            roomTypeBox.Text = "";
            roomBox.Text = "";
            durationBox.Text = "";
            totalBillBox.Text = "";
        }
        private void ShowInformation(Customer obj)
        {
            gunaLabel1.Visible = true;
            gunaLabel6.Visible = true;
            gunaLabel5.Visible = true;
            gunaLabel7.Visible = true;
            gunaLabel4.Visible = true;
            gunaLabel2.Visible = true;
            durationLabel.Visible = true;
            gunaLabel3.Visible = true;
            nameBox.Text = obj.Name;
            ageBox.Text = obj.Age;
            phoneNumberBox.Text = obj.PhoneNumber;
            addressBox.Text = obj.Address;
            roomTypeBox.Text = obj.room.Type;
            roomBox.Text = obj.room.RoomNumber.ToString();
            durationBox.Text = obj.Duration.ToString() + " days";
            totalBillBox.Text = $"{obj.room.PricePerNight * obj.Duration}$";
        }

        private void searchByNameBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            roomPanel.Visible = false;
            allCustmerPanel.Visible = true;
            searchMode = "name";
            searchInput.Text = "";
            searchInput.Visible = true;
            roomTypeComboBox.Visible = false;
            searchPopup.Visible = true;
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            allCustmerPanel.Visible = true;
            ClearPanel();
            currentCustomerList = new List<Customer>();
            if (searchMode == "name")
            {
                App.customers.ForEach(element =>
                {
                    if (element.Name.ToLower() == searchInput.Text.ToLower())
                    {
                        currentCustomerList.Add(element);
                    }
                });
            }
            else if (searchMode == "phoneNumber")
            {
                App.customers.ForEach(element =>
                {
                    if (element.PhoneNumber.ToLower() == searchInput.Text.ToLower())
                    {
                        currentCustomerList.Add(element);
                    }
                });
            }
            else if (searchMode == "roomType")
            {
                App.customers.ForEach(element =>
                {
                    if (element.room.Type.ToLower() == roomTypeComboBox.Text.ToLower())
                    {
                        currentCustomerList.Add(element);
                    }
                });
            }
            currentCustomerList.ForEach(element =>
            {
                listBoxCustomer.Items.Add(element.Name);
            });
            searchPopup.Visible = false;
        }
        private void popupCloseBtn_Click(object sender, EventArgs e)
        {
            searchPopup.Visible = false;
        }

        private void searchByPhoneBtn_Click(object sender, EventArgs e)
        {
            ClearPanel();
            roomPanel.Visible = false;
            allCustmerPanel.Visible = true;
            searchMode = "phoneNumber";
            searchInput.Text = "";
            searchInput.Visible = true;
            roomTypeComboBox.Visible = false;
            searchPopup.Visible = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            roomTypeComboBox.Items.Clear();
            roomPanel.Visible = false;
            allCustmerPanel.Visible = true;
            Room.RoomTypes().ForEach(element =>
            {
                roomTypeComboBox.Items.Add(element);
            });
            ClearPanel();
            roomTypeComboBox.Text = "";
            searchInput.Visible = false;
            roomTypeComboBox.Visible = true;
            searchMode = "roomType";
            searchPopup.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (allCustmerPanel.Visible == true && listBoxCustomer.SelectedIndex >= 0)
            {
                editBtn.Visible = true;
            }
            else
            {
                editBtn.Visible = false;
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            int index = listBoxCustomer.SelectedIndex;
            nameEdittingTextBox.Text = currentCustomerList[index].Name;
            ageEdittingTextBox.Text = currentCustomerList[index].Age;
            phoneumberEdittingTextBox.Text = currentCustomerList[index].PhoneNumber;
            addressEditingTextBox.Text = currentCustomerList[index].Address;
            edittingPopup.Visible = true;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            edittingPopup.Visible = false;
        }
        private void edittingSaveButton_Click(object sender, EventArgs e)
        {
            int index = listBoxCustomer.SelectedIndex;
            currentCustomerList[index].Name = nameEdittingTextBox.Text;
            currentCustomerList[index].Age = ageEdittingTextBox.Text;
            currentCustomerList[index].PhoneNumber = phoneumberEdittingTextBox.Text;
            currentCustomerList[index].Address = addressEditingTextBox.Text;
            App.WriteDataToMemory();
            if (searchMode == "")
            {
                viewAllCustomerBtn.PerformClick();
            }
            else
            {
                searchBtn.PerformClick();
            }
            edittingPopup.Visible = false;
            MessageBox.Show("Done!");
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Room.UpdateRoomList(currentCustomerList[listBoxCustomer.SelectedIndex].room.Type, currentCustomerList[listBoxCustomer.SelectedIndex].room.RoomNumber);
            App.customers.Remove(currentCustomerList[listBoxCustomer.SelectedIndex]);
            App.WriteDataToMemory();
            if (searchMode == "")
            {
                viewAllCustomerBtn.PerformClick();
            }
            else
            {
                searchBtn.PerformClick();
            }
            edittingPopup.Visible = false;
            MessageBox.Show("Done!");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            allCustmerPanel.Visible = false;
            changePasswordPanel.Visible = true;
            roomPanel.Visible = false;
        }
        private void changePwdActionBtn_Click(object sender, EventArgs e)
        {
            App.ChangePassword(currentPasswordInput.Text, newPasswordInput.Text, repeatNewPasswordInput.Text);
            changePasswordPanel.Visible = false;
        }
        private void viewEmptyRoomBtn_Click(object sender, EventArgs e)
        {
            string roomAvaiable = "";
            List<string> roomTypes = Room.RoomTypes();
            roomTypes.ForEach(type =>
            {
                int count = 0;
                List<int> roomLeft = Room.FindAvailableRoom(type);
                string tempRow = type+": ";
                roomLeft.ForEach(element =>
                {
                    tempRow += $"Room {element} ";
                    count++;
                });
                if (count == 0)
                {
                    tempRow += "none";
                }
                roomAvaiable += tempRow + "; ";
            });
            roomPanel.Visible = true;
            roomLabel.Text = roomAvaiable;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
