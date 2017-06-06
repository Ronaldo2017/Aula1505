using AvaliacaoWebForms.Model; 
using System.Collections.Generic;
using System.Linq;
 

namespace AvaliacaoWebForms.Controller.CadastrarMaquinas
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

        public Maquina BuscarMaquinaPorNome(Maquina maquina)
        {
            return contexto.Maquinas.FirstOrDefault(m => m.Nome.Equals(maquina.Nome));
        }

        public Maquina BuscarMaquinaPorId(int id)
        {
            return contexto.Maquinas.Find(id);
        }

        public List<Maquina> ListarMaquina()
        {
            return contexto.Maquinas.ToList();
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
    }
}