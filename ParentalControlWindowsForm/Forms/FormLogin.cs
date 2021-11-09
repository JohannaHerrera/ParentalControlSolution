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
                    loginModelList = loginBO.ValidateCredentials(loginModel);                    

                    if (loginModelList.Count > 0)
                    {
                        List<DeviceModel> deviceModelList = new List<DeviceModel>();
                        DeviceModel deviceModel = new DeviceModel();
                        DeviceBO deviceBO = new DeviceBO();
                        ParentBO parentBO = new ParentBO();

                        deviceModel.DeviceCode = deviceBO.GetMACAddress();
                        deviceModel.ParentId = parentBO.GetParentId(loginModel);

                        if (deviceModel.ParentId != 0)
                        {
                            // Verifica si el dispositivo está vinculado a la cuenta del Padre
                            deviceModelList = deviceBO.VerifyDevice(deviceModel);
                                                        
                            if (deviceModelList.Count == 0)
                            {
                                // Si no está vinculado a la cuenta actual, verifica que no esté vinculado a otra cuenta
                                deviceModelList = deviceBO.VerifyDeviceExist(deviceModel.DeviceCode);

                                if (deviceModelList.Count > 0)
                                {
                                    MessageBox.Show("El dispositivo actual ya está vinculado a una cuenta.");
                                    return;
                                }
                                else
                                {
                                    deviceModel.DeviceName = Environment.MachineName;

                                    // Si hay algún error se notifica
                                    if (!deviceBO.RegisterDevice(deviceModel))
                                    {
                                        MessageBox.Show("Ha ocurrido un error, vuelva a intentarlo.");
                                        return;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, inténtelo de nuevo.");
                            return;
                        }
                        

                        // Envío el Id del Padre al FormHome                        
                        this.Hide();
                        FormHome formHome = new FormHome();
                        formHome.parentId = deviceModel.ParentId;
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
