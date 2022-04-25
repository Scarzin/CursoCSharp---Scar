using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Daniel";
            Console.WriteLine(nome);

            // var idade; variaves de tipo implicito devem ser inicializadas(ter valor)
            var idade = 30;
            Console.WriteLine(idade);

            int a; //declarando
            a = 3; //inicializando

            int b = 2; //declarando e inicializando

            Console.WriteLine($"a = {a} e b = {b}");
        }
    }
}
