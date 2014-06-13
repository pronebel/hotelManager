using System;
using System.Collections.Generic;
using System.Text;

using HotelManagerModels;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace HotelManagerDAL.SqlService
{
    public  class  RoomTypeService
    {
        public static string connString = ConfigurationManager.ConnectionStrings["SqlConnString"].ConnectionString.ToString();

        #region IHotelService 成员

        public List<RoomType> GetRoomTypeListByTypeName(string name)
        {
            List<RoomType> rts = new List<RoomType>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from roomType where typeName like '%" + name + "%'";


                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        RoomType rt = new RoomType();
                        rt.TypeId = Convert.ToInt32(dr["TypeId"]);
                        rt.TypeName = dr["TypeName"].ToString();
                        rt.TypePrice = Convert.ToDouble(dr["TypePrice"]);
                        rt.IsAddBed = dr["IsAddBed"].ToString();
                        rt.AddBedPrice = Convert.ToDouble(dr["AddBedPrice"]);
                        rt.Remark = dr["Remark"].ToString();
                        rts.Add(rt);
                    }
                }
            }
            return rts;
        }

        /// <summary>
        /// 根据房间类型id查询房间信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public List<RoomType> GetRoomTypeListByTypeId(int typeId)
        {
            List<RoomType> rts = new List<RoomType>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand("select * from RoomType where TypeId="+typeId, conn);
                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        RoomType rt = new RoomType();
                        rt.TypeId = Convert.ToInt32(dr["TypeId"]);
                        rt.TypeName = dr["TypeName"].ToString();
                        rt.TypePrice = Convert.ToDouble(dr["TypePrice"]);
                        rt.IsAddBed = dr["IsAddBed"].ToString();
                        rt.AddBedPrice = Convert.ToDouble(dr["AddBedPrice"]);
                        rt.Remark = dr["Remark"].ToString();
                        rts.Add(rt);
                    }
                }
            }
            return rts;
        }

        public int GetTypeIDByTypeName(string TypeName)
        {
            int TypeID = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select TypeID from RoomType where TypeName='" + TypeName + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        TypeID = Convert.ToInt32(dr["TypeID"]);
                    }
                }
            }
            return TypeID;
        }

        public int AddRoomType(RoomType rt)
        {
            int number = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand("usp_InsetRoomType", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@TypeName", SqlDbType.NVarChar, 20).Value = rt.TypeName;
                comm.Parameters.Add("@TypePrice", SqlDbType.Money).Value = rt.TypePrice;
                comm.Parameters.Add("@AddBedPrice", SqlDbType.Money).Value = rt.AddBedPrice;
                comm.Parameters.Add("@IsAddBed", SqlDbType.NVarChar, 2).Value = rt.IsAddBed;
                comm.Parameters.Add("@Remark", SqlDbType.NVarChar, 200).Value = rt.Remark;
                conn.Open();
                number = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            return number;
        }

        public int UpdateRoomType(RoomType rt)
        {
            int number = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand("usp_UpdatRoomType", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add("@TypeID", SqlDbType.Int).Value = rt.TypeId;
                comm.Parameters.Add("@TypeName", SqlDbType.NVarChar, 20).Value = rt.TypeName;
                comm.Parameters.Add("@TypePrice", SqlDbType.Money).Value = rt.TypePrice;
                comm.Parameters.Add("@AddBedPrice", SqlDbType.Money).Value = rt.AddBedPrice;
                comm.Parameters.Add("@IsAddBed", SqlDbType.NVarChar, 2).Value = rt.IsAddBed;
                comm.Parameters.Add("@Remark", SqlDbType.NVarChar, 200).Value = rt.Remark;
                conn.Open();
                number = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            return number;
        }

        public int DeleteRoomType(string name)
        {
            int number = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = new SqlCommand("delete  from RoomType where TypeName='" + name + "'", conn);
                
                conn.Open();
                number = Convert.ToInt32(comm.ExecuteNonQuery());
            }
            return number;
        }


        public string GetTypeNameByTypeID(int TypeID)
        {
            string typeName = null;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select typename from roomtype where typeid=" + TypeID;


                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader dr = comm.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        typeName = dr["TypeName"].ToString();
                    }
                }
            }
            return typeName;
        }

        #endregion
    }
}
