using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //IO = input and output

namespace ByteBankImportacaoExportacao 
{ 
    partial class Program 
    { 
        static void Main(string[] args) 
        {

            var numero = 691693903;

           

            using (var fs = new FileStream("StreamWriter.txt", FileMode.Create))
            using (var writer = new StreamWriter(fs))
            {
                writer.Write(numero);
            }

            //LeituraBinaria();
            //TestaEscrita();
            //Console.WriteLine("Aplicação finalizada!");

            Console.ReadLine();
        }

       



    }
} 
 