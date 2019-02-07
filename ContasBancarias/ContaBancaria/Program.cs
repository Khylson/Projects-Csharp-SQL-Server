using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaBancaria;

namespace ContaBancaria 
{
    abstract class Program
    {
        static void Main(string[] args)
        {

        }
        
        private string nomeConta;
        private int numeroConta;
        private double saldoConta;
        private static int contador = 100000;

        public abstract string[] Extraato();

        public string NomeConta { get { return nomeConta; } }
        public int NumeConta { get { return numeroConta; } }
        public double SaldoConta { get { return saldoConta; } }



        

    }
       
  
 }
            

      


