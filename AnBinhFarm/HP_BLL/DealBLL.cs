using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HP_DAL;

namespace HP_BLL
{
    public class DealBLL
    {
        public static Deal getDealbyId(int dealId)
        {
            foreach (Deal temp in getListDeal())
            {
                if (temp.DealId == dealId)
                    return temp;
            }
            return null;
        }
        public static List<Deal> getListDeal()
        {
           return DealDAL.getListDeal();
        }
        public static List<Deal> getListDealHH()
        {
            List<Deal> dsdeal = DealDAL.getListDeal();
            IEnumerable<Deal> list = from Deal deal in dsdeal
                                     where (deal.IsActive == true && deal.Isdelete != true && deal.StopDate<DateTime.Now)
                                     select deal;

            return new List<Deal>(list);
        }
        public static Deal getDealActiving()
        {
           List<Deal> dsdeal=DealDAL.getListDeal();
           IEnumerable<Deal> list = from Deal deal in dsdeal
                                    where (deal.IsActive == true && deal.Isdelete == false && deal.StartDate < DateTime.Now)
                                    orderby deal.DealId descending
                                   select deal;

           foreach (Deal i in list)
           {
               return i;
           }
           return null;
        }
        public static int updateDeal(int DealId, int productid, float newPrice, int giamPT, DateTime Startdate, DateTime StopDate, string creteaBy)
        {
            return DealDAL.updateDeal(DealId,productid,newPrice,giamPT,Startdate,StopDate,creteaBy);
        }
        public static int deleteDeal(int dealId)
        {
            return DealDAL.deleteDeal(dealId);
        }
        public static int insertDeal(int productid, float newPrice, int giamPT, DateTime Startdate, DateTime StopDate, string creteaBy)
        {
            return DealDAL.insertDeal( productid, newPrice, giamPT, Startdate, StopDate, creteaBy);
        }
    }
}
