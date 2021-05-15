using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - calcula Poupança");
            double valorInvestido = 1000;
            int contadorMes = 1;
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);

                //contadorMes = contadorMes + 1;
                // contadorMes += 1;
                contadorMes++;

            }

            Console.ReadLine();
        }
    }
}

/*o problema do código do betino é que ele inicializou o contador
 porém ele não decrementou essa variável dentro do while ficando infinitamente
no 1 já que não existe variável para mudar o seu status*/
