using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecaoStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach (var item in pilha) {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}\n");

            foreach (var item in pilha) {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}\n");
            Console.WriteLine(pilha.Count);
        }
    }
}
// O PRIMEIRO A ENTRAR EH O ULTIMO A SAIR
// O PRIMEIRO A ENTRAR EH O ULTIMO A SAIR