using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace HP_DAL
{
    public class ProductDAL
    {
        public static Product getProductById(int IDProduct)
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dtB = db.GetDateTable("SELECT * FROM Product WHERE IdProduct=" + IDProduct.ToString());
            List<Product> list = new List<Product>();
            if(dtB!=null)
            foreach (DataRow row in dtB.Rows)
            {
                return(new Product(row));

            }
            
            return null;

        }
        public static Product getProductById2(int IDProduct)
        {

            List<Product> listP = GetListProduct();
            foreach (Product temp in listP)
            {
                if (temp.IdProduct == IDProduct)
                    return temp;
            }

            return null;

        }
        public  List<Product> getListProductByGroup(int IdGroup)
        {
            
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter paraMaproduct = new SqlParameter("@GroupIterm", IdGroup);
            SqlParameter[] mang = new SqlParameter[] { paraMaproduct };
            DataTable dtB = db.GetDateTable("SELECT * FROM Product WHERE IsDelete<>'True' AND GroupIterm=@GroupIterm  ORDER BY IsHot DESC  , IdProduct DESC", mang);
            List<Product> list = new List<Product>();
            foreach (DataRow row in dtB.Rows)
            {
                list.Add(new Product(row));
            }
            return list;

        }
         public static List<Product> GetListProduct()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dtB = db.GetDateTable("SELECT * FROM Product ORDER BY IdProduct DESC");
             List<Product> list = new List<Product>();
            if (dtB != null)
            foreach (DataRow row in dtB.Rows)
            {
                list.Add(new Product(row));
            }
            return list;
        }
         
         public static List<Product> GetListProduct(string dieukien)
         {
             DataAccessHelper db = new DataAccessHelper();
             DataTable dtB = db.GetDateTable("SELECT * FROM Product Where "+dieukien);
             List<Product> list = new List<Product>();
             foreach (DataRow row in dtB.Rows)
             {
                 list.Add(new Product(row));
             }
             return list;
         }
         public static List<Product> GetListPro()
         {
             DataAccessHelper db = new DataAccessHelper();
             SqlDataReader reader = db.GetList("SELECT * FROM Product");
             
             List<Product> list = new List<Product>();
             while (reader.Read())
             {
                 Product temp = new Product(reader);
                 list.Add(temp);
             }

             return list;
         }
         public static int DeleteProduct(int ProductId, string username)
        {
            DataAccessHelper db = new DataAccessHelper();

            return db.ExecuteNonQuery("Update  Product SET IsDelete='True',UpdateDate=@UpdateDate,UpdateUser=@UpdateUser WHERE IdProduct= @IdProduct ", new SqlParameter[] { new SqlParameter("@UpdateUser", username), new SqlParameter("@IdProduct", ProductId.ToString()), new SqlParameter("@UpdateDate", DateTime.Now) });
        }
        public static int tangluotxem(int productId,int luotxem)
        {
            DataAccessHelper db = new DataAccessHelper();
            
            SqlParameter[] @parameterArray = new SqlParameter[] {       
                new SqlParameter("@LuotXem",luotxem)           
             ,new SqlParameter("@IdProduct", productId)
                     
            };
            
            return db.ExecuteNonQuery("Update Product SET LuotXem=@LuotXem  Where IdProduct=@IdProduct ", @parameterArray);

        }
         public static int updateProduct(int productId, string productIdName, string NameProduct, string image, string color, int groupIterm, string mota, float gia, float giaMota,string Material, string MultiPrice, int soluong, bool isNew, bool isHot, int luotxem, int luotmua, bool isgiamgiatien, int Giamgiatien, bool isGiamGiaPT, int GiamGiaPT, string updateUser, DateTime updatedate, string keyWord, string metatitle)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray =  new SqlParameter[] { 
                new SqlParameter("@IdProduct", productId),
                new SqlParameter("@IdNameProduct",productIdName ),
                new SqlParameter("@NameProduct",NameProduct ),
                new SqlParameter("@Image",image ),
                new SqlParameter("@Color",color ),
                new SqlParameter("@GroupIterm",groupIterm ),
                new SqlParameter("@DesCription",mota ),
                new SqlParameter("@Price",gia ),
                new SqlParameter("@PriceNote", giaMota),
                new SqlParameter("@Material", Material),
                new SqlParameter("@MultiPrice", MultiPrice),
                new SqlParameter("@Soluong",soluong ),
                new SqlParameter("@IsNew",isNew ),
                new SqlParameter("@IsHot",isHot ),
                new SqlParameter("@LuotXem",luotxem ),
                new SqlParameter("@LuotMua",luotmua),
                new SqlParameter("@IsGiamGiaPT" , isGiamGiaPT),
                new SqlParameter("@GiamGiaPT",GiamGiaPT ),
                new SqlParameter("@IsGiaGiaTien",isgiamgiatien),
                new SqlParameter("@GiamGiaTien",Giamgiatien),            
                new SqlParameter("@UpdateUser" ,updateUser),
                new SqlParameter("@UpdateDate" ,updatedate),
                new SqlParameter("@MetaTitle",metatitle),
                new SqlParameter("@Keyword",keyWord )
            };
            return db.ExecuteNonQuery("Update Product SET IdNameProduct=@IdNameProduct ,NameProduct=@NameProduct ,GroupIterm=@GroupIterm,Image=@Image ,Color=@Color,DesCription=@DesCription,Price=@Price,PriceNote=@PriceNote, Material=@Material,  MultiPrice=@MultiPrice, Soluong=@Soluong,IsNew=@IsNew,IsHot=@IsHot,LuotXem=@LuotXem,LuotMua=@LuotMua ,IsGiamGiaPT=@IsGiamGiaPT , GiamGiaPT=@GiamGiaPT, IsGiaGiaTien=@IsGiaGiaTien, GiamGiaTien=@GiamGiaTien , UpdateUser=@UpdateUser , UpdateDate=@UpdateDate , MetaTitle=@MetaTitle , Keyword =@Keyword    Where IdProduct=@IdProduct ", @parameterArray);
        }
         public static int insertProduct(string IdNameProduct, string NameProduct, string Image, string Color, int groupIterm, string DesCription, float Price, float PriceNote,string Material, string MultiPrice, int Soluong, bool IsNew, bool IsHot, bool IsGiamGiaPT, int GiamGiaPT, bool IsGiaGiaTien, int GiamGiaTien, string CreateUser, string MetaTitle, string Keyword)
        {            
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray =  new SqlParameter[]{        
                new SqlParameter("@IdNameProduct",IdNameProduct ),
                new SqlParameter("@NameProduct",NameProduct ),
                new SqlParameter("@Image",Image ),
                new SqlParameter("@Color",Color ),
                new SqlParameter("@GroupIterm",groupIterm ),
                new SqlParameter("@DesCription",DesCription ),
                new SqlParameter("@Price",Price ),
                new SqlParameter("@PriceNote", PriceNote),
                new SqlParameter("@Material", Material),
                new SqlParameter("@MultiPrice", MultiPrice),
                new SqlParameter("@Soluong",Soluong ),
                new SqlParameter("@IsNew",IsNew ),
                new SqlParameter("@IsHot",IsHot ),
                new SqlParameter("@IsGiamGiaPT" , IsGiamGiaPT),
                new SqlParameter("@GiamGiaPT",GiamGiaPT ),
                new SqlParameter("@IsGiaGiaTien",IsGiaGiaTien),
                new SqlParameter("@GiamGiaTien",GiamGiaTien),            
                new SqlParameter("@CreateUser",CreateUser),
                new SqlParameter("@MetaTitle",MetaTitle),
                new SqlParameter("@Keyword",Keyword )
            };
            string lenh = "INSERT INTO Product (IdNameProduct ,NameProduct ,Image,Color,GroupIterm,ManufacturerID,DesCription ,Price ,PriceNote,Material,MultiPrice ,Soluong ,IsNew ,IsHot ,IsGiamGiaPT ,GiamGiaPT ,IsGiaGiaTien ,GiamGiaTien ,CreateUser ,MetaTitle,Keyword) VALUES (@IdNameProduct,@NameProduct ,@Image ,@Color, @GroupIterm,1, @DesCription ,@Price ,@PriceNote ,@Material,@MultiPrice ,@Soluong ,@IsNew ,@IsHot,@IsGiamGiaPT ,@GiamGiaPT ,@IsGiaGiaTien ,@GiamGiaTien ,@CreateUser ,@MetaTitle  ,@Keyword)";
            return db.ExecuteNonQuery(lenh, @parameterArray);
        }

    }
}
