using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemplosValidation.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Nome é um campo obrigatório!")]
        public string Nome { get; set; }
        [StringLength(50,MinimumLength = 5 , ErrorMessage = "Minimo 5 caracters, maxiomo 50" )]
        public string Observacao { get; set; }
        [Range(18,50,ErrorMessage = "A idade deve ser entre 18 e 50 anos")]
        [Required(ErrorMessage = "Informe sua idade")]
        public int Idade { get; set; }
        [RegularExpression(@"[A-Za-z\d_.-]+@[A-Za-z\d]+\.[a-z]{2,4}(\.[a-z]{2})?", ErrorMessage = "Email Invalido !!")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Login deve possuir somente Lentras de 5 a 15 caracters")]
        [Required(ErrorMessage = "O login é obrigatório!")]
        [Remote("LoginUnico","Pessoa",ErrorMessage = "O login ja existe!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Informe sua senha")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha",ErrorMessage = "As senhas não são compativeis")]
        public string ConfirmarSenha { get; set; }
    }
}
