using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP_DAL
{
    public class Product
    {
        int idProduct;

        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }
        string iDNameProduct;

        public string IDNameProduct
        {
            get { return iDNameProduct; }
            set { iDNameProduct = value; }
        }
        string nameProduct;

        public string NameProduct
        {
            get { return nameProduct; }
            set { nameProduct = value; }
        }
        int groupIterm;

        public int GroupIterm
        {
            get { return groupIterm; }
            set { groupIterm = value; }
        }
        string images;

        public string Images
        {
            get { return images; }
            set { images = value; }
        }
        string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (color == value)
                    return;
                color = value;
            }
        }
        string material;

        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        string multiPrice;

        public string MultiPrice
        {
            get { return multiPrice; }
            set { multiPrice = value; }
        }
        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        float priceNote;

        public float PriceNote
        {
            get { return priceNote; }
            set { priceNote = value; }
        }
        int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        bool isNew;

        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
        bool isHot;

        public bool IsHot
        {
            get { return isHot; }
            set { isHot = value; }
        }
        int luotXem;

        public int LuotXem
        {
            get { return luotXem; }
            set { luotXem = value; }
        }
        int luotMua;

        public int LuotMua
        {
            get { return luotMua; }
            set { luotMua = value; }
        }
        bool isGiamGiaPt;

        public bool IsGiamGiaPt
        {
            get { return isGiamGiaPt; }
            set { isGiamGiaPt = value; }
        }
        int giamGiaPT;

        public int GiamGiaPT
        {
            get { return giamGiaPT; }
            set { giamGiaPT = value; }
        }
        bool isGiamGiaTien;

        public bool IsGiamGiaTien
        {
            get { return isGiamGiaTien; }
            set { isGiamGiaTien = value; }
        }
        int giamgiaTien;

        public int GiamgiaTien
        {
            get { return giamgiaTien; }
            set { giamgiaTien = value; }
        }
        bool isDelete;

        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
        string createUser;

        public string CreateUser
        {
            get { return createUser; }
            set { createUser = value; }
        }
        DateTime createDate;

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        string updateUser;

        public string UpdateUser
        {
            get { return updateUser; }
            set { updateUser = value; }
        }
        DateTime updateDate;

        public DateTime UpdateDate
        {
            get { return updateDate; }
            set { updateDate = value; }
        }
        string metaTitile;

        public string MetaTitile
        {
            get { return metaTitile; }
            set { metaTitile = value; }
        }
        string keyWord;
        int manufacturer;
        public int Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (manufacturer == value)
                    return;
                manufacturer = value;
            }
        }

        public string KeyWord
        {
            get { return keyWord; }
            set { keyWord = value; }
        }

        List<Harvest> _HarvestList;
        public List<Harvest> HarvestList
        {
            get { return _HarvestList; }
            set { _HarvestList = value; }
        }



        public Product()
        {
        }
       
        public Product(DataRow row)
        {   
        this.IdProduct = (int)row["IdProduct"] ;
        this.IDNameProduct = row["IdNameProduct"].ToString() ;
        this.NameProduct = row["NameProduct"].ToString() ;
        this.GroupIterm = (row["GroupIterm"] is DBNull) ? int.MinValue : int.Parse(row["GroupIterm"].ToString());
        this.Description = (row["DesCription"] is DBNull) ? "" : row["DesCription"].ToString();
        this.Manufacturer = (row["ManufacturerID"] is DBNull) ? int.MinValue : int.Parse(row["ManufacturerID"].ToString());
        this.Price =(row["Price"]is DBNull) ? (float.MinValue) : float.Parse(row["Price"].ToString()) ;
        this.PriceNote = (row["PriceNote"] is DBNull) ? (float.MinValue) :float.Parse(row["PriceNote"].ToString());
        this.Images = row["Image"].ToString() ;
        this.Color = row["Color"].ToString();
        this.Material = row["Material"].ToString();
        this.MultiPrice = row["MultiPrice"].ToString();
        this.Soluong = (row["Soluong"] is DBNull) ? int.MinValue : (int)row["Soluong"];
        this.IsNew =(bool)row["IsNew"] ;
        this.IsHot =(bool) row["IsHot"] ;
        this.luotMua = (row["LuotMua"] is DBNull) ? int.MinValue : (int)row["LuotMua"];
        this.luotXem = (row["LuotXem"] is DBNull) ? int.MinValue : (int)row["LuotXem"];
        this.IsGiamGiaPt = (bool)row["IsGiamGiaPT"];
        this.GiamGiaPT =(row["GiamGiaPT"] is DBNull) ?(int.MinValue) : int.Parse(row["GiamGiaPT"].ToString()) ;
        this.IsGiamGiaTien =(bool) row["IsGiaGiaTien"];
        this.GiamgiaTien = (row["GiamGiaTien"] is DBNull) ? (int.MinValue) : int.Parse(row["GiamGiaTien"].ToString());
        this.KeyWord = (row["Keyword"] is DBNull) ? "" : row["Keyword"].ToString();
        this.IsDelete =(bool) row["IsDelete"];
        this.CreateDate = (row["CretaDate"] is DBNull) ? DateTime.MinValue : (DateTime)row["CretaDate"]; 
        this.UpdateDate = (row["UpdateDate"] is DBNull) ? DateTime.MinValue : (DateTime)row["UpdateDate"]; 
        this.CreateUser =(row["CreateUser"] is DBNull) ?"": row["CreateUser"].ToString();
        this.UpdateUser = (row["UpdateUser"] is DBNull) ? "" : row["UpdateUser"].ToString();
        this.MetaTitile = (row["MetaTitle"] is DBNull) ? "" : row["MetaTitle"].ToString(); 
        }
        public Product(SqlDataReader reader)
        {

            this.IdProduct = (reader["IdProduct"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["IdProduct"].ToString()));
            this.IDNameProduct = (reader["IdNameProduct"] is DBNull) ? string.Empty : (System.String)reader["IdNameProduct"] ;
            this.NameProduct = (reader["NameProduct"] is DBNull) ? string.Empty : (System.String)reader["NameProduct"];
            this.GroupIterm = (reader["GroupIterm"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["GroupIterm"].ToString()));
            this.Description = (reader["DesCription"] is DBNull) ? string.Empty : (System.String)reader["DesCription"] ;
            this.Price = (reader["Price"] is DBNull) ? (float.MinValue) : (float.Parse((System.String)reader["Price"].ToString()));
            this.PriceNote = (reader["PriceNote"] is DBNull) ? (float.MinValue) : float.Parse((System.String)reader["PriceNote"].ToString());
            this.Images = (reader["Image"] is DBNull) ? string.Empty : (System.String)reader["Image"] ;
            this.Color = (reader["Color"] is DBNull) ? string.Empty : (System.String)reader["Color"];
            this.Material = (reader["Material"] is DBNull) ? string.Empty : (System.String)reader["Material"];
            this.MultiPrice = (reader["MultiPrice"] is DBNull) ? string.Empty : (System.String)reader["MultiPrice"];
            this.Soluong = (reader["Soluong"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["Soluong"].ToString()));
            this.IsNew = (reader["IsNew"] is DBNull) ? false : bool.Parse(reader["IsNew"].ToString());
            this.IsHot = (reader["IsHot"] is DBNull) ? false : bool.Parse(reader["IsHot"].ToString());
            this.luotMua = (reader["LuotMua"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["LuotMua"].ToString()));
            this.luotXem = (reader["LuotXem"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["LuotXem"].ToString()));
            this.IsGiamGiaPt = (reader["IsGiamGiaPT"] is DBNull) ? false : bool.Parse(reader["IsGiamGiaPT"].ToString());
            this.GiamGiaPT = (reader["GiamGiaPT"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["GiamGiaPT"].ToString()));
            this.IsGiamGiaTien = (reader["IsGiaGiaTien"] is DBNull) ? false : bool.Parse(reader["IsGiaGiaTien"].ToString());
            this.GiamgiaTien = (reader["GiamGiaTien"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["GiamGiaTien"].ToString()));
            this.KeyWord = (reader["Keyword"] is DBNull) ? string.Empty : (System.String)reader["Keyword"]; ;
            this.IsDelete = (reader["IsDelete"] is DBNull) ? false : bool.Parse(reader["IsDelete"].ToString());
            this.CreateDate = (reader["CretaDate"] is DBNull) ? DateTime.MinValue : (DateTime)reader["CretaDate"]; ;
            this.UpdateDate = (reader["UpdateDate"] is DBNull) ? DateTime.MinValue : (DateTime)reader["UpdateDate"]; 
            this.CreateUser = (reader["CreateUser"] is DBNull) ? string.Empty : (System.String)reader["CreateUser"]; 
            this.UpdateUser = (reader["UpdateUser"] is DBNull) ? string.Empty : (System.String)reader["UpdateUser"]; 
            this.MetaTitile = (reader["MetaTitle"] is DBNull) ? string.Empty : (System.String)reader["MetaTitle"]; 
            
            
            

        }


    }
}
