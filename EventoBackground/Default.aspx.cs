using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventoBackground
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExecuta_OnClick(object sender, EventArgs e)
        {
            MyThread.GravaArquivo();
            Response.Redirect("Redirect.aspx");
        }
    }
}