using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp {
    internal class CodeWars {
        public static string GetMiddle(string s) {
            return string.IsNullOrEmpty(s)
                ? s
                : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
        }
    


        public static void Executar() {
        }
    }
}

