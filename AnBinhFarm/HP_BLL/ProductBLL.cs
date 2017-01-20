using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HP_DAL;

namespace HP_BLL
{
    public class ProductBLL
    {
        public static Product getProductById(int IDProduct)
        {
            return ProductDAL.getProductById(IDProduct);
        }
        public static List<Product> getListProductByGroup(int IdGroup)
        {
            return (new ProductDAL()).getListProductByGroup(IdGroup);
        }
        public static List<Product> getListProductByGroup2(int IdGroup)
        {
             List<Product> dsPr = ProductDAL.GetListProduct();
            IEnumerable<Product> list = from Product prd in dsPr
                                        where (prd.GroupIterm == IdGroup && prd.IsDelete!= true)
                                           select prd;


            return new List<Product>(list);
            
        }
        public static List<Product> getListProductByGroupSortPrice(int IdGroup)
        {
            List<Product> dsPr = (new ProductDAL()).getListProductByGroup(IdGroup);
            IEnumerable<Product> list = from Product prd in dsPr
                                        orderby prd.Price
                                        select prd;


            return new List<Product>(list);

        }
        public static List<Product> getListProductByGroupSaleGood(int IdGroup)
        {
            List<Product> dsPr = ProductDAL.GetListProduct();
            IEnumerable<Product> list = from Product prd in dsPr
                                        orderby prd.LuotXem descending 
                                        where (prd.GroupIterm == IdGroup && prd.IsDelete != true)
                                        select prd ;

            return new List<Product>(list);

        }
        public static List<Product> getListProductByGroupNew(int IdGroup)
        {
            List<Product> dsPr = ProductDAL.GetListProduct();
            IEnumerable<Product> list = from Product prd in dsPr
                                        orderby prd.IdProduct descending
                                        where (prd.GroupIterm == IdGroup && prd.IsDelete != true)
                                        select prd;

            return new List<Product>(list);

        }
        public static List<Product> getListProductSaleGood()
        {
            List<Product> dsPr = ProductDAL.GetListProduct();
            IEnumerable<Product> list = from Product prd in dsPr
                                        orderby prd.LuotXem descending
                                        where (prd.IsDelete != true)
                                        select prd;

            return new List<Product>(list);

        }
        
        public static List<Product> getListProduct()
        {
            return ProductDAL.GetListProduct();
        }
        public static List<Product> GetListProductAndHarvest()
         {
             List<Product> list = ProductDAL.GetListProduct();
             foreach (Product product in list)
             {
                 product.HarvestList = HarvestBLL.getListHarvestByProduct(product.IdProduct);
             }
             return list;
         }
        
        public static List<Product> getListProductByPrice(int IdGroup,float PriceFrom,float priceTo)
        {
            
            List<Product> dsPr = ProductDAL.GetListProduct();
            IEnumerable<Product> list = from Product prd in dsPr
                                        where (prd.GroupIterm == IdGroup && prd.IsDelete != true) && (prd.Price >= PriceFrom && prd.Price <= priceTo)
                                        select prd;
       
            return new List<Product>(list);

        }
        public static List<Product> getListProductByPriceAndHang(int IdGroup, float PriceFrom, float priceTo,int manufacturerId)
        {

            List<Product> dsPr = ProductDAL.GetListProduct();
            IEnumerable<Product> list;
            if(manufacturerId>0)
             list = from Product prd in dsPr
                                        where (prd.GroupIterm == IdGroup && prd.IsDelete != true) && (prd.Price >= PriceFrom && prd.Price <= priceTo) && (prd.Manufacturer== manufacturerId)
                                        select prd;

            else
                list =from Product prd in dsPr
                                        where (prd.GroupIterm == IdGroup && prd.IsDelete != true) && (prd.Price >= PriceFrom && prd.Price <= priceTo) 
                                        select prd;

            return new List<Product>(list);

        }
        public static List<Product> timkiemProduct(int maloai, string tukhoa)
        {
             string dkmoi="";
             string tukhoamoi = BLL.convertToUnSign2(tukhoa);
             List<string> dstukhoa = new List<string>();
             string tugoc = tukhoa;
             while (tugoc.IndexOf(" ")>0&&tugoc.Length>0)
             {
                 dstukhoa.Add(tugoc.Substring(0, tugoc.IndexOf(" ")));
                 tugoc = tugoc.Substring(tugoc.IndexOf(" ")+1);
                 int i=tugoc.IndexOf(" ");
                 if (i < 0) dstukhoa.Add(tugoc);

             }
             if (maloai > 0)
             {
                 dkmoi = "( GroupIterm =" + maloai;
                 List<int> idslistcon = GroupItermBLL.listChildernGroup(maloai);
                 foreach (int i in idslistcon)
                 {
                     dkmoi = dkmoi + " or GroupIterm =" + i;
                 }
                 dkmoi = dkmoi + " ) and " + "(NameProduct like '%" + tukhoa + "%' or DesCription like '%" + tukhoa + "%'";
                 dkmoi += "or NameProduct like '%" + tukhoamoi + "%' or DesCription like '%" + tukhoamoi + "%' ";
                 dkmoi += "or IdNameProduct like '%" + tukhoa + "%'";
                 foreach (string dk in dstukhoa)
                 {
                     dkmoi += "or NameProduct like '%" + dk + "%' or DesCription like '%" + tukhoamoi + "%'";
                 }
                 dkmoi += ")";
             }
             else
             {
                 dkmoi = " NameProduct like '%" + tukhoa + "%' or DesCription like '%" + tukhoa + "%' or NameProduct like '%" + tukhoamoi + "%' or DesCription like '%" + tukhoamoi + "%' or IdNameProduct like '%" + tukhoa + "%' ";
                 foreach (string dk in dstukhoa)
                 {
                     dkmoi += "or NameProduct like '%" + dk + "%' or DesCription like '%" + tukhoamoi + "%'";
                 }
             }
            return ProductDAL.GetListProduct(dkmoi);
        }        
        public static List<Product> getListProductByGroupAndRoot(int IdGroup)
        {
            List<Product> dsPr = ProductDAL.GetListProduct();
            List<int> dsGroupId = GroupItermBLL.listChildernGroup(IdGroup);
            List<Product> listGr = new List<Product>();
            foreach (int i in dsGroupId)
            {
                List<Product> list = (new ProductDAL()).getListProductByGroup(i);
                listGr.AddRange(list);                
            }
            IEnumerable<Product> listRes = from Product prd in listGr
                                        orderby prd.Price
                                        select prd;


            return new List<Product>(listRes);
        }
        public static void tangluotxem(int productID)
        {
            try
            {
                Product tempP = getProductById(productID);
                int i = ProductDAL.tangluotxem(productID, tempP.LuotXem + 1);
            }
            catch { }
        }
        public static void tangluotmua(int productID)
        {
           try
            { Product tempP = getProductById(productID);
            int i = ProductDAL.updateProduct(productID, tempP.IDNameProduct, tempP.NameProduct, tempP.Images, tempP.Color, tempP.GroupIterm, tempP.Description, tempP.Price, tempP.PriceNote,tempP.Material,tempP.MultiPrice, tempP.Soluong, tempP.IsNew, tempP.IsHot, tempP.LuotXem + 1, tempP.LuotMua+1, tempP.IsGiamGiaTien, tempP.GiamgiaTien, tempP.IsGiamGiaPt, tempP.GiamGiaPT, tempP.UpdateUser, tempP.UpdateDate, tempP.KeyWord, tempP.MetaTitile);
            }
           catch { }
        }
        public static int insertProdcut(string IdNameProduct, string NameProduct, string Image, string Color, int groupIterm, string DesCription, float Price, float PriceNote, string Material, string MultiPrice, int Soluong, bool IsNew, bool IsHot, bool IsGiamGiaPT, int GiamGiaPT, string CreateUser, string MetaTitle, string Keyword)
        {
            return ProductDAL.insertProduct(IdNameProduct, NameProduct, Image, Color, groupIterm, DesCription, Price, PriceNote,Material,MultiPrice, Soluong, IsNew, IsHot, IsGiamGiaPT, GiamGiaPT, false, 0, CreateUser, MetaTitle, Keyword);
        }
        public static int updateProduct(int productId, string productIdName, string NameProduct, string image, string color, int groupIterm, string mota, float gia, float giaMota, string Material, string MultiPrice, int soluong, bool isNew, bool isHot, bool isGiamGiaPT, int GiamGiaPT, string updateUser, string keyWord, string metatitle)
        {
            Product tempP = getProductById(productId);
            return ProductDAL.updateProduct(productId, productIdName, NameProduct, image, color, groupIterm, mota, gia, giaMota, Material,MultiPrice, soluong, isNew, isHot, tempP.LuotXem, tempP.LuotMua, false, 0, isGiamGiaPT, GiamGiaPT, updateUser, DateTime.Now, keyWord, metatitle);
        }
        public static int deleteProduct(int productId, string userName)
        {
            return ProductDAL.DeleteProduct(productId, userName);
        }
    }
}
