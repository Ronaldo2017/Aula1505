﻿using Aula22005_EF_DF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula22005_EF_DF.Views.Produto
{
    public partial class ListaProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StrConnLojaEntities contexto = new StrConnLojaEntities();

            gvwProduto.DataSource = contexto.Produto.ToList();
            gvwProduto.DataBind();
        }
    }
}