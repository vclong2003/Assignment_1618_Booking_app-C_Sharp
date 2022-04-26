using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace ASM_1618_Mark3
{
    [Serializable]
    public class Room
    {
        private static Dictionary<string, List<int>> roomLeft = new Dictionary<string, List<int>>()
        {
            {"Standard", new List<int>() { 1, 2, 3 } },
            {"Deluxe", new List<int>() { 4, 5 } },
            {"Family Suite", new List<int>() { 6 } }
        };
        private static Dictionary<string, int> roomPrice = new Dictionary<string, int>()
        {
            {"Standard", 1000 },
            {"Deluxe", 1500 },
            {"Family Suite", 2000 }
        };
        public string Type { get; set; }
        public int RoomNumber { get; set; }
        public int PricePerNight { get; set; }
        public Room(string type, int roomNumber)
        {
            this.Type = type;
            this.RoomNumber = roomNumber;
            this.PricePerNight = roomPrice[this.Type];
            roomLeft[this.Type].Remove(this.RoomNumber);
            SaveDataToMemory();
        }
        public static List<int> FindAvailableRoom(string roomType)
        {
            return roomLeft[roomType];
        }
        public static List<string> RoomTypes()
        {
            List<string> roomTypes = new List<string>();
            foreach (KeyValuePair<string, List<int>> pair in roomLeft)
            {
                roomTypes.Add(pair.Key);
            }
            return roomTypes;
        }
        public static int GetPricePerDay(string roomType)
        {
            return roomPrice[roomType];
        }
        public static void SaveDataToMemory()
        {
            using (Stream stream = File.Open("Room.bin", FileMode.Create))
            {
                var bFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bFormatter.Serialize(stream, roomLeft);
            }
        }
        public static void ReadDataFromMemory()
        {
            if (File.Exists("Room.bin"))
            {
                using (Stream stream = File.Open("Room.bin", FileMode.Open))
                {
                    var bFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    roomLeft = (Dictionary<string, List<int>>)bFormatter.Deserialize(stream);
                }
            }
        }
        public static void UpdateRoomList(string roomType, int roomNUmber)
        {
            roomLeft[roomType].Add(roomNUmber);
            roomLeft[roomType] = roomLeft[roomType].OrderBy(x => x).ToList();
            SaveDataToMemory();
        }
    }
}
