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
    public partial class frmEmpregados : Form
    {
        public frmEmpregados()
        {
            InitializeComponent();
        }
        public void CarregarEmpregados(List<Employee> Empregado)
        {
            this.dgvEmpregado.DataSource = Empregado;

        }
        private void frmEmpregados_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmEditarEmpregado frm = new frmEditarEmpregado();
            frm.Show();
        }

        private void dgvEmpregado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var tabela = (List<Employee>)dgvEmpregado.DataSource;
            var frm = new frmEditarEmpregado();
            frm.CarregarEmpregado(tabela[e.RowIndex]);


            frm.Show();
        }

        private void frmEmpregados_DoubleClick(object sender, EventArgs e)
        {
            
           
        }
        
    }
}
