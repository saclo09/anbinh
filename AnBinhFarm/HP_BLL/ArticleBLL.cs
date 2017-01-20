using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HP_DAL;

namespace HP_BLL
{
    public class ArticleBLL
    {
        public static Article getArticleByID(int articleID)
        {
            return ArticleDAL.getArticleById(articleID);
        }
        public static Article getArticleKMNew()
        {
            List<Article> dsBv = ArticleDAL.GetListArticle();
            IEnumerable<Article> dsByGroup = from Article bv in dsBv
                                             where (bv.GroupIterm == -2 && bv.IsDelete != true)
                                             orderby bv.ArticleID descending
                                             select bv;
            foreach (Article bv in dsByGroup)
                return bv;
            return null;
        }
        public static List<Article> getListArticleByGroup(int GroupItermId)
        {
            List<Article> dsBv = ArticleDAL.GetListArticleByGroup(GroupItermId);

            return dsBv;
        }
        public static List<Article> getListArticle()
        {
            List<Article> dsBv = ArticleDAL.GetListArticle();
            IEnumerable<Article> dsByGroup = from Article bv in dsBv
                                             where ( bv.IsDelete != true)
                                             select bv;
            List<Article> dsResult = new List<Article>();
            foreach (Article bvm in dsByGroup)
            {
                dsResult.Add(bvm);
            }
            return dsResult;
           
        }
        public static int InsertArticle(string articleName, string articleImage, string noteImage, string articleContent,string articleSummary, string articleKeyWords , int GroupIterm, string CreateBy)
        {
            return ArticleDAL.InsertArticle(articleName, articleImage, noteImage, articleContent, articleSummary, articleKeyWords, GroupIterm, CreateBy);
        }
        public static int upDateArticle(int articleID, string articleName, string articleImage, string noteImage, string articleContent, string articleSummary, string articleKeyWords, int GroupIterm)
        {
            return ArticleDAL.upDateArticle(articleID, articleName, articleImage, noteImage, articleContent, articleSummary, articleKeyWords, GroupIterm);
        }
        public static int deleteArticle(int articleID)
        {
            return ArticleDAL.deleteArticle(articleID);
        }
    }
}
