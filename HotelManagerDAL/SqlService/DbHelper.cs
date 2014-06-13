using System;
using System.Collections.Generic;
using System.Text;


using HotelManagerModels;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



namespace HotelManagerDAL.SqlService
{

    //æ≤Ã¨∞Ô÷˙¿‡
    public class DbHelper
    {
        private static String GetConnectionString()
        {
            string connString = ConfigurationManager.ConnectionStrings["SqlConnString"].ConnectionString.ToString();


            return connString;
        }

        public static SqlParameter MakeParameter(String strParam, SqlDbType dbType, Object objValue)
        {
            SqlParameter param = new SqlParameter(strParam, dbType);
            param.Value = objValue;
            return param;
        }

        private static SqlCommand BuildCommand(SqlConnection conn, String strProcName, SqlParameter[] paramLists)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = strProcName;
            if (paramLists != null)
            {
                foreach (SqlParameter p in paramLists)
                {
                    cmd.Parameters.Add(p);
                }
            }
            return cmd;
        }

        public static Int32 ReaderInt32(String strProcName, SqlParameter[] paramLists)
        {
            Int32 nRet = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = BuildCommand(conn, strProcName, paramLists);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (sdr.Read())
                {
                    nRet = sdr.GetInt32(0);
                }
                sdr.Close();
                cmd.Dispose();
            }
            return nRet;
        }
        public static String ReaderString(String strProcName, SqlParameter[] paramLists)
        {
            String strRet = String.Empty;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = BuildCommand(conn, strProcName, paramLists);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (sdr.Read())
                {
                    strRet = sdr.GetString(0);
                }
                sdr.Close();
                cmd.Dispose();
            }
            return strRet;
        }

        public static int ExecNonQuery(String strProcName, SqlParameter[] paramLists)
        {
            int nRet = 0;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = BuildCommand(conn, strProcName, paramLists);
                conn.Open();
                nRet = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            return nRet;
        }

        public static SqlDataReader ExecQuery(String strProcName, SqlParameter[] paramLists)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            SqlCommand cmd = BuildCommand(conn, strProcName, paramLists);
            conn.Open();
            SqlDataReader drData = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Dispose();
            return drData;
            //  return cmd.ExecuteReader(CommandBehavior.CloseConnection);

        }
    }
}
