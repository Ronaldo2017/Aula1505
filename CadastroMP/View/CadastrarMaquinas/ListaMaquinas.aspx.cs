using CadastroMP.Controller.MaquinaController;
using CadastroMP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroMP.View.CadastrarMaquinas
{
    public partial class ListaMaquinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaquinasController ctrlm = new MaquinasController();
            List<Maquina> m = ctrlm.ListarMaquina();

            gvwListaMaquinas.DataSource = m;
            gvwListaMaquinas.DataBind();
        }

        protected void linkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarMaquinas.aspx");
        }
    }
}