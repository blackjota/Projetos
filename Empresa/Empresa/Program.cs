using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Joao",21,"996548266",2000);
            f1.ExibeDados();
            Gerente g1 = new Gerente("Daniilo Gerente: ",30,"852369857",5000,"Demitir");
            g1.ExibeDados();
            Tecnico t1 = new Tecnico("Maria",30,"52147856",1100,202545,150);
            t1.ExibeDados();
            Console.ReadKey();

        }
        
    }
}
