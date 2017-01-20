using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_BLL;
using HP_DAL;

namespace AnBinhFarm.Admin.usc
{
    public partial class Groupnew : System.Web.UI.UserControl
    {
        static int manh=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lienketCCB();
                lienketdl();
            }
            

        }

        void lienketdl()
        {
            manh = 0;
            try
            {

                manh = int.Parse(Request.QueryString["loai"]);
            }
            catch { manh =0; }
            if (manh != 0)
            {
                GroupIterm sp = GroupItermBLL.getGroupItermByID(manh);
                txtTennhom.Text = sp.NameGroup;
                int rot =int.Parse( sp.Root.ToString());
                if (rot >= 0)
                    cbo.SelectedValue = sp.Root.ToString();
                else cbo.SelectedValue = "0";
                chbHot.Checked = sp.IsHot;
                lblMAnhom.Text = sp.IDGroup.ToString();
                txtmotaNhom.Value = sp.Description;
                txtKeywword.Text = sp.Keyword;
                txtmeta.Text = sp.Tittle;
            }

        }
         void lienketCCB()
        {        
        
            List<nhom> dsloai = new List<nhom>();
            List<GroupIterm> ds = GroupItermBLL.getListGroupItermMain();
             dsloai.Add(new nhom(0,"gốc"));
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
            cbo.DataSource = dsloai;
            cbo.DataTextField = "Ten";
            cbo.DataValueField = "Ma";
            cbo.DataBind();
            cbo.SelectedIndex = 0;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string tennhom=txtTennhom.Text;
            string mota=txtmotaNhom.Value;
            int cha=int.Parse(cbo.SelectedValue);
            int level=1;int root=-1;
            bool ishot=chbHot.Checked;
            string meta=txtmeta.Text;
            string keyword=txtKeywword.Text;
            if( cha>0)
            {
                root=cha;
                level=GroupItermBLL.getGroupItermByID(cha).Level+1;                   
            }
            if (manh > 0)
            {
                int i = GroupItermBLL.updateGroupIterm(manh, tennhom, mota, root, level, ishot, meta, keyword);

                if (i == 1)
                {
                    MessageBox.Show("Cập nhật thành công ");
                    Response.Redirect("GroupItermManager.aspx");
                }
                else MessageBox.Show("hãy bổ sung đầy đủ thông tin ");
            }
            else
            {
                int i = GroupItermBLL.insertGroupIterm( tennhom, mota, root, level, ishot, meta, keyword,Session["user"].ToString());
                if (i == 1)
                {
                    MessageBox.Show("Cập nhật thành công ");
                    Response.Redirect("GroupItermManager.aspx");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("GroupItermManager.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
          int i=  GroupItermBLL.deleteGroupIterm(manh, Session["user"].ToString());
          if (i == 1)
          {
              MessageBox.Show("Xóa thành công!");
              Response.Redirect("GroupItermManager.aspx");
          }
          else
              MessageBox.Show("Xóa không thành công!");

        }
    }
}