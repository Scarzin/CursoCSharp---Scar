using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            var nota = 9.0;
            var bomComportamento = true;
            var resultado = nota >= 7 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
