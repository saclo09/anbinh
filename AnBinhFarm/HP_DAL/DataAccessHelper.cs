using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HP_DAL
{
    public class DataAccessHelper
    {
        #region 1. Khai báo các thành viên dữ liệu
        SqlConnection conn;
        SqlCommand cmd;
        #endregion

        #region 2. Các phương thức khởi tạo
        public DataAccessHelper()
        {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
           

        }
        #endregion

        #region 3. Các phương thức thao tác với CSDL

       private void Open()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
       
        private void Close()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }


        public object GetValue(string query)
        {
            try
            {
                Open();
                cmd = new SqlCommand(query, conn);
                return cmd.ExecuteScalar();
            }
            catch
            {
                return 0;
            }
        }
        public object GetValue(string query, SqlParameter[] @parameterArray)
        {
            try{
            Open();
            cmd = new SqlCommand(query, conn);
            for (int i = 0; i <= @parameterArray.Length - 1; i++)
            {
                cmd.Parameters.Add(@parameterArray[i]);
            }

            foreach (IDataParameter param in cmd.Parameters)
            {
                if (param.Value == null) param.Value = DBNull.Value;
            } 
            return cmd.ExecuteScalar();
            }
            catch
            {
                return null;
            }
        }
        public IDataReader GetList(string query, SqlParameter[] @parameterArray)
        {
            try{
                Open();
                cmd = new SqlCommand(query, conn);
                for (int i = 0; i <= @parameterArray.Length - 1; i++)
                {
                    cmd.Parameters.Add(@parameterArray[i]);
                }

                foreach (IDataParameter param in cmd.Parameters)
                {
                    if (param.Value == null) param.Value = DBNull.Value;
                } 
                IDataReader dtR=cmd.ExecuteReader();
                Close();
                return dtR;
            }
            catch
            {
                return null;
            }
        }
        public SqlDataReader GetList(string query)
        {
            try
            {
                Open();
                cmd = new SqlCommand(query, conn);
                SqlDataReader Datar = cmd.ExecuteReader();
               // Close();
                return Datar;
            } 
            catch
            {
                return null;
            }

        }
        public DataTable GetDateTable(string select)
        {
            try
            {
               
                SqlDataAdapter da = new SqlDataAdapter(select, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            } 
            catch
            {
                return null;
            }
        }
        public DataTable GetDateTable(string select, SqlParameter[] @parameterArray)
        {
            try
            {
                Open();
                cmd = new SqlCommand(select, conn);
                for (int i = 0; i <= @parameterArray.Length - 1; i++)
                {
                    cmd.Parameters.Add(@parameterArray[i]);
                }

                foreach (IDataParameter param in cmd.Parameters)
                {
                    if (param.Value == null) param.Value = DBNull.Value;
                } 
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
        }
        public int ExecuteNonQuery(string query, SqlParameter[] @parameterArray)
        {
            try
            {
                Open();
                cmd = new SqlCommand(query, conn);
                for (int i = 0; i <= @parameterArray.Length - 1; i++)
                {
                    cmd.Parameters.Add(@parameterArray[i]);
                }

                foreach (IDataParameter param in cmd.Parameters)
                {
                    if (param.Value == null) param.Value = DBNull.Value;
                }

                return cmd.ExecuteNonQuery();
            } 
            catch
            {
              return 0;
            }
        }
        public int ExecuteNonQuery(string query)
        {
            try
            {
                Open();

                cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            } 
            catch
            {
                return 0;
            }
        }        
      #endregion
    }

}