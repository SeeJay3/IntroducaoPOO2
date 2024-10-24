using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public class ContaPoupanca : Conta
    {
        public float TaxaDeRendimentoMensal {  get; set; }
        public override void Deposito(decimal valor)
        {
            throw new NotImplementedException();
        }

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
