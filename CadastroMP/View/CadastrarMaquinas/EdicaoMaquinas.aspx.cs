using CadastroMP.Controller.MaquinaController;
using CadastroMP.Model;
using System;


namespace CadastroMP.View.CadastrarMaquinas
{
    public partial class EdicaoMaquinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void linkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarMaquinas.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int idMaquina = int.Parse(txtId.Text);
            MaquinasController ctrlm = new MaquinasController();
            Maquina m = ctrlm.BuscarMaquinaPorId(idMaquina);

            if (m != null)
            {
                txtNome.Text = m.Nome;
                txtDescricao.Text = m.Descricao;
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Maquina maq = new Maquina();
            MaquinasController ctrlm = new MaquinasController();
            maq.Nome = txtNome.Text;
            maq = ctrlm.BuscarMaquinaPorNome(maq);

            if (maq != null)
            {
                maq.Nome = txtNome.Text;
                maq.Descricao = txtDescricao.Text;
                ctrlm.EditarMaquina(maq);
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Maquina maq = new Maquina();
            MaquinasController ctrlm = new MaquinasController();
            maq.Nome = txtNome.Text;
            maq = ctrlm.BuscarMaquinaPorNome(maq);

            if (maq != null)
            {
                txtNome.Text = maq.Nome;
                txtDescricao.Text = maq.Descricao;
                ctrlm.ExcluirMaquina(maq);
            }
        }
    }
}