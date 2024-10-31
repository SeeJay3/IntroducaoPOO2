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
            Saldo += valor;
        }

        //O saldo da conta nunca poderá ficar negativo além do seu limite
        public override bool Saque(decimal valor)
        {
            if(Saldo + Limite >= valor)
            {
                Saldo -= valor;
                return true;
            }  
            else
            {
                throw new Exception("Saldo insuficiente.");
            }
        }

        public override void Transferencia(Conta destino, decimal valor)
        {
            if (Saque(valor))
                destino.Deposito(valor);
            
        }
    }
}
