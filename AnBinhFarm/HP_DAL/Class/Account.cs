using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Data.SqlClient;
using System.Data;

namespace HP_DAL
{
    public class Account
    {
        int idAccount;

        public int IdAccount
        {
            get { return idAccount; }
            set { idAccount = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        int groupId;

        public int GroupId
        {
            get { return groupId; }
            set { groupId = value; }
        }
        string createUser;

        public string CreateUser
        {
            get { return createUser; }
            set { createUser = value; }
        }
        DateTime createDate;

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        bool isDelete;

        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; }
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
        DateTime lastLogin;

        public DateTime LastLogin
        {
            get { return lastLogin; }
            set { lastLogin = value; }
        }
        int loginCount;

        public int LoginCount
        {
            get { return loginCount; }
            set { loginCount = value; }
        }
        string loginIp;

        public string LoginIp
        {
            get { return loginIp; }
            set { loginIp = value; }
        }
           
        public Account()
        { }
        public Account(DataRow row)
        {
          this.IdAccount= (row["AcountID"] is DBNull) ? int.MinValue :(int)row["AcountID"]; 
            this.FullName=(row["FullName"]is DBNull) ? "" :row["FullName"].ToString();
            this.Username=(row["UserName"]is DBNull) ? "" :row["UserName"].ToString();
            this.Password=(row["Password"]is DBNull) ? "" :row["Password"].ToString();
            this.Phone=(row["Phone"]is DBNull) ? "" :row["Phone"].ToString();
            this.Email=(row["Email"]is DBNull) ? "" :row["Email"].ToString();            
            this.GroupId=(row["GroupId"] is DBNull) ? int.MinValue :int.Parse(row["GroupId"].ToString()); 
            this.CreateDate=(row["CreateDate"] is DBNull) ? DateTime.MinValue :DateTime.Parse( row["CreateDate"].ToString());
            this.CreateUser=(row["CreateUser"]is DBNull) ? "" :row["CreateUser"].ToString();;
            this.IsDelete=bool.Parse(row["IsDelete"].ToString());
            this.DeleteDate=(row["DeleteDate"] is DBNull) ? DateTime.MinValue :DateTime.Parse( row["DeleteDate"].ToString());;
            this.DeleteBy=(row["DeleteUser"]is DBNull) ? "" :row["DeleteUser"].ToString();;
            this.LoginCount=(row["LoginCount"] is DBNull) ? int.MinValue :int.Parse(row["LoginCount"].ToString());
            this.LoginIp=(row["LoginIp"]is DBNull) ? "" :row["LoginIp"].ToString();;
            this.LastLogin=(row["LastLogin"] is DBNull) ? DateTime.MinValue :DateTime.Parse( row["LastLogin"].ToString());;
           
      
        }
         
        


    }
}
