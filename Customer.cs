using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1618_Mark3
{
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }

        public int Duration { get; set; }
        public int TotalBill { get; set; }
        public Room room;
        public Customer(string name, string phoneNumber, string age, string address, string roomType, int roomNumber, int stayingNights)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
            this.Address = address;
            this.Duration = stayingNights;
            room = new Room(roomType, roomNumber);
            this.TotalBill = room.PricePerNight * Duration;
        }
    }
}
