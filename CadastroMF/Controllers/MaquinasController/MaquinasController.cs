
using CadastroMF.Modells;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.Controllers.MaquinasController
{
    public class MaquinasController
    {
        protected CadastroContainer contexto = new CadastroContainer();

        public void AdicionarMaquina(Maquina maquina)
        {
            if (maquina != null)
            {
                contexto.Maquinas.Add(maquina);
                contexto.SaveChanges();
            }
        }
            
        public   Maquina ObterMaquinPorCodigo(int codigo)
        {
            return contexto.Maquinas.Find(codigo);
        }

        public List<Maquina> Listar()
        {
            return contexto.Maquinas.ToList();//retorna a lista completa
        }

        public void ExcluirMaquina(Maquina maquina)
        {
            contexto.Entry(maquina).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public void EditarMaquina(Maquina maquina)
        {
            contexto.Entry(maquina).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void LimparDados()
        {

        }
    }
}