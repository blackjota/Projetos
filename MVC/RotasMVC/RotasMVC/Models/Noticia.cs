using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace RotasMVC.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia()
                {
                    NoticiaId = 1,
                    Categoria = "Esporte",
                    Titulo = "Felipe Massa ganha F1",
                    Conteudo = "Ganhou a porra toda",
                    Data = new DateTime(2012,7,5)
                } ,
                new Noticia()
                {
                    NoticiaId = 2,
                    Categoria = "Economia",
                    Titulo = "Dollar a R$5,00",
                    Conteudo = "Dollar aumenta devido a inflação, e chega a 5 reais",
                    Data = new DateTime(2012,7,5)
                },
                new Noticia()
                {
                    NoticiaId = 3,
                    Categoria = "Politica",
                    Titulo = "Geral foi preso",
                    Conteudo = "PF Chegou e prendeu geral, lula chora",
                    Data = new DateTime(2012,7,3)
                },
                new Noticia()
                {
                    NoticiaId = 4,
                    Categoria = "Jogos",
                    Titulo = "Immortals perde pra Gambit na final do major",
                    Conteudo = "Immortals perde de 2 a 1 pra gambit em krakow",
                    Data = new DateTime(2017,7,23)
                }
            };
            return retorno;
        }
    }
}