﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnBinhFarm.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (bool.Parse(Session["dnh"].ToString()) == true)
                lblTen.Text ="Xin chào bạn : "+ Session["user"];
            else
                Response.Redirect("login.aspx");
        }
    }
}