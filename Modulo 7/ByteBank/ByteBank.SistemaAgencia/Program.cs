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

            //palavra
            //0123456

            //ARRAY de inteiros com 5 posições!
            int[] idades = new int[5];

            idades[0]=15;
            idades[1]=28;
            idades[2]=35;
            idades[3]=50;
            idades[4]=28;

            Console.WriteLine(idades[4]);

          

            Console.ReadLine();
        }

    }


}
