using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OrientacaoObjeto;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecao;
using CursoCSharp.API;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // FUNDAMENTOS
                {"CODEWARS", CodeWars.Executar},
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"VariavesEConstantes - Fundamentos", VariavesEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar},
                {"LendoDados - Fundamentos", LendoDados.Executar},
                {"FormatandoNumeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"OperadoresAritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"OperadoresRelacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"OperadoresLogicos - Fundamentos", OperadoresLogicos.Executar},
                {"OperadoresAtribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"OperadoresUnarios - Fundamentos", OperadoresUnarios.Executar},
                {"OperadorTernario - Fundamentos", OperadorTernario.Executar},
                // ESTRUTURAS DE CONTROLE
                {"EstruturaIf - Estruturas de Controle", EstruturaIf.Executar},
                {"EstruturaIfElse - Estruturas de Controle", EstruturaIfElse.Executar},
                {"EstruturaIfElseIf - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"EstruturaSwitch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"EstruturaWhile - Estruturas de Controle", EstruturaWhile.Executar},
                // CLASSES E MÉTODOS
                {"Membros - ClassesEMetodos", Membros.Executar},
                {"Construtores - ClassesEMetodos", Construtores.Executar},
                {"MetodosComRetorno - ClassesEMetodos", MetodosComRetorno.Executar},
                {"MetodosEstaticos - ClassesEMetodos", MetodosEstaticos.Executar},
                {"AtributosEstaticos - ClassesEMetodos", AtributosEstaticos.Executar},
                {"DesafioAtributo - ClassesEMetodos", DesafioAtributo.Executar},
                {"Params - ClassesEMetodos", Params.Executar},
                // colecoes
                {"Arrays - Colecoes", Arrays.Executar},
                {"Listas - Colecoes", Listas.Executar},
                {"Exemplo ArrayList - Colecoes", ExemploArrayLists.Executar},
                {"Colecoes Set - Colecoes", ColecoesSet.Executar},
                {"Colecoes Queue - Colecoes", ColecoesQueue.Executar},
                {"Igualdade - Colecoes", Igualdade.Executar},
                {"STack - Colecoes", ColecaoStack.Executar},
                {"DIctionary - Colecoes", ColecaoDict.Executar},
                // O.O
                {"Sealed - O.O", Sealed.Executar},
                //Metodos e Funcoes
                {"Lambda - Metodos e Funcoes", FuncaoLambda.Executar},
                {"Lambda Delegate - Metodos e Funcoes", DelegateComLambda.Executar},
                {"Usando Delegate - Metodos e Funcoes", UsandoDelegate.Executar},
                {"Delegate Func Anonima - Metodos e Funcoes", DelegateFuncAnom.Executar},
                {"Delegate como Parametro - Metodos e Funcoes", DelegateParam.Executar},
                {"Metodo de extensao - Metodos e Funcoes", MetodoDeExtensao.Executar},
                //Exception
                {"Primeira Excecao - Excecoes", PrimeiraExcecao.Executar},
                {"Excecoes PErsonalizadas - Excecoes", ExcecoesPersonalizadas.Executar},
                //API
                {"Primeiro arquivo - usando API", PrimeiroArquivo.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}