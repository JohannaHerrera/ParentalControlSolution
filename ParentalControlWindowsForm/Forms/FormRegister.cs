using ParentalControl.Business.BusinessBO;
using ParentalControl.Models.Login;
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

namespace ParentalControlWindowsForm.Forms
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                RegisterModel registerModel = new RegisterModel();
                LoginBO loginBO = new LoginBO();

                registerModel.Name = txtName.Text;
                registerModel.User = txtUser.Text;
                registerModel.Password = txtPassword.Text;

                string message = registerModel.Validate(registerModel);

                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message);
                    return;
                }
                else
                {
                    dataTable = loginBO.validateRegister(registerModel.User);

                    if (dataTable.Rows.Count == 0)
                    {
                        if (loginBO.registerUser(registerModel))
                        {
                            MessageBox.Show("¡Te has registrado satisfactoriamente!");
                            this.Hide();
                            FormLogin formLogin = new FormLogin();
                            formLogin.Show();
                        }                       
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una cuenta con el mismo correo electrónico.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
