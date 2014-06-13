using System;
using System.Collections.Generic;
using System.Text;
using HotelManagerDAL.SqlService;

using HotelManagerModels;

namespace HotelManagerBLL
{
    public class RoomTypeManage
    {

        RoomManage roomManage = new RoomManage();

        private RoomTypeService hotelService = new RoomTypeService();

        public List<RoomType> GetRoomTypeListByTypeName(string name)
        {
            return hotelService.GetRoomTypeListByTypeName(name);
        }

        /// <summary>
        /// 根据房间类型id获取房间类型列表
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public List<RoomType> GetRoomTypeListByTypeId(int typeid)
        {
          return  hotelService.GetRoomTypeListByTypeId(typeid);
        }


        public string UpdateRoomType(RoomType rt)
        {
            string message = string.Empty;
            string TypeName = rt.TypeName;
            int TypeID = 0;
            TypeID = hotelService.UpdateRoomType(rt) ;
            if (TypeID > 0)
                message = "更新成功！";
            else
                message = "更新失败！";
            return message;
        }
        public string AddRoomType(RoomType rt)
        {
            string message = string.Empty;
            string TypeName = rt.TypeName;
            int TypeID = 0;
            TypeID = hotelService.GetTypeIDByTypeName(TypeName);
            if (TypeID > 0)
            {
                message = "此类型房型已存在，请更换类型名称！";
            }
            else
            {
                TypeID = hotelService.AddRoomType(rt);
                if (TypeID > 0)
                    message = "创建房型成功！";
                else
                    message = "创建房型失败！";
            }
            return message;
        }

        /// <summary>
        /// 删除房间类型
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string DeleteRoomType(string name)
        {
            //检查是否当前类型有被房间信息使用


           
            List<Room> roomList = roomManage.GetRoomByRoomTypeName(name);

            if (roomList.Count > 0)
            {
                return "不可以删除当前类型，有" + roomList.Count + "个房间信息正在使用该房间类型，请先删除房间信息！";
               
            }
            else
            {
                string message = string.Empty;
                int number = 0;
                number = hotelService.DeleteRoomType(name);
                if (number > 0)
                    message = "删除成功！";
                else
                    message = "删除失败！";
                return message;

            }

        }
    }
}
