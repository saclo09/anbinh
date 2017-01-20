using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HP_DAL;

namespace HP_BLL
{
    public class ManufacturerBLL
    {
        public static List<Manufacturer> getListManufacturerBYGroup(int groupterm)
        {
            List < Manufacturer > dsMn = ManufacturerDAL.getListManufacturer();
            IEnumerable<Manufacturer> dsloc = from Manufacturer mn in dsMn
                                              where (mn.GroupIterm == groupterm && mn.IsDelete != true)
                                              select mn;
            return new List<Manufacturer>(dsloc);
        }
        public static List<Manufacturer> getListManufacturerIs()
        {
            List<Manufacturer> dsMn = ManufacturerDAL.getListManufacturer();
            IEnumerable<Manufacturer> dsloc = from Manufacturer mn in dsMn
                                              where (mn.IsDelete != true)
                                              select mn;
            return new List<Manufacturer>(dsloc);
        }
        public static Manufacturer getManufacturerBYId(int manufactureID)
        {
            return ManufacturerDAL.getManufacturerByID(manufactureID);
        }
        public static int updateManufacturer(int ManufacturerID, string ManufacturerName, int GroupIterm, string DesCription, string Image)
        {
            return ManufacturerDAL.updateManufacturer(ManufacturerID, ManufacturerName, GroupIterm, DesCription, Image);
        }
        public static int insertManufacturer( string ManufacturerName, int GroupIterm, string DesCription, string Image)
        {
            return ManufacturerDAL.insertManufacturer(ManufacturerName, GroupIterm, DesCription, Image);
        }
        public static int deleteManufacturer(int ManufacturerId)
        {
            return ManufacturerDAL.deleteManufacturer(ManufacturerId);
        }
    }
}
