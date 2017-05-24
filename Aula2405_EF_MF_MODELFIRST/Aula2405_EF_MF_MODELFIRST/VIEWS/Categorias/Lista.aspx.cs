using Aula2405_EF_MF_MODELFIRST.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula2405_EF_MF_MODELFIRST.VIEWS.Categorias
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Categoria> Categorias = contexto.Categorias.ToList();
        }
    }
}