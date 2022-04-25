using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            Console.WriteLine("digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9) {
                Console.WriteLine("Quadro de Honra!");
            } else if (nota > 7) {
                Console.WriteLine("Aluno aprovado!");
            } else if (nota >= 5) {
                Console.WriteLine("Recuperação!");
            } else {
                Console.WriteLine("tomastes bomba!");
            }

            Console.WriteLine("Fim!");
        }
    }
}
