using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            // preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preco final eh: {totalComDesconto}");

            // IMC
            var peso = 91.2;
            double altura = 1.82;
            double imc = peso / (altura * altura);
            Console.WriteLine($"O imc eh: {imc}.");

            int par = 24;
            int impar = 55;
            Console.WriteLine($"{par}/2 tem resto {par % 2}");
            Console.WriteLine($"{impar}/2 tem resto {impar % 2}");
        }
    }
}
