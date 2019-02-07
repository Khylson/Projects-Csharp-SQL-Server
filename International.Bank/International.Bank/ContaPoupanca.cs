using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International.Bank
{
   public class ContaPoupanca : ContaBancaria
    {
        private static int Contador = 500000;
        public ContaPoupanca(string nome, double saldo) : base(nome,saldo)
        {
            numero = Contador;
            Contador++;
        }
        public double ObterTaxaRendimento()
        {
            if (Saldo > 1000)
                return 0.06;
            else
                return 0.03;
        }

        public override string[] Extrato()
        {
            // Aqui deveria ser escrita o metodo Extrato
            return null;
        }
    }
}
