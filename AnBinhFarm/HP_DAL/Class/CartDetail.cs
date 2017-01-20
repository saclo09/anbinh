using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HP_DAL
{
    public class CartDetail
    {
        int idCart;

        public int IdCart
        {
            get { return idCart; }
            set { idCart = value; }
        }
        int idProduct;

        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }
        int aMount;

        public int AMount
        {
            get { return aMount; }
            set { aMount = value; }
        }
        float priceSaled;
        public float PriceSaled
        {
            get
            {
                return priceSaled;
            }
            set
            {
                if (priceSaled == value)
                    return;
                priceSaled = value;
            }
        }
        bool isDeal;
        public bool IsDeal
        {
            get
            {
                return isDeal;
            }
            set
            {
                if (isDeal == value)
                    return;
                isDeal = value;
            }
        }
        public CartDetail()
        {
        }
        public CartDetail(DataRow row)
        {
            this.IdCart = (row["IDGioHang"] is DBNull) ? int.MinValue : int.Parse(row["IDGioHang"].ToString());
            this.IdProduct = (row["IDSanPham"] is DBNull) ? int.MinValue : int.Parse(row["IDSanPham"].ToString()); ;
            this.aMount = (row["Soluong"] is DBNull) ? int.MinValue : int.Parse(row["Soluong"].ToString()); ;
            this.PriceSaled = (row["Price"] is DBNull) ? float.MinValue : float.Parse(row["Price"].ToString()); ;
            this.IsDeal = (row["IsDeal"] is DBNull) ? false : bool.Parse(row["IsDeal"].ToString()); ;
        }

    }
}
