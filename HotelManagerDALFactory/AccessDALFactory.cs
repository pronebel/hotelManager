using System;
using System.Collections.Generic;
using System.Text;
using HotelManagerDAL.Access;

namespace HotelManagerDALFactory
{
    public  class AccessDALFactory:AbstractDALFactory
    {
        public override HotelManagerIDAL.IHotelService CreateHotelService()
        {
            return new HotelService();
        }

        public override HotelManagerIDAL.IRoomService CreateRoomService()
        {
            return new RoomService();
        }
    }
}
