using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace ASM_1618_Mark3
{
    public static class App
    {
        public static BookingScreen bookingScreen = new BookingScreen();
        public static ManagerConsole managerConsole = new ManagerConsole();
        private static string userNameCurrent = "admin";
        private static string passwordCurrent = "admin";
        public static List<Customer> customers = new List<Customer>();
        public static bool CheckPassword(string userNameInput, string passwordInput)
        {
            if (userNameInput == userNameCurrent && passwordInput == passwordCurrent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ChangePassword(string currentPasswordInput, string newPasswordInput, string newPasswordRepeatInput)
        {
            if (CheckPassword(userNameCurrent ,currentPasswordInput))
            {
                if (newPasswordInput != newPasswordRepeatInput)
                {
                    MessageBox.Show("PLease enter repeat password properly!");
                }
                else
                {
                    passwordCurrent = newPasswordInput;
                    WriteDataToMemory();
                    MessageBox.Show("Changed successfully!");
                }
            }
            else
            {
                MessageBox.Show("Wrong current password!");
            }
        }
        public static void WriteDataToMemory()
        {
            using (Stream stream = File.Open("CustomerObject.bin", FileMode.Create))
            {
                var bFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bFormatter.Serialize(stream, customers);
            }
            using (Stream passwordFile = File.Open("pwd.bin", FileMode.Create))
            {
                var bFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bFormatter.Serialize(passwordFile, passwordCurrent);
            }
        }
        public static void ReadDataFromMemory()
        {
            if (File.Exists("CustomerObject.bin"))
            {
                using (Stream stream = File.Open("CustomerObject.bin", FileMode.Open))
                {
                    var bFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    customers = (List<Customer>)bFormatter.Deserialize(stream);
                }
            }
            if (File.Exists("pwd.bin"))
            {
                using (Stream passwordFile = File.Open("pwd.bin", FileMode.Open))
                {
                    var bFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    passwordCurrent = (string)bFormatter.Deserialize(passwordFile);
                }
            }
        }
    }
}
