using Aula1206_MVC_2.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aula1206_MVC_2.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            ////lista 
            //List<string> categorias = new List<string>();
            //categorias.Add("Carros");
            //categorias.Add("Motos");
            //categorias.Add("Barcos");
            //categorias.Add("Aviões");
            //categorias.Add("Caminhões");

            List<Categoria> categorias = new List<Categoria>();


            categorias.Add(new Categoria()
            {
                Nome = "Carros",
                Descricao = "Super carros de coleção"
            });
            categorias.Add(new Categoria() { Nome = "Motos", Descricao = "Moto mais veloz" });
            categorias.Add(new Categoria() { Nome = "Barcos", Descricao = "Verniz auto proteção" });
            categorias.Add(new Categoria() { Nome = "Aviões", Descricao = "Poltra para primeira classe" });
            categorias.Add(new Categoria() { Nome = "Caminhões", });


            ViewBag.ListaCategorias = categorias;
            return View(categorias);
        }

        //GET = carrega a pagina do formulario
        public ActionResult Create()
        {
            return View();
        }

        //recupera a informação que foi mandada
        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            return View(categoria);
        }
    }
}