using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    public class TestandoSobrecarga
    {
        public int EscreveNumero(int n)
        {
            return n;

        }
        public double EscreveNumero(double n)
        {
            return n;

        }

        public void TestaSobrecarga(int a, int b)
        {
            Console.WriteLine("TestaSobrecarga(int, int)");
        }

        public void TestaSobrecarga(double a, double b)
        {
            Console.WriteLine("TestaSobrecarga(double, double)");
        }
    }
}
