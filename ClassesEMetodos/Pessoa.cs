using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;
        public string Apresentar() {
            return $"olá, me chamo {Nome} e tenho {Idade} anos!";
        }

        public void Mostrar() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
