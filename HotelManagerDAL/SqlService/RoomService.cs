using System;
using System.Collections.Generic;
using System.Text;

using HotelManagerModels;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace HotelManagerDAL.SqlService
{
     public class RoomService
    {
         public static string connString = ConfigurationManager.ConnectionStrings["SqlConnString"].ConnectionString.ToString();

  


         public List<Room> GetAllRoom()
         {
             List<Room> rooms = new List<Room>();
             using (SqlConnection conn = new SqlConnection(connString))
             {


                 string sql = "SELECT RoomID,Number,TypeID,BedNumber,Description,State,GuestNumber FROM Room ";
               

                 SqlCommand comm = new SqlCommand(sql, conn);

                 conn.Open();
                 using (SqlDataReader dr = comm.ExecuteReader())
                 {
                     while (dr.Read())
                     {
                         Room room = new Room();
                         room.RoomID = Convert.ToInt32(dr["RoomID"]);
                         room.Number = dr["Number"].ToString();
                         room.TypeID = Convert.ToInt32(dr["TypeID"]);
                         room.BedNumber = Convert.ToInt32(dr["BedNumber"]);
                         room.Description = dr["Description"].ToString();
                         room.State = dr["State"].ToString();
                         room.GuestNumber = Convert.ToInt32(dr["GuestNumber"]);
                         rooms.Add(room);
                     }
                 }
             }
             return rooms;
         }

        public List<Room> GetRoomByRoomNumber(string roomNumber,int typeid,string state)
        {
            List<Room> rooms = new List<Room>();
            using (SqlConnection conn = new SqlConnection(connString))
            {


                string sql = "SELECT RoomID,Number,TypeID,BedNumber,Description,State,GuestNumber FROM Room ";
                if (roomNumber!="")
                {
                    sql += " WHERE Number= '" + roomNumber + "'";

                }
                else
                {
                    if (typeid != 0)
                    {
                        sql += " WHERE TypeId=" + typeid + "";
                        if (state != "全部")
                        {
                            sql += " and state='" + state + "'";
                        }
                    }
                    else
                    {
                        if (state != "全部")
                        {
                            sql += "WHERE  state='" + state + "'";
                        }
                    }
                }

                SqlCommand comm = new SqlCommand(sql, conn);
           
                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Room room = new Room();
                        room.RoomID = Convert.ToInt32(dr["RoomID"]);
                        room.Number = dr["Number"].ToString();
                        room.TypeID = Convert.ToInt32(dr["TypeID"]);
                        room.BedNumber = Convert.ToInt32(dr["BedNumber"]);
                        room.Description = dr["Description"].ToString();
                        room.State = dr["State"].ToString();
                        room.GuestNumber = Convert.ToInt32(dr["GuestNumber"]);
                        rooms.Add(room);
                    }
                }
            }
            return rooms;
        }

        /// <summary>
        /// 根据房间号查询RoomId
        /// </summary>
        /// <param name="roomNubmer"></param>
        /// <returns></returns>
        public int GetRoomIDByRoomNumber(string roomNubmer)
        {
            int RoomID = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand("select RoomID from room where number='" + roomNubmer + "'", conn);
              
                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        RoomID = Convert.ToInt32(dr["RoomID"]);
                    }
                }
            }
            return RoomID;
        }
        /// <summary>
        /// 根据房间号查询房间信息
        /// </summary>
        /// <param name="roomNubmer"></param>
        /// <returns></returns>
         public List<Room> GetRoomDetailByRoomNumber(string roomNubmer)
         {
             List<Room> rooms = new List<Room>();
             using (SqlConnection conn = new SqlConnection(connString))
             {
                 SqlCommand comm = new SqlCommand("select * from room where number='" + roomNubmer + "'", conn);
                 
                 conn.Open();
                 using (SqlDataReader dr = comm.ExecuteReader())
                 {
                     if (dr.Read())
                     {
                         Room room = new Room();
                         room.RoomID = Convert.ToInt32(dr["RoomID"]);
                         room.Number = dr["Number"].ToString();
                         room.TypeID = Convert.ToInt32(dr["TypeID"]);
                         room.BedNumber = Convert.ToInt32(dr["BedNumber"]);
                         room.Description = dr["Description"].ToString();
                         room.State = dr["State"].ToString();
                         room.GuestNumber = Convert.ToInt32(dr["GuestNumber"]);
                         rooms.Add(room);
                     }
                 }
             }
             return rooms;
         }

        /// <summary>
        /// 增加房间
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public int AddRoom(Room room)
        {
            /*int number = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand("usp_InsetRoom", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@Number", SqlDbType.VarChar, 20).Value = room.Number;
                comm.Parameters.Add("@TypeID", SqlDbType.Int).Value = room.TypeID;
                comm.Parameters.Add("@BedNumber", SqlDbType.Int).Value = room.BedNumber;
                comm.Parameters.Add("@Description", SqlDbType.VarChar, 200).Value = room.Description;
                comm.Parameters.Add("@State", SqlDbType.VarChar, 20).Value = room.State;
                comm.Parameters.Add("@GuestNumber",SqlDbType.Int).Value=room.GuestNumber;
                conn.Open();
                number = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            return number;*/




            SqlParameter[] param = new SqlParameter[6];


            param[0] = DbHelper.MakeParameter("@Number", SqlDbType.VarChar, room.Number);
            param[1] = DbHelper.MakeParameter("@TypeID", SqlDbType.Int, room.TypeID);
            param[2] = DbHelper.MakeParameter("@BedNumber", SqlDbType.Int, room.BedNumber);
            param[3] = DbHelper.MakeParameter("@Description", SqlDbType.VarChar, room.Description);
            param[4] = DbHelper.MakeParameter("@State", SqlDbType.VarChar, room.State);
            param[5] = DbHelper.MakeParameter("@GuestNumber", SqlDbType.Int,room.GuestNumber) ;

            int number = DbHelper.ExecNonQuery("usp_InsetRoom", param);
            return number;
        }

         public int UpdateRoomState(string roomNumber, string state)
         {
             string sql = "update room set state='" + state + "' where number=" + roomNumber;

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
         /// 更新房间信息
         /// </summary>
         /// <param name="room"></param>
         /// <returns></returns>
        public int UpdateRoom(Room room)
        {
            int number = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand("usp_UpdatRoom", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@RoomID",SqlDbType.Int).Value=room.RoomID;
                comm.Parameters.Add("@Number", SqlDbType.VarChar, 20).Value = room.Number;
                comm.Parameters.Add("@TypeID", SqlDbType.Int).Value = room.TypeID;
                comm.Parameters.Add("@BedNumber", SqlDbType.Int).Value = room.BedNumber;
                comm.Parameters.Add("@Description", SqlDbType.VarChar, 200).Value = room.Description;
                comm.Parameters.Add("@State", SqlDbType.VarChar, 20).Value = room.State;
                comm.Parameters.Add("GuestNumber", SqlDbType.Int).Value = room.GuestNumber;
                conn.Open();
                number = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            return number;
        }

        /// <summary>
        /// 删除房间信息
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public int DeleteRoom(string roomNumber)
        {
            int number = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand("delete from room where number='" + roomNumber + "'", conn);
         
                conn.Open();
                number = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            return number;
        }

    


        public List<RoomType> GetRoomType()
        {
            List<RoomType> rts = new List<RoomType>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
               // string sql = "SELECT TypeID,TypeName,TypePrice,AddBedPrice,IsAddBed,Remark FROM RoomType";
                string sql = "SELECT * FROM RoomType";
                
                SqlCommand comm = new SqlCommand(sql, conn);             
                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        RoomType rt = new RoomType();
                        rt.TypeId = Convert.ToInt32(dr["TypeID"]);
                        rt.TypeName = dr["TypeName"].ToString();
                        rts.Add(rt);
                    }
                }
            }
            return rts;
        }

   


         public int GetTypePriceByTypeID(int TypeID)
         {
             int TypePrice = 0;
             using (SqlConnection conn = new SqlConnection(connString))
             {
                 string sql = "select typeprice from roomtype where typeid=" + TypeID;
                 SqlCommand comm = new SqlCommand(sql, conn);
                 conn.Open();
                 using (SqlDataReader dr = comm.ExecuteReader())
                 {
                     if (dr.Read())
                     {
                         TypePrice =Convert.ToInt32(dr["TypePrice"]);
                     }
                 }
             }
             return TypePrice;
         }

      


         public int GetTypePriceByTypeName(string TypeName)
         {
              int TypePrice = 0;
             using (SqlConnection conn = new SqlConnection(connString))
             {
                 string sql = "select typeprice from roomtype where typename='"+TypeName+"'";
                 SqlCommand comm = new SqlCommand(sql, conn);
                 conn.Open();
                 using (SqlDataReader dr = comm.ExecuteReader())
                 {
                     if (dr.Read())
                     {
                         TypePrice =Convert.ToInt32(dr["TypePrice"]);
                     }
                 }
             }
             return TypePrice;
         }
         




     }
}
