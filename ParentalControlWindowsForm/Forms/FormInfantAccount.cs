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
    public partial class FormInfantAccount : Form
    {
        public int parentId;
        public int infantId;
        public FormInfantAccount()
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

        private void addInfantButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormAddInfantAccount formAddInfantAccount = new FormAddInfantAccount();
                formAddInfantAccount.parentId = this.parentId;
                formAddInfantAccount.Show();
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

        private void imgDevice_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceBO deviceBO = new DeviceBO();
                string deviceCode = deviceBO.GetDeviceIdentifier();
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

        private void imgLogo_Click_1(object sender, EventArgs e)
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

        private void imgScheedule_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormSchedule formSchedule = new FormSchedule();
                formSchedule.parentId = this.parentId;
                formSchedule.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
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

        private void FormInfantAccount_Load(object sender, EventArgs e)
        {
            try
            {
             
                InfantAccountBO infantAccountBO = new InfantAccountBO();
                Constants constants = new Constants();
                List<InfantAccountModel> infantAccounts = new List<InfantAccountModel>();
                
                infantAccounts = infantAccountBO.GetInfantAccounts(this.parentId);                
               
                if (infantAccounts.Count > 0)
                {
                    foreach (var infant in infantAccounts)
                    {
                        
                        this.EditButton.Image = global::ParentalControlWindowsForm.Properties.Resources.editar_32;
                        this.delete.Image = global::ParentalControlWindowsForm.Properties.Resources.eliminar_32;
                        this.Reglas.Image = global::ParentalControlWindowsForm.Properties.Resources.flecha_32;

                        if (infant.InfantGender.Equals(constants.Femenino))
                        {
                            this.InfantImage.Image = global::ParentalControlWindowsForm.Properties.Resources.nina_64;              
                        }
                        else
                        {
                            this.InfantImage.Image = global::ParentalControlWindowsForm.Properties.Resources.hijo_64;
                        }

                        this.dtgInfantAccounts.Rows.Add(this.InfantImage.Image, infant.InfantName, this.EditButton.Image, this.delete.Image,this.Reglas.Image); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgInfantAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                InfantAccountBO infantAccountBO = new InfantAccountBO();
                this.infantId = infantAccountBO.GetInfantId(dtgInfantAccounts.CurrentRow.Cells[1].Value.ToString());
                this.Hide();
                FormEditInfantAccount formEditInfantAccount = new FormEditInfantAccount();
                formEditInfantAccount.parentId = this.parentId;
                formEditInfantAccount.infantId = this.infantId;
                formEditInfantAccount.Show();
            }
            if (e.ColumnIndex == 3)
            {
                try
                {                 
                    DialogResult res = MessageBox.Show("¿Estás seguro que deseas eliminar la cuenta de infante?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.No)
                    {
                        return;
                    }
                    if (res == DialogResult.Yes)
                    {
                        InfantAccountBO infantAccountBO = new InfantAccountBO();
                        this.infantId = infantAccountBO.GetInfantId(dtgInfantAccounts.CurrentRow.Cells[1].Value.ToString());
                        
                        if (infantAccountBO.DeleteInfantAccount(this.infantId))
                        {
                            MessageBox.Show("Se eliminó la cuenta correctamente.");
                            this.Hide();
                            FormInfantAccount formInfantAccount = new FormInfantAccount();
                            formInfantAccount.parentId = this.parentId;
                            formInfantAccount.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un problema al eliminar la cuenta infantil.");
                            this.Hide();
                            FormInfantAccount formInfantAccount = new FormInfantAccount();
                            formInfantAccount.parentId = this.parentId;
                            formInfantAccount.Show();
                        }                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.ColumnIndex == 4)
            {
                InfantAccountBO infantAccountBO = new InfantAccountBO();
                this.infantId = infantAccountBO.GetInfantId(dtgInfantAccounts.CurrentRow.Cells[1].Value.ToString());
                this.Hide();
                FormInfantRules formInfantRules = new FormInfantRules();
                formInfantRules.parentId = this.parentId;
                formInfantRules.infantId = this.infantId;
                formInfantRules.Show();
            }

        }

        private void imgNotifications_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormNotifications formNotifications = new FormNotifications();
                formNotifications.parentId = this.parentId;
                formNotifications.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
