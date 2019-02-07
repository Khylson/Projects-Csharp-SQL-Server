using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International.Bank
{
   public abstract class ContaBancaria
    {
        private string nome;
        private double saldo;
        protected int numero;

        public abstract string[] Extrato();


        public string Nome { get { return nome; } }
        public double Saldo { get { return saldo; } }
        public int Numero { get { return numero; } }

        public ContaBancaria(string Nome, double Saldo)
        {
            nome = Nome;
            saldo = Saldo;
        }

        public void Deposito(double valor)
        {
            saldo = saldo + valor;
            // ou saldo += valor;
        }

        public virtual bool Saque(double valor)
        {
            if (saldo >= valor)
            {
                saldo = saldo - valor;
                return true;
            }
            return false;

            // ou Saldo -= valor;
        }
    }
}
