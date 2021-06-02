using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        //ctor + tab -> cria método automaticamente
        //prop + tab cria método get e set automaticamente
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {

            //string.IsNullOrEmpty(url);

            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("O argumento url não pode ser nulo ou vazio ", nameof(url));
            }



            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            if (url == "msngjks")
            {
                URL = url;
            }
            else
            {
                URL = "msngjks";
            }



        }
        //modedaOrigem=real&moedaDestino=dolar
       //MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR
       //funcionaria tudo de qualquer maneira que estivesse escrito
        public string GetValor(string nomeDoParametro)
        {
            nomeDoParametro = nomeDoParametro.ToUpper(); // VALOR
            string argumentoEmCaixaAlta = _argumentos.ToUpper(); // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeDoParametro + "="; //moedaDestino concatenado com valor de =
            int indiceTermo =argumentoEmCaixaAlta.IndexOf(termo); // posicao da variavel 'm' de moeda destino


            string resultado = _argumentos.Substring(indiceTermo + termo.Length);

            //string resultado = argumentoEmCaixaAlta.Substring(indiceTermo + termo.Length);//dolar
            //concatena o m + moedaDestino = e começa a contar a partir de toda essa concatenação
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);



            //int indiceParametro = _argumentos.IndexOf

        }


    }
}
