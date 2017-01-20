using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HP_DAL;

namespace HP_BLL
{
    public class CartDetailBLL
    {
        public static List<CartDetail> getListCartDetailByCart(int cartID)
        {
            List<CartDetail> dsChitietGH = CartDetailDAL.getListCartDetail();
            IEnumerable<CartDetail> list = from CartDetail prd in dsChitietGH
                                           where (prd.IdCart == cartID)
                                        select prd;
            List<CartDetail> dstrave = new List<CartDetail>(list);
            return dstrave;
        }
        public static int insertCartDetail(int CartId, int ProductId, int soluong, float GiaSale, bool isDeal)
        {
            return CartDetailDAL.insertCartDetail(CartId,ProductId,soluong,GiaSale,isDeal);
        }
    }
}
