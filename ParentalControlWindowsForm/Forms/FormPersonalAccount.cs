using ParentalControl.Business.BusinessBO;
using ParentalControl.Models.Login;
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
    public partial class FormPersonalAccount : Form
    {
        public int parentId;

        public FormPersonalAccount()
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

        private void imgDevice_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceBO deviceBO = new DeviceBO();
                string deviceCode = deviceBO.GetMACAddress();
                this.Hide();
                FormDevice formDevice = new FormDevice();
                formDevice.deviceName = deviceBO.GetDeviceName(deviceCode);
                formDevice.parentId = this.parentId;
                formDevice.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPersonalAccount_Load(object sender, EventArgs e)
        {
            try
            {
                ParentModel parentModel = new ParentModel();
                ParentBO parentBO = new ParentBO();

                parentModel = parentBO.GetParenInformation(this.parentId);

                if (parentModel != null)
                {
                    this.txtName.Text = parentModel.ParentUsername;
                    this.txtEmail.Text = parentModel.ParentEmail;
                    this.txtPassword.Text = parentModel.ParentPassword;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al obtener la información de su cuenta.");
                    this.Hide();
                    FormHome formHome = new FormHome();
                    formHome.parentId = this.parentId;
                    formHome.Show();
                }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtName.Enabled = true;
                this.txtEmail.Enabled = true;
                this.txtPassword.Enabled = true;
                this.btnCancel.Visible = true;
                this.btnSave.Visible = true;
                this.btnEditar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ParentBO parentBO = new ParentBO();
                ParentModel parentModel = new ParentModel();
                this.txtName.Enabled = false;
                this.txtEmail.Enabled = false;
                this.txtPassword.Enabled = false;
                this.btnCancel.Visible = false;
                this.btnSave.Visible = false;
                this.btnEditar.Visible = true;

                parentModel.ParentId = this.parentId;
                parentModel.ParentUsername = this.txtName.Text;
                parentModel.ParentEmail = this.txtEmail.Text;
                parentModel.ParentPassword = this.txtPassword.Text;

                if (parentBO.UpdateParenInformation(parentModel))
                {
                    MessageBox.Show("La información se actualizó correctamente.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar la información. Inténtelo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersonalAccount formPersonalAccount = new FormPersonalAccount();
            formPersonalAccount.parentId = this.parentId;
            formPersonalAccount.Show();
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
    }
}
