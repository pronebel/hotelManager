using System;
using System.Collections.Generic;
using System.Text;
using HotelManagerDAL.SqlService;
using HotelManagerModels;

namespace HotelManagerBLL
{
    public class RoomManage
    {


        private RoomService roomService = new RoomService();
        private RoomTypeService roomTypeService = new RoomTypeService();

        /// <summary>
        /// 获取房间信息根据 房间number,或者房间类型id，或者房间状态
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <param name="typeId"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public List<Room> GetRoomByRoomNumber(string roomNumber,int typeId,string state)
        {
            return roomService.GetRoomByRoomNumber(roomNumber,typeId,state);
        }

        /// <summary>
        /// 根据房间类型名称获取房间信息列表
        /// </summary>
        /// <param name="RoomTypeName"></param>
        /// <returns></returns>
        public List<Room> GetRoomByRoomTypeName(string RoomTypeName)
        {
            int roomTypeId = this.GetTypeIDByTypeName(RoomTypeName);
            return this.GetRoomByRoomNumber("", roomTypeId, "全部");


        }

        /// <summary>
        /// 获取全部房间
        /// </summary>
        /// <returns></returns>
        public List<Room> GetAllRoom()
        {
            return roomService.GetAllRoom();
        }
        /// <summary>
        /// 更新房间信息
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public string UpdateRoom(Room room)
        {
            string message = string.Empty;
            int roomID = 0;
            roomID = roomService.UpdateRoom(room);
            if (roomID > 0)
        
                message = "更新成功！";
            else
                message = "更新失败！";
            return message;
        }

        /// <summary>
        /// 添加房间信息
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public string AddRoom(Room room)
        {
            string message = string.Empty;
            string roomNumber = room.Number;
            int roomID = 0;
            roomID = roomService.GetRoomIDByRoomNumber(roomNumber);
            if (roomID > 0)
            {
                message = "此房间号已存在，请更换！";
            }
            else
            {
                roomID = roomService.AddRoom(room);
                if (roomID > 0)
                    message = "创建房间号成功！";
                else
                    message = "创建房间号失败！";
            }
            return message;
        }

        /// <summary>
        /// 删除房间信息
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public string DeleteRoom(string roomNumber)
        {

            CustomerManage customerM = new CustomerManage();

            List<Customer> customerListNoPay = customerM.GetListIsNoPay(roomNumber);

            if (customerListNoPay.Count > 0)
            {
                return "房间号" + roomNumber + "的房间有入住登记处于未付费状态，请先处理该记录再进行删除";
            }
            else
            {
                string message = string.Empty;
                int number = 0;
                number = roomService.DeleteRoom(roomNumber);
                if (number > 0)
                    message = "删除成功！";
                else
                    message = "删除失败！";
                return message;
            }


           
        }

        public List<RoomType> GetRoomType()
        {
            return roomService.GetRoomType();
        }

        /// <summary>
        /// 根据房间类型id获取房间类型名称
        /// </summary>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public string GetTypeNameByTypeID(int TypeID)
        {
            return roomTypeService.GetTypeNameByTypeID(TypeID);
        }

        /// <summary>
        /// 根据房间类型id获取房间类型价格
        /// </summary>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public int GetTypePriceByTypeID(int TypeID)
        {
            return roomService.GetTypePriceByTypeID(TypeID);
        }
        /// <summary>
        /// 根据房间类型名称获取房间类型价格
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public int GetTypePriceByTypeName(string TypeName)
        {
            return roomService.GetTypePriceByTypeName(TypeName);
        }
        /// <summary>
        /// 根据房间类型名称获取房间类型ID
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public int GetTypeIDByTypeName(string TypeName)
        {
            return roomTypeService.GetTypeIDByTypeName(TypeName);
        }

        /// <summary>
        /// 更新房间类型
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public int UpdateRoomState(string roomNumber, string state)
        {
            return roomService.UpdateRoomState(roomNumber, state);
        }

    }
}
