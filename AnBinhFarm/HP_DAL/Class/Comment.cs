using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HP_DAL
{
    public class Comment
    {
        int commentId;
        public int CommentId
        {
            get
            {
                return commentId;
            }
            set
            {
                if (commentId == value)
                    return;
                commentId = value;
            }
        }
        int productId;
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
        string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email == value)
                    return;
                email = value;
            }
        }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name == value)
                    return;
                name = value;
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
        string contentComment;
        public string ContentComment
        {
            get
            {
                return contentComment;
            }
            set
            {
                if (contentComment == value)
                    return;
                contentComment = value;
            }
        }
        bool isCheck;
        public bool IsCheck
        {
            get
            {
                return isCheck;
            }
            set
            {
                if (isCheck == value)
                    return;
                isCheck = value;
            }
        }
        string checkBy;
        public string CheckBy
        {
            get
            {
                return checkBy;
            }
            set
            {
                if (checkBy == value)
                    return;
                checkBy = value;
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
        public Comment()
        { }
        public Comment(DataRow row)
        {
            this.CommentId = (row["CommentId"] is DBNull) ? int.MinValue : int.Parse(row["CommentId"].ToString());
            this.ProductId = (row["ProductId"] is DBNull) ? int.MinValue : int.Parse(row["ProductId"].ToString());
            this.Name=(row["Name"] is DBNull) ? "Noname":row["Name"].ToString();
            this.Email = (row["Email"] is DBNull) ? "NoEmail" : row["Email"].ToString();
            this.ContentComment = (row["Content"] is DBNull) ? "Noname" : row["Content"].ToString();
            this.Date = (row["Date"] is DBNull) ? DateTime.MinValue :DateTime.Parse( row["Date"].ToString());
            this.IsCheck = (row["IsCheck"] is DBNull) ? false : bool.Parse( row["IsCheck"].ToString());
            this.IsDelete = (row["IsDelete"] is DBNull) ? false : bool.Parse(row["IsDelete"].ToString());
            this.CheckBy = (row["CheckBy"] is DBNull) ? "Noname" : row["CheckBy"].ToString();
        }


    }
}
