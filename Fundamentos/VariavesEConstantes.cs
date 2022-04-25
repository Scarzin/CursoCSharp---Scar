using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariavesEConstantes {
        public static void Executar() {
            // area da circunferencia(var) e pi(const)
            double raio = 4.5;
            const double PI = 3.14;

            double area = raio * raio * PI;

            Console.WriteLine(area);
            Console.WriteLine("A area eh de: " + area);

            //tipos internos
            //bool (boolean) => true/false
            bool estaChovendo = true;
            bool chuvaForte = false;

            Console.WriteLine("Hoje esta chovendo? " + estaChovendo);
            Console.WriteLine("A chuva eh forte? " + chuvaForte);

            //tipos numericos inteiros (todos inteiros diferença é armazenamento)
            byte idade = 45;
            Console.WriteLine("idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("menor int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("a populacao do brasil eh de: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("populacao mundial : " + populacaoMundial);

            //tipos numericos reais
            float precoComputador = 1299.99f;
            Console.WriteLine("preco do com,putador: " + precoComputador);

            double valorEmpresaApple = 1_000_000_000_000;
            Console.WriteLine("valor da apple: " + valorEmpresaApple);

            decimal distanciaEstrelas = decimal.MaxValue;
            Console.WriteLine("distancia entre estrelas: " + distanciaEstrelas);

            // tipos textuais

            char letra = 'a';
            Console.WriteLine("Letra : " + letra);

            string texto = "Bem vindo ao curso C#";
            Console.WriteLine(texto);

        }
    }
}
