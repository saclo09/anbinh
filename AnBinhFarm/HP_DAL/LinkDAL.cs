using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HP_DAL
{
    public class LinkDAL
    {
        public static Link getLinkByID(int LinkID)
        {
            Link result = new Link();
            List<Link> list = getListLink();
            foreach (Link gh in list)
                if (gh.LinkID == LinkID)
                { result = gh; break; }
            return result;
        }
        public static List<Link> getListLink()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dtB = db.GetDateTable("SELECT * FROM Link ");
            List<Link> list = new List<Link>();
            foreach (DataRow row in dtB.Rows)
            {
                list.Add(new Link(row));
            }
            return list;
        }
        public static List<Link> getListLinkByParentIDAndType(int parentID,string type)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[]
                {  
                    new SqlParameter("@parentID",parentID ),
                     new SqlParameter("@type",type ),

                  };

            string lenh = "SELECT * FROM Link WHERE ParentID=@parentID AND Type=@type Order by OrderValue";

            DataTable dtB = db.GetDateTable(lenh, @parameterArray);
            List<Link> list = new List<Link>();
            if(dtB!=null&&dtB.Rows.Count>0)
            foreach (DataRow row in dtB.Rows)
            {
                list.Add(new Link(row));
            }
            return list;
        }
        //public static int InsertAccount(string UserName, string Password, string FullName, string Phone, string Email, int GroupId, string CreateUser)
        //{
        //    DataAccessHelper db = new DataAccessHelper();
        //    SqlParameter[] @parameterArray = new SqlParameter[]{        
        //        new SqlParameter("@UserName",UserName ),
        //        new SqlParameter("@Password",Password ),
        //        new SqlParameter("@FullName", FullName),
        //        new SqlParameter("@Phone", Phone),
        //        new SqlParameter("@Email",Email ),
        //        new SqlParameter("@GroupId", GroupId),
        //         new SqlParameter("@CreateUser", CreateUser)
                
        //          };

        //    string lenh = " INSERT INTO Account ( UserName , Password  , FullName    , Phone , Email   , GroupId   , CreateUser) VALUES ( @UserName , @Password  , @FullName    , @Phone , @Email   , @GroupId   , @CreateUser )";

        //    return db.ExecuteNonQuery(lenh, @parameterArray);
        //}
        //public static int upDateAccount(int IdAccount, string FullName, string Phone, string Email, int GroupId, bool IsDelete, string DeleteUser)
        //{
        //    DataAccessHelper db = new DataAccessHelper();
        //    SqlParameter[] @parameterArray = new SqlParameter[]
        //    {  
        //        new SqlParameter("@AcountID",IdAccount ),
        //        new SqlParameter("@FullName",FullName ),
        //        new SqlParameter("@Phone", Phone),
        //        new SqlParameter("@Email",Email ),
        //        new SqlParameter("@GroupId", GroupId),
        //        new SqlParameter("@IsDelete",IsDelete ),
        //        new SqlParameter("@DeleteUser", DeleteUser),
        //        new SqlParameter("@DeleteDate",DateTime.Now )
        //          };

        //    string lenh = "UPDATE Account   SET  FullName  = @FullName , Phone  = @Phone, Email  = @Email, GroupId  = @GroupId ,  IsDelete  = @IsDelete, DeleteUser  = @DeleteUser , DeleteDate  = @DeleteDate  WHERE AcountID=@AcountID ";

        //    return db.ExecuteNonQuery(lenh, @parameterArray);
        //}
        //public static int MyupDateAccount(int IdAccount, string Password, string FullName, string Phone, string Email)
        //{
        //    DataAccessHelper db = new DataAccessHelper();
        //    SqlParameter[] @parameterArray = new SqlParameter[]
        //    {  
        //        new SqlParameter("@AcountID",IdAccount ),
        //        new SqlParameter("@Password",Password ),
        //        new SqlParameter("@FullName",FullName ),
        //        new SqlParameter("@Phone", Phone),
        //        new SqlParameter("@Email",Email )  
              
        //      };

        //    string lenh = "UPDATE Account   SET  Password  = @Password, FullName  = @FullName , Phone  = @Phone, Email  = @Email  WHERE AcountID=@AcountID ";

        //    return db.ExecuteNonQuery(lenh, @parameterArray);
        //}
    }
}
