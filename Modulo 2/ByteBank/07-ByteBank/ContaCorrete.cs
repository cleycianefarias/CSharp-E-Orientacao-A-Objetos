//using _05_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        // quando não existe lógica dentro do get e set eu coloco apenas os nomes get e set
        // e separo por virgula
        //simplificação de campos


        public static int TotalDeContasCriadas { get; private set; }


        public Cliente Titular{get;set;}

        private int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            } 
        }
        public int Numero { get; set; }

        private double _saldo = 100;

        //propriedade de get e set
        public double Saldo
        {
            get
            {
                //vai retornar um valor
                return _saldo;
            }
            set
            {
                //definir o saldo
                //não escolhe o nome do argumento ele já vem padrão com o nome de value
                if (value < 0)
                {
                    //para de executar o método e dessa forma faz a chamada
                    return;
                }
                _saldo = value;
            }
        } 

        //construtor da conta corrente
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        //todo nome de função comeca com maiusculo
        //toda funcao deve ser em verbo infinitivo
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }

        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }

}
