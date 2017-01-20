using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnBinhFarm
{
    public partial class _Default : Page
    {
        public string title;
        protected void Page_Load(object sender, EventArgs e)
        {
            title = ConfigurationManager.AppSettings["title"].ToString();
        }
    }
}