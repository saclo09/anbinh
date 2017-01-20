using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using HP_BLL;
using HP_DAL;

namespace HPSHOP.WEBUSC
{
    public partial class NdChinh : System.Web.UI.UserControl
    {
        public StringBuilder strNd = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<GroupIterm> DsNhom = GroupItermBLL.getListGroupItermMainHot();
            foreach (GroupIterm Iterm in DsNhom)
            {
                string nameGroup = Iterm.NameGroup;
                strNd.Append("<div class='divboxnd'> ");
                strNd.Append("<a  href='/sp-list/" + Iterm.IDGroup + "/" + BLL.convertURL(Iterm.NameGroup) + ".aspx' title='" + Iterm.NameGroup + "' ><div class='boxtittle'> <img src='Images/Icon_Cam.png' style='float:left; padding-top:7px;padding-left:5px; '/><h1 class='chuvua' style='padding-top:5px;'> " + nameGroup + "</h1> </div></a>");
                // strNd.Append("<div class='div4sp'>");
                //==========Hiện thi 4 sp=========================================;
                List<Product> DsSp = ProductBLL.getListProductByGroupAndRoot(Iterm.IDGroup);
                int i = 0;
                foreach (Product Sp in DsSp)
                {
                    strNd.Append("<div class='boxSp'><center>");
                    strNd.Append("<div style='width:100%; position:relative;height:12px;float:left'> </div>");
                    //  strNd.Append("<div style='height:32px;'><h2 class='tieudeSPnho' title='" + Sp.NameProduct + "' >" + Sp.NameProduct + "</h2></div>");
                    //  strNd.Append("<h2 class='maSPnho'> Mã :"+Sp.IDNameProduct+"  </h2>");
                    strNd.Append("<a href='/Sp/" + Sp.IdProduct + "/" + BLL.convertURL(Sp.NameProduct) + ".aspx'> ");
                    strNd.Append("<img class='hinhSPnho' onmouseover='Hien()' onmouseout='An()' title='" + Sp.NameProduct + "' alt='" + Sp.NameProduct + "'");
                    if (string.IsNullOrEmpty(Sp.Images)) strNd.Append(" src='/Images/noimage.jpg'");
                    else strNd.Append(" src='/Hinhsp/" + Sp.Images + "'");


                    strNd.Append("/></a>");
                    //========box hiển thị nỗi lên==================================
                    strNd.Append("</center><div class='boxspShow' >");
                    strNd.Append("<div class='tieudeboxshow' ><center>THÔNG TIN SẢN PHẨM</center></div>");
                    strNd.Append("<div class='ndboxshow' >");
                    strNd.Append("<center><b style='font-size:15px;color:blue;'>" + Sp.NameProduct + "</b></center>");
                    strNd.Append("<ul><li>Mã sản phẩm: <b>" + Sp.IDNameProduct + "</b></li>");
                    strNd.Append("<li>Màu sắc: <b>" + Sp.Color + "</b></li>");
                    strNd.Append("<li>Chất liệu: <b>" + Sp.Material + "</b></li>");
                    strNd.Append("<li>Tình trang: <b>");
                    if (Sp.Soluong > 0) strNd.Append(" Còn hàng ");
                    else strNd.Append(" Hết hàng ");
                    strNd.Append("</b></li><li>Khuyến mãi: <b>");
                    if (Sp.IsGiamGiaPt == true)
                        strNd.Append(" Đang khuyến mãi " + Sp.GiamGiaPT.ToString() + " %");
                    else strNd.Append(" Không ");
                    if (Sp.Price > 0) strNd.Append("</b></li><li><b style='Color:Red'> Giá : " + Sp.Price.ToString() + ".000VND </b></li>");
                    else strNd.Append("</b></li><li><b style='Color:Red'> Giá : LIÊN HỆ </b></li>");
                    strNd.Append("</div>");
                    strNd.Append("</div>");
                    //========================================
                    //if (Sp.PriceNote>0)
                    //    strNd.Append("<br /><del>Giá:" + Sp.PriceNote.ToString() + ".000 Đồng</del>");
                    strNd.Append("<div class='Ma'>" + Sp.IDNameProduct + "</div>");
                    strNd.Append("<div class='Gia'>");
                    if (Sp.Price > 0)
                        strNd.Append(Sp.Price.ToString() + ".000 VNĐ");
                    else
                        strNd.Append("Giá: Liên hệ ");
                    strNd.Append("</div> ");
                    strNd.Append("<div style='width:100%; position:relative;height:12px;float:left'> </div>");
                    strNd.Append("</div> ");
                    i++;
                    if (i == 5) break;
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
        }
    }
}