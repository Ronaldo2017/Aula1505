using Aula2405_EF_MF_MODELFIRST.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2405_EF_MF_MODELFIRST.VIEWS.Produtos
{
    public partial class ListaProdutosaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProdutosController ctrl = new ProdutosController();
            List<Produto> lista = ctrl.ListarProduto();

            //gvwProduto.DataSource = lista.OrderBy(p => p.Nome);
            //gvwProduto.DataBind();

            //gvwProdutosExcluidas.DataSource = ctrl.ListarInativos();
            //gvwProdutosExcluidas.DataBind();
             


        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;

            ProdutosController ctrl = new ProdutosController();
            ctrl.AdicionarProduto(produto);

        }
    }
}