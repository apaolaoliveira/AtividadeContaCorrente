using System.Collections;
using System.Security.AccessControl;

namespace AtividadeContaCorrente
{
    public class ContaCorrente
    {
        private int numeroDaConta;
        private double saldo;
        private bool contaEspecial;
        private double limite;

        public double Saldo
        {
            get { return this.saldo; }

            private set
            {
                if (value < 0)
                    return;
                else
                    this.saldo = value;
            }
        }

        private ArrayList Movimentacoes = new ArrayList();

        private static int contadorDeMovimentacoes;

        public ContaCorrente(Cliente cliente, int numeroDaConta, double saldo, bool contaEspecial) 
        {
            Cliente nomeCliente = cliente;
            this.numeroDaConta = numeroDaConta;
            this.saldo = saldo;
            this.contaEspecial = contaEspecial;
        }

        public bool Sacar(double valor, string tipo)
        {
            double limiteSaldo = limite + saldo;

            if (valor > limiteSaldo)
            {
                Console.WriteLine("Saldo insuficiente para saque.");
                return false;
            }
            else
            {
                Movimentacao movimentacao = new Movimentacao(-valor, tipo);
                Movimentacoes.Add(movimentacao);
                saldo -= valor;
                Console.WriteLine("Saque efetuado com sucesso!");
                contadorDeMovimentacoes++;
                return true;
            }
        }
        public void Depositar(double valor, string tipo)
        {
            saldo += valor;
            Movimentacao movimentacao = new Movimentacao(valor, tipo);
            Movimentacoes.Add(movimentacao);
            Console.WriteLine("Deposito efetuado com sucesso!");
            contadorDeMovimentacoes++;
        }

        public bool Transferir(ContaCorrente destino, double valor, string tipo)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
                return false;
            }
            else
            {
                Sacar(valor, tipo);
                destino.Depositar(valor, tipo);
                Console.WriteLine($"Transferência efetuada com sucesso! \n Valor transferido: {valor}");
                contadorDeMovimentacoes++;
                return true;
            }
        }

        public void ObterExtrato()
        {

            foreach (Movimentacao movimentacao in Movimentacoes)
            {
                Console.WriteLine($"Movimentação número {contadorDeMovimentacoes}");
                Console.WriteLine($"Valor: {movimentacao.valor}");
                Console.WriteLine($"Tipo: {movimentacao.tipo}");
            }
        }
    }
}
