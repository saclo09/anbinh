using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HP_DAL
{
    public class Cart
    {
        int idCart;

        public int IdCart
        {
            get { return idCart; }
            set { idCart = value; }
        }
        string nameKhach;

        public string NameKhach
        {
            get { return nameKhach; }
            set { nameKhach = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        float totalMoney;

        public float TotalMoney
        {
            get { return totalMoney; }
            set { totalMoney = value; }
        }
        string pTThanhToan;

        public string PTThanhToan
        {
            get { return pTThanhToan; }
            set { pTThanhToan = value; }
        }
        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        bool isXem;

        public bool IsXem
        {
            get { return isXem; }
            set { isXem = value; }
        }
        bool isGiao;

        public bool IsGiao
        {
            get { return isGiao; }
            set { isGiao = value; }
        }
        string accountCheck;

        public string AccountCheck
        {
            get { return accountCheck; }
            set { accountCheck = value; }
        }
        bool isDelete;

        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
        string deleteBy;

        public string DeleteBy
        {
            get { return deleteBy; }
            set { deleteBy = value; }
        }
        public Cart()
        { }
        public Cart(DataRow row)
        {
          this.IdCart= (row["IDGioHang"] is DBNull) ? int.MinValue :(int)row["IDGioHang"]; 
            this.NameKhach=(row["Name"]is DBNull) ? "" :row["Name"].ToString();
      this.Phone=(row["Phone"]is DBNull) ? "" :row["Phone"].ToString();
      this.Address=(row["Address"]is DBNull) ? "" :row["Address"].ToString();
      this.Note=(row["Note"]is DBNull) ? "" :row["Note"].ToString();
      this.Email=(row["Email"]is DBNull) ? "" :row["Email"].ToString();
      this.PTThanhToan = (row["PTThanhToan"] is DBNull) ? "Tiền mặt" : row["PTThanhToan"].ToString();
      this.TotalMoney=(row["Tongtien"]is DBNull) ? float.MinValue : float.Parse(row["Tongtien"].ToString());
      this.Date=(row["Date"]is DBNull) ? DateTime.MinValue :DateTime.Parse(row["Date"].ToString());
      this.IsXem=(row["IsXem"]is DBNull) ? false :bool.Parse(row["IsXem"].ToString());
      this.IsGiao=(row["IsGiao"]is DBNull) ? false :bool.Parse(row["IsGiao"].ToString());
      this.AccountCheck=(row["AcountCheck"]is DBNull) ? "" :row["AcountCheck"].ToString();
      this.IsDelete=(row["IsDelete"]is DBNull) ? false :bool.Parse(row["IsDelete"].ToString());
      this.DeleteBy = (row["deleteBy"] is DBNull) ? "" : row["deleteBy"].ToString();
        }


        


    }
}
