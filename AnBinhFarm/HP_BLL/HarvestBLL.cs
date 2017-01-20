using HP_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HP_BLL
{
    public class HarvestBLL
    {

        public static Harvest getHarvestByID(int HarvestID)
        {
            return HarvestDAL.getHarvestByID(HarvestID);
        }
        public static List<Harvest> getListHarvest()
        {
            List<Harvest> ds = HarvestDAL.getListHarvest();
            return ds;
        }
        public static List<Harvest> getListHarvestByProduct(int ProductID)
        {
            List<Harvest> ds = HarvestDAL.getListHarvestByProduct(ProductID).Take(3).ToList<Harvest>();

            return ds;
        }
        public static int InsertHarvest(int ProductID, string ProductName, int Total, DateTime HarvestDate, string CreateUser)
        { 
            return HarvestDAL.InsertHarvest(ProductID,  ProductName,  Total,  HarvestDate,  CreateUser);
        }
        //public static int updateHarvest(int HarvestId, string HarvestIdName, string NameHarvest, string image, string color, int groupIterm, string mota, float gia, float giaMota, string Material, string MultiPrice, int soluong, bool isNew, bool isHot, bool isGiamGiaPT, int GiamGiaPT, string updateUser, string keyWord, string metatitle)
        //{
        //    Harvest tempP = getHarvestByID(HarvestId);
        //    return HarvestDAL.UpdateHarvest(HarvestId, HarvestIdName, NameHarvest, image, color, groupIterm, mota, gia, giaMota, Material, MultiPrice, soluong, isNew, isHot, tempP.LuotXem, tempP.LuotMua, false, 0, isGiamGiaPT, GiamGiaPT, updateUser, DateTime.Now, keyWord, metatitle);
        //}
    }
}
