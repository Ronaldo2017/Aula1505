using AvaliacaoWebForms.Controller.CadastrarMaquinas;
using AvaliacaoWebForms.Model;
using System;
using System.Collections.Generic;
 

namespace AvaliacaoWebForms.View.CadastrarMaquinas
{
    public partial class ListarMaquinas : System.Web.UI.Page
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