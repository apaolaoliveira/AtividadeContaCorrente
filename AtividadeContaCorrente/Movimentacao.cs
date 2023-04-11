using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeContaCorrente
{
    internal class Movimentacao
    {
        public double valor;
        public string tipo;

        // O tipo é para definir se é crédito ou débito.

        public Movimentacao(double valor, string tipo) 
        {
            this.valor = valor;
            this.tipo = tipo;
        }
    }
}
