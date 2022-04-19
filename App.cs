using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (userNameInput == userNameCurrent && passwordInput== passwordCurrent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
