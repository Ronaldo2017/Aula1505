

using AvaliacaoWebForms.Model;
using System.Collections.Generic;
using System.Linq;

namespace AvaliacaoWebForms.Controller.ProdutosController
{
    public class ProdutoController
    {
        protected CadastroContainer contexto = new CadastroContainer();

        public void AdicionarProduto(Produto produto)
        {
            if (produto != null)
            {
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
            }
        }

        public Produto BuscarProdutoPorNome(Produto produto)
        {
            return contexto.Produtos.FirstOrDefault(p => p.Nome.Equals(produto.Nome));
        }

        public Produto BuscarProdutoPorId(int id)
        {
            return contexto.Produtos.Find(id);
        }

        public List<Produto> ListarProduto()
        {
            return contexto.Produtos.ToList();
        }

        public void ExcluirProduto(Produto produto)
        {
            contexto.Entry(produto).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public void EditarProduto(Produto produto)
        {
            contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}