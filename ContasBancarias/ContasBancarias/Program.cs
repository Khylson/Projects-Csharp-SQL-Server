using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias
{
  
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente cc = null;
            ContaPoupança cp = null;
            string resp = "";
            do
            {

                resp = MostrarMenu();
                if (resp == "1")
                {
                    Console.WriteLine("----------- Crie Uma Conta Corrente ---------------");
                    Console.WriteLine("Insira o nome da Conta Corrente ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Insira o Valor de Deposito: ");
                    int valordeposito = int.Parse(Console.ReadLine());
                    cc = new ContaCorrente(nome, valordeposito);
                    MostrarDadosConta(cc);
                }
                else if (resp == "2")
                {
                    cc.PedirCheque();
                    var retorno = cc.PedirCheque();
                    if (retorno == true)
                    {
                        Console.WriteLine("Talão de Cheque Solicitado");
                    }
                    else
                    {
                        Console.WriteLine("Talão de Cheque não Solicitado");
                    }

                }
                else if (resp == "3")
                {
                    cc.Deposito(900);
                    Console.WriteLine(900);
                    MostrarDadosConta(cc);

                }
                else if (resp == "4")
                {
                    bool resps = (cc.Saque(100));
                    if (resps)
                    {
                        MostrarDadosConta(cc);
                    }
                    else
                    {
                        Console.WriteLine("O Saque não foi Autorizado!");
                        MostrarDadosConta(cc);
                    }

                    Console.ReadLine();

                }
                if (resp == "5")
                {
                    Console.WriteLine("----------- Crie Uma Conta Poupança ------------- ");
                    Console.WriteLine("Insira o nome da Conta Poupança ");
                    string nomeP = Console.ReadLine();
                    Console.WriteLine("Insira o Valor de Deposito: ");
                    int valordepositoP = int.Parse(Console.ReadLine());
                    cp = new ContaPoupança(nomeP, valordepositoP);
                    MostraDadosContaPoupança(cp);
                    
                }
                else if (resp == "6")
                {
                    Console.Clear();
                    Console.WriteLine("A Taxa de Rendimento: {0} ", cp.ObterTaxaRendimento());
                    Console.ReadLine();

                }
                else if (resp == "7")
                {
                    cp.DespositoPoupança(400);
                    Console.WriteLine("400");
                    MostraDadosContaPoupança(cp);

                }
                else if (resp == "8")
                {
                    bool resps = (cp.SaqueContaPoupança(100));
                    if (resps)
                    {
                        MostraDadosContaPoupança(cp);
                    }
                    else
                    {
                        Console.WriteLine("O Saque não foi Autorizado!");
                        MostraDadosContaPoupança(cp);
                    }

                    Console.ReadLine();

                }

            } while (resp != "9");

        }
        private static void MostrarDadosConta(ContaCorrente cc)
        {

            Console.WriteLine("Numero {0} ", cc.NumeroConta);
            Console.WriteLine("Nome: {0} ", cc.NomeConta);
            Console.WriteLine("Saldo: {0} ", cc.SaldoConta);
            Console.ReadLine();

        }

        private static void MostraDadosContaPoupança(ContaPoupança cp)
        {
            Console.WriteLine("Numero {0} ", cp.NumeroContaP);
            Console.WriteLine("Nome: {0} ", cp.NomeContaP);
            Console.WriteLine("Saldo: {0} ", cp.SaldoContaP);
            Console.ReadLine();

        }
        private static string MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Criar Conta Corrente");
            Console.WriteLine("2. Pedir Cheque");
            Console.WriteLine("3. Depositar 900");
            Console.WriteLine("4. Sacar 100");
            Console.WriteLine("5. Criar Conta Poupança");
            Console.WriteLine("6. Mostra Rendimento");
            Console.WriteLine("7. Depositar 400 (Pouoança)");
            Console.WriteLine("8. Sacar 100 (Poupança)");
            Console.WriteLine("Sair");
            return Console.ReadLine();
        }

    }


}
class ContaCorrente
{

    public string NomeConta;
    public int NumeroConta;
    public double SaldoConta;
    public int contador = 100000;




    public ContaCorrente(string nomeConta, double saldoConta)
    {

        NomeConta = nomeConta;
        SaldoConta = saldoConta;
        NumeroConta = contador;
        contador++;

    }

    public bool PedirCheque()
    {
        return true;
    }
    public void Deposito(double valor)
    {
        SaldoConta = SaldoConta + valor;

    }
    public bool Saque(double saque)
    {

        if (SaldoConta >= saque)
        {
            SaldoConta -= saque;
            return true;
        }
        return false;

    }

}
class ContaPoupança
{
    public string NomeContaP;
    public int NumeroContaP;
    public double SaldoContaP;
    private static int contadorP = 500000;


    public ContaPoupança(string nomeContaP, double saldoContaP)
    {
        NomeContaP = nomeContaP;
        SaldoContaP = saldoContaP;
        NumeroContaP = contadorP;
        contadorP++;
    }

    public double ObterTaxaRendimento()
    {
        if (SaldoContaP > 100)
        {
            return 0.6;
        }
        else
            return 0.3;

    }

    public void DespositoPoupança(double dpoupança)
    {
        SaldoContaP += dpoupança;
    }
    public bool SaqueContaPoupança(double saquepoupança)
    {
        if (SaldoContaP >= saquepoupança)
        {
            SaldoContaP -= saquepoupança;
            return true;
        }
        return false;

    }

}




