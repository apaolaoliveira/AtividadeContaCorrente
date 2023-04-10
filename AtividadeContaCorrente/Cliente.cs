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
        public string nome;
        public string email;
        public int cpf;
        public int id;

        public Cliente (string nome, string email, int cpf, int id) 
        {
            this.nome = nome;                
            this.email = email;                
            this.cpf = cpf;
            this.id = id;
        }
    }
}
