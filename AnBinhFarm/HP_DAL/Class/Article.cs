using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HP_DAL
{
    public class Article
    {
       int articleID;
        public int ArticleID
        {
          get
          {
            return articleID;
          }
          set
          {
            if (articleID == value)
              return;
            articleID = value;
          }
        }
      string articleName;
        public string ArticleName
        {
          get
          {
            return articleName;
          }
          set
          {
            if (articleName == value)
              return;
            articleName = value;
          }
        }
     string articleImage;
        public string ArticleImage
        {
          get
          {
            return articleImage;
          }
          set
          {
            if (articleImage == value)
              return;
            articleImage = value;
          }
        }
      string noteImage;
        public string NoteImage
        {
          get
          {
            return noteImage;
          }
          set
          {
            if (noteImage == value)
              return;
            noteImage = value;
          }
        }
     string articleContent;
        public string ArticleContent
        {
          get
          {
            return articleContent;
          }
          set
          {
            if (articleContent == value)
              return;
            articleContent = value;
          }
        }
      int groupIterm;
        public int GroupIterm
        {
          get
          {
            return groupIterm;
          }
          set
          {
            if (groupIterm == value)
              return;
            groupIterm = value;
          }
        }
      DateTime date;
        public DateTime Date
        {
          get
          {
            return date;
          }
          set
          {
            if (date == value)
              return;
            date = value;
          }
        }
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
        bool isDelete;
        public bool IsDelete
        {
            get
            {
                return isDelete;
            }
            set
            {
                if (isDelete == value)
                    return;
                isDelete = value;
            }
        }
        string articleSummary;

        public string ArticleSummary
        {
            get { return articleSummary; }
            set { articleSummary = value; }
        }
        string articlekeywords;

        public string ArticleKeyWords
        {
            get { return articlekeywords; }
            set { articlekeywords = value; }
        }

    
    public Article(){}
    public Article(DataRow row) 
    {
       this.ArticleID= (int)row["articleID"];
       this.ArticleName = (row["articleName"] is DBNull) ? "" : row["articleName"].ToString();
       this.ArticleImage = (row["articleImage"] is DBNull) ? "" : row["articleImage"].ToString();
       this.NoteImage = (row["noteImage"] is DBNull) ? "" : row["noteImage"].ToString();
       this.ArticleSummary = (row["articleSummary"] is DBNull) ? "" : row["articleSummary"].ToString();
       this.ArticleKeyWords = (row["articleKeyword"] is DBNull) ? "" : row["articleKeyword"].ToString();        
       this.ArticleContent = (row["articleContent"] is DBNull) ? "" : row["articleContent"].ToString();
       this.GroupIterm = (row["GroupIterm"] is DBNull) ? int.MinValue : int.Parse(row["GroupIterm"].ToString());
       this.Date = (row["Date"] is DBNull) ? DateTime.MinValue : DateTime.Parse(row["Date"].ToString());
       this.CreateBy = (row["CreateBy"] is DBNull) ? "" : row["CreateBy"].ToString();
       this.IsDelete = (row["isDelete"] is DBNull) ? false : bool.Parse(row["isDelete"].ToString());
        
    }

    }
}
