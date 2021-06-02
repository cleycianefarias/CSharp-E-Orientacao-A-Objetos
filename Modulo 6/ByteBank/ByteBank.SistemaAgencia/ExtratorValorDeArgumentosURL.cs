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
                throw new ArgumentNullException("O argumento url não pode ser nulo ou vazio ",nameof(url));
            }

            

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            if(url == "msngjks")
            {
                URL = url;
            }
            else
            {
               URL = "msngjks" ;
            }

           

        }
        //modedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeDoParametro)
        {
            return null;
            //int indiceParametro = _argumentos.IndexOf

        }


    }
}
