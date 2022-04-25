using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            sicrano.Mostrar();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 25;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.ToUpper());
            Console.WriteLine(apresentacaoDoFulano.Length);
        }
    }
}
