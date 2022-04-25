using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados {
        public static void Executar()
        {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salario? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {idade} {salario}");
        }
    }
}
