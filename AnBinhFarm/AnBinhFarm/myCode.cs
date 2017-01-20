using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HP_DAL;

namespace AnBinhFarm
{
    public class myCode
    {
        public static int getCounter()
        {
            int intResult = int.MinValue;
            DataAccessHelper DB = new DataAccessHelper();
            try
            {

                string strSQL = "SELECT TOP 1 [Counter] FROM Counter ORDER BY [Counter] DESC";
               object aa= DB.GetValue(strSQL);
                intResult = Convert.ToInt32(aa);
            }
            catch 
            {
                
            }
            
            return intResult;
        }
        public static int updateCounter(int value)
        {
             int intResult = int.MinValue;
            DataAccessHelper DB = new DataAccessHelper();
            try
            {
                string strSQL=String.Format("INSERT INTO Counter (Counter) VALUES({0})",value);
               intResult= DB.ExecuteNonQuery(strSQL);
            }
            catch 
            {
               intResult=int.MinValue;
            }
            
            return intResult;
        }
    }
}