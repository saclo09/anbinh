using HP_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HP_BLL
{
   public class LinkBLL
    {
        public static Link getLinkbyId(int ID)
        {
            List<Link> ds = LinkDAL.getListLink();
            Link a = new Link();
            foreach (Link acc in ds)
            {
                if (acc.LinkID == ID)
                { a = acc; break; }
            }
            return a;
        }

        public static List<Link> getListLinkMainMenu(int IdGroup)
        {
            return ( LinkDAL.getListLinkByParentIDAndType(IdGroup,"Mainmenu"));
        }
    }
}
