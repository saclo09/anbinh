using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP_DAL
{
    
    public class ManufacturerDAL
    {
        public static List<Manufacturer> getListManufacturer()
        {
            DataAccessHelper DB = new DataAccessHelper();
            using (DataTable bangMn = DB.GetDateTable("SELECT * FROM Manufacturer"))
            {
                List<Manufacturer> dstraVe = new List<Manufacturer>();
                foreach (DataRow row in bangMn.Rows)
                {
                    Manufacturer temp = new Manufacturer(row);
                    dstraVe.Add(temp);
                }
                return dstraVe;
            }
        }
        public static Manufacturer getManufacturerByID(int ManufacturerID)
        {
            List<Manufacturer> dstraVe = getListManufacturer();
                foreach (Manufacturer row in dstraVe)
                {
                    if(row.ManufacturerId==ManufacturerID)
                        return row;
                }
                return null;
        }
        public static int insertManufacturer(string ManufacturerName   ,int GroupIterm,string DesCription  ,string Image)
        {
            DataAccessHelper DB = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]
            {       
                new SqlParameter("@ManufacturerName",ManufacturerName) ,         
                new SqlParameter("@GroupIterm", GroupIterm),
                new SqlParameter("@DesCription",DesCription)  ,
                new SqlParameter("@Image",Image)                                    
            };
            string lenh = "INSERT INTO Manufacturer  (ManufacturerName   ,GroupIterm,DesCription  ,Image  ) VALUES (@ManufacturerName ,@GroupIterm  ,@DesCription ,@Image )";
            return DB.ExecuteNonQuery(lenh, @parameterArray);
        }
        public static int updateManufacturer(int ManufacturerID, string ManufacturerName, int GroupIterm, string DesCription, string Image)
        {
            DataAccessHelper DB = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]
            {       
                new SqlParameter("@ManufacturerName",ManufacturerName) ,         
                new SqlParameter("@GroupIterm", GroupIterm),
                new SqlParameter("@DesCription",DesCription)  ,
                new SqlParameter("@Image",Image) ,   
                new SqlParameter("@ManufacturerID",ManufacturerID)                  
            };
            string lenh = "UPDATE Manufacturer SET ManufacturerName= @ManufacturerName    ,GroupIterm= @GroupIterm  ,DesCription= @DesCription   ,Image= @Image   WHERE ManufacturerID= @ManufacturerID";
            return DB.ExecuteNonQuery(lenh, @parameterArray);
        }
        public static int deleteManufacturer(int ManufacturerID)
        {
            DataAccessHelper DB = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[] 
            {
                new SqlParameter("@ManufacturerID",ManufacturerID) 
            };
            string lenh = "UPDATE IsDelete ='true' WHERE ManufacturerID= @ManufacturerID";
            return DB.ExecuteNonQuery(lenh, @parameterArray);
        }

    }
}
