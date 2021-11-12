using ParentalControl.Business.BusinessBO;
using ParentalControl.Business.Enums;
using ParentalControl.Models.Device;
using ParentalControl.Models.InfantAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControlWindowsForm.Forms
{
    public partial class FormAddInfantAccount : Form
    {
        public int parentId;
        public FormAddInfantAccount()
        {
            InitializeComponent();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormHome formHome = new FormHome();
                formHome.parentId = this.parentId;
                formHome.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormPersonalAccount formPersonalAccount = new FormPersonalAccount();
                formPersonalAccount.parentId = this.parentId;
                formPersonalAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgInfants_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormInfantAccount formInfantAccount = new FormInfantAccount();
                formInfantAccount.parentId = this.parentId;
                formInfantAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgDevice_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceBO deviceBO = new DeviceBO();
                string deviceCode = deviceBO.GetMACAddress();
                this.Hide();
                FormDevice formDevice = new FormDevice();
                formDevice.parentId = this.parentId;
                formDevice.deviceName = deviceBO.GetDeviceName(deviceCode);
                formDevice.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Se validan los datos del registro
            //    InfantAccountModel infantAccountModel = new InfantAccountModel();
            //    LoginBO loginBO = new LoginBO();

            //    registerModel.ParentUsername = txtName.Text;
            //    registerModel.ParentEmail = txtUser.Text;
            //    registerModel.ParentPassword = txtPassword.Text;

            //    string message = registerModel.Validate(registerModel);

            //    if (!string.IsNullOrEmpty(message))
            //    {
            //        MessageBox.Show(message);
            //        return;
            //    }
            //    else
            //    {
            //        // Se verifica que no exista una cuenta con el mismo correo
            //        List<RegisterModel> registerModelList = new List<RegisterModel>();
            //        registerModelList = loginBO.ValidateRegister(registerModel.ParentEmail);

            //        if (registerModelList.Count == 0)
            //        {
            //            if (loginBO.RegisterUser(registerModel))
            //            {
            //                MessageBox.Show("¡Te has registrado satisfactoriamente!");
            //                this.Hide();
            //                FormLogin formLogin = new FormLogin();
            //                formLogin.Show();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Ya existe una cuenta con el mismo correo electrónico.");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
