using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv59 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"comprou a tv 59? {comprouTv59}.");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"comprou sorvete? {comprouSorvete}.");

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"comprou tv 32? {comprouTv32}.");

            Console.WriteLine($"mais saudavel? {!comprouSorvete}");
        }
    }
}
