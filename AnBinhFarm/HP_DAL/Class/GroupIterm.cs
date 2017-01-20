using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HP_DAL
{
    public class GroupIterm
    {
        int iDGroup;

        public int IDGroup
        {
            get { return iDGroup; }
            set { iDGroup = value; }
        }
        string nameGroup;

        public string NameGroup
        {
            get { return nameGroup; }
            set { nameGroup = value; }
        }
        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        int root;

        public int Root
        {
            get { return root; }
            set { root = value; }
        }
        int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        bool isdelete;
        bool isHot;
        public bool IsHot
        {
            get
            {
                return isHot;
            }
            set
            {
                if (isHot == value)
                    return;
                isHot = value;
            }
        }

        public bool Isdelete
        {
            get { return isdelete; }
            set { isdelete = value; }
        }
        string keyword;

        public string Keyword
        {
            get { return keyword; }
            set { keyword = value; }
        }
        string tittle;

        public string Tittle
        {
            get { return tittle; }
            set { tittle = value; }
        }
        string createBy;

        public string CreateBy
        {
            get { return createBy; }
            set { createBy = value; }
        }
        DateTime createDate;

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        string deleteBy;

        public string DeleteBy
        {
            get { return deleteBy; }
            set { deleteBy = value; }
        }
        DateTime deleteDate;

        public DateTime DeleteDate
        {
            get { return deleteDate; }
            set { deleteDate = value; }
        }
        int _stt;

        public int Stt
        {
            get { return _stt; }
            set { _stt = value; }
        }
        public GroupIterm(DataRow row)
        {
            this.iDGroup = (int)row["IDGroup"];
            this.NameGroup = row["NameGroup"].ToString();
            this.Description = row["DesCription"].ToString();
            this.Root = (row["Root"] is DBNull) ? int.MinValue : (int)row["Root"];
            this.Stt = (row["STT"] is DBNull) ? int.MinValue : (int)row["STT"];
            this.Level = (int)row["IsLevel"];
            this.Isdelete = (bool)row["IsDelete"];
            this.IsHot = (bool)row["IsHot"];
            this.Keyword = row["Keyword"].ToString();
            this.Tittle = row["MetaTitle"].ToString();
            this.CreateBy = row["CreateBy"].ToString();
            this.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
            this.DeleteBy = row["DeleteBy"].ToString();
            this.DeleteDate = (row["DeleteDate"] is DBNull) ? DateTime.MinValue :DateTime.Parse(row["DeleteDate"].ToString());

        }
        public GroupIterm(IDataReader reader)
        {
            this.iDGroup = (reader["IDGroup"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["IDGroup"].ToString()));
            this.NameGroup = (reader["NameGroup"] is DBNull) ? string.Empty : (System.String)reader["NameGroup"];
            this.Description = (reader["DesCription"] is DBNull) ? string.Empty : (System.String)reader["DesCription"];
            this.Root = (reader["Root"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["Root"].ToString()));
            this.Stt = (reader["STT"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["STT"].ToString()));
            this.Level = (reader["IsLevel"] is DBNull) ? (int.MinValue) : (int.Parse((System.String)reader["IsLevel"].ToString()));
            this.Isdelete = (reader["IsDelete"] is DBNull) ? false : bool.Parse((System.String)reader["Isdelete"].ToString());
            this.IsHot = (reader["IsHot"] is DBNull) ? false : bool.Parse((System.String)reader["IsHot"].ToString());
            this.Keyword = (reader["Keyword"] is DBNull) ? string.Empty : (System.String)reader["Keyword"];
            this.Tittle = (reader["MetaTitle"] is DBNull) ? string.Empty : (System.String)reader["MetaTitle"];
            this.CreateBy = (reader["CreateBy"] is DBNull) ? string.Empty : (System.String)reader["CreateBy"];
            this.CreateDate = (reader["CreateDate"] is DBNull) ? DateTime.MinValue : (DateTime.Parse(reader["CreateDate"].ToString()));
            this.DeleteBy = (reader["DeleteBy"] is DBNull) ? string.Empty : (System.String)reader["DeleteBy"];
            this.DeleteDate = (reader["DeleteDate"] is DBNull) ? DateTime.MinValue : (DateTime.Parse(reader["DeleteDate"].ToString()));
        }


    }
}
