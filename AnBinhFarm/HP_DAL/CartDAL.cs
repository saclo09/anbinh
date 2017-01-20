using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP_DAL
{
    public class CartDAL
    {
        public static Cart getCartByID(int CartId)
        {
            Cart result= new Cart();
            List<Cart> list = getListCart();
            foreach (Cart gh in list)
                if (gh.IdCart == CartId)
                    result = gh;
            return result;
        }
        public static List<Cart> getListCart()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dtB = db.GetDateTable("SELECT * FROM GioHang ORDER BY IDGioHang DESC ");
            List<Cart> list = new List<Cart>();
            foreach (DataRow row in dtB.Rows)
            {
                list.Add(new Cart(row));
            }
            return list;
        }
        public static int InsertCart(string Name,string Phone,string Address ,string Note,string Email,float Tongtien,string phuongthuTT ,DateTime Date,bool IsXem ,bool IsGiao  ,string AcountCheck ,bool IsDelete,string deleteBy)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]{        
                new SqlParameter("@Name",Name ),
                new SqlParameter("@Phone",Phone ),
                new SqlParameter("@Address", Address),
                new SqlParameter("@Note", Note),
                new SqlParameter("@Email",Email ),
                new SqlParameter("@Tongtien", Tongtien),
                 new SqlParameter("@PTThanhToan", phuongthuTT)
                
                  };

            string lenh = " INSERT INTO GioHang( Name, Phone, Address, Note, Email, Tongtien,PTThanhToan) VALUES( @Name, @Phone, @Address, @Note, @Email, @Tongtien,@PTThanhToan )";
               
            return db.ExecuteNonQuery(lenh, @parameterArray);
        }
        public static int upDateCart(int IdCart, string Name, string Phone, string Address, string Note, string Email, float Tongtien, DateTime Date, bool IsXem, bool IsGiao, string AcountCheck, string IsDelete, string deleteBy)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]
            {  
                new SqlParameter("@IDGioHang",IdCart ),
                new SqlParameter("@Name",Name ),
                new SqlParameter("@Phone",Phone ),
                new SqlParameter("@Address", Address),
                new SqlParameter("@Note", Note),
                new SqlParameter("@Email",Email ),
                new SqlParameter("@Tongtien", Tongtien),
                new SqlParameter("@Date",Date ),
                new SqlParameter("@IsXem", IsXem),
                new SqlParameter("@IsGiao",IsGiao ),
                new SqlParameter("@AcountCheck", AcountCheck),
                new SqlParameter("@IsDelete",IsDelete ),
                new SqlParameter("@deleteBy", deleteBy)
                  };

            string lenh = " UPDATE GioHang SET  Name  = @Name, Phone  = @Phone , Address  = @Address , Note  = @Note , Email  = @Email, Tongtien  = @Tongtien, Date  = @Date , IsXem  = @IsXem , IsGiao  = @IsGiao , AcountCheck  = @AcountCheck , IsDelete  = @IsDelete , deleteBy  = @deleteBy WHERE IDGioHang=@IDGioHang";

            return db.ExecuteNonQuery(lenh, @parameterArray);
        }
        public static int deleteCart(int IdCart, string username)
        {
             DataAccessHelper db = new DataAccessHelper();
             SqlParameter[] @parameterArray = new SqlParameter[]
             {  
                new SqlParameter("@IDGioHang",IdCart ),
                new SqlParameter("@deleteBy",username )
             };
             string lenh = " UPDATE GioHang SET  IsDelete  = 'true',deleteBy=@deleteBy  WHERE IDGioHang=@IDGioHang";
             return db.ExecuteNonQuery(lenh,@parameterArray);
        }
        public static int xemCart(int IdCart,string username)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]
            {  
                new SqlParameter("@IDGioHang",IdCart ),
                new SqlParameter("@AcountCheck",username )
            };

            string lenh = " UPDATE GioHang SET  IsXem  = 'true',AcountCheck=@AcountCheck  WHERE IDGioHang=@IDGioHang";
            return db.ExecuteNonQuery(lenh,@parameterArray);
        }
        public static int GiaoCart(int IdCart,string username)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]
            {  
                new SqlParameter("@IDGioHang",IdCart ),
                new SqlParameter("@deleteBy",username )
            };
            string lenh = " UPDATE GioHang SET  IsGiao  = 'true', deleteBy=@deleteBy WHERE IDGioHang=@IDGioHang";
            return db.ExecuteNonQuery(lenh,@parameterArray);
        }
    }
}
