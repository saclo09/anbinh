using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HP_DAL;


namespace HP_BLL
{
    public class GroupItermBLL
    {
        public static GroupIterm getGroupItermByID(int idGroupIt)
        {
            return GroupItermDAL.getGroupItermByID(idGroupIt);
        }
        public static List<int> listChildernGroup(int IDgroupRoot)
        {
            List<GroupIterm> ds = GroupItermDAL.GetListGroupIterm();
            IEnumerable<int> list = from GroupIterm gr in ds
                                    where (gr.Root == IDgroupRoot && gr.Isdelete != true)
                                           select gr.IDGroup;
            List<int> dsGrID = new List<int>();
            dsGrID.Add(IDgroupRoot);
            foreach (int i in list)
                dsGrID.Add(i);
            return dsGrID;
        }
        
        public static List<GroupIterm> getListGroupItermMain()
        {
            List < GroupIterm >ds= GroupItermDAL.GetListGroupIterm();
            IEnumerable<GroupIterm> list = from GroupIterm gr in ds
                                           where (gr.Root<= 0 && gr.Isdelete!=true)
                                           orderby gr.Stt
                                           select gr;
            List<GroupIterm> listGr = new List<GroupIterm>();
            foreach (GroupIterm grIt in list)
            {
                listGr.Add(grIt);
            }
            return listGr;
        }
        public static List<GroupIterm> getListGroupItermMainHot()
        {
            List<GroupIterm> ds = GroupItermDAL.GetListGroupIterm();
            IEnumerable<GroupIterm> list = from GroupIterm gr in ds
                                           where (gr.Root <=0 && gr.Isdelete != true && gr.IsHot==true)
                                           orderby gr.Stt 
                                           select gr;
            List<GroupIterm> listGr = new List<GroupIterm>();
            foreach (GroupIterm grIt in list)
            {
                listGr.Add(grIt);
            }
            return listGr;
        }
        public static List<GroupIterm> getListGroupItermChilDren(int root)
        {
            List<GroupIterm> ds = GroupItermDAL.GetListGroupIterm();
            IEnumerable<GroupIterm> list = from GroupIterm gr in ds
                                           where gr.Root == root&& gr.Isdelete!=true
                                           select gr;
            
            return new List<GroupIterm>(list);
        }
        public static int updateGroupIterm(int idgroupt,string NameGroup, string DesCription, int Root, int IsLevel, bool IsHot, string MetaTitle, string Keyword)
        {
            return GroupItermDAL.updateGroupIterm(idgroupt,NameGroup,DesCription,Root,IsLevel,IsHot,MetaTitle,Keyword);
        }
       public static int insertGroupIterm( string NameGroup, string DesCription, int Root, int IsLevel, bool IsHot, string MetaTitle, string Keyword,string createby)
        {
            return GroupItermDAL.insertGroupIterm(NameGroup, DesCription, Root, IsLevel, IsHot, MetaTitle, Keyword, createby);
        }
       public static int deleteGroupIterm(int idgroupt,string userDelete)
       {
           return GroupItermDAL.deleteGroupIterm(idgroupt, userDelete);
       }
    }
}
