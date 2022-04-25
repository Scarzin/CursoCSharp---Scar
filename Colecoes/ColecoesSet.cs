﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("GOT", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("camisa", 29.9),
                new Produto("8 temporada got", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
        
}

