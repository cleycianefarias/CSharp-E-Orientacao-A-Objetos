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
            //var conta = new ContaCorrente(456,456456);
            //diretorio de onde está o arquivo
            var enderecoDoArquivo = "contas.txt";
            //modo de abertura do documento
            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
            
            //declarando uma variavel buffer com 1024 bytes
            //após isso inicializa o valor para leitura do arquivo
            var buffer = new byte [1024]; //1kb 
            var numeroDeBytesLidos = -1;


            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);   
            }

            
            

            Console.ReadLine();

        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }
    }
} 
 