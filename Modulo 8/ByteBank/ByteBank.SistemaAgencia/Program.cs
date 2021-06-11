using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
    
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(5);
            idades.Add(6);
            idades.Add(7);
            idades.Add(8);
            idades.Add(9);

            idades.AdicionarVarios(45, 80, 12);
      

            for (int i = 0; i < idades.Count; i++)
            {
                //int idadeAtual = idades[i];
                Console.WriteLine(idades[i]);
            }


            //Console.WriteLine(SomarVarios(1, 2, 3, 4, 5, 6));
            //Console.WriteLine(SomarVarios(1, 2, 45));
            
            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar("Um texto qualquer");
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }
        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.MeuMetodo(numero: 10);
            lista.MeuMetodo("texto padrão", 10);

            ContaCorrente contaDoGui = new ContaCorrente(111, 1111111111);


            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679754),
                new ContaCorrente(875, 5679755),
                new ContaCorrente(873, 5679756)
                );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

           lista.Remover(contaDoGui);
           Console.WriteLine("Após remover o item");


        }
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
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
