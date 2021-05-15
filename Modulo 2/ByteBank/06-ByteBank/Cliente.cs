using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {

        private string _cpf;
        // digita o prop e tecla tab duas vezes 
        //vai pegar todas as declarações de código e colocar dentro de um unico get e set
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo minha lógica de validação de cpf
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

    }
}
