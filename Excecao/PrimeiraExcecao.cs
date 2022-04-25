﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecao {
    public class Conta {
        double Saldo;


        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= valor;
            }
    }
    internal class PrimeiraExcecao {
        
        public static void Executar() {
            var conta = new Conta(1_223.45);

            try {
                conta.Sacar(1600);
                Console.WriteLine("retirada com sucesso");
            } catch (Exception ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Obrigado");
            }
        }
    }
}
