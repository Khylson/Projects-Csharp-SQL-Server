using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrejectoTerinee
{
    class Program
    {

        static void NumeroDecrescente()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
        static void Exercicio1()
        {
            int Numero;
            var rnd = new Random();

            Console.WriteLine("Quantos Numeros Desejas Sortear? : ");
            Numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < Numero; i++)
            {
                Console.WriteLine("Numero {0} ", rnd.Next(1, 100));
            }
        }

        static void Exercicio2()
        {
            int Numer1;
            int Numer2;

            var rst = new Random();


            Console.WriteLine("Digite o numero incial: ");
            Numer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero incial: ");
            Numer2 = int.Parse(Console.ReadLine());

            int[] numeros = new int[Numer1 - Numer2 + 1];

            for (int i = 0; i < numeros.Length; i++)
            {

                numeros[i] = rst.Next(Numer1, Numer2 + 1);

            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Data: {0}", DateTime.Now);
                Console.WriteLine("Numeor {0}", numeros);

            }

        }

        static void Exercici03()
        {
            ;

            var rst = new Random();
            string resp = "S";


            Console.WriteLine("Digite o numero incial: ");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero incial: ");
            int NN2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos brindes vai sortear? ");
            int brindes = int.Parse(Console.ReadLine());

            int[] numerosSorteados = new int[brindes];

            for (int i = 0; i < brindes; i++)
            {

                while (true)
                {
                    // soetear os numeros 
                    int numerosSorteado = rst.Next(N1, NN2 + 1);

                    // varrer toidos numeros que já foram sorteados
                    // para saber se o numero já existe ou já foi sorteado...
                    bool JaExiste = false;
                    for (int j = 0; j < numerosSorteados.Length; j++)
                    {
                        if (numerosSorteados[j] == numerosSorteado)
                        {
                            JaExiste = true;
                        }
                    }
                    // fim da verficação 
                    if (JaExiste == false)
                    {
                        numerosSorteados[i] = numerosSorteado;
                        break;
                    }
                }

            }

            while (resp.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Data: {0}", DateTime.Now);
                Console.WriteLine("Número Sorteado: {0} ", rst.Next(N1, NN2 + 1));
                Console.WriteLine("Deseja Continar? <S/N> ");
                resp = Console.ReadLine();


            }



            Console.ReadKey();
        }

        static void SorteioJA2()

        {
            // Para Sortear Numeros 

            int Ninicial = 0;
            int Nfinal = 0;
            var rnd = new Random();

            do
            {
                try
                {
                    Console.WriteLine("Digite o numero do inicio do sorteio: ");
                    Ninicial = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro no Caracter!");
                }
            }

            while (true);

            do
            {
                try
                {
                    Console.WriteLine("Digite o numero do inicio do sorteio: ");
                    Nfinal = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro no Caracter!");
                }
            }

            while (true);

            int?[] listaNumerosSorteados = new int?[Nfinal - Ninicial + 1];
            int contador = 0;
            string resposta = "S";
            while (resposta.ToUpper() == "S")
            {
                while (true)
                {
                    int numerosSorteado = rnd.Next(Ninicial, Nfinal + 1);
                    bool naoExiste = true;

                    for (int i = 0; i < listaNumerosSorteados.Length; i++)
                    {
                        if (listaNumerosSorteados[i] == numerosSorteado)
                        {
                            naoExiste = false;
                        }
                    }
                    if (naoExiste)
                    {
                        listaNumerosSorteados[contador] = numerosSorteado;
                        break;
                    }
                }

                Console.Clear();
                Console.WriteLine("Lista dos numeros sorteados: ");
                for (int j = 0; j <= contador; j++)
                {
                    Console.WriteLine("Numeros Soteados: {0} ", listaNumerosSorteados[1]);
                }

                //verficar se todos numeros forma sorteados ...
                if (contador == listaNumerosSorteados.Length - 1)
                {
                    Console.WriteLine("Todos os numeros foram sorteados:");
                    break;
                }

                Console.WriteLine("Deseja Continar? <S/N> ");
                contador++;
                resposta = Console.ReadLine();


            }


        }

        static void SorteioJA()

        {
            // Para Sortear Numeros 

            int n;
            int nn;

            var rnd = new Random();
            string resposta = "S";

            Console.WriteLine("Digite o numero do inicio do sorteio: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero do inicio do sorteio: ");
            nn = int.Parse(Console.ReadLine());

            while (resposta.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Data: {0}", DateTime.Now);
                Console.WriteLine("Número Sorteado: {0} ", rnd.Next(n, nn + 1));
                resposta = Console.ReadLine();


            }
        }


        static void LoopWhile()


        {
            // Para Sortear Numeros 

            var rnd = new Random();


            string resposta = "S";

            while (resposta.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Data: {0}", DateTime.Now);
                Console.WriteLine("Número Sorteado: {0} ", rnd.Next(1, 6));
                resposta = Console.ReadLine();


            }


        }

        static void Main(string[] args)
        {
            Retangulo.lengthMain = 3;
            Retangulo obj;
            obj = new Retangulo();
            obj.with = 10;
            Console.WriteLine(obj.GetArea());

            Retangulo obj2;
            obj2 = new Retangulo();
            obj2.with = 11;

            Console.WriteLine(obj.GetArea());
            Console.ReadKey();
            //var f = new System.Windows.Forms.Form();
            //f.Text = "Formulario 01";
            //var c1 = new System.Windows.Forms.TextBox();
            //c1.Visible = true;
            //f.Controls.Add(c1);
            //f.Show();
        }


    }
    class Retangulo 
    {
       public static int lengthMain;
       public double length = lengthMain;
       public double with;

        public double GetArea()
        {
            return length * with;

        }


    }
    
    
}





//  Console.WriteLine("OLÁ quem é você?: ");
//  String retorno = Console.ReadLine();


//  Console.WriteLine(" Seja bem vindo " + retorno + " procure não faltar!");
//  Console.WriteLine("Hojé é: {1}. Seja bem vindo {0}. Procure não faltar", retorno,
//  DateTime.Now.ToString());
//  */
///*
//Console.WriteLine("digite um numero A: ");
//int NumeroA = int.Parse(Console.ReadLine());
//Console.WriteLine("digite numero B: ");
//int NumeroB = int.Parse(Console.ReadLine());

//Console.WriteLine("A Soma é: {0}", NumeroA + NumeroB );


/* double resultado = 11 % 2;
 Console.WriteLine(resultado);

 //Estrutura de decisão 

 if (resultado > 5)
 {
     Console.WriteLine("Resultador Maior ou igual a 5 ");
 }
 else
 {
     Console.WriteLine("Resulatdo Menor ou igual a  5 ");
 } 

int Numero;

Console.WriteLine("Digite um numero: ");
Numero = Console.Read();

if (Numero/2 == 0)
{
    Console.WriteLine("O numero é par");
}

else

{
    Console.WriteLine("O numero é par");

}


int nn = 0;
  int n = 0;

  Console.WriteLine("Digite 1 numero: ");
  nn = int.Parse(Console.ReadLine());

  Console.WriteLine("Digite 2 numero:");
  n = int.Parse(Console.ReadLine());


  if (nn == n)
  {
      Console.WriteLine("Numeros iguais");
  }

  else
  if (nn > n)
  {

      Console.WriteLine("O maior numero é" + nn);
  }
  else
  {
      Console.WriteLine("O maior numero é" + n);

Console.ReadKey();
  }*/







