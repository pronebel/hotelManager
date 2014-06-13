
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
        /// ��ȡ���е���ס��¼
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
        /// ɾ����Ϣ
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public string DeleteById(int CustomId)
        {
            List<Customer> record = curstomerSV.GetItemById(CustomId);
            if (record.Count == 0)
            {
                return "��ǰû��Ҫɾ���ĸü�¼";

            }
            else
            {
                


                string message = string.Empty;
                int number = 0;
                number = curstomerSV.DeleteById(CustomId);


                if (number > 0)
                {
                    message = "ɾ���ɹ���";

                    if (record[0].IsPayOff.Trim() == "��")
                    {
                        roomManage.UpdateRoomState(record[0].RoomId, "����");
                    }

                }
                else
                {
                    message = "ɾ��ʧ�ܣ�";
                }
                    return message;


            }

     

          
        }

 
        /// <summary>
        /// ���ݷ���Ų�������δ���ѵļ�¼
        /// </summary>
        /// <param name="roomnum"></param>
        /// <returns></returns>
        public List<Customer> GetListIsNoPay(string roomnum)
        {
            return curstomerSV.GetListIsNoPay(roomnum);
        }

        /// <summary>
        /// ��ס�Ǽ�
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string Add(Customer user)
        {
            string message = string.Empty;
   
            List<Room> rooms = roomSV.GetRoomDetailByRoomNumber(user.RoomId);
            if ( rooms.Count ==0)
            {
                message = "-1";// ���䲻���ڣ�
            }
            else
            {
                if (rooms[0].State != "����")
                {
                    message = "-2";//��ǰ���䲻�ǿ���״̬
                }
                else{


                    if (this.GetListIsNoPay(user.RoomId).Count > 0)
                    {
                        message = "-3";//��ǰ����δ����
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



                        if (user.IsAddBed == "��")
                        {
                            charge += Convert.ToInt32(days * addBedPrice);

                        }

                        user.Charge = charge;


                        if (curstomerSV.Add(user) > 0)
                        {
                            message = charge.ToString();

                            roomSV.UpdateRoomState(user.RoomId, "��ס");

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
        /// �����û���ס����״̬
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
        /// �����û���Ϣ��ѯ��ס�ǼǼ�¼
        /// </summary>
        /// <param name="cardNum"></param>
        /// <param name="TelNum"></param>
        /// <returns></returns>
        public List<Customer> GetListByUserInfo(string cardNum,string TelNum){


            return curstomerSV.GetListByUserInfo(cardNum, TelNum);
        }


    }
}
