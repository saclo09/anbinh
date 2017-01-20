using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HP_DAL
{
    public  class HarvestDAL
    {
        public static Harvest getHarvestByID(int HarvestId)
        {
            Harvest result = new Harvest();
            List<Harvest> list = getListHarvest();
            foreach (Harvest gh in list)
                if (gh.HarvestID == HarvestId)
                    result = gh;
            return result;
        }
        public static List<Harvest> getListHarvest()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dtB = db.GetDateTable("SELECT * FROM Harvest ORDER BY Harvest DESC ");
            List<Harvest> list = new List<Harvest>();
            foreach (DataRow row in dtB.Rows)
            {
                list.Add(new Harvest(row));
            }
            return list;
        }
        public static List<Harvest> getListHarvestByProduct(int ProductID)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]{        
                new SqlParameter("@ProductID",ProductID ),
                
               
                  };
            DataTable dtB = db.GetDateTable("SELECT * FROM Harvest WHERE ProductID=@ProductID ");//ORDER BY HarvestDate DESC ");
            List<Harvest> list = new List<Harvest>();
            if(dtB!=null)
            foreach (DataRow row in dtB.Rows)
            {
                list.Add(new Harvest(row));
            }
            return list;
        }
        public static int InsertHarvest(int ProductID, string ProductName, int Total, DateTime HarvestDate, string CreateUser)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]{        
                new SqlParameter("@ProductID",ProductID ),
                new SqlParameter("@ProductName",ProductName ),
                new SqlParameter("@Total", Total),
                new SqlParameter("@HarvestDate", HarvestDate),
                new SqlParameter("@CreateDate", DateTime.Now),
                new SqlParameter("@CreateUser", CreateUser),
                  };

            string lenh = " INSERT INTO Harvest  ( ProductID , ProductName , Total , Selled , HarvestDate , CreateDate , CreateUser)  VALUES  " +
                "(@ProductID, @ProductName, @Total, @Selled, @HarvestDate,@CreateDate,@CreateUser)";
            return db.ExecuteNonQuery(lenh, @parameterArray);
        }

        public static int UpdateHarvest(string IdNameHarvest, string NameHarvest, string Image, string Color, int groupIterm, string DesCription, float Price, float PriceNote, string Material, string MultiPrice, int Soluong, bool IsNew, bool IsHot, bool IsGiamGiaPT, int GiamGiaPT, bool p1, int p2, string CreateUser, string MetaTitle, string Keyword)
        {
            throw new NotImplementedException();
        }
    }
}
