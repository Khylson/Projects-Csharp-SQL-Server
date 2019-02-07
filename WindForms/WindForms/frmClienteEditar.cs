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
    public partial class frmClienteEditar : Form
    {
        private bool edicao = false;
        public frmClienteEditar()
        {
            InitializeComponent();
        }

        public void CarregarCliente (Customer cr)
        {
            // Informando a edição 
            edicao = true;
            
            txtCustomerID.Text = cr. CustomerID;
            txtCustomerID.ReadOnly = true;
            txtCompanyName.Text = cr. CompanyName;
            txtContactName.Text = cr. ContactName;
            txtContactTitle.Text = cr. ContactTitle;
            txtAddress.Text = cr. Address;
            txtCity.Text = cr.City;
            txtRegion.Text = cr. Region;
            txtPostalCode.Text = cr. PostalCode;
            txtCountry.Text = cr. Country;
            txtPhone.Text = cr.Phone;
            txtFax.Text = cr.Fax;
           
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            var Customer = new Customer
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text
            };
            
            try
            {
                if (edicao)
                {
                    db.Customers.Attach(Customer);
                    db.Entry(Customer).State = EntityState.Modified;
                }
                else
                {
                    // Salvar n a memoria 
                    db.Customers.Add(Customer);
                }
               
                // Salvar no Banco de dados
                db.SaveChanges();
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {
                string message = "";
                message = ex.Message;
                if (ex.InnerException == null)
                    message = ex.Message;

                else if (ex.InnerException.InnerException == null)
                    message = ex.InnerException.Message;
                else if (ex.InnerException.InnerException.Message == null)
                    message = ex.InnerException.InnerException.Message;


                    MessageBox.Show(ex.Message);
            }

            txtCustomerID.Text = "";
            txtCompanyName.Text = "";
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtRegion.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
            txtFax.Text = "";

        }

        private void frmClienteEditar_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Para eExcluir, traga o registro do banco de dados e depois 
            // Exclua da memoria...
            var bd = new NorthwindEntities();
            var customer = (from c in bd.Customers
                            where c.CustomerID == txtCustomerID.Text
                            select c).FirstOrDefault();

            if (customer != null)
            {
                bd.Customers.Remove(customer);
                try
                {
                    bd.SaveChanges();
                    MessageBox.Show("Registro Excluido com Sucesso!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("O Cliente não pode ser Excluido!");
                }
            }
            else
            {
                MessageBox.Show("O Registro não foi encontrolado!");
            }
                           
        }
    }
}
