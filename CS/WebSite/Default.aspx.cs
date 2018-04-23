using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string[] names = File.ReadAllLines(Server.MapPath("~/App_Data/customers.txt"), Encoding.Unicode);
        ASPxTitleIndex1.DataSource = names;
        ASPxTitleIndex1.DataBind();
    }
}
