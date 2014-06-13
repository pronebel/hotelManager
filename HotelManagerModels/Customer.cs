using System;
using System.Collections.Generic;
using System.Text;



namespace HotelManagerModels
{
     public class Customer
    {
         public Customer() { }
         public Customer(int customerId, string roomId, string name, string sex, string identifyNumber, string phone, int charge, DateTime checkinDate, DateTime checkoutDate, int userNum, string isAddBed, string isPayOff,DateTime addtime)
         {
             this.CustomerId = customerId;
             this.RoomId = roomId;
             this.Name = name;
             this.Sex = sex;
             this.IdentifyNumber = identifyNumber;
             this.Phone = phone;
             this.Charge = charge;
             this.CheckinDate = checkinDate;
             this.CheckoutDate = checkoutDate;
             this.UserNum = userNum;
             this.IsAddBed = isAddBed;
             this.IsPayOff = isPayOff;
             this.AddTime = addTime;
         }
         public Customer(int customerId, string roomId, string name, string sex, string identifyNumber, string phone, int charge, DateTime checkinDate, DateTime checkoutDate, int userNum, string isAddBed, string isPayOff)
         {
             this.CustomerId = customerId;
             this.RoomId = roomId;
             this.Name = name;
             this.Sex = sex;
             this.IdentifyNumber = identifyNumber;
             this.Phone = phone;
             this.Charge = charge;
             this.CheckinDate = checkinDate;
             this.CheckoutDate = checkoutDate;
             this.UserNum = userNum;
             this.IsAddBed = isAddBed;
             this.IsPayOff = isPayOff;
         }


         private int customerId;
         public int CustomerId
         {
             get { return customerId; }
             set { customerId = value; }
         }

         private string roomId;
         public string RoomId
         {
             get { return roomId; }
             set { roomId = value; }
         }


         private string name;
         public string Name
         {
             get { return name; }
             set { name = value; }
         }

         private string sex;
         public string Sex
         {
             get { return sex; }
             set { sex = value; }
         }


         private string identifyNumber;
         public string IdentifyNumber
         {
             get { return identifyNumber; }
             set { identifyNumber = value; }
         }


         private string phone;
         public string Phone
         {
             get { return phone; }
             set { phone = value; }
         }



         private int charge;
         public int Charge
         {
             get { return charge; }
             set { charge = value; }
         }


         private DateTime addTime;
         public DateTime AddTime
         {
             get { return addTime; }
             set { addTime = value; }
         }

         private DateTime checkinDate;
         public DateTime CheckinDate
         {
             get { return checkinDate; }
             set { checkinDate = value; }
         }

         private DateTime checkoutDate;
         public DateTime CheckoutDate
         {
             get { return checkoutDate; }
             set { checkoutDate = value; }
         }

         private int userNum;
         public int UserNum
         {
             get { return userNum; }
             set { userNum = value; }
         }


         private string isAddBed;
         public string IsAddBed
         {
             get { return isAddBed; }
             set { isAddBed = value; }
         }

         private string isPayOff;
         public string IsPayOff
         {
             get { return isPayOff; }
             set { isPayOff = value; }
         }




    }
}
