using System;
using System.Collections.Generic;
using System.Text;
using HotelManagerModels;


namespace HotelManagerIDAL
{
    public interface IHotelService
    {
        List<RoomType> GetRoomTypeListByTypeName(string name);
        int GetTypeIDByTypeName(string TypeName);
        int AddRoomType(RoomType rt);
        int UpdateRoomType(RoomType rt);
        int DeleteRoomType(string name);
    }
}
