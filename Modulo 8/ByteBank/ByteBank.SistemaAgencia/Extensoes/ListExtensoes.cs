using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        //lista genérica
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }
        public static void TesteGenerico<T2>(this string texto)
        {
            
        }
        static void Teste()
        {
            List<int> idades = new List<int>();
            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            idades.AdicionarVarios(54, 5465, 465);

            string guilherme = "Guilherme";
            guilherme.TesteGenerico<int>();

            //ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4, 5);


            List<string> nomes = new List<string>();
            nomes.Add("Guilherme");

            //ListExtensoes<string>.AdicionarVarios(nomes, "Lucas", "mariana");
            //string é usado como método genperico da extensão
            nomes.AdicionarVarios("Lucas", "Mariana");
        }
    }
}
