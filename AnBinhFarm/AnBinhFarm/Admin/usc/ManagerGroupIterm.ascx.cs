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
    public partial class ManagerGroupIterm : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lienketCCB();
                cbo_SelectedIndexChanged(sender, e);
            }
        }
        void lienketCCB()
        {        
        
            List<nhom> dsloai = new List<nhom>();
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
                   List<GroupIterm> dsConC = GroupItermBLL.getListGroupItermChilDren(con.IDGroup);
                   foreach (GroupIterm conC in dsConC)
                   {
                       nhom temptt = new nhom(conC.IDGroup, "--|->" + conC.NameGroup);
                       dsloai.Add(temptt);
                   }
               }
            }
            cbo.DataSource = dsloai;
            cbo.DataTextField = "Ten";
            cbo.DataValueField = "Ma";
            cbo.DataBind();
            
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

        protected void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int manhom = int.Parse(cbo.SelectedValue);
            GroupIterm tempnh = GroupItermBLL.getGroupItermByID(manhom);
            lblMAnhom.Text = tempnh.IDGroup.ToString();
            txtTennhom.Text = tempnh.NameGroup;
            if (tempnh.Root > 0) lblNhomcha.Text = GroupItermBLL.getGroupItermByID(tempnh.Root).NameGroup;
            else lblNhomcha.Text = "Nút gốc";
            lblnguoitao.Text = tempnh.CreateBy;
            chbHot.Checked = tempnh.IsHot;
            lblNgaytao.Text = tempnh.CreateDate.ToString("dd/MM/yyyy");
            txtmota.Text = tempnh.Description;
            txtkeywword.Text = tempnh.Keyword;
            txtmetatitile.Text = tempnh.Tittle;
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            int manhom = int.Parse(cbo.SelectedValue);
            Response.Redirect("GroupitermNew.aspx?loai="+manhom);
        }

        protected void btnthemmoi_Click(object sender, EventArgs e)
        {
            Response.Redirect("GroupitermNew.aspx");
        }
    }
}