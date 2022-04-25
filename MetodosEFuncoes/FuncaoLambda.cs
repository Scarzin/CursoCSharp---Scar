using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class FuncaoLambda {
        public static void Executar() {
            Action algoNoConsole = () => {
                Console.WriteLine("lambda com c#");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random rand = new Random();
                return rand.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = (numero) => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => $"{dia:D2}/{mes:D2}/{ano:D4}";
            Console.WriteLine(formatarData(11,3,2022));
        }
    }
}
