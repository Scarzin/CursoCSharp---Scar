using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ExemploArrayLists {
        public static void Executar() {
            var arrlist = new ArrayList {
                "palavra",
                3,
                true
            };

            arrlist.Add(3.14);

            foreach (var item in arrlist) {
                Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}
