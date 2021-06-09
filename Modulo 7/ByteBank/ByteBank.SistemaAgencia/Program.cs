﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.MeuMetodo(numero:10);
            lista.MeuMetodo("texto padrão", 10);

            ContaCorrente contaDoGui = new ContaCorrente(111, 1111111111);
            lista.Adicionar(contaDoGui);

            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679754));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679746));
            lista.Adicionar(new ContaCorrente(874, 5679747));
            lista.Adicionar(new ContaCorrente(874, 56797458));
            lista.Adicionar(new ContaCorrente(874, 56797459));
            lista.Adicionar(new ContaCorrente(874, 567974560));
            lista.Adicionar(new ContaCorrente(874, 567974561));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
            
            lista.Remover(contaDoGui);
           // Console.WriteLine("Após remover o item");
           

            Console.ReadLine();
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
          {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
          };


            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

        }
        static void TestaArrayInt()
        {
            //palavra
            //0123456

            //ARRAY de inteiros com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3]=50;
            //idades[4]=28;
            //idades[5]=60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades [{indice}] = {idade}");
                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média das idades = {media}");

            Console.ReadLine();
        }

    }


}
