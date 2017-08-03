using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemplosValidation.Models;

namespace ExemplosValidation.Controllers
{
    public class PessoaController : Controller
    {

        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            //if (string.IsNullOrEmpty(pessoa.Nome))
            //{
            //    ModelState.AddModelError("Nome","O campo nome é obrigatório!");
            //}
            //if (pessoa.Senha != pessoa.ConfirmarSenha)
            //{
            //    ModelState.AddModelError("","As senhas não são iguais");
            //}
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }
            return View(pessoa);
        }
        
        public ActionResult Resultado(Pessoa pessoa)
        {

            return View(pessoa);
        }
    }
}