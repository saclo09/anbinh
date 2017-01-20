using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_DAL;
using HP_BLL;

namespace AnBinhFarm.Admin.usc
{
    public partial class ManagerProduct : System.Web.UI.UserControl
    {
        public static int mnhom = -3;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_dl();
                Load_GRV(0);
            }
        }
         
       
        void load_dl()
        {
            List<nhom> dsloai = new List<nhom>();
            dsloai.Add(new nhom(0, "(--Tất cả--)"));
            List<GroupIterm> ds = GroupItermBLL.getListGroupItermMain();
            foreach (GroupIterm b in ds)
            {
                nhom temp = new nhom(b.IDGroup, b.NameGroup);
                dsloai.Add(temp);
               List<GroupIterm> dsCon =GroupItermBLL.getListGroupItermChilDren(b.IDGroup);
               foreach (GroupIterm con in dsCon)
               {
                   nhom temp2 = new nhom(con.IDGroup, "->"+con.NameGroup);
                   dsloai.Add(temp2);

               }
            }
            cboNhomSp.DataSource = dsloai;
            cboNhomSp.DataTextField = "Ten";
            cboNhomSp.DataValueField = "Ma";
            cboNhomSp.DataBind();
        }
     
        void Load_GRV(int snhom)
        {
            if (snhom <= 0)
            {
                List<Product> dssp = ProductBLL.getListProduct();
                grvSp.DataSource = dssp;
                grvSp.DataKeyNames = new string[] { "IdProduct" };
                grvSp.DataBind();

            }
            else
            {
                List<Product> dssp = ProductBLL.getListProductByGroupAndRoot(snhom);
                grvSp.DataSource = dssp;
                grvSp.DataKeyNames = new string[] { "IdProduct" };
                grvSp.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnhom = int.Parse(cboNhomSp.SelectedValue);
            Load_GRV(mnhom);
        }
     class nhom
    {
        int ma;
        public int Ma
        {
            get
            {
                return ma;
            }
            set
            {
                if (ma == value)
                    return;
                ma = value;
            }
        }
        string ten;
        public string Ten
        {
            get
            {
                return ten;
            }
            set
            {
                if (ten == value)
                    return;
                ten = value;
            }
        }
        public nhom() { }
        public nhom(int pma, string pten)
        {
            this.Ten = pten;
            this.Ma = pma;
        }
    }

     protected void grvSp_RowCommand(object sender, GridViewCommandEventArgs e)
     {
         if (e.CommandName.ToUpper() == "SUA")
         {

             int magh = int.Parse(grvSp.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
             Response.Redirect("Sanpham.aspx?sp=" + magh);
             
         }
     }

        protected void Button1_Click(object sender, EventArgs e)
     {
         Response.Redirect("Sanpham.aspx");
     }

        protected void grvSp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvSp.PageIndex = e.NewPageIndex;
            Load_GRV(mnhom);
        }

    

     

     
    }
}