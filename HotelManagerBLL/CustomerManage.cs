
using System;
using System.Collections.Generic;
using System.Text;
using HotelManagerDAL.SqlService;
using HotelManagerModels;

namespace HotelManagerBLL
{
    public class CustomerManage
    {

        private RoomManage roomManage = new RoomManage();
        private CustomerService curstomerSV = new CustomerService();
        private RoomService roomSV = new RoomService();
        private RoomTypeService roomTypeSV = new RoomTypeService();

        /// <summary>
        /// 获取所有的入住记录
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAll()
        {
            return curstomerSV.GetAll();
        }



        public List<Customer> GetListByRoomNumber(string roomNumber)
        {

           return curstomerSV.GetListByRoomNumber(roomNumber);

        }

        /// <summary>
        /// 删除信息
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public string DeleteById(int CustomId)
        {
            List<Customer> record = curstomerSV.GetItemById(CustomId);
            if (record.Count == 0)
            {
                return "当前没有要删除的该记录";

            }
            else
            {
                


                string message = string.Empty;
                int number = 0;
                number = curstomerSV.DeleteById(CustomId);


                if (number > 0)
                {
                    message = "删除成功！";

                    if (record[0].IsPayOff.Trim() == "否")
                    {
                        roomManage.UpdateRoomState(record[0].RoomId, "空闲");
                    }

                }
                else
                {
                    message = "删除失败！";
                }
                    return message;


            }

     

          
        }

 
        /// <summary>
        /// 根据房间号查找所有未付费的记录
        /// </summary>
        /// <param name="roomnum"></param>
        /// <returns></returns>
        public List<Customer> GetListIsNoPay(string roomnum)
        {
            return curstomerSV.GetListIsNoPay(roomnum);
        }

        /// <summary>
        /// 入住登记
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Add(Customer user)
        {
            string message = string.Empty;
   
            List<Room> rooms = roomSV.GetRoomDetailByRoomNumber(user.RoomId);
            if ( rooms.Count ==0)
            {
                message = "-1";// 房间不存在！
            }
            else
            {
                if (rooms[0].State != "空闲")
                {
                    message = "-2";//当前房间不是空闲状态
                }
                else{


                    if (this.GetListIsNoPay(user.RoomId).Count > 0)
                    {
                        message = "-3";//当前房间未结清
                    }
                    else
                    {

                        RoomType roomTypeDetail = roomTypeSV.GetRoomTypeListByTypeId(Convert.ToInt32(rooms[0].TypeID))[0];

                        double roomPrice = roomTypeDetail.TypePrice;
                        double addBedPrice = roomTypeDetail.AddBedPrice;


                        TimeSpan dateDif = user.CheckoutDate.Subtract(user.CheckinDate);
                        int days = dateDif.Days;
                        if (days == 0)
                        {
                            days = 1;
                        }
                        int charge = Convert.ToInt32(days * roomPrice); 



                        if (user.IsAddBed == "是")
                        {
                            charge += Convert.ToInt32(days * addBedPrice);

                        }

                        user.Charge = charge;


                        if (curstomerSV.Add(user) > 0)
                        {
                            message = charge.ToString();

                            roomSV.UpdateRoomState(user.RoomId, "入住");

                        }
                        else
                        {
                            message = "0";
                        }

                    }



                
                }
           
            }
            return message;
        }


        /// <summary>
        /// 更新用户入住款项状态
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public int UpdateChargeState(int userid, string state)
        {
            int nRet =  curstomerSV.UpdateChargeState(userid, state);
            return nRet;

        }


        /// <summary>
        /// 根据用户信息查询入住登记记录
        /// </summary>
        /// <param name="cardNum"></param>
        /// <param name="TelNum"></param>
        /// <returns></returns>
        public List<Customer> GetListByUserInfo(string cardNum,string TelNum){


            return curstomerSV.GetListByUserInfo(cardNum, TelNum);
        }


    }
}
