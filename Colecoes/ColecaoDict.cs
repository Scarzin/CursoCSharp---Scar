using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecaoDict {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "homi aranha");
            filmes.Add(2004, "incriveis");
            filmes.Add(2006, "trucoso");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                filmes.TryGetValue(2004, out string filme2006);
                Console.WriteLine($"Filme {filme2006}");
            }
            foreach (var key in filmes.Keys) {
                Console.WriteLine(key);
            }

            foreach (var filme in filmes.Values) {
                Console.WriteLine(filme);
            }

            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} eh de {filme.Key}");
            }

            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} eh de {filme.Key}");
            
            }
        }
    }
}
