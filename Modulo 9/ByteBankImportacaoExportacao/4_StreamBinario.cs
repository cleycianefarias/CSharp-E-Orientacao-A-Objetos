using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {

            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456); // número da agencia
                escritor.Write(546544); // numero da conta
                escritor.Write(4000.50); //saldo
                escritor.Write("Gustavo Braga");
            }

        }
        static void LeituraBinaria() 
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var conta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();


                Console.WriteLine($"{agencia}/{conta} {saldo} {titular}");
            }

        }

    }
}
