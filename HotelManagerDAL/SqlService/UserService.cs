using System;
using System.Collections.Generic;
using System.Text;

using HotelManagerModels;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace HotelManagerDAL.SqlService
{
   public class UserService
    {

        /// <summary>
        /// sql数据库连接字符
        /// </summary>
        public static string connString = ConfigurationManager.ConnectionStrings["SqlConnString"].ConnectionString.ToString();





        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Add(User user)
        {
            string sql = "insert into Admin (name,email,mobile,password) values ('" + user.Name + "','" + user.Email + "','" + user.Mobile + "','" + user.Password + "') ";

            int number = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                number = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            return number;

        }

        public int Delete(Int32 userId)
        {
            string sql = "delete from Admin where id='"+userId+"'";
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
        /// 更新用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Update(User user)
        {
            string sql = "update Admin set name='" + user.Name + "',email='" + user.Email + "',mobile='" + user.Mobile+"'";
            if (user.Password != string.Empty)
            {
                sql += " ,password='" + user.Password + "'";
            }
            sql += " where id = " + user.Id;
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
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<User> GetInfoByName(string name)
        {

            List<User> rts = new List<User>();
            using (SqlConnection conn = new SqlConnection(connString))
            {

                string sql = "SELECT * FROM Admin where name='" + name + "'";

                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        User rt = new User();
                        rt.Id = Convert.ToInt32(dr["id"]);
                        rt.Mobile = dr["mobile"].ToString();
                        rt.Email = dr["email"].ToString();
                        rt.Name = dr["name"].ToString();
                        rt.Password = dr["password"].ToString();
                        rts.Add(rt);
                    }
                }
            }
            return rts;

        }

        /// <summary>
        /// 获取管理员用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<User> GetList()
        {

            List<User> rts = new List<User>();
            using (SqlConnection conn = new SqlConnection(connString))
            {

                string sql = "SELECT * FROM Admin";

                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        User rt = new User();
                        rt.Id = Convert.ToInt32(dr["id"]);
                        rt.Mobile = dr["mobile"].ToString();
                        rt.Email = dr["email"].ToString();
                        rt.Name = dr["name"].ToString();
                        rt.Password = dr["password"].ToString();
                        rts.Add(rt);
                    }
                }
            }
            return rts;

        }




    }
}
