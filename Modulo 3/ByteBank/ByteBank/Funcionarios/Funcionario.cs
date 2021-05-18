using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
       public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private  set; }
        public double Salario { get; protected set; }

        //tornando o cpf obrigatorio
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionario");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        //outras classes podem sobrescrever a aplicação
        public virtual void AumentarSalario()
        {
           // Salario = Salario + (Salario * 0.1);
           // Salario = Salario * 1.1;
            Salario *= 1.1;
        }

        //criar metodo
        public virtual double GetBonificacao()
        {    
            return Salario * 0.10;
        }

    }
}
