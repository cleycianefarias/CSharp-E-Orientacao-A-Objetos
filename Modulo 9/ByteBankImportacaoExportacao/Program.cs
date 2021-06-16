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
            var bytesArquivo = File.ReadAllBytes("contas.txt");
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            Console.WriteLine($"Arquivos contas.txt possui {bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();


            //UsarStreamDeEntrada();
            //LeituraBinaria();
            //TestaEscrita();
            //Console.WriteLine("Aplicação finalizada!");

            Console.ReadLine();
        }

       



    }
} 
 