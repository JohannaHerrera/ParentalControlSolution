using ParentalControl.Business.BusinessBO;
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
            try
            {
                DataTable dataTable = new DataTable();
                LoginModel loginModel = new LoginModel();
                LoginBO loginBO = new LoginBO();

                loginModel.User = txtUser.Text;
                loginModel.Password = txtPassword.Text;

                string message = loginModel.Validate(loginModel);

                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message);
                    return;
                }
                else
                {
                    dataTable = loginBO.validateCredentials(loginModel);

                    if (dataTable.Rows.Count == 1)
                    {
                        this.Hide();
                        FormHome formHome = new FormHome();
                        formHome.parentId = 1;
                        formHome.Show(); 
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
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
