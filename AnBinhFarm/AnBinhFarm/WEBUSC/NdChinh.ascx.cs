using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using HP_BLL;
using HP_DAL;
using System.Configuration;

namespace AnBinhFarm.WEBUSC
{
    public partial class NdChinh : System.Web.UI.UserControl
    {
        public StringBuilder strNd = new StringBuilder();
        string donvitien;
        string lienhe;
        protected void Page_Load(object sender, EventArgs e)
        {
            try{
               donvitien= ConfigurationManager.AppSettings["DONVITIEN"].ToString();
                lienhe=ConfigurationManager.AppSettings["LIENHE"].ToString();
            }
            catch{
                donvitien="VNĐ";
                lienhe="Liên hệ";
            }
            List<GroupIterm> DsNhom = GroupItermBLL.getListGroupItermMainHot();
          //  int j = 0;
            foreach (GroupIterm Iterm in DsNhom)
            {
               string nameGroup= Iterm.NameGroup;
               strNd.Append("<div class='divboxnd'> ");
               strNd.Append("<a  href='/sp-list/" + Iterm.IDGroup + "/" + BLL.convertURL(Iterm.NameGroup) + ".aspx' title='" + Iterm.NameGroup + "' ><div class='boxtittle'> <img src='Images/Icon_Cam.png' style='float:left; padding-top:7px;padding-left:5px; '/><h1 class='chuvua' style='padding-top:5px;'> " + nameGroup + "</h1> </div></a>");
              // strNd.Append("<div class='div4sp'>");
                //==========Hiện thi 4 sp=========================================;
                List<Product> DsSp= ProductBLL.getListProductByGroupAndRoot(Iterm.IDGroup);
                int i=0;
                foreach (Product Sp in DsSp)
                {
                    strNd.Append("<div class='boxSp' data-tooltip='sticky"+Sp.IdProduct.ToString()+"'><center>");
                    strNd.Append("<div style='width:100%; position:relative;height:12px;float:left'> </div>");
                  //  strNd.Append("<div style='height:32px;'><h2 class='tieudeSPnho' title='" + Sp.NameProduct + "' >" + Sp.NameProduct + "</h2></div>");
                  //  strNd.Append("<h2 class='maSPnho'> Mã :"+Sp.IDNameProduct+"  </h2>");
                    strNd.Append("<a href='/Sp/" + Sp.IdProduct + "/"+BLL.convertURL( Sp.NameProduct)+".aspx'> ");
                    strNd.Append("<img class='hinhSPnho' onmouseover='Hien()' onmouseout='An()' title='"+Sp.NameProduct+ "' alt='"+Sp.NameProduct+"'");
                   if(string.IsNullOrEmpty(Sp.Images))strNd.Append(" src='/Images/noimage.jpg'");
                   else  strNd.Append(" src='/Hinhsp/"+Sp.Images+"'");
                       
                          
                    strNd.Append("/></a>");
                    strNd.Append("</center>");
                   
                    //if (Sp.PriceNote>0)
                    //    strNd.Append("<br /><del>Giá:" + Sp.PriceNote.ToString() + ".000 Đồng</del>");
                     strNd.Append("<div class='Ma'>"+Sp.IDNameProduct+"</div>");
                     strNd.Append("<div class='Gia'>");
                    if(Sp.Price>0)
                        strNd.Append(Sp.Price.ToString() + ".000"+donvitien );
                    else
                        strNd.Append(lienhe);
                    strNd.Append("</div> ");
                    strNd.Append("<div style='width:100%; position:relative;height:12px;float:left'> </div>");
                    strNd.Append("</div> ");                    
                    i++;
                    if(i==5) break;
                }
              
                //=================hien thị 5 bài viết===============================
                //strNd.Append("</div>");
                //    strNd.Append("<div class='boxBv'><div class='boxtitlebv'><center><a href='/bv-list/" + Iterm.IDGroup + "/" + BLL.convertURL(Iterm.NameGroup) + ".aspx' tittle='" + Iterm.NameGroup + "'>Bài viết tư vấn </a></center></div>");
                //List<Article> dsbv = ArticleBLL.getListArticleByGroup(Iterm.IDGroup);
                // i=0;
                //foreach (Article bv in dsbv)
                //{
                //    strNd.Append("<img src='Images/icon.gif' height='10' width='10' /> <a class='tieudebvnho' href='/bv/" + bv.ArticleID + "/" + BLL.convertURL(bv.ArticleName) + ".aspx' title='" + bv.ArticleName + "'>" + bv.ArticleName + "</a><br>");
                    
                //    i++;
                //    if (i == 5) break;
                //}
                //strNd.Append("</div>");
               
                strNd.Append("</div>");
            }
            strNd.Append(" <div id='mystickytooltip' class='stickytooltip'>");
            DsNhom = GroupItermBLL.getListGroupItermMainHot();
            foreach (GroupIterm Iterm in DsNhom)
            {
                string nameGroup = Iterm.NameGroup;               
                //=============hiện 5 sp trong box show========
                List<Product> DsSp = ProductBLL.getListProductByGroupAndRoot(Iterm.IDGroup);
                int i = 0;
                foreach (Product Sp in DsSp)
                {
                    //========box hiển thị nỗi lên==================================
                    strNd.Append("<div  id='sticky" + Sp.IdProduct.ToString() + "' class='atip'  >");
                    //class='boxspShow'
                    strNd.Append("<div class='tieudeboxshow' ><center>THÔNG TIN SẢN PHẨM</center></div>");
                    strNd.Append("<div class='ndboxshow' >");
                    strNd.Append("<center><b style='font-size:15px;color:blue;'>" + Sp.NameProduct + "</b></center>");
                    strNd.Append("<ul><li>Mã sản phẩm: <b>" + Sp.IDNameProduct + "</b></li>");
                    strNd.Append("<li>Kích thước: <b>" + Sp.Color + "</b></li>");
                    strNd.Append("<li>Đơn vị tính: <b>" + Sp.Material + "</b></li>");
                    string xuatxu = "Hòa phát";
                    try { xuatxu = ManufacturerBLL.getManufacturerBYId(Sp.Manufacturer).ManufacturerName; }
                    catch { }
                    strNd.Append("<li>Xuất xứ: <b>" + xuatxu  + "</b></li>");
                    strNd.Append("<li>Bảo hành:  <b>12 tháng</b></li>");  
                   // strNd.Append("<li>Tình trang: <b>");
                  //  if (Sp.Soluong > 0) strNd.Append(" Còn hàng ");
                   // else strNd.Append(" Hết hàng ");
                    strNd.Append("</b></li><li>Khuyến mãi: <b>");
                    if (Sp.IsGiamGiaPt == true)
                        strNd.Append(" Đang khuyến mãi " + Sp.GiamGiaPT.ToString() + " %");
                    else strNd.Append(" Không ");
                    if (Sp.Price > 0) strNd.Append("</b></li><li><b style='Color:Red'> Giá : " + Sp.Price.ToString() + ".000"+donvitien+" </b></li>");
                    else strNd.Append("</b></li><li><b style='Color:Red'> Giá : "+lienhe +" </b></li>");
                    strNd.Append("</div>");
                    strNd.Append("</div>");
                    //========================================
                    i++;
                    if (i == 5) break;
                }               
            }
            strNd.Append("<div class='stickystatus'></div>");
            strNd.Append("</div>");
        }
    }
}