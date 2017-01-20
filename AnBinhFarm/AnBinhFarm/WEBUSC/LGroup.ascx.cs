using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using HP_DAL;

namespace AnBinhFarm.WEBUSC
{
    public partial class LGroup : System.Web.UI.UserControl
    {
        public static int Mnh;
        protected void Page_Load(object sender, EventArgs e)
        {
            loadDL();
        }
        void loadDL()
        {
            try{
                Mnh = (string.IsNullOrEmpty(Request.QueryString["loai"])) ? int.MinValue : int.Parse(Request.QueryString["loai"].ToString());
            }
            catch{Mnh=1;}
          
            List<GroupIterm> dsnhomcon = GroupItermBLL.getListGroupItermChilDren(Mnh);
            dsnhomCON.DataSource = dsnhomcon;
            dsnhomCON.DataBind();
            List<Manufacturer> dshangsx = ManufacturerBLL.getListManufacturerBYGroup(Mnh);
            foreach(Manufacturer hang in dshangsx)
            {
                ListItem ds=new ListItem();
                ds.Text = hang.ManufacturerName;
                ds.Value = hang.ManufacturerId.ToString();
                cbbHang.Items.Add(ds);
            }
            
        }

        protected void btnTimkiem_Click(object sender, EventArgs e)
        {
            int tu=int.Parse(cbbTuGia.SelectedValue);
            int den=int.Parse(cbbDenGia.SelectedValue);
            int hang=int.Parse(cbbHang.SelectedValue);

            Response.Redirect("/sp-list-search/" + Mnh + "/" + tu + "/" + den + "/" + hang+"/timkiem.aspx");
        }
    }
}