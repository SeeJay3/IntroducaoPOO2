using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public abstract class Conta
    {
        public long Numero { get; set; }
        public decimal Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public abstract bool Saque(decimal valor);
        public abstract void Deposito(decimal valor);
        public abstract void Transferencia(Conta destino, decimal valor);
        
    }
}
