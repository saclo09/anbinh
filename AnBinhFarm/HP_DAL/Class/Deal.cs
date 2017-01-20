using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HP_DAL
{
	public class Deal
	{
        int dealId;
        public int DealId
        {
            get
            {
                return dealId;
            }
            set
            {
                if (dealId == value)
                    return;
                dealId = value;
            }
        }
        int productId;
        string createBy;
        public string CreateBy
        {
            get
            {
                return createBy;
            }
            set
            {
                if (createBy == value)
                    return;
                createBy = value;
            }
        }

        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                if (productId == value)
                    return;
                productId = value;
            }
        }
        float newPrice;
        public float NewPrice
        {
            get
            {
                return newPrice;
            }
            set
            {
                if (newPrice == value)
                    return;
                newPrice = value;
            }
        }
        int giamPT;

        public int GiamPT
        {
            get { return giamPT; }
            set { giamPT = value; }
        }
        DateTime startDate;
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                if (startDate == value)
                    return;
                startDate = value;
            }
        }
        DateTime stopDate;
        public DateTime StopDate
        {
            get
            {
                return stopDate;
            }
            set
            {
                if (stopDate == value)
                    return;
                stopDate = value;
            }
        }
        bool isdelete;
        public bool Isdelete
        {
            get
            {
                return isdelete;
            }
            set
            {
                if (isdelete == value)
                    return;
                isdelete = value;
            }
        }
        bool isActive;
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                if (isActive == value)
                    return;
                isActive = value;
            }
        }
        public Deal()
        {
        }
        public Deal(DataRow row)
        {
            this.DealId = (row["DealId"] is DBNull) ? int.MinValue : int.Parse(row["DealId"].ToString());
            this.ProductId = (row["ProductId"] is DBNull) ? int.MinValue : int.Parse(row["ProductId"].ToString()); ;
            this.NewPrice = (row["PriceNew"] is DBNull) ? int.MinValue : int.Parse(row["PriceNew"].ToString()); ;
            this.GiamPT = (row["GiamPT"] is DBNull) ? int.MinValue : int.Parse(row["GiamPT"].ToString()); ;
            this.StartDate = (row["TimeStart"] is DBNull) ? DateTime.MinValue : DateTime.Parse(row["TimeStart"].ToString()); ;
            this.StopDate = (row["TimeStop"] is DBNull) ? DateTime.MinValue : DateTime.Parse(row["TimeStop"].ToString()); ;
            this.Isdelete=(row["isDelete"]is DBNull)?false : bool.Parse(row["isDelete"].ToString());
            this.CreateBy = (row["CreateBy"] is DBNull) ? "" : row["CreateBy"].ToString();
            this.IsActive = (row["isActive"] is DBNull) ? false : bool.Parse(row["isActive"].ToString());
        }
	}
}
