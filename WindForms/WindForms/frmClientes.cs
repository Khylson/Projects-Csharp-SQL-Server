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
    public partial class frmClientes : Form
    {
       
        public frmClientes()
        {
            InitializeComponent();
            // Preencher os páis 
            var db = new NorthwindEntities();
            var paises = (from c in db.Customers
                          orderby c.Country
                          select c.Country)
                          .Distinct()
                          .ToList();
            cboPais.DataSource = paises;

            // Preencher os cidadde 
            
            var cidade = (from c in db.Customers
                          orderby c.City
                          select c.City)
                          .Distinct()
                          .ToList();

            cboCidade.DataSource = cidade;
            


        }
        public void CarregaCleintes(List<Customer> Clientes)
        {
           this.dgvClientes.DataSource = Clientes;
            
        }

        private void brn_Novo_Click(object sender, EventArgs e)
        {
            frmClienteEditar novo = new frmClienteEditar();
            novo.Show();
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmClientes atualizar = new frmClientes();
            var bd = new NorthwindEntities();
            var clientes = (from c in bd.Customers
                           
                            orderby c.CompanyName
                            select c).ToList();
            atualizar.CarregaCleintes(clientes);
            atualizar.Show(); Close();
            

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
          
            var bd = new NorthwindEntities();
            var clientes = (from c in bd.Customers
                                // where c.Country == txtFiltron.Text || c.CompanyName == txtFiltron.Text || c.CustomerID == txtFiltron.Text
                            where (cboPais.Text != "" ? c.Country == cboPais.Text : true)
                            &&
                            (cboCidade.Text != "" ? c.City == cboCidade.Text : true)
                            orderby c.CompanyName
                            select c).ToList();

            CarregaCleintes(clientes);

           
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tabela = (List<Customer>)dgvClientes.DataSource;
            var frm = new frmClienteEditar();
            frm.CarregarCliente(tabela[e.RowIndex]);
            
            frm.Show(); 
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bd = new NorthwindEntities();
            var cidade = (from c in bd.Customers
                               
                            where c.Country == cboPais.Text
                            orderby c.City
                            select c.City)
                            .Distinct()
                            .ToList();
            
        }

        private void cboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
