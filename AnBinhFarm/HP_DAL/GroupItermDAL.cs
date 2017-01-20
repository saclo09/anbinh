using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HP_DAL
{
    public class GroupItermDAL
    {
        public static GroupIterm getGroupItermByID(int GroupItermID)
        {
            List<GroupIterm> list = GetListGroupIterm();
            foreach (GroupIterm temp in list)
            {
                if (temp.IDGroup == GroupItermID)
                    return temp;
            }
            return null;
        }
        List<GroupIterm> DataTableToListGroupIterm(DataTable dt)
        {
            List<GroupIterm> list = new List<GroupIterm>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new GroupIterm(row));
            }
            return list;
        }
        List<GroupIterm> IdataRederToList(IDataReader reader)
        {
            List<GroupIterm> list = new List<GroupIterm>();
            while (reader.Read())
            {
                GroupIterm temp = new GroupIterm(reader);
                list.Add(temp);
            }

            return list;
        }
       public static List<GroupIterm> GetListGroupIterm()
        {
            List<GroupIterm> ds = new List<GroupIterm>();
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDateTable("SELECT * FROM GroupIterm");
            if (dt!=null)
            foreach (DataRow row in dt.Rows)
            {
                ds.Add(new GroupIterm(row));
            }
            return ds;
        }
       public static int deleteGroupIterm(int GroupItermID, string userDelete)
       {
           SqlParameter[] @parameterArray = new SqlParameter[] 
           {       
              new SqlParameter("@IsDelete",true)  
              ,new SqlParameter("@IDGroup", GroupItermID)
             ,new SqlParameter("@DeleteBy",userDelete)           
             ,new SqlParameter("@DeleteDate", DateTime.Now)
           };
           DataAccessHelper db = new DataAccessHelper();
           string lenh = " UPDATE GroupIterm  SET  [IsDelete] =@IsDelete  ,[DeleteBy] =@DeleteBy ,[DeleteDate] =@DeleteDate  WHERE IDGroup=@IDGroup ";
           return db.ExecuteNonQuery(lenh, @parameterArray);
       }
        public static int updateGroupIterm(int GroupItermID, string NameGroup, string DesCription, int Root, int IsLevel, bool IsHot, string MetaTitle, string Keyword)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlParameter[] @parameterArray = new SqlParameter[] 
           {       
              new SqlParameter("@NameGroup",NameGroup)           
             ,new SqlParameter("@DesCription",DesCription)           
             ,new SqlParameter("@Root", Root)
             ,new SqlParameter("@IsLevel", IsLevel)
             ,new SqlParameter("@IsHot", IsHot)
             ,new SqlParameter("@MetaTitle", MetaTitle)
             ,new SqlParameter("@Keyword", Keyword)
             ,new SqlParameter("@IDGroup", GroupItermID)
           };

            string lenh = "UPDATE GroupIterm   SET [NameGroup]= @NameGroup,[DesCription]=@DesCription ,[Root] = @Root,[IsLevel] =@IsLevel ,[IsHot] =@IsHot ,[MetaTitle] =@MetaTitle ,[Keyword] = @Keyword  WHERE   IDGroup=@IDGroup ";
            return db.ExecuteNonQuery(lenh,@parameterArray);
        }
         public static int insertGroupIterm(string NameGroup ,string DesCription ,int Root ,int IsLevel ,bool IsHot ,string MetaTitle ,string Keyword  ,string CreateBy )
         {
             DataAccessHelper db = new DataAccessHelper();
             SqlParameter[] @parameterArray = new SqlParameter[] 
           {       
              new SqlParameter("@NameGroup",NameGroup)           
             ,new SqlParameter("@DesCription",DesCription)           
             ,new SqlParameter("@Root", Root)
             ,new SqlParameter("@IsLevel", IsLevel)
             ,new SqlParameter("@IsHot", IsHot)
             ,new SqlParameter("@MetaTitle", MetaTitle)
             ,new SqlParameter("@Keyword", Keyword)
             ,new SqlParameter("@CreateBy", CreateBy)
           };

             string lenh = "INSERT INTO GroupIterm( [NameGroup],[DesCription],[Root],[IsLevel],[IsHot],[MetaTitle] ,[Keyword] ,[CreateBy] ) VALUES (@NameGroup ,@DesCription ,@Root ,@IsLevel ,@IsHot ,@MetaTitle ,@Keyword  ,@CreateBy )";
             return db.ExecuteNonQuery(lenh, @parameterArray);
         }
         
    }
}
