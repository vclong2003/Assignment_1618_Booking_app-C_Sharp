using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1618_Mark3
{
    public class Customer
    {
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public int TotalBill { get; set; }
        Room room;
        public Customer(string name, string idNUmber, string age, string address, string roomType, int roomNumber, int stayingNights)
        {
            this.Name = name;
            this.IdNumber = idNUmber;
            this.Age = age;
            this.Address = address;
            room = new Room(roomType, roomNumber);
            this.TotalBill = room.PricePerNight * stayingNights;
        }
    }
}
