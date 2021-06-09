using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    //lista é uma classe abstrata - argumento de lista genérica
    public class Lista<T>
    {

        private T[] _itens;
        private int _proximaPosicao;
        int x = 0;

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public Lista(int capacidadeIncial = 5)
        {
            _itens = new T[capacidadeIncial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "texto padrão", int numero = 5)
        {

        }

        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params T[] itens)
        {
            foreach (T item in itens)
            {
                Adicionar(item);
            }
        }
        public void Remover(T item)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            //[0*01][0*02][0*03][null]
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            //_itens[_proximaPosicao] = null;
        }

        public T GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }


        private void VerificarCapacidade(int tamanhoNecessario)
        {
            //Console.WriteLine($"Passa aqui a iteração {x}");
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }


            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            //Console.WriteLine("Aumentando a capacidade da lista");

            //criando um novo array como tamanho necessario para aumentar a string
            T[] novoArray = new T[novoTamanho];
            //passando os resultados do array antigo para o array novo

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                //Console.WriteLine(".");
            }

            _itens = novoArray;
            x++;

        }

        public T this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}
