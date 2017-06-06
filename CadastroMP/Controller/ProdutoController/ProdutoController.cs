using CadastroMP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroMP.Controller.ProdutoController
{
    public class ProdutoController
    {
        protected CadastroMPContainer contexto = new CadastroMPContainer();

        public void AdicionarProduto(Produto produto)
        {
            if (produto != null)
            {
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
            }
        }

        public Produto BuscarProdutoPorNome(string nome)
        {
            return contexto.Produtos.Find(nome);
        }

        public List<Produto> ListarProduto()
        {
            return contexto.Produtos.ToList();
        }

        public void ExcluirMaquina(Produto produto)
        {
            contexto.Entry(produto).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public void EditarMaquina(Produto produto)
        {
            contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}