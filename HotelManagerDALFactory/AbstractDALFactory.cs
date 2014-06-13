using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using HotelManagerIDAL;


namespace HotelManagerDALFactory
{
    public abstract class AbstractDALFactory
    {
        public abstract IHotelService CreateHotelService();

        public abstract IRoomService CreateRoomService();

        public static AbstractDALFactory ChooseFactory()
        {
            AbstractDALFactory factory = null;
            string DbType = ConfigurationManager.AppSettings["DbType"].ToString();
            switch (DbType)
            {
                case "sql": factory = new SqlDALFactory(); break;
                case "Access": factory = new AccessDALFactory(); break;
            }
            return factory;
        }
    }
}
