using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrejectoTerinee
{
    public partial class ProjetoTreinee : Form
    {

        string nome = "mxkhylson";
        string senha = "1234567890";

        public ProjetoTreinee()
        {
            InitializeComponent();

          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == nome && textBox2.Text == senha)
            {
              
            }
        }
    }
}
