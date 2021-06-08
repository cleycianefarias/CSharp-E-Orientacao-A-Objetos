using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {

        // 
        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        int x=0;


        public ListaDeContaCorrente(int capacidadeIncial = 5)
        {
            _itens = new ContaCorrente[capacidadeIncial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texto padrão", int numero = 5 )
        {

        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {            
            Console.WriteLine($"Passa aqui a iteração {x}");
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }


            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            Console.WriteLine("Aumentando a capacidade da lista");

            //criando um novo array como tamanho necessario para aumentar a string
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            //passando os resultados do array antigo para o array novo

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                Console.WriteLine(".");
            }

            _itens = novoArray;
            x++;
          
        }
    }
}
