using System.Collections;
using System.Security.AccessControl;

namespace AtividadeContaCorrente
{
    public class ContaCorrente
    {
        public static void MensagemColorida(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public Cliente Cliente { get; set; }

        string nomeDoCliente = Cliente.nome;

        private static int numeroDaConta = 00000;
        private double saldo = 100;
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

        public ContaCorrente(Cliente cliente, int numeroDaConta, double saldo, bool contaEspecial) 
        {
            Cliente nomeCliente = cliente;
            ContaCorrente.numeroDaConta = numeroDaConta++;
            this.saldo = saldo;
            this.contaEspecial = contaEspecial;
        }

        public bool Sacar(double valor, string tipo, bool exibirMensagem = true)
        {
            double limiteSaldo = limite + saldo;

            if (valor > limiteSaldo)
            {
                MensagemColorida("Saldo insuficiente para saque.", ConsoleColor.Red);
                return false;
            }
            else
            {
                Movimentacao movimentacao = new Movimentacao(-valor, tipo);
                Movimentacoes.Add(movimentacao);
                saldo -= valor;
                if (exibirMensagem)
                    MensagemColorida($"Saque de {valor.ToString("C2")} efetuado com sucesso!", ConsoleColor.Green);                
                return true;
            }
        }

        public void Depositar(double valor, string tipo, bool exibirMensagem = true)
        {
            saldo += valor;
            Movimentacao movimentacao = new Movimentacao(valor, tipo);
            Movimentacoes.Add(movimentacao);
            if (exibirMensagem)
                MensagemColorida($"Deposito de {valor.ToString("C2")} efetuado com sucesso!", ConsoleColor.Green);           
        }

        public bool Transferir(ContaCorrente destino, double valor, string tipo)
        { 
            if (saldo < valor)
            {
                MensagemColorida("Saldo insuficiente para transferência.", ConsoleColor.Red);
                return false;
            }
            else
            {
                Sacar(valor, tipo, false);
                destino.Depositar(valor, tipo, false);
                MensagemColorida($"\nTransferência efetuada com sucesso!", ConsoleColor.Green);
                MensagemColorida($"\nCliente {nomeDoCliente} tranferiu {valor.ToString("C2")} para {destino.nomeDoCliente}.", ConsoleColor.Blue);                
                return true;
            }
        }

        public void ExibirExtrato()
        {
            Console.WriteLine($"\nExtrato de {nomeDoCliente}\n");

            foreach (Movimentacao movimentacao in Movimentacoes)
            {
                MensagemColorida($"Valor: {movimentacao.valor}", ConsoleColor.Cyan);
                MensagemColorida($"Tipo: {movimentacao.tipo}", ConsoleColor.Cyan);
            }
        }
    }
}
