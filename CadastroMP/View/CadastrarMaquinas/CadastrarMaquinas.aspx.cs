using CadastroMP.Controller.MaquinaController;
using CadastroMP.Controller.ProdutoController;
using CadastroMP.Model;
using System;


namespace CadastroMP.View
{
    public partial class Cadastrar : System.Web.UI.Page
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
            Response.Redirect("ListaMaquinas.aspx");
        }

        protected void lnkEditarMaquinas_Click(object sender, EventArgs e)
        {
            Response.Redirect("EdicaoMaquinas.aspx");
        }

        //protected void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    MaquinasController ctrlm = new MaquinasController();
        //    Maquina maq = new Maquina();
        //    maq.Nome = txtNome.Text;           
        //    ctrlm.BuscarMaquinaPorNome(maq);

        //    if (maq != null)
        //    {
        //        txtDescricao.Text = maq.Descricao;
        //    }
        //}

        //protected void btnAlterar_Click(object sender, EventArgs e)
        //{
           
        //}

        //protected void btnExcluir_Click(object sender, EventArgs e)
        //{
           

        //}
    }
}