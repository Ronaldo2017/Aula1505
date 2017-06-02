using Cadastro.Controllers.ProdutosController;
using CadastroMF.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroMF.Views.Produtos
{
    public partial class ListaProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProdutosController ctrl = new ProdutosController();
            List<Produto> lista = ctrl.ListarProduto();

            gvwProdutos.DataSource = lista;
            gvwProdutos.DataBind();

        }
    }
}