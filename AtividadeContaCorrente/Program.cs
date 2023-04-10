namespace AtividadeContaCorrente
{
    internal class Program
    {
        public static void mock()
        {
            Cliente olivier = new Cliente ("Olivier Florence", "olivier.gameplays@gmail.com" ,234456234-33, 01);
            ContaCorrente contaOlivier = new ContaCorrente(olivier, 00001, 159000, true);

            Cliente milo = new Cliente ("Milo Castello", "milo.castello@gmail.com" ,657685136-52, 02);
            ContaCorrente contaMilo = new ContaCorrente(milo, 00002, 10, false);

            Cliente barbara = new Cliente ("Bárbara Lima", "barbara.lima@gmail.com" ,897986413-95, 03);
            ContaCorrente contaBarbara = new ContaCorrente(barbara, 00003, 20, false);

            Cliente wanderley = new Cliente ("Wanderley Nascimento", "wanderley.nascimento@gmail.com" ,796874136-86, 04);
            ContaCorrente contaWanderley = new ContaCorrente(wanderley, 00004, 36000, true);

            Cliente amelie = new Cliente ("Amelie Florence", "amelie.florence@gmail.com" ,121366546-33, 05);
            ContaCorrente contaAmelie = new ContaCorrente(amelie, 00005, 150000, true);
        }

        static void Main(string[] args)
        {
            mock();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("BEM VINDO(A) AO BANCO TIPORA");

                Console.WriteLine("Menu Principal");
                Console.WriteLine("---------------------");
                Console.WriteLine("[1] Login");
                Console.WriteLine("[2] Cadastro");
                string opcaoMenuPrincipal = Console.ReadLine();

                Console.WriteLine("Login");
                Console.WriteLine("----------------------");
                Console.Write("Email: ");
                Console.Write("Senha: ");




                Console.WriteLine("\nQual o seu email de acesso?");
                Console.WriteLine("[1] ");


            }

            Console.WriteLine();
        }
    }
}
