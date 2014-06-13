using System;
using System.Collections.Generic;
using System.Text;

using HotelManagerModels;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace HotelManagerDAL.SqlService
{
 public   class CustomerService

    {


     /// <summary>
     /// sql数据库连接字符
     /// </summary>
        public static string connString = ConfigurationManager.ConnectionStrings["SqlConnString"].ConnectionString.ToString();


     /// <summary>
     /// 更新入住记录的付费状态
     /// </summary>
     /// <param name="userid">入住登记的id</param>
     /// <param name="state">是，否</param>
     /// <returns></returns>
     public int UpdateChargeState(int userid, string state)
     {
         string sql = "update customer set isPayOff='" + state + "' where CustomerId=" + userid;

         int number = 0;
         using (SqlConnection conn = new SqlConnection(connString))
         {
             SqlCommand comm = new SqlCommand(sql, conn);
             conn.Open();
             number = Convert.ToInt32(comm.ExecuteNonQuery());
         }
         return number;
     }

        /// <summary>
        /// 获取所有的订单记录
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(connString))
            {



                string sql = "SELECT * FROM Customer order by addtime desc ";


                SqlCommand comm = new SqlCommand(sql, conn);

                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Customer user = new Customer();

                        user.CustomerId = Convert.ToInt32(dr["CustomerId"]);
                        user.RoomId = dr["RoomId"].ToString() ;
                        user.Name = dr["Name"].ToString();
                        user.Sex = dr["Sex"].ToString();
                        user.IdentifyNumber = dr["IdentifyNumber"].ToString();
                        user.Phone = dr["Phone"].ToString();
                        user.Charge = Convert.ToInt32(dr["Charge"]);
                        user.CheckinDate = Convert.ToDateTime(dr["CheckinDate"]);
                        user.CheckoutDate = Convert.ToDateTime(dr["CheckoutDate"]);
                        user.UserNum = Convert.ToInt32(dr["UserNum"]);
                        user.IsAddBed = dr["isAddBed"].ToString();
                        user.IsPayOff = dr["IsPayOff"].ToString();
                        user.AddTime = Convert.ToDateTime(dr["addtime"]);
                        customers.Add(user);
                    }
                }
            }
            return customers;
        }
       
     /// <summary>
     /// 根据id获取记录
     /// </summary>
     /// <param name="CustomerId"></param>
     /// <returns></returns>
        public List<Customer> GetItemById(int CustomerId)
        {
            List<Customer> users = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(connString))
            {


                string sql = "SELECT * FROM Customer   ";


                sql += " WHERE CustomerId= " + CustomerId;

                sql += " order by addtime desc";


                SqlCommand comm = new SqlCommand(sql, conn);

                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Customer user = new Customer();

                        user.CustomerId = Convert.ToInt32(dr["CustomerId"]);
                        user.RoomId = dr["RoomId"].ToString();
                        user.Name = dr["Name"].ToString();
                        user.Sex = dr["Sex"].ToString();
                        user.IdentifyNumber = dr["IdentifyNumber"].ToString();
                        user.Phone = dr["Phone"].ToString();
                        user.Charge = Convert.ToInt32(dr["Charge"]);
                        user.CheckinDate = Convert.ToDateTime(dr["CheckinDate"]);
                        user.CheckoutDate = Convert.ToDateTime(dr["CheckoutDate"]);
                        user.UserNum = Convert.ToInt32(dr["UserNum"]);

                        user.IsAddBed = dr["isAddBed"].ToString();
                        user.IsPayOff = dr["IsPayOff"].ToString();
                        user.AddTime = Convert.ToDateTime(dr["addtime"]);

                        users.Add(user);
                    }
                }
            }
            return users;
        }

     
        /// <summary>
        /// 根据房间号，返回订单记录
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public List<Customer> GetListByRoomNumber(string roomNumber)
        {
            List<Customer> users = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(connString))
            {


                string sql = "SELECT * FROM Customer ";
                
                sql += " WHERE RoomId= '" + roomNumber + "'";

                sql += " order  by addtime desc";


                SqlCommand comm = new SqlCommand(sql, conn);

                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Customer user = new Customer();

                        user.CustomerId = Convert.ToInt32(dr["CustomerId"]);
                        user.RoomId = dr["RoomId"].ToString();
                        user.Name = dr["Name"].ToString();
                        user.Sex = dr["Sex"].ToString();
                        user.IdentifyNumber = dr["IdentifyNumber"].ToString();
                        user.Phone = dr["Phone"].ToString();
                        user.Charge = Convert.ToInt32(dr["Charge"]);
                        user.CheckinDate = Convert.ToDateTime(dr["CheckinDate"]);
                        user.CheckoutDate = Convert.ToDateTime(dr["CheckoutDate"]);
                        user.UserNum = Convert.ToInt32(dr["UserNum"]);

                        user.IsAddBed = dr["isAddBed"].ToString();
                        user.IsPayOff = dr["IsPayOff"].ToString();
                        user.AddTime = Convert.ToDateTime(dr["addtime"]);

                        users.Add(user);
                    }
                }
            }
            return users;
        }


     /// <summary>
     /// 根据用户信息查询入住登记记录
     /// </summary>
     /// <param name="cardNum"></param>
     /// <param name="TelNum"></param>
     /// <returns></returns>
     public List<Customer> GetListByUserInfo(string cardNum, string TelNum)
     {
         List<Customer> users = new List<Customer>();
         using (SqlConnection conn = new SqlConnection(connString))
         {


             string sql = "SELECT * FROM Customer ";

             if (cardNum != String.Empty)
             {
                 sql += " WHERE IdentifyNumber= '" + cardNum + "' ";
             }

             if (TelNum != String.Empty)
             {
                 if (cardNum != String.Empty)
                 {
                    
                     sql += "and  Phone= '" + TelNum + "' ";
                 }
                 else
                 {

                     sql += " WHERE Phone= '" + TelNum + "' ";
                 }

             


             }
            


             sql += " order by addtime desc";


             SqlCommand comm = new SqlCommand(sql, conn);

             conn.Open();
             using (SqlDataReader dr = comm.ExecuteReader())
             {
                 while (dr.Read())
                 {
                     Customer user = new Customer();

                     user.CustomerId = Convert.ToInt32(dr["CustomerId"]);
                     user.RoomId = dr["RoomId"].ToString();
                     user.Name = dr["Name"].ToString();
                     user.Sex = dr["Sex"].ToString();
                     user.IdentifyNumber = dr["IdentifyNumber"].ToString();
                     user.Phone = dr["Phone"].ToString();
                     user.Charge = Convert.ToInt32(dr["Charge"]);
                     user.CheckinDate = Convert.ToDateTime(dr["CheckinDate"]);
                     user.CheckoutDate = Convert.ToDateTime(dr["CheckoutDate"]);
                     user.UserNum = Convert.ToInt32(dr["UserNum"]);

                     user.IsAddBed = dr["isAddBed"].ToString();
                     user.IsPayOff = dr["IsPayOff"].ToString();

                     user.AddTime = Convert.ToDateTime(dr["addtime"]);

                     users.Add(user);
                 }
             }
         }
         return users;
     }


     /// <summary>
     /// 根据房间号查询所有的未付费的记录
     /// </summary>
     /// <param name="roomnum"></param>
     /// <returns></returns>
     public List<Customer> GetListIsNoPay(string roomnum)
     {
         List<Customer> users = new List<Customer>();
         using (SqlConnection conn = new SqlConnection(connString))
         {


             string sql = "SELECT * FROM Customer ";

             sql += " WHERE isPayOff= '否' and RoomId='" + roomnum + "'";

             sql += " order  by addtime desc";


             SqlCommand comm = new SqlCommand(sql, conn);

             conn.Open();
             using (SqlDataReader dr = comm.ExecuteReader())
             {
                 while (dr.Read())
                 {
                     Customer user = new Customer();

                     user.CustomerId = Convert.ToInt32(dr["CustomerId"]);
                     user.RoomId = dr["RoomId"].ToString();
                     user.Name = dr["Name"].ToString();
                     user.Sex = dr["Sex"].ToString();
                     user.IdentifyNumber = dr["IdentifyNumber"].ToString();
                     user.Phone = dr["Phone"].ToString();
                     user.Charge = Convert.ToInt32(dr["Charge"]);
                     user.CheckinDate = Convert.ToDateTime(dr["CheckinDate"]);
                     user.CheckoutDate = Convert.ToDateTime(dr["CheckoutDate"]);
                     user.UserNum = Convert.ToInt32(dr["UserNum"]);

                     user.IsAddBed = dr["isAddBed"].ToString();
                     user.IsPayOff = dr["IsPayOff"].ToString();

                     user.AddTime = Convert.ToDateTime(dr["addtime"]);

                     users.Add(user);
                 }
             }
         }
         return users;
     }

        /// <summary>
        /// 添加用户入住信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
     public int Add(Customer user)
     {
         /**
             @RoomId nvarchar(50),
             @Name nvarchar(50),
             @Sex nvarchar(50),
             @IdentifyNumber nvarchar(50),
             @Phone nvarchar(50),
             @Charge int,
             @CheckinDate DateTime,
             @CheckoutDate datetime,
             @UserNum int
          * 
          */



         SqlParameter[] param = new SqlParameter[12];

         param[0] = DbHelper.MakeParameter("@RoomId", SqlDbType.NVarChar, user.RoomId);
         param[1] = DbHelper.MakeParameter("@Name", SqlDbType.NVarChar, user.Name);
         param[2] = DbHelper.MakeParameter("@Sex", SqlDbType.NVarChar, user.Sex);
         param[3] = DbHelper.MakeParameter("@IdentifyNumber", SqlDbType.NVarChar, user.IdentifyNumber);
         param[4] = DbHelper.MakeParameter("@Phone", SqlDbType.NVarChar, user.Phone);
         param[5] = DbHelper.MakeParameter("@Charge", SqlDbType.Int, user.Charge);
         param[6] = DbHelper.MakeParameter("@CheckinDate", SqlDbType.DateTime, user.CheckinDate);
         param[7] = DbHelper.MakeParameter("@CheckoutDate", SqlDbType.DateTime, user.CheckoutDate);
         param[8] = DbHelper.MakeParameter("@UserNum", SqlDbType.Int, user.UserNum);
         param[9] = DbHelper.MakeParameter("@isAddBed", SqlDbType.NVarChar, user.IsAddBed);
         param[10] = DbHelper.MakeParameter("@isPayOff", SqlDbType.NVarChar, user.IsPayOff);
         param[11] = DbHelper.MakeParameter("@addtime", SqlDbType.DateTime, DateTime.Now);
         return DbHelper.ExecNonQuery("usp_AddCustomer", param);
     }

     /// <summary>
     /// 删除信息
     /// </summary>
     /// <param name="roomNumber"></param>
     /// <returns></returns>
     public int DeleteById(int CustomId)
     {
         int number = 0;
         using (SqlConnection conn = new SqlConnection(connString))
         {
             SqlCommand comm = new SqlCommand("delete from Customer where CustomerId=" + CustomId + "", conn);

             conn.Open();
             number = Convert.ToInt32(comm.ExecuteNonQuery());
         }
         return number;
     }

    }
}
