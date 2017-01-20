using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP_DAL
{
    public class ArticleDAL
    {

        public static Article getArticleById(int articleId)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]{        
                new SqlParameter("@articleID",articleId ),
             };
            using (DataTable dtB = db.GetDateTable("SELECT * FROM Article WHERE ArticleID=@articleID",@parameterArray))
            {
                Article article = null;
                if (dtB != null&&dtB.Rows.Count>0)                
                    {
                       article= new Article(  dtB.Rows[0]);
                    }
                return article;
            }
            
        }
        
        public static List<Article> GetListArticle()
        {
            DataAccessHelper db = new DataAccessHelper();
            using (DataTable dtB = db.GetDateTable("SELECT * FROM Article ORDER BY articleID DESC "))
            {
                List<Article> list = new List<Article>();
                if (dtB != null)
                foreach (DataRow row in dtB.Rows)
                {
                    list.Add(new Article(row));
                }
                return list;
            }
        }
        public static List<Article> GetListArticleByGroup(int GroupTypeID)
        {
            DataAccessHelper db = new DataAccessHelper();
             SqlParameter[] @parameterArray = new SqlParameter[]{        
                new SqlParameter("@GroupTypeID",GroupTypeID ),
             };
            using (DataTable dtB = db.GetDateTable("SELECT * FROM Article WHERE GroupIterm=@GroupTypeID ORDER BY articleID DESC ",@parameterArray))
            {
                List<Article> list = new List<Article>();
                if(dtB!=null)
                foreach (DataRow row in dtB.Rows)
                {
                    list.Add(new Article(row));
                }
                return list;
            }
        }
        public static int InsertArticle(string articleName, string articleImage, string noteImage, string articleContent, string articleSummary, string articleKeyWords, int GroupIterm, string CreateBy)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]{        
                new SqlParameter("@articleName",articleName ),
                new SqlParameter("@articleImage",articleImage ),
                new SqlParameter("@noteImage", noteImage),
                new SqlParameter("@articleContent", articleContent),
                new SqlParameter("@articleSummary", articleSummary),
                new SqlParameter("@articleKeyWords", articleKeyWords),
                new SqlParameter("@GroupIterm",GroupIterm ),
                new SqlParameter("@CreateBy", CreateBy)
            };

            string lenh = " INSERT INTO Article(articleName ,articleImage ,noteImage    ,articleContent  ,articleSummary ,articleKeyword ,GroupIterm  ,CreateBy  )   "
            + "VALUES (@articleName ,@articleImage ,@noteImage    ,@articleContent  ,@articleSummary ,@articleKeyWords ,@GroupIterm  ,@CreateBy ) ";

            return db.ExecuteNonQuery(lenh, @parameterArray);
        }
        public static int upDateArticle(int articleID, string articleName, string articleImage, string noteImage, string articleContent, string articleSummary, string articleKeyWords, int GroupIterm)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]
            {  
                new SqlParameter("@articleID",articleID ),
                new SqlParameter("@articleName",articleName ),
                new SqlParameter("@articleImage",articleImage ),
                new SqlParameter("@noteImage", noteImage),
                new SqlParameter("@articleContent", articleContent),
                new SqlParameter("@articleSummary", articleSummary),
                new SqlParameter("@articleKeyWords", articleKeyWords),                  
                new SqlParameter("@GroupIterm",GroupIterm )
                
            };

            string lenh = " UPDATE Article   SET articleName = @articleName      , articleImage =  @articleImage, noteImage  =  @noteImage     , articleContent  = @articleContent ,"
            + " articleSummary = @articleSummary  ,articleKeyword = @articleKeyWords  , GroupIterm  = @GroupIterm   WHERE articleID=@articleID ";

            return db.ExecuteNonQuery(lenh, @parameterArray);
        }
      public static int deleteArticle(int articleID)
      {
          DataAccessHelper db = new DataAccessHelper();
          SqlParameter[] @parameterArray = new SqlParameter[]
            {  
                new SqlParameter("@articleID",articleID )
              
            };

          string lenh = " UPDATE Article   SET isDelete='True'  WHERE articleID=@articleID ";

          return db.ExecuteNonQuery(lenh, @parameterArray);
      }

    }
}
