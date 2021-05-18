using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Auxiliar é um Funcionario 
    public class Auxiliar : Funcionario
    {

        public Auxiliar(string cpf): base(2000,cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
            
        }

        // sobrepondo o comportamento do funcionario
        public override double GetBonificacao()
        {
            return Salario * 0.2 ;
        }
    }
}


