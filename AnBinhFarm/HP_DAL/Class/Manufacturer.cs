using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HP_DAL
{
    public class Manufacturer
    {
        int manufacturerId;

        public int ManufacturerId
        {
          get { return manufacturerId; }
          set { manufacturerId = value; }
        }

        string manufacturerName;

        public string ManufacturerName
        {
            get { return manufacturerName; }
            set { manufacturerName = value; }
        }
        int groupIterm;

        public int GroupIterm
        {
            get { return groupIterm; }
            set { groupIterm = value; }
        }
        string desCription;

        public string DesCription
        {
            get { return desCription; }
            set { desCription = value; }
        }
        string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        bool isDelete;

        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
        }
        //======hàm khởi tạo============
        public Manufacturer()
        {
        }
        public Manufacturer(DataRow row)
        {
            this.ManufacturerId = int.Parse(row["ManufacturerId"].ToString());
            this.ManufacturerName = (row["ManufacturerName"] is DBNull) ? "" : row["ManufacturerName"].ToString();
            this.GroupIterm = (row["GroupIterm"] is DBNull) ? int.MinValue : int.Parse(row["GroupIterm"].ToString());
            this.DesCription = (row["DesCription"] is DBNull) ? "" : row["DesCription"].ToString();
            this.Image = (row["Image"] is DBNull) ? "" : row["Image"].ToString();
            this.IsDelete = (row["IsDelete"] is DBNull) ? false : bool.Parse(row["IsDelete"].ToString());
        }
    }
}
