using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class UsandoBreak {
        public static void Exec() {
            Random r = new Random();
            int numero = r.Next(1,51);
            Console.WriteLine($"O numero que queremos eh {numero}");

            for (int i = 1; i <= 50; i++) {
                Console.Write($"{i} eh o numero que queremos? ");
                if (i == numero) {
                    Console.WriteLine("Sim");
                    break;
                } else {
                    Console.WriteLine("Nao");
                }
            }
        }
    }
}
