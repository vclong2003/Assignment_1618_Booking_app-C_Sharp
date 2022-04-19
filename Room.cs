using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ASM_1618_Mark3
{
    public class Room
    {
        private static Dictionary<string, List<int>> roomList = new Dictionary<string, List<int>>()
        {
            {"Standard", new List<int>() { 1000, 1, 2, 3 } },
            {"Deluxe", new List<int>() { 1500, 4, 5 } },
            {"Family Suite", new List<int>() { 2000, 6 } }
        };

        public static string test = "success!";
        public string Type { get; set; }
        public int RoomNumber { get; set; }
        public int PricePerNight { get; set; }
        public Room(string type, int roomNumber)
        {
            this.Type = type;
            this.RoomNumber = roomNumber;
            foreach (KeyValuePair<string, List<int>> pair in roomList)
            {
                if (pair.Key == this.Type)
                {
                    this.PricePerNight = pair.Value[0];
                }
            }
            roomList[this.Type].Remove(this.RoomNumber);
        }
        public static List<int> FindAvailableRoom(string roomType)
        {
            return roomList[roomType];
        }
        public static List<string> RoomTypes()
        {
            List<string> roomTypes = new List<string>();
            foreach (KeyValuePair<string, List<int>> pair in roomList)
            {
                roomTypes.Add(pair.Key);
            }
            return roomTypes;
        }
    }
}
