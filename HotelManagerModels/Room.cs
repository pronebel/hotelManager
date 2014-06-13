using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagerModels
{
     public class Room
    {
         public Room() { }
         public Room(int roomID,string number,int bedNumber,string description,string state,int guestNumber,int typeID)
         {
             this.RoomID = roomID;
             this.Number = number;
             this.BedNumber = bedNumber;
             this.Description = description;
             this.State = state;
             this.GuestNumber = guestNumber;
             this.TypeID = typeID;
         }
         private int typeID;

         public int TypeID
         {
             get { return typeID; }
             set { typeID = value; }
         }

        
        private int guestNumber;

        public int GuestNumber
        {
            get { return guestNumber; }
            set { guestNumber = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int bedNumber;

        public int BedNumber
        {
            get { return bedNumber; }
            set { bedNumber = value; }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        private int roomID;

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
    }
}
