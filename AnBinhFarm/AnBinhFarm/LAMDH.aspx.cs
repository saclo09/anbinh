using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HPSHOP
{
    public partial class LAMDH : System.Web.UI.Page
    {
        protected string remaingTime = String.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            var expiredDate = new DateTime(2013, 03, 16, 16, 0, 0);
            var timeLeft = expiredDate.Subtract(TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SE Asia Standard Time"));
            remaingTime = timeLeft.TotalMilliseconds.ToString();
        }

        
    }
}