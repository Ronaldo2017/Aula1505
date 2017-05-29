using Aula2405_EF_MF_MODELFIRST.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2405_EF_MF_MODELFIRST
{
    public class ProdutosController
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();

        public void AdicionarProduto(Produto produto)
        {
            if (produto != null)
            {
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
            }
        }

        public List<Produto> ListarProduto()
        {
            return contexto.Produtos.Where(p => p.Ativo == true).ToList();
        }

        public List<Produto> ListarInativos()
        {
            return contexto.Produtos.Where(p => p.Ativo == false).ToList();
        
        }

        public Produto BuscarProdutoPorId(int id)
        {
            return contexto.Produtos.Find(id);
        }

        public void Excluir(Produto produto)
        {
            produto.Ativo = false;
            contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void EditarProduto(Produto produto)
        {
            contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

    }
}