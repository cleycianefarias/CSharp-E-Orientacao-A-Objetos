using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Diretor é um Funcionario 
    public class Diretor : Funcionario
    {

        public Diretor(string cpf): base(5000,cpf)
        {
            Console.WriteLine("Criando diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
            
        }

        // sobrepondo o comportamento do funcionario
        public override double GetBonificacao()
        {         
            //base - torna a implementação base da classe principal
            return Salario * 0.5 ;
        }
    }
}


// o método protected, as classes filhas tem acesso a classe base,
// porém não manipulam esse valor externamente

