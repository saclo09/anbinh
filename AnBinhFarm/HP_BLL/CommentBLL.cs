using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HP_DAL;

namespace HP_BLL
{
    public class CommentBLL
    {
        public static Comment getCommentById(int ComentID)
        {
            return CommentDAL.getCommentById(ComentID);
        }

        public static List<Comment> getListCommentByProduct(int productId)
        {
            List<Comment> dsCm = CommentDAL.getListComment();
            IEnumerable<Comment> dsByProduct = from Comment cm in dsCm
                                               where (cm.ProductId == productId && cm.IsCheck != false)
                                               select cm;

            return new List<Comment>(dsByProduct);
        }
        public static List<Comment> getListComment()
        {
            List<Comment> dsCm = CommentDAL.getListComment();
            IEnumerable<Comment> dsByProduct = from Comment cm in dsCm
                                               orderby cm.CommentId descending
                                               select cm;

            return new List<Comment>(dsByProduct);
        }
            public static int insertComment(int productId,string name,string email, string content )
        {
                return CommentDAL.insertComment( productId, name, email,  content);
        }

        public static int deleteComment(int commentId)
        {
            return CommentDAL.deleteComment(commentId);
        }
        public static int checkComment(int commentId,string Checkby)
        {
            Comment a = CommentDAL.getCommentById(commentId);
            return CommentDAL.updateComment(commentId,a.ProductId,a.Name,a.Email,a.ContentComment,Checkby);
        }
        public static int updateComment(int commentId, int productId, string name, string email, string content, string Checkby)
        {
            return CommentDAL.updateComment(commentId, productId, name, email, content, Checkby);
        }
        
    }
}
