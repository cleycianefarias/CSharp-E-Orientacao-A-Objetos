﻿using ByteBankImportacaoExportacao.Modelos;
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
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78945,4785.50,Gustavo Santos";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);
                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("456,65456,456.0,Pedro");
            }

        }

        static void TestaEscrita()
        {
            Console.WriteLine("Passando por aqui");

            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 10000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); // despeja o buffer para o stream

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. tecle enter para adicionar mais uma...");
                    Console.ReadLine();
                }
            }
        }
    }
}