using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaSoma
{
    public partial class PaginaPrinciapal : System.Web.UI.Page
    {
        int num1, num2;

        public int Res
        {
            get
            {
                return Convert.ToInt32(ViewState["resultado"]);
            }
            set
            {
                ViewState["resultado"] = value;
            }

        }



        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //    Res = 0;

        }



        protected void txtNum1_TextChanged(object sender, EventArgs e)
        {
            txtNum1.Text = num1.ToString();
        }

        protected void txtNum2_TextChanged(object sender, EventArgs e)
        {
            txtNum2.Text = num2.ToString();
        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
          txtNum1.Text = num1.ToString();
          txtNum2.Text = num2.ToString();
            Res = int.Parse(txtNum1.Text = txtNum2.Text);

        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
           
            Session.Add("resultadoSession", Res);
            Response.Redirect("~/SegundaPaginaaspx.aspx");

        }
    }
}