using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdClientes_Click(object sender, EventArgs e)
        {

            frmClientes frm = new frmClientes ();
            var bd = new NorthwindEntities();
            var clientes = (from c in bd.Customers
                            //where c.Country == "Angola"
                            orderby c.CompanyName
                            select c).ToList();
            frm.CarregaCleintes(clientes);
           
            frm.Show();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmpregados frm = new frmEmpregados();
            var bd = new NorthwindEntities();
            var empregados = (from em in bd.Employees
                                //where c.Country == "Angola"
                            select em).ToList();
            frm.CarregarEmpregados(empregados);

            frm.Show();
        }
    }
}
