using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RotasMVC.Models;

namespace RotasMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> TodasAsNoticias;

        public HomeController()
        {
            TodasAsNoticias = new Noticia().TodasNoticias().OrderByDescending(x=> x.Data);
        }
        public ActionResult Index()
        {
            var ultimasnoticias = TodasAsNoticias.Take(3);
            var todasAsCategorias = TodasAsNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = todasAsCategorias;
            return View(ultimasnoticias);
        }

        
    }
}