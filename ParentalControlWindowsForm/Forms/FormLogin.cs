using ParentalControl.Models.Login;
using ParentalControlWindowsForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControlWindowsForm
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            LoginModel loginModel = new LoginModel();
            LoginBO loginBO = new LoginBO();

            loginModel.User = txtUser.Text;
            loginModel.Password = txtPassword.Text;


            if (loginModel.User == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Por favor, ingrese su correo y contraseña");
                return;
            }

            try
            {
                string query = $"SELECT * FROM Parent WHERE ParentEmail = {txtUser.Text}" +
                               $"AND ParentPassword = {txtPassword.Text}";

                DataSet dataSet = SQLConexionDataBase.Query(query);

                int count = dataSet.Tables[0].Rows.Count;

                //Si el login es exitoso, ingresa a Home
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    FormHome formHome = new FormHome();
                    formHome.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormRegister formRegister = new FormRegister();
                formRegister.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
