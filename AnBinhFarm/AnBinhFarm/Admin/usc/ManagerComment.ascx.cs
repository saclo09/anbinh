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
    public partial class ManagerComment : System.Web.UI.UserControl
    {
        public static int macm;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                loadGrv();
        }
        void loadGrv()
        {
            List<Comment> dsBL = CommentBLL.getListComment();
            List<Binhluan> dsBLM = new List<Binhluan>();
            foreach (Comment cm in dsBL)
            {
                Binhluan bltemp = new Binhluan();
                if (cm.IsCheck != true)
                {
                    bltemp.Hoten = "<b>" + cm.Name + "</b>";
                    bltemp.Email = "<b>" + cm.Email + "</b>";
                    bltemp.Ndbl = "<b>" + cm.ContentComment + "</b>";
                    bltemp.Tensp = "<b>" +ProductBLL.getProductById(cm.ProductId).NameProduct + "</b>";
                 
                }
                else
                {
                    bltemp.Hoten =  cm.Name ;
                    bltemp.Email =  cm.Email;
                    bltemp.Ndbl =  cm.ContentComment;
                    bltemp.Tensp = ProductBLL.getProductById(cm.ProductId).NameProduct;
                }
                bltemp.Mabl=cm.CommentId;
                bltemp.Masp = cm.ProductId;
                bltemp.Ngay = cm.Date;
                bltemp.IsDelete = cm.IsDelete;
                bltemp.IsCheck = cm.IsCheck;
                bltemp.Nguoiduyet = cm.CheckBy;
                dsBLM.Add(bltemp);

            }
            grvComment.DataSource = dsBLM;
            grvComment.DataKeyNames =new string[]{"Mabl"};
            grvComment.DataBind();
        }

        void load_dlCon(int mabl)
        {
            txthoten.ReadOnly = txtEmail.ReadOnly = txtnoidung.ReadOnly = true;
            Comment bl = CommentBLL.getCommentById(mabl);
            txthoten.Text = bl.Name;
            txtEmail.Text = bl.Email;
            txtnoidung.Text = bl.ContentComment;
            txtThoigian.Text = bl.Date.ToString("dd/MM/yyyy h:mm tt");
            chbDuyet.Checked = bl.IsCheck;
            btnDuyeetu.Visible = !chbDuyet.Checked;
            hblSp.Text = ProductBLL.getProductById(bl.ProductId).NameProduct;
            hblSp.NavigateUrl = "../../ChiTietSp.aspx?sp=" + bl.ProductId;
        }       

        protected void grvComment_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "CHITIET")
            {

                int mabl = int.Parse(grvComment.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
                macm = mabl;
                load_dlCon(mabl);
            }
        }

        protected void grvComment_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvComment.PageIndex = e.NewPageIndex;
            loadGrv();
        }
        class Binhluan
        {
            int mabl;

            public int Mabl
            {
                get { return mabl; }
                set { mabl = value; }
            }
            int masp;


            public int Masp
            {
                get { return masp; }
                set { masp = value; }
            }
            string tensp;

            public string Tensp
            {
                get { return tensp; }
                set { tensp = value; }
            }
            string ndbl;

            public string Ndbl
            {
                get { return ndbl; }
                set { ndbl = value; }
            }
            string hoten;

            public string Hoten
            {
                get { return hoten; }
                set { hoten = value; }
            }
            string email;

            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            DateTime ngay;

            public DateTime Ngay
            {
                get { return ngay; }
                set { ngay = value; }
            }
            string nguoiduyet;

            public string Nguoiduyet
            {
                get { return nguoiduyet; }
                set { nguoiduyet = value; }
            }
            bool isCheck;

            public bool IsCheck
            {
                get { return isCheck; }
                set { isCheck = value; }
            }
            bool isDelete;

            public bool IsDelete
            {
                get { return isDelete; }
                set { isDelete = value; }
            }
            public Binhluan()
            {
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = !txtEmail.ReadOnly;
            txtnoidung.ReadOnly = !txtnoidung.ReadOnly;
            txthoten.ReadOnly = !txthoten.ReadOnly;
            if (btnSua.Text == "Sửa bình luận") btnSua.Text = "Cập nhật"; 
            else
            {
               Comment a= CommentBLL.getCommentById(macm);
              int i= CommentBLL.updateComment(macm, a.ProductId, txthoten.Text, txtEmail.Text, txtnoidung.Text, Session["user"].ToString());
              if (i == 1)
              {
                  MessageBox.Show("Update thành công!");
                  txtEmail.Text = txthoten.Text = txtnoidung.Text = "";
              }
                btnSua.Text = "Sửa bình luận";
            }


        }

        protected void btnDuyeetu_Click(object sender, EventArgs e)
        {
            int i = CommentBLL.checkComment(macm, Session["user"].ToString());
            if (i == 1) MessageBox.Show("Đã cập nhật!");
            load_dlCon(macm);
        }

    }
}