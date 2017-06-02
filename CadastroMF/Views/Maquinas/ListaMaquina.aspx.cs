using Cadastro.Controllers.MaquinasController;
using CadastroMF.Modells;
using System;
using System.Collections.Generic;
 

namespace CadastroMF.Views.Maquinas
{
    public partial class ListaMaquina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaquinasController ctrl = new MaquinasController();
            List<Maquina> maquina = ctrl.Listar();

            gvwListaMaquinas.DataSource = maquina;
            gvwListaMaquinas.DataBind();
        }
    }
}