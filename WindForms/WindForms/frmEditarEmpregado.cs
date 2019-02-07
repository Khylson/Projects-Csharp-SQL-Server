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
    public partial class frmEditarEmpregado : Form
    {
        private bool edicao = false;
        public frmEditarEmpregado()
        {
            InitializeComponent();
        }
         public void CarregarEmpregado (Employee cr)
        {
            // Informando a edição 
            edicao = true;

            txtEmployeeID.Text = cr.EmployeeID.ToString();
            txtEmployeeID.ReadOnly = true;
            txtLastName.Text = cr.LastName;
            txtFirstName.Text = cr.FirstName;
            txtTitle.Text = cr.Title;
            txtTitleOfCourtesy.Text = cr.TitleOfCourtesy;
            txtBirthDate.Text = cr.BirthDate.ToString();
            txtHireDate.Text = cr.HireDate.ToString();
            txtAddress.Text = cr.Address;
            txtCity.Text = cr.City;
            txtRegion.Text = cr.Region;
            txtPostalCode.Text = cr.PostalCode;
            txtCountry.Text = cr.Country;
            txtHomePhone.Text = cr.HomePhone;
            txtExtension.Text = cr.Extension;
            txtNotes.Text = cr.Notes;
            txtReportsTo.Text = cr.ReportsTo.ToString();
            txtReportsTo.Text = cr.PhotoPath;



        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
             var db = new NorthwindEntities();
            var Employee = new Employee
            {

                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Title = txtTitle.Text,
                TitleOfCourtesy = txtTitleOfCourtesy.Text,
                BirthDate = DateTime.Parse(txtBirthDate.Text),
                HireDate = DateTime.Parse(txtHireDate.Text),
                Address = txtAddress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                HomePhone = txtHomePhone.Text,
                Extension = txtExtension.Text,
                Notes = txtNotes.Text,
                ReportsTo = int.Parse( txtReportsTo.Text),
                PhotoPath = txtReportsTo.Text
               

            };
            try
            {
                if (edicao)
                {
                    db.Employees.Attach(Employee);
                    db.Entry(Employee).State = EntityState.Modified;
                }
                else
                {
                    // Salvar n a memoria
                    db.Employees.Add(Employee);
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

            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtTitle.Text = "";
            txtTitleOfCourtesy.Text = "";
            txtBirthDate.Text = "";
            txtHireDate.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtRegion.Text = "";
            txtPostalCode.Text = "";
            txtCountry.Text = "";
            txtHomePhone.Text = "";
            txtExtension.Text = "";
            txtNotes.Text = "";
           // txtReportsTo.Text = ""
            txtReportsTo.Text = "";



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Para eExcluir, traga o registro do banco de dados e depois 
            // Exclua da memoria...
            var bd = new NorthwindEntities();
            var empregado = (from em in bd.Employees
                            where em.EmployeeID == int.Parse( txtEmployeeID.Text)
                           // where em.FirstName == txtFirstName.Text
                            select em).FirstOrDefault();

            if (empregado != null)
            {
                bd.Employees.Remove(empregado);
                try
                {
                    bd.SaveChanges();
                    MessageBox.Show("Registro Excluido com Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("O Cliente não pode ser Excluido!");
                }
            }
            else
            {
                MessageBox.Show("O Registro não foi encontrolado!");
            }

        }

        private void frmEditarEmpregado_Load(object sender, EventArgs e)
        {

        }
    }
}
