using AvaliacaoWebForms.Controller.ProdutosController;
using AvaliacaoWebForms.Model;
using System;
 

namespace AvaliacaoWebForms.View.CadastrarProdutos
{
    public partial class CadastrarProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNomeP.Text.Equals("") && !txtDescricaoP.Equals("") )
            {
                ProdutoController ctrlp = new ProdutoController();
                Produto p = new Produto();
                //adicionando produto
                p.Nome = txtNomeP.Text;
                p.Descricao = txtDescricaoP.Text;
                p.MaquinaId = int.Parse(dwlMaquinas.SelectedItem.Value);          
                ctrlp.AdicionarProduto(p);
            }
            LimparDados();
        }

        private void LimparDados()
        {
            txtNomeP.Text = string.Empty;
            txtDescricaoP.Text = string.Empty;
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeP.Text = string.Empty;
            txtDescricaoP.Text = string.Empty;
        }

        protected void lnkListaProdutos_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarProdutos.aspx");
        }

        protected void lnkEditarProdutos_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarProdutos.aspx");
        }
    }
}