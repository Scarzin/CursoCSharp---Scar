using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecao {
    public class NegativoException : Exception {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    public class ImparExcepetion : Exception {
        public ImparExcepetion(string message) : base(message) { }
    }

    internal class ExcecoesPersonalizadas {
        public static int PositivoPar() {
            Random rand = new Random();
            int valor = rand.Next(-30, 30);

            if (valor < 0) {
                throw new NegativoException("valor negativo");
            }

            if (valor % 2 == 1) {
                throw new ImparExcepetion("Numero impar");
                }

            return valor;
        }
        public static void Executar() {
            try {
                Console.WriteLine(PositivoPar());
            } catch (NegativoException ex) {
                Console.WriteLine(ex.Message);
            } catch (ImparExcepetion ex) {
                Console.WriteLine(ex.Message);
            } catch (Exception) {
                Console.WriteLine("Erro Inesperado");
            }
        }
    }
}
