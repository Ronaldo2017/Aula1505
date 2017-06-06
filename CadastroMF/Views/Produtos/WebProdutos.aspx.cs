using Cadastro.Controllers.ProdutosController;
using CadastroMF.Modells;
using System;
 
namespace CadastroMF.Views.Produtos
{
    public partial class WebProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Codigo = txtCodigo.Text;
            produto.Descrição = txtDescricaoP.Text;
            produto.MaquinaId = dwlMaquinas.SelectedIndex;
            ProdutosController ctrlp = new ProdutosController();
            ctrlp.AdicionarProduto(produto);
            LimparDados();
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtDescricaoP.Text = string.Empty;
        }

        private void LimparDados()
        {
            txtCodigo.Text = string.Empty;
            txtDescricaoP.Text = string.Empty;
        }

        protected void lnkListaProduto_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaProdutos.aspx");
        }

        protected void lnkEditarProduto_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarProdutos.aspx");
        }
    }
}