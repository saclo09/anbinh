using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HP_DAL;
using HP_BLL;

namespace AnBinhFarm.WEBUSC
{
    public partial class Timkiem : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load_dl();

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

        protected void btnTimkiem_Click(object sender, EventArgs e)
        {
            int loai= int.Parse(cboNhomSp.SelectedValue);
            string tukhoa = txtTukhoa.Text;

            Response.Redirect("/Search.aspx?loai="+loai+"&tk="+tukhoa);
        }
        
    }
    public class nhom
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
}