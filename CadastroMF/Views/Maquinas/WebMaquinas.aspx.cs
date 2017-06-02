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

        protected void btnProcurar_Click(object sender, EventArgs e)
        {
            Maquina maquina = new Maquina();
            maquina.Código = txtCodigoM.Text;
           

            if(maquina != null)
            {
                 txtDescricaoM.Text = maquina.Descrição;
            }
            
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Maquina maquina = new Maquina();
            maquina.Código = txtCodigoM.Text;
            if(maquina != null)
            {              
                txtDescricaoM.Text = maquina.Descrição;                
            }
        }

        protected void btnEcluir_Click(object sender, EventArgs e)
        {
            Maquina maquina = new Maquina();
            maquina.Código = txtCodigoM.Text;
            if (maquina != null)
            {               
                txtDescricaoM.Text = maquina.Descrição;
            }
        }
    }
}