﻿using AvaliacaoWebForms.Controller.CadastrarMaquinas;
using AvaliacaoWebForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoWebForms.View.CadastrarMaquinas
{
    public partial class EditarMaquinas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
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
           
            MaquinasController ctrlm = new MaquinasController();
            Maquina maq = ctrlm.BuscarMaquinaPorId(int.Parse(txtId.Text));
            maq.Nome = txtNome.Text;            

            if (maq != null)
            {
                maq.Nome = txtNome.Text;
                maq.Descricao = txtDescricao.Text;
                ctrlm.EditarMaquina(maq);
            }

            LimparDados();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            MaquinasController ctrlm = new MaquinasController();
            Maquina maq = ctrlm.BuscarMaquinaPorId(int.Parse(txtId.Text));
           

            if (maq != null)
            {
                txtId.Text =  maq.Id.ToString();
                txtNome.Text = maq.Nome;
                txtDescricao.Text = maq.Descricao;
                ctrlm.ExcluirMaquina(maq);                
            }
            
            LimparDados();
        }

        protected void linkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarMaquinas.aspx");
        }

        private void LimparDados()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
           
        }

    }
}