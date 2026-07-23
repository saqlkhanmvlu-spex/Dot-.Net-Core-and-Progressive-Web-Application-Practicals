using System;
using System.Web;

namespace Practical_5C
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["count"] = 1;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(ViewState["count"]);

            Label1.Text = "View State Count = " + count;

            count++;

            ViewState["count"] = count;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("name");
            c.Value = TextBox1.Text;

            Response.Cookies.Add(c);

            Response.Redirect("WebForm2.aspx");
        }
    }
}
