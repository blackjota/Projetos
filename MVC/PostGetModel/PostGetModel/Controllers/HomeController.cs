using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostGetModel.Models;

namespace PostGetModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "João Guilherme",
                Twitter = "@tostesjoao"
            };

            return View(pessoa);
        }

        public ActionResult Lista(Pessoa pessoa)
        {
            
            return View(pessoa);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}