using Cadastro.Controllers.MaquinasController;
using CadastroMF.Modells;
using System;


namespace CadastroMF.Views.MaquinasEProdutos
{
    public partial class ListaMaquinasEProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Maquina maquina = new Maquina();

            maquina.Código = txtCodigoM.Text;
            maquina.Descrição = txtDescricaoM.Text;

            MaquinasController ctrlm = new MaquinasController();

            ctrlm.AdicionarMaquina(maquina);

        }

        

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoM.Text = string.Empty;
            txtDescricaoM.Text = string.Empty;
        }
    }
}