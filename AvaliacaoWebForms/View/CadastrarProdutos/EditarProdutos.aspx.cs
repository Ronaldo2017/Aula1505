using AvaliacaoWebForms.Controller.ProdutosController;
using AvaliacaoWebForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoWebForms.View.CadastrarProdutos
{
    public partial class EditarProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int idProduto = int.Parse(txtId.Text);
            ProdutoController ctrlp = new ProdutoController();
            Produto  p = ctrlp.BuscarProdutoPorId(idProduto);

            if(p != null)
            {
                txtNome.Text = p.Nome;
                txtDescricao.Text = p.Descricao;
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            ProdutoController ctrp = new ProdutoController();
            Produto p = ctrp.BuscarProdutoPorId(int.Parse(txtId.Text));
            p.Nome = txtNome.Text;
          
            if(p != null)
            {
                p.Nome = txtNome.Text;
                p.Descricao = txtDescricao.Text;
                ctrp.EditarProduto(p);
            }
            LimparDados();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {            
            ProdutoController ctrp = new ProdutoController();
            Produto p = ctrp.BuscarProdutoPorId(int.Parse(txtId.Text));
            p.Nome = txtNome.Text;           

            if (p != null)
            {
                p.Nome = txtNome.Text;
                p.Descricao = txtDescricao.Text;
                ctrp.ExcluirProduto(p);
            }
            LimparDados();
        }

        protected void linkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarProdutos.aspx");
        }

        private void LimparDados()
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtId.Text = string.Empty;
        }

    }
}