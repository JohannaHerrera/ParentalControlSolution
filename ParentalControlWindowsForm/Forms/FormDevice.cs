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
    public partial class FormDevice : Form
    {
        public int parentId;
        public string deviceName;

        public FormDevice()
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

        private void FormDevice_Load(object sender, EventArgs e)
        {
            try
            {
                DeviceBO deviceBO = new DeviceBO();
                WindowsAccountBO windowsAccountBO = new WindowsAccountBO();
                List<string> windowsAccounts = new List<string>();
                List<InfantAccountModel> infantAccounts = new List<InfantAccountModel>();
                List<WindowsAccountModel> windowsAccountModelList = new List<WindowsAccountModel>();
                int iterator = 0;

                this.lblDeviceName.Text = this.deviceName.ToString();
                windowsAccounts = deviceBO.GetWindowsAccounts();
                infantAccounts = deviceBO.GetInfantAccounts(this.parentId);

                if (infantAccounts.Count > 0)
                {
                    foreach (var account in infantAccounts)
                    {
                        this.cmbInfantAccount.Items.Add(account.InfantName);
                    }
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al obtener la lista de cuentas infantiles.");
                    this.Hide();
                    FormHome formHome = new FormHome();
                    formHome.parentId = this.parentId;
                    formHome.Show();
                }                

                if (windowsAccounts.Count > 0)
                {
                    foreach (var account in windowsAccounts)
                    {
                        this.dtgWindowsAccounts.Rows.Add(account);
                        windowsAccountModelList = windowsAccountBO.VerifyWindowsAccount(account);

                        // Si la cuenta Windows está registrada, se setea la cuenta Infantil vinculada
                        if (windowsAccountModelList.Count > 0)
                        {
                            string accountName = windowsAccountBO.GetInfantAccountLinked(windowsAccountModelList.FirstOrDefault().InfantAccountId);
                            
                            // Si no se obtiene la cuenta infantil vinculada se muestra el mensaje de error
                            if (string.IsNullOrEmpty(accountName))
                            {
                                MessageBox.Show("Ha ocurrido un error al obtener la lista de las cuentas Windows.");
                                this.Hide();
                                FormHome formHome = new FormHome();
                                formHome.parentId = this.parentId;
                                formHome.Show();
                            }
                            else
                            {
                                var query = (from infant in infantAccounts
                                             where infant.Equals(accountName)
                                             select infant.InfantName).FirstOrDefault();

                                int index = query.FirstOrDefault();
                                this.dtgWindowsAccounts.Rows[iterator].Cells[1].Value = this.cmbInfantAccount.Items[index];
                            }                           
                        }
                        // Sino, se deja por defecto "No Protegido"
                        else
                        {
                            this.dtgWindowsAccounts.Rows[iterator].Cells[1].Value = this.cmbInfantAccount.Items[0];
                        }

                        iterator++;
                    }
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al obtener la lista de las cuentas Windows.");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                WindowsAccountBO windowsAccountBO = new WindowsAccountBO();
                DeviceBO deviceBO = new DeviceBO();
                WindowsAccountModel windowsAccountModel = new WindowsAccountModel();
                List<WindowsAccountModel> windowsAccountModelList = new List<WindowsAccountModel>();
                Constants constants = new Constants();
                bool updateState = true;
                this.lblDeviceName.Enabled = false;
                this.lblDeviceName.BorderStyle = BorderStyle.None;

                // Se actualiza el nombre del dispositivo
                updateState = deviceBO.UpdateDeviceName(this.lblDeviceName.Text);

                foreach (DataGridViewRow row in this.dtgWindowsAccounts.Rows)
                {
                    string windowsAccountName = row.Cells[0].Value.ToString();
                    windowsAccountModelList = windowsAccountBO.VerifyWindowsAccount(windowsAccountName);
                    string infantAccountName = row.Cells[1].Value.ToString();

                    if (windowsAccountModelList.Count > 0)
                    {
                        if (!infantAccountName.Equals(constants.NoProtected.ToString()))
                        {
                            if (!windowsAccountBO.UpdateInfantAccountLinked(infantAccountName, windowsAccountName, parentId))
                            {
                                updateState = false;
                            }
                        }
                    }
                    else
                    {
                        if (!infantAccountName.Equals(constants.NoProtected.ToString()))
                        {
                            if (!windowsAccountBO.UpdateInfantAccountLinked(infantAccountName, windowsAccountName, parentId))
                            {
                                updateState = false;
                            }
                        }
                    }
                }

                if (!updateState)
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar la información. Inténtelo otra vez.");
                    return;
                }
                else
                {
                    MessageBox.Show("La información se actualizó correctamente.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lblDeviceName.Enabled)
                {
                    this.lblDeviceName.Enabled = false;
                    this.lblDeviceName.BorderStyle = BorderStyle.None;
                }
                else
                {
                    this.lblDeviceName.Enabled = true;
                    this.lblDeviceName.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.lblDeviceName.Enabled = false;
                this.lblDeviceName.BorderStyle = BorderStyle.None;

                DialogResult res = MessageBox.Show("¿Estás seguro que deseas eliminar este dispositivo?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    return;
                }
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("You have clicked Ok Button");
                    // TODO: CREAR MÉTODO PARA ELIMINAR 
                }
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
