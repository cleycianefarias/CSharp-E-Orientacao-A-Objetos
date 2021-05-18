using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000,"546.879.157-20");
            carlos.Nome = "Carlos";
            

            carlos.AumentarSalario();
            Console.WriteLine("Novo salári do carlos " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);


            Diretor roberta = new Diretor("457.658.148-3");
            roberta.Nome = "Roberta";
            

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Funcionario robertaTeste = roberta;


            roberta.AumentarSalario();
            Console.WriteLine("Novo salario de roberta " + roberta.Salario);

            //retorna o salario da roberta a partir de diretor
            Console.WriteLine("Bonificação de uma referencia de Diretor " + roberta.GetBonificacao());
            //retorna o salario de roberta a partir da classe de funcionario
            Console.WriteLine("Bonificação de uma referencia de Diretor " + robertaTeste.GetBonificacao());

            
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();

            //colocar em uma variavel do tipo base um objeto base é o polimorfismo
        }
    }
}

// A palavra chave com a menor visibilidade é private,
// depois vem o protected e depois public.
// private - apenas visível dentro da classe;
// protected - visível dentro da classe e também para as filhas;
// public - visível em todo lugar;
