using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //IO = input and output

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            var enderecoDoArquivo = "contas.txt";
          
            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; //1kb 
                var numeroDeBytesLidos = -1;


                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"bytes lidos {numeroDeBytesLidos}");
                    EscreverBuffer(buffer,numeroDeBytesLidos);
                
                }
            }

            Console.ReadLine();

        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;
            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);
        }
    }
} 
 