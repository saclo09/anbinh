using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP_DAL
{
    public class CommentDAL
    {
        public static Comment getCommentById(int ComentID)
        {
            List<Comment> dsCm= getListComment();
            foreach (Comment tempCm in dsCm)
            {
                if (tempCm.CommentId == ComentID)
                    return tempCm;
            }
            return null;
        }
        public static List<Comment> getListComment()
        {
            List<Comment> resultList = new List<Comment>();
            DataAccessHelper db = new DataAccessHelper();
            using (DataTable btCM = db.GetDateTable("SELECT * FROM Comment ORDER BY CommentId DESC "))
            {
                foreach (DataRow row in btCM.Rows)
                {
                    Comment temp = new Comment(row);
                    resultList.Add(temp);
                }
            }

           return resultList;

        }
        public static int insertComment(int productId,string name,string email, string content )
        {
            DataAccessHelper db = new DataAccessHelper();
           SqlParameter[] @parameterArray = new SqlParameter[] 
           {       
              new SqlParameter("@ProductId",productId)           
             ,new SqlParameter("@Name", name)
             ,new SqlParameter("@Email", email)
             ,new SqlParameter("@Content", content)
                     
            };
           string lenh="INSERT INTO Comment([ProductId]  ,[Name]  ,[Email] ,[Content]  ) VALUES (@ProductId   ,@Name ,@Email   ,@Content ) ";
          return  db.ExecuteNonQuery(lenh,@parameterArray);
        }
        public static int updateComment(int commentId,int productId, string name, string email, string content,string Checkby )
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[] 
           {       
              new SqlParameter("@CommentId",commentId)           
             ,new SqlParameter("@ProductId",productId)           
             ,new SqlParameter("@Name", name)
             ,new SqlParameter("@Email", email)
             ,new SqlParameter("@Content", content)
             ,new SqlParameter("@IsCheck", true)
             ,new SqlParameter("@CheckBy",Checkby)
                     
            };
           string lenh = "UPDATE Comment   SET [ProductId] =@ProductId ,[Name] =@Name ,[Email] =@Email ,[Content] =@Content ,[IsCheck] =@IsCheck ,[CheckBy] =@CheckBy   WHERE [CommentId]=@CommentId ";
            return db.ExecuteNonQuery(lenh, @parameterArray);
        }
        public static int deleteComment(int commentId)
        { DataAccessHelper db = new DataAccessHelper();
        SqlParameter[] @parameterArray = new SqlParameter[] 
           {       
              new SqlParameter("@CommentId",commentId)   
           };
        string lenh = "UPDATE Comment   SET isDelete=true   WHERE [CommentId]=@CommentId ";
        return db.ExecuteNonQuery(lenh, @parameterArray);
        }
        
    }
}
