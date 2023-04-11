using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeContaCorrente
{
    public class Cliente
    {
        public static string nome;
        public string email;
        public string senha;
        public int cpf;

        public Cliente (string nome, string email, string senha, int cpf) 
        {
            Cliente.nome = nome;                
            this.email = email;   
            this.senha = senha;
            this.cpf = cpf;
        }
    }
}
