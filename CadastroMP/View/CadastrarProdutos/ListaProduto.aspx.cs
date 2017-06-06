using CadastroMP.Controller.ProdutoController;
using CadastroMP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroMP.View.ListasMP
{
    public partial class ListarMP : System.Web.UI.Page
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