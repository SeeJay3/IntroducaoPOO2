using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Model
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public List<Conta> Contas { get; set; }
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }
        public override string ToString()
        {
            if (Telefone != string.Empty)
                return Nome + " - " + CPF + $" - {Telefone}";
            else
                return Nome + " - " + CPF;
        }
        public decimal SaldoDasContas()
        {
            {
                decimal total = 0;
                foreach (Conta conta in Contas)
                {
                    total += conta.Saldo; 
                }
                return total;
            }
        }
    }
}

