using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public class Conta
    {
        public long Numero { get; set; }
        public decimal Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public void Saque(decimal valor)
        {
            if (valor <= Saldo && valor > 0)
            Saldo -= valor;
        }

        public void Deposito(decimal valor)
        {
            if (valor > 0)
            Saldo += valor;
        }
    }
}
