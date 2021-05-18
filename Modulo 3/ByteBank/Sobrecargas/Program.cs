using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {
            TestandoSobrecarga a = new TestandoSobrecarga();
            // Console.WriteLine(a.EscreveNumero(2));
            double numero = 10;
            a.EscreveNumero(numero);
            a.EscreveNumero(1.0);
            a.TestaSobrecarga(10,20);



            Console.ReadLine();
        }
    }
}
