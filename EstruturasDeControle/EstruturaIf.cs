using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento ? (S/N): ");
            entrada = Console.ReadLine().ToLower();

            if (entrada == "s")
                bomComportamento = true;

            if(nota >= 9 && bomComportamento) {
                Console.WriteLine("Quadro de Honra!");
            }
        }
    }
}
 