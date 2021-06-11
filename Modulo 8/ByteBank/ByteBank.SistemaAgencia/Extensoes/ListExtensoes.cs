using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public class ListExtensoes
    {
        //lista genérica
        public static void AdicionarVarios(this List<int> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void Teste()
        {
            List<int> idades = new List<int>();
            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            ListExtensoes<int>.AdicionarVarios(idades, 2, 3, 4, 5);


            List<string> nomes = new List<string>();
            nomes.Add("Guilherme");

            ListExtensoes<string>.AdicionarVarios(nomes, "Lucas", "mariana");



            nomes.AdicionarVarios("Lucas", "Mariana");
        }
    }
}
