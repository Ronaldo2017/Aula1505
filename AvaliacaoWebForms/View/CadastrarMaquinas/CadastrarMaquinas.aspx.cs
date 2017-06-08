using AvaliacaoWebForms.Controller.CadastrarMaquinas;
using AvaliacaoWebForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoWebForms.View.CadastrarMaquinas
{
    public partial class CadastrarMaquinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals("") && !txtDescricao.Equals(""))
            {
                Maquina m = new Maquina();
                //adicionando maquina
                m.Nome = txtNome.Text;
                m.Descricao = txtDescricao.Text;
                MaquinasController ctrlm = new MaquinasController();
                ctrlm.AdicionarMaquina(m);

            }

            LimparDados();
        }

        private void LimparDados()
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        protected void lnkListaMaquinas_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarMaquinas.aspx");
        }

        protected void lnkEditarMaquinas_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarMaquinas.aspx");
        }
    }
}