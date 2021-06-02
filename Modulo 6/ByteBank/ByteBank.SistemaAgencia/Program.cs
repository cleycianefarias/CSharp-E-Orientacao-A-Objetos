using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // pagina?argumentos
            // 012345678

            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "smkmkdfbnkjsbfhfs";


            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine("indice: "+indice);
            Console.WriteLine("Nome do argumento: "+nomeArgumento.Length);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine("Palavra: " + palavra);
            Console.WriteLine("substring: " + palavra.Substring(indice));
            Console.WriteLine("palavrafinal " + palavra.Substring(indice+nomeArgumento.Length+1));

            Console.WriteLine("Tamanho da string "+ nomeArgumento.Length );

            
          

            Console.ReadLine();


            //testando IsNullOrEmpty
            //Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            //Console.WriteLine(string.IsNullOrEmpty(textoQualquer));
            //Console.ReadLine();


            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(null);

            string url = "pagina?modedaOrigem=real&moedaDestino=dolar";
            

            //url += "sufixo";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao+1);
            Console.WriteLine(argumentos);

            

            Console.ReadLine();


        }
    }


}
