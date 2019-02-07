using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International.Bank
{
   public class ContaCorrente : ContaBancaria
    {
        private static int Contador = 100000;

        public ContaCorrente(string nome, double saldo) : base(nome, saldo)
        {
            numero = Contador;
            Contador++;
        }
        public bool PedirCheque()
        {
            return true;
        }

        public override string[] Extrato()
        {
            // Aqui deveria ser escrita o metodo Extrato
            return null;
        }

        public override bool Saque(double valor)
        {
            if (valor > Saldo)
            {
                // verificar se o individuo tem limite de credito
                // se sim, coloque saldo na conta do pobre coitado
                Deposito(valor);
            }
            return base.Saque(valor);
        }

    }
}
