using System;
using System.Collections.Generic;
using System.Text;
using HotelManagerDAL.SqlService;
using HotelManagerIDAL;

namespace HotelManagerDALFactory
{
    public class SqlDALFactory:AbstractDALFactory
    {

        public override IHotelService CreateHotelService()
        {
            return new HotelService();
        }

        public override IRoomService CreateRoomService()
        {
            return new RoomService();
        }
    }
}
