using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class UsandoDelegate {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double minhaSoma(double x, double y) {
            return x + y;
        }
         
        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a+b);
        }
        public static void Executar() {
            Soma op1 = minhaSoma;
            Console.WriteLine(op1(2,3.9));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.4, 8);

            Func<double, double, double> op3 = minhaSoma;
            Console.WriteLine(op3(2.5, 3));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7, 3.5);
        }
    }
}
