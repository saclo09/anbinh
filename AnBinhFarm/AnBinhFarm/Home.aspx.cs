﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
namespace AnBinhFarm
{
    public partial class Home2 : System.Web.UI.Page
    {
        public string title;
        protected void Page_Load(object sender, EventArgs e)
        {
            title = ConfigurationManager.AppSettings["title"].ToString();
        }
    }
}