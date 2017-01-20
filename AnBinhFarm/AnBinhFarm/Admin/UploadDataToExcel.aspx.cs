using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace AnBinhFarm.Admin
{
    public partial class UploadDataToExcel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            string ExcelContentType = "application/vnd.ms-excel";
            string Excel2010Contentype = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            if (!FileUpload1.HasFile)
            {
                lblthongbao.Text = "Vui lòng chọn file";
            }
            else
            {
               // try
             //  {
                    if (FileUpload1.PostedFile.ContentType != ExcelContentType && FileUpload1.PostedFile.ContentType != Excel2010Contentype)
                    {
                        lblthongbao.Text = "Vui lòng chọn file excel";
                    }
                    else
                    {
                        string path = string.Concat(Server.MapPath("~/DataTemp/" + FileUpload1.FileName));
                        FileUpload1.SaveAs(path);
                        string ExcelconnectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0;",path);
                        OleDbConnection connection = new OleDbConnection();
                        connection.ConnectionString = ExcelconnectionString;
                        OleDbCommand Lenh = new OleDbCommand("SELECT * FROM [Sheet1$]",connection);
                        connection.Open();
                        DbDataReader dr = Lenh.ExecuteReader();
                        SqlConnection sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                        sqlconn.Open();
                        SqlBulkCopy bulkInsert = new SqlBulkCopy(sqlconn);
                        bulkInsert.DestinationTableName = ConfigurationManager.AppSettings["UploadTable"].ToString();
                        bulkInsert.WriteToServer(dr);
                        lblthongbao.Text = " ghi thành công !";
                    }
               //}
              //  catch(Exception ex)
             // {
              //      lblthongbao.Text = "Lỗi xãy ra trong quá trình upload!<br/>"+ex.ToString();
             //  }
            }
        }
    }
}