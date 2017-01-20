using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HP_DAL
{
    public class Link
    {
        int _LinkID;

        public int LinkID
        {
            get { return _LinkID; }
            set { _LinkID = value; }
        }
        string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        string _LinkString;

        public string LinkString
        {
            get { return _LinkString; }
            set { _LinkString = value; }
        }
        string _Type;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        int _Rank;

        public int Rank
        {
            get { return _Rank; }
            set { _Rank = value; }
        }

        int _ParentID;

        public int ParentID
        {
            get { return _ParentID; }
            set { _ParentID = value; }
        }

        int _OrderValue;

        public int OrderValue
        {
            get { return _OrderValue; }
            set { _OrderValue = value; }
        }

        bool _IsArticle;

        public bool IsArticle
        {
            get { return _IsArticle; }
            set { _IsArticle = value; }
        }
        bool _hasChild;

        public bool HasChild
        {
            get { return _hasChild; }
            set { _hasChild = value; }
        }
        

          public Link()
        { }
          public Link(DataRow row)
        {
            this.LinkID = (row["LinkID"] is DBNull) ? int.MinValue : (int)row["LinkID"];
            this.Name = (row["Name"] is DBNull) ? "" : row["Name"].ToString();
            this.LinkString = (row["LinkString"] is DBNull) ? "" : row["LinkString"].ToString();
            this.Type = (row["Type"] is DBNull) ? "" : row["Type"].ToString();           
            this.Rank = (row["Rank"] is DBNull) ? int.MinValue : (int)row["Rank"];
            this.OrderValue = (row["OrderValue"] is DBNull) ? int.MinValue : (int)row["OrderValue"];
            this.ParentID = (row["ParentID"] is DBNull) ? int.MinValue : (int)row["ParentID"];
            this.IsArticle = (bool)row["IsArticle"];

            this.HasChild = LinkDAL.getListLinkByParentIDAndType(LinkID, Type).Count() > 0;
        }
    }
}
