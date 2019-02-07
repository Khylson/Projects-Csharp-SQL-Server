using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using International.Bank;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {

        ContaBancaria[] cb = new ContaBancaria [20];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            float valor = float.Parse(textBox2.Text);
            cb[contador] = new ContaCorrente(nome, valor);
            MostarDadosConta(cb[contador]);
            contador++;

        }
        private void MostarDadosConta(ContaBancaria cb)
        {
           
            
            Tela.Text += string.Format("\nConta Numero: {0}", cb.Numero);
            Tela.Text += string.Format("\nConta Nome: {0}", cb.Nome);
            Tela.Text += string.Format("\nConta Saldo: {0}", cb.Saldo);
            Tela.Text += string.Format("\n");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void btnContaPoupança_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            float valor = float.Parse(textBox2.Text);
            cb[contador] = new ContaPoupanca(nome, valor);
            MostarDadosContaPoupança(cb[contador]);
            contador++;
        }
         private void MostarDadosContaPoupança(ContaBancaria cb)
        {
           
            
     Tela2.Text  += string.Format("\nConta Numero: {0}", cb.Numero);
            Tela2.Text += string.Format("\nConta Nome: {0}", cb.Nome);
            Tela2.Text += string.Format("\nConta Saldo: {0}", cb.Saldo);
            Tela2.Text += string.Format("\n");

        }

    }
}
