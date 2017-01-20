using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HP_DAL;

namespace HP_BLL
{
    public class CartBLL
    {
         public static Cart getCarByID(int IdCart)
        {
            return CartDAL.getCartByID(IdCart);
        }
         public static List<Cart> getListCart()
         {
             List<Cart> ds = CartDAL.getListCart();
             IEnumerable<Cart> list = from Cart gh in ds
                                     where gh.IsDelete!=true
                                     orderby gh.IdCart descending
                                     select gh;

             return new List<Cart>(list);
         }
         public static Cart getCartNew(string sdt)
         {
             List<Cart> ds = CartDAL.getListCart();
             IEnumerable<Cart> list = from Cart gh in ds
                                      where gh.Phone == sdt
                                      orderby gh.IdCart descending
                                      select gh;
             foreach (Cart ghn in list)
             {
                 return ghn;
             }
             return null;
         }
         public static int InsertCart(string Name, string Phone, string Address, string Note, string Email, float Tongtien,string ptTT)
         {
             return CartDAL.InsertCart(Name, Phone, Address, Note, Email, Tongtien,ptTT,DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt")), false, false, "",false, "");
         }
         public static int deleteCart(int Idcart, string username)
         {
             return CartDAL.deleteCart(Idcart, username);
         }
         public static int xemCart(int Idcart, string username)
         {
             return CartDAL.xemCart(Idcart, username);
         }
         public static int GiaoCart(int Idcart, string username)
         {
             return CartDAL.GiaoCart(Idcart, username);
         }
     }
}
