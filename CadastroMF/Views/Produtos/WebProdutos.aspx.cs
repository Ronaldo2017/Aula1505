using Cadastro.Controllers.ProdutosController;
using CadastroMF.Modells;
using System;
using System.Collections.Generic;

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

            produto.Código = txtCodigoP.Text;
            produto.Descrição = txtDescricaoP.Text;
           
            

            ProdutosController ctrlp = new ProdutosController();

            ctrlp.AdicionarProduto(produto);
        }

       
    }
}