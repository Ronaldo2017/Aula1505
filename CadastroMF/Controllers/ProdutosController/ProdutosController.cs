using CadastroMF.Modells;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Controllers.ProdutosController
{
    public class ProdutosController
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

        public Produto BuscarProdutoPorCodigo(int codigo)
        {
            return contexto.Produtos.Find(codigo);
        }

        public void ExcluirProduto(Produto produto)
        {
            contexto.Entry(produto).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public void EditarProduto(Produto produto)
        {
            contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
        }

       public List<Produto> ListarProduto()
        {
            return contexto.Produtos.ToList();
        }

        public List<Maquina> ListarMaquina()
        {
            return contexto.Maquinas.ToList();
        }
         
    }
}