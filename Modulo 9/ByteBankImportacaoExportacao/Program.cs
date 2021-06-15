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
            //arquivo que já existe
            var arquivoOriginal = new FileStream("teste.txt", FileMode.Open);
            //criando novo arquivo
            var arquivoNovo = new FileStream("teste_copia.txt", FileMode.Create);
            //armazenando a variavel buffer com 1024 byte
            var buffer = new byte[1024];

            using (arquivoOriginal)
            using (arquivoNovo)
            {
                var bytesLidos = -1;
                while (bytesLidos != 0)
                {
                    bytesLidos = arquivoOriginal.Read(buffer, 0, 1024);
                    arquivoNovo.Write(buffer, 0, bytesLidos);
                }
            }

            var rodape = Encoding.UTF8.GetBytes("Este documento é uma cópia do original");
            arquivoNovo.Write(rodape, 0, rodape.Length);

            Console.ReadLine();
        }

       



    }
} 
 