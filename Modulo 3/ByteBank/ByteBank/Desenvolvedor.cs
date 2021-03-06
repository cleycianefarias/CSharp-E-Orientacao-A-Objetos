using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(String cpf): base(3000, cpf)
        {

        }

        public override void AumentarSalario()
        {
            Salario  *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
