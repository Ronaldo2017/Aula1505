using CadastroMP.Controller.ProdutoController;
using CadastroMP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroMP.View.CadastrarProdutos
{
    public partial class CadastrarProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNomeP.Text.Equals("") && !txtDescricaoP.Equals(""))
            {
                Produto p = new Produto();
                //adicionando produto
                p.Nome = txtNomeP.Text;
                p.Descricao = txtDescricaoP.Text;
                p.MaquinaId = dwlMaquinas.SelectedIndex;
                ProdutoController ctrlp = new ProdutoController();
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
            Response.Redirect("ListaProduto.aspx");
        }
    }
}