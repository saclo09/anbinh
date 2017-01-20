using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HP_DAL
{
    public class CartDetailDAL
    {
        public static List<CartDetail> getListCartDetail()
        {
            DataAccessHelper Db = new DataAccessHelper();
             List<CartDetail> resultList = new List<CartDetail>();
           
           DataTable btCM= Db.GetDateTable("SELECT * FROM ChitietGioHang ");
           foreach (DataRow row in btCM.Rows)
           {

               CartDetail temp = new CartDetail(row);
               resultList.Add(temp);
           }
           return resultList;
        }
        public static CartDetail getCartDetailByID(int cartID, int productID)
        {
           List<CartDetail> resultList= getListCartDetail();
            foreach(CartDetail cdtTemp in resultList)
            {
                if(cdtTemp.IdCart==cartID && cdtTemp.IdProduct==productID)
                {
                    return cdtTemp;
                }
            }
            return null;
        }
        public static int insertCartDetail(int CartID,int productId,int soluong, float gia, bool isDeal )
        {
            DataAccessHelper DB = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[] {       
                new SqlParameter("@IDGioHang",CartID) ,         
             new SqlParameter("@IDSanPham", productId),
              new SqlParameter("@Soluong",soluong)  ,
               new SqlParameter("@Price",gia)  ,
                new SqlParameter("@IsDeal",isDeal)                    
            };
            string lenh="INSERT INTO ChitietGioHang ( IDGioHang , IDSanPham  , Soluong , Price , IsDeal )  VALUES (@IDGioHang ,@IDSanPham  ,@Soluong  ,@Price ,@IsDeal) ";
            return DB.ExecuteNonQuery(lenh,@parameterArray);
        }
    }
}
