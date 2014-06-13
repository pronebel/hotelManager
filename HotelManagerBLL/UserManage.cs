using System;
using System.Collections.Generic;
using System.Text;
using HotelManagerDAL.SqlService;
using HotelManagerModels;

namespace HotelManagerBLL
{
   public class UserManage
    {

        UserService userSV = new UserService();



        /// <summary>
        /// ����û�
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Add(User user)
        {
            if (userSV.GetInfoByName(user.Name).Count > 0)
            {
                return -1;
            }
            else
            {
                return userSV.Add(user);
             
            }
          

        }

        /// <summary>
        /// �����û�
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Update(User user)
        {
            return userSV.Update(user);


        }


        /// <summary>
        /// �����û�����ȡ�û���Ϣ
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<User> GetInfoByName(string name)
        {
            return userSV.GetInfoByName(name);

        }

       public List<User> GetList()
       {
           return userSV.GetList();

       }
       public int Delete(Int32 userId)
       {
           return userSV.Delete(userId);
       }

    }
}
