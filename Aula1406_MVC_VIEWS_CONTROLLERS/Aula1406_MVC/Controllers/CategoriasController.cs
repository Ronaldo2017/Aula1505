using Aula1406_MVC.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace Aula1406_MVC.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias, busca a informação, carrega a página
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();
            //retornar a lista de objetos cadastrados
            return View(categorias);
        }

        public ActionResult Create()
        {
            return View();
        }

        //post
        //public ActionResult Create(FormCollection campos = recupera campo a campo sem ter model)
        [HttpPost]// tipo de requisição a ser pedido
        public ActionResult Create(Categoria categoria)//pode ser usado FormCollection campos= recupera campo a campo sem ter model
        {
            if (ModelState.IsValid)// garante que o objeto é válido
            {
                // insert

            }
            return View(categoria);
        }

        //GET
        public ActionResult Edit(int? id)
        {
            //verificar se veio id = BadRequest
            if (id == null)
            {
                //erro = 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //pesquisa na fonte de dados do objeto a editar
            // Categoria categoria = null;
            Categoria categoria = new Categoria()
            {
                CategoriaId = id.Value,
                Nome = "Carros",
                Descricao = "Super carros",
                Ativo = true

            };

            //se objeto nao foi encontrado na fonte de dados
            if (categoria == null)
            {
                //erro = 404
                return HttpNotFound();//não foi encontrado
            }
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    //fazer update no bd
                    //redirecionar

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return View(categoria);
        }

        //get
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = new Categoria()
            {
                CategoriaId = id.Value,
                Nome = "Carros",
                Descricao = "Super carros",
                Ativo = true

            };

            if (categoria == null)
            {
                return HttpNotFound();
            }

            return View(categoria);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //pesquisar objeto por id

            //alterar status do objeto para deleted ou ativo para false
            TempData["Mensagem"] = "Categoria excluída com sucesso!";

            return RedirectToAction("Index");
        }
    }
}