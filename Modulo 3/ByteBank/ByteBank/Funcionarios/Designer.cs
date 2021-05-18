using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Designer é um Funcionario 
    public class Designer : Funcionario
    {

        public Designer(string cpf): base(3000,cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
            
        }

        // sobrepondo o comportamento da classe mãe
        public override double GetBonificacao()
        {    
            return Salario * 0.17 ;
            
        }
    }
}

