﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1206_MVC_2.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            //lista 
            List<string> categorias = new List<string>();
            categorias.Add("Carros");
            categorias.Add("Motos");
            categorias.Add("Barcos");
            categorias.Add("Aviões");
            categorias.Add("Caminhões");

            ViewBag.ListaCategorias = categorias;
            return View();
        }
    }
}