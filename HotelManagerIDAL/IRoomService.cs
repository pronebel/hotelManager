using System;
using System.Collections.Generic;
using System.Text;
using HotelManagerModels;

namespace HotelManagerIDAL
{
     public interface  IRoomService
    {
         List<Room> GetRoomByRoomNumber(string roomNumber);
         int GetRoomIDByRoomNumber(string roomNubmer);
         int AddRoom(Room room);
         int UpdateRoom(Room room);
         int DeleteRoom(string number);
         List<RoomType> GetRoomType();
         string GetTypeNameByTypeID(int TypeID);
         int GetTypePriceByTypeID(int TypeID);
         int GetTypePriceByTypeName(string TypeName);
         int GetTypeIDByTypeName(string TypeName);
    }
}
