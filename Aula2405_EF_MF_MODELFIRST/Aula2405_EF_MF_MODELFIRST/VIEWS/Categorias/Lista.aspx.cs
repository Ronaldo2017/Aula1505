﻿using Aula2405_EF_MF_MODELFIRST.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula2405_EF_MF_MODELFIRST.VIEWS.Categorias
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriasController ctrl = new CategoriasController();
            List<Categoria> lista = ctrl.Listar();

            gvwCategoria.DataSource = lista.OrderBy(c => c.Nome);
            gvwCategoria.DataBind();

            gvCategoriasExcluidas.DataSource = ctrl.listarInativos();
            gvCategoriasExcluidas.DataBind();


        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();

            cat.Nome = txtNome.Text;
            cat.Descricao = txtDescricao.Text;

            CategoriasController ctrl = new CategoriasController();

            ctrl.Adicionar(cat);

        }
    }
}