using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaDoWhile {
        public static void Exec() {
            string entrada;
            do {
                Console.WriteLine("Qual seu nome?");
                entrada = Console.ReadLine();
                Console.WriteLine($"Seja bem vindo {entrada}");
                Console.WriteLine("Deseja Continuar? S/N");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
