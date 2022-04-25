using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine($"a nota foi: {nota}.");
            Console.WriteLine($"Nota invalida ? {nota > 10}");
            Console.WriteLine($"Nota invalida ? {nota < 10}");
            Console.WriteLine($"Perfeito ? {nota == 10}");
            Console.WriteLine($"Da pra melhorar ? {nota != 10}");
            Console.WriteLine($"Passou por media ? {nota >= notaDeCorte}");
            Console.WriteLine($"Reprovado ? {nota < notaDeCorte}");
        }
    }
}
