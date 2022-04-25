using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjeto {
    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_406_033.85;
        }
    }
        //class SouFilho : SemFilho {
        //}

    class Avo {
        public virtual bool HonrarNome () {
            return true;
        }
    }
    class Pai : Avo {
        public sealed override bool HonrarNome() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
        //public override bool HonrarNome() {
        //    return false;
        //}
    }
    internal class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNome());
        }
    }
}
