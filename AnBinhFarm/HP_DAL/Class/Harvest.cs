using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HP_DAL
{
   public class Harvest
    {
        int _HarvestID;

        public int HarvestID
        {
            get { return _HarvestID; }
            set { _HarvestID = value; }
        }
        int _ProductID;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        string _ProductName;

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        float _Total;

        public float Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
        float _Selled;

        public float Selled
        {
            get { return _Selled; }
            set { _Selled = value; }
        }
        DateTime _HarvestDate;

        public DateTime HarvestDate
        {
            get { return _HarvestDate; }
            set { _HarvestDate = value; }
        }
         public Harvest()
        { }
         public Harvest(DataRow row)
        {
            this.HarvestID = (row["HarvestID"] is DBNull) ? int.MinValue : (int)row["HarvestID"];
            this.ProductID = (row["ProductID"] is DBNull) ? int.MinValue : (int)row["ProductID"];
            this.ProductName = (row["ProductName"] is DBNull) ? "" : row["ProductName"].ToString();
            this.Total = (row["Total"] is DBNull) ? int.MinValue : (int)row["Total"];
            this.Selled = (row["Selled"] is DBNull) ? int.MinValue : (int)row["Selled"];
            this.HarvestDate = (row["HarvestDate"] is DBNull) ? DateTime.MinValue : DateTime.Parse(row["HarvestDate"].ToString());
          
        }

    }
}
