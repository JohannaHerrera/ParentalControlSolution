using ParentalControl.Business.BusinessBO;
using ParentalControl.Models.Device;
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
                List<LoginModel> loginModelList = new List<LoginModel>();
                LoginModel loginModel = new LoginModel();
                LoginBO loginBO = new LoginBO();

                loginModel.User = txtUser.Text;
                loginModel.Password = txtPassword.Text;

                // Valida los datos del login (campos vacíos, dirección de correo)
                string message = loginModel.Validate(loginModel);

                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message);
                    return;
                }
                else
                {        
                    // Valida las credenciales ingresadas
                    loginModelList = loginBO.validateCredentials(loginModel);                    

                    if (loginModelList.Count > 0)
                    {
                        // Si se encuentran los datos, verifica si el dispositivo está vinculado
                        List<DeviceModel> deviceModelList = new List<DeviceModel>();
                        DeviceModel deviceModel = new DeviceModel();
                        DeviceBO deviceBO = new DeviceBO();

                        deviceModel.DeviceCode = Environment.UserName;
                        deviceModel.ParentId = 1;

                        deviceModelList = deviceBO.verifyDevice(deviceModel);

                        // Si no está vinculado el dispositivo, se realiza el registro
                        if (deviceModelList.Count == 0)
                        {
                            deviceModel.DeviceName = Environment.UserName;
                            
                            // Si hay algún error se notifica
                            if (!deviceBO.registerDevice(deviceModel))
                            {
                                MessageBox.Show("Ha ocurrido un error, vuelva a intentarlo.");
                                return;
                            }
                        }

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
