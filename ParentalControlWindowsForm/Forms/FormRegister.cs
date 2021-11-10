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
                // Se validan los datos del registro
                RegisterModel registerModel = new RegisterModel();
                LoginBO loginBO = new LoginBO();

                registerModel.ParentUsername = txtName.Text;
                registerModel.ParentEmail = txtUser.Text;
                registerModel.ParentPassword = txtPassword.Text;

                string message = registerModel.Validate(registerModel);

                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message);
                    return;
                }
                else
                {
                    // Se verifica que no exista una cuenta con el mismo correo
                    List<RegisterModel> registerModelList = new List<RegisterModel>();
                    registerModelList = loginBO.ValidateRegister(registerModel.ParentEmail);

                    if (registerModelList.Count == 0)
                    {
                        if (loginBO.RegisterUser(registerModel))
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
