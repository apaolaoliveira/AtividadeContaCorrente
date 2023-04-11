namespace AtividadeContaCorrente
{
    internal class Program
    {
        public static List<ContaCorrente> Mock()
        {
            Cliente olivier = new Cliente ("Olivier Florence", "olivier.gameplays@gmail.com", "senhadobanco", 234456234-33);
            ContaCorrente contaOlivier = new ContaCorrente(olivier, 00001, 159000, true);

            Cliente milo = new Cliente ("Milo Castello", "milo.castello@gmail.com", "oceanomechama", 657685136-52);
            ContaCorrente contaMilo = new ContaCorrente(milo, 00002, 10, false);

            Cliente barbara = new Cliente ("Bárbara Lima", "barbara.lima@gmail.com", "margarida", 897986413-95);
            ContaCorrente contaBarbara = new ContaCorrente(barbara, 00003, 20, false);

            Cliente wanderley = new Cliente ("Wanderley Nascimento", "wanderley.nascimento@gmail.com", "humildade", 796874136-86);
            ContaCorrente contaWanderley = new ContaCorrente(wanderley, 00004, 36000, true);

            Cliente amelie = new Cliente ("Amelie Florence", "amelie.florence@gmail.com", "odeiopobres", 121366546-33);
            ContaCorrente contaAmelie = new ContaCorrente(amelie, 00005, 150000, true);

            List<ContaCorrente> contas = new List<ContaCorrente> {contaOlivier, contaMilo, contaBarbara, contaWanderley, contaAmelie};

            return contas;
        }

        static void Main(string[] args)
        {
            // Chamando as contas da lista.
            List<ContaCorrente> contas = Mock() ;
            ContaCorrente contaOlivier = contas[0];
            ContaCorrente contaMilo = contas[1];
            ContaCorrente contaBarbara = contas[2];
            ContaCorrente contaWanderley = contas[3];
            ContaCorrente contaAmelie = contas[4];

            // Operações:

            ContaCorrente.MensagemColorida("\nVisualize o nosso Banco funcionando! \nAperte qualquer tecla para simular operações.", ConsoleColor.DarkYellow);
            Console.ReadKey();

            //---------------------

            Console.Clear();
            ContaCorrente.MensagemColorida("\nSaque: ", ConsoleColor.DarkYellow);

            Console.WriteLine("\nConta Olivier saldo: " + contaOlivier.Saldo + "\n");
            contaOlivier.Sacar(500, "Saque");
            Console.WriteLine("\nConta Olivier saldo: " + contaOlivier.Saldo);
            Console.ReadKey();

            //---------------------

            Console.Clear();
            ContaCorrente.MensagemColorida("\nDepósito: ", ConsoleColor.DarkYellow);

            Console.WriteLine("\nSaldo conta Wanderley: " + contaWanderley.Saldo + "\n");
            contaWanderley.Depositar(500, "Depósito");
            Console.WriteLine("\nSaldo conta Wanderley: " + contaWanderley.Saldo);
            Console.ReadKey();

            //---------------------

            Console.Clear();
            ContaCorrente.MensagemColorida("\nTransferência entre contas: ", ConsoleColor.DarkYellow);

            Console.WriteLine("\nConta Amelie saldo: " + contaAmelie.Saldo);
            Console.WriteLine("Conta Bárbara saldo: " + contaBarbara.Saldo);
            contaAmelie.Transferir(contaBarbara, 10, "Tranferência entre contas.");
            Console.WriteLine("\nConta Amelie saldo: " + contaAmelie.Saldo);
            Console.WriteLine("Conta Bárbara saldo: " + contaBarbara.Saldo);
            Console.ReadKey();

            //---------------------

            Console.Clear();
            ContaCorrente.MensagemColorida("\nExtrato conta Amelie: \n", ConsoleColor.DarkYellow);

            contaAmelie.ExibirExtrato();
            Console.ReadKey();

            //---------------------

            Console.Clear();
            ContaCorrente.MensagemColorida("\nFim do tuor! Esperamos que tenha gostado da nossa primeira versão." +
                                           "\nPressione qualquer tecla para sair :)", ConsoleColor.DarkYellow);
            Console.ReadKey();
        }
    }
}
