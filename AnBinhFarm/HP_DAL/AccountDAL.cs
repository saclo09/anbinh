using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP_DAL
{
    public class AccountDAL
    {
        public static Account getAccountByID(int AccountId)
        {
            Account result = new Account();
            List<Account> list = getListAccount();
            foreach (Account gh in list)
                if (gh.IdAccount == AccountId)
                    result = gh;
            return result;
        }
        public static List<Account> getListAccount()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dtB = db.GetDateTable("SELECT * FROM Account ");
            List<Account> list = new List<Account>();
            foreach (DataRow row in dtB.Rows)
            {
                list.Add(new Account(row));
            }
            return list;
        }
        public static int InsertAccount(string UserName, string Password, string FullName, string Phone, string Email, int GroupId, string CreateUser)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]{        
                new SqlParameter("@UserName",UserName ),
                new SqlParameter("@Password",Password ),
                new SqlParameter("@FullName", FullName),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@Email",Email ),
                new SqlParameter("@GroupId", GroupId),
                 new SqlParameter("@CreateUser", CreateUser)
                
                  };

            string lenh = " INSERT INTO Account ( UserName , Password  , FullName    , Phone , Email   , GroupId   , CreateUser) VALUES ( @UserName , @Password  , @FullName    , @Phone , @Email   , @GroupId   , @CreateUser )";

            return db.ExecuteNonQuery(lenh, @parameterArray);
        }
        public static int upDateAccount(int IdAccount, string FullName, string Phone, string Email, int GroupId, bool IsDelete, string DeleteUser)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]
            {  
                new SqlParameter("@AcountID",IdAccount ),
                new SqlParameter("@FullName",FullName ),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@Email",Email ),
                new SqlParameter("@GroupId", GroupId),
                new SqlParameter("@IsDelete",IsDelete ),
                new SqlParameter("@DeleteUser", DeleteUser),
                new SqlParameter("@DeleteDate",DateTime.Now )
                  };

            string lenh = "UPDATE Account   SET  FullName  = @FullName , Phone  = @Phone, Email  = @Email, GroupId  = @GroupId ,  IsDelete  = @IsDelete, DeleteUser  = @DeleteUser , DeleteDate  = @DeleteDate  WHERE AcountID=@AcountID ";

            return db.ExecuteNonQuery(lenh, @parameterArray);
        }
        public static int MyupDateAccount(int IdAccount, string Password, string FullName, string Phone, string Email)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]
            {  
                new SqlParameter("@AcountID",IdAccount ),
                new SqlParameter("@Password",Password ),
                new SqlParameter("@FullName",FullName ),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@Email",Email )  
              
              };

            string lenh = "UPDATE Account   SET  Password  = @Password, FullName  = @FullName , Phone  = @Phone, Email  = @Email  WHERE AcountID=@AcountID ";

            return db.ExecuteNonQuery(lenh, @parameterArray);
        }
    }
}
