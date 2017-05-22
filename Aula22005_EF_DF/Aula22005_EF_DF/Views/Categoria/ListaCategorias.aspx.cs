using Aula22005_EF_DF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula22005_EF_DF.Views.Categoria
{
    public partial class ListaCategorias :  Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //contexto(referencia pro banco)
            StrConnLojaEntities contexto = new StrConnLojaEntities();

            gvwCategoria.DataSource = contexto.Categoria.ToList();
            gvwCategoria.DataBind();
        }
    }
}