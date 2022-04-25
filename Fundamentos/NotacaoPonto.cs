using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Ola".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");
            //ToUpper() = OLA  -  Insert(index a inserir, valor) 
            // Replace(valor antigo, novo valor)
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); // ? faz navegação segura
        }
    }
}
