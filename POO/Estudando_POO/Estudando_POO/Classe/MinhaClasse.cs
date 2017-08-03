using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudando_POO.Classe
{
    public class MinhaClasse
    {
        public MinhaClasse()
        {
            // Criando o objeto telefone
            Telefone meuTelefone = new Telefone("Preto","Android");

            // Mandando o meu objeto telefone executar o metodo ligar
            meuTelefone.Ligar("(16)","99321-6653");
        }
    }

   public class Telefone
    {
        private string cor;
        private string SO;

        // Criando construtor
        public Telefone(string _cor, string _SO)
        {
            cor = _cor;
            SO = _SO;
        }

        // Criando o método Ligar
        public void Ligar(string ddd, string numDiscado)
        {
            string texto = BemVindo();
            Console.WriteLine(texto);
            Console.WriteLine($"Telefone {cor} com sitema operacionao {SO}");
            Console.WriteLine($"Discando para {ddd} {numDiscado}...");
        }

        public string BemVindo()
        {
            string texto = $"Telefone cor {cor} sistema operacional {SO}";
            return texto;
        }

        public static void Discar(String numDiscar)
        {
            Console.WriteLine($"Discando para {numDiscar}...");
        }

        //Destrutor
         ~Telefone()
        {
            Console.WriteLine("Telefone liberado da memoria!!");

            Console.ReadKey();
        }
        
    }
}
