using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaSoma
{
    public partial class SegundaPaginaaspx : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            int Soma1ViewState = Convert.ToInt32(ViewState["soma1"]);

            int Soma1Session = Convert.ToInt32(ViewState["soma1Session"]);

            int Soma2ViewState = Convert.ToInt32(ViewState["soma2"]);

            int Soma2Session = Convert.ToInt32(ViewState["soma2Session"]);

            txtSoma1.Text = Soma1Session.ToString();

            txtSoma2.Text = Soma2Session.ToString();
            
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PaginaPrinciapal.aspx");
        }

       
    }
}