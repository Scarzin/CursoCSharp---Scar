using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElse {
        public static void Executar() {
            double nota;
            Console.Write("Adicione sua nota: ");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
            } else {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
