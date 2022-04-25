using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaFor {
        public static void Exec() {
            //        for (int i=1; i<=10; int++) {
            //           Console.WriteLine($" O valor de I eh: {i}.");
            //       }

            double soma = 0;
            string entrada;

            Console.Write("informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.WriteLine($"Informe a nota do aluno {i+1}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                soma += notaAtual;
            }

            double media = tamanhoTurma > 0 ? soma / tamanhoTurma : 0;
            Console.WriteLine($"media da turma eh: {media}");
        }
    }
}
