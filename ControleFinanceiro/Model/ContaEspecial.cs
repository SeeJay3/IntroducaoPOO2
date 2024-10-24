using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public class ContaEspecial : Conta
    {
        public decimal Limite { get; set; }

        public override void Deposito(decimal valor)
        {
            throw new NotImplementedException();
        }

        //O saldo da conta nunca poderá ficar negativo além do seu limite
        public override void Saque(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override void Transferencia(Conta destino, decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
