using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");
            for (int ContadorLinha = 0; ContadorLinha < 10; ContadorLinha++)
            {
                //escrevendo asteriscos com o break
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= ContadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            for (int ContadorLinha = 0; ContadorLinha < 10; ContadorLinha++)
            {
                //escrevendo asteriscos sem o break
                for (int contadorColuna = 0; contadorColuna <= ContadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
