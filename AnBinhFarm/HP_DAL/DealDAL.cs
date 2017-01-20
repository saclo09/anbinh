using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HP_DAL
{
    public class DealDAL
    {
        public static Deal getDealById(int DealID)
        {
            List<Deal> dsCm = getListDeal();
            foreach (Deal tempCm in dsCm)
            {
                if (tempCm.DealId == DealID)
                    return tempCm;
            }
            return null;
        }
        public static List<Deal> getListDeal()
        {
            List<Deal> resultList = new List<Deal>();
            DataAccessHelper db = new DataAccessHelper();
            DataTable btCM = db.GetDateTable("SELECT * FROM Deal order by dealid desc ");
            foreach (DataRow row in btCM.Rows)
            {
                Deal temp = new Deal(row);
                resultList.Add(temp);
            }

            return resultList;

        }
        public static int insertDeal(int productid, float newPrice,int giamPT, DateTime Startdate, DateTime StopDate, string creteaBy)
        {
            DataAccessHelper db = new DataAccessHelper();
            string lenh = String.Format("INSERT INTO Deal(ProductId , PriceNew  ,GiamPT, TimeStart , TimeStop , isDelete    , CreateBy ) VALUES  ({0},{1},{2},'{3}','{4}','{5}','{6}' )", productid, newPrice, giamPT, Startdate.ToString("yyyy-MM-dd hh:mm:ss tt"), StopDate.ToString("yyyy-MM-dd hh:mm:ss tt"), false, creteaBy);
            return db.ExecuteNonQuery(lenh);
            
        }
        public static int deleteDeal(int dealId)
        {
            DataAccessHelper db = new DataAccessHelper();
            string lenh = String.Format(" UPDATE Deal  SET isDelete ='True' WHERE deadId={0}", dealId);    
            return db.ExecuteNonQuery(lenh);

        }
        public static int updateDeal(int DealId, int productid, float newPrice, int giamPT, DateTime Startdate, DateTime StopDate, string creteaBy)
        {
            DataAccessHelper db = new DataAccessHelper();
            string lenh = String.Format("UPDATE Deal  SET ProductId={0}   , PriceNew={1} ,GiamPT={2}, TimeStart={3} , TimeStop={4}  , isDelete= 'false', CreateBy={5} WHERE DealId={6} ", productid, newPrice,giamPT, Startdate, StopDate, creteaBy, DealId);
            return db.ExecuteNonQuery(lenh);
        }
    }
}
