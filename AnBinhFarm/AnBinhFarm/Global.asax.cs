using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace AnBinhFarm
{
    public class Global : HttpApplication
    {
       

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Code that runs on application startup
            Application["Online"] = 12;
            Application["Counter"] = myCode.getCounter();
            Application["FCKeditor:UserFilesPath"] = "~/Uploads/Editor";

             // Add Routes.
          RegisterCustomRoutes(RouteTable.Routes);
        }

        void RegisterCustomRoutes(RouteCollection routes)
        {
          routes.MapPageRoute(
              "ArticleByNameRoute",
              "Baiviet/{articleName}-{articleID}",
              "~/Chitietbv.aspx"
          );
          routes.MapPageRoute(
              "ProductByNameRoute",
              "Sanpham/{productName}-{productID}",
              "~/ChiTietSp.aspx"
          );                    
            
          routes.MapPageRoute(
              "ArticlePathRoute",
              "Anbinh/{path}",
              "~/Chitietbv.aspx"
          );

//           
        }
      

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown
            try
            {
                myCode.updateCounter(Convert.ToInt32(Application["Counter"]));
            }
            catch
            {
            }

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
            Session["user"] = null;
            Session["dnh"] = false;
            Session["loai"] = -1;
            Session["Gio_Hang"] = new ArrayList();
            Session["So_tien"] = 0;

            Application.Lock();
            try
            {
                Application["Counter"] = Convert.ToInt32(Application["Counter"]) + 1;
                Application["Online"] = Convert.ToInt32(Application["Online"]) + 1;
            }
            catch { }
            Application.UnLock();

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

            Application.Lock();
            try
            {
                Application["Online"] = Convert.ToInt32(Application["Online"]) - 1;
            }
            catch { }
            Application.UnLock();

        }

    }
}