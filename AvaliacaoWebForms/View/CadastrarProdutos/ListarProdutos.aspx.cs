using AvaliacaoWebForms.Controller.ProdutosController;
using AvaliacaoWebForms.Model;
using System;
using System.Collections.Generic;


namespace AvaliacaoWebForms.View.CadastrarProdutos
{
    public partial class ListarProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProdutoController ctrlp = new ProdutoController();
            List<Produto> p = ctrlp.ListarProduto();

            gvwListaProdutos.DataSource = p;
            gvwListaProdutos.DataBind();
        }

        protected void linkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarProdutos.aspx");
        }
    }
}