using ParentalControl.Business.BusinessBO;
using ParentalControl.Business.Enums;
using ParentalControl.Models.InfantAccount;
using ParentalControl.Models.Request;
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
    public partial class FormNotifications : Form
    {
        public int parentId;

        public FormNotifications()
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
            return;
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

        private void imgSchedule_Click_1(object sender, EventArgs e)
        {
            ScheduleBO scheduleBO = new ScheduleBO();
            FormSchedule formSchedule = new FormSchedule();
            this.Hide();
            formSchedule.Show();
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

        private void FormNotifications_Load(object sender, EventArgs e)
        {
            try
            {
                NotificationBO notificationBO = new NotificationBO();
                Constants constants = new Constants();
                InfantAccountBO infantAccountBO = new InfantAccountBO();
                List<RequestModel> requestModelList = notificationBO.GetParentNotifications(this.parentId);
                List<InfantAccountModel> infantAccounts = infantAccountBO.GetInfantAccounts(this.parentId);
                int cont = 0;

                if (requestModelList.Count > 0)
                {
                    foreach (var request in requestModelList)
                    {
                        string infantGender = infantAccounts.Where(x => x.InfantAccountId == request.InfantAccountId)
                                        .Select(x => x.InfantGender).FirstOrDefault();
                        string infantName = infantAccounts.Where(x => x.InfantAccountId == request.InfantAccountId)
                                        .Select(x => x.InfantName).FirstOrDefault();
                        string description = string.Empty;
                        int numEntero = 0;
                        int numDecimal = 0;

                        // Imagen del infante
                        if (infantGender.Equals(constants.Femenino))
                        {
                            this.imgInfant.Image = global::ParentalControlWindowsForm.Properties.Resources.nina_64;
                        }
                        else
                        {
                            this.imgInfant.Image = global::ParentalControlWindowsForm.Properties.Resources.hijo_64;
                        }

                        // Descripción de la petición
                        if (request.RequestTypeId == constants.WebConfiguration)
                        {
                            description = $"Petición para habilitar el acceso a la categoría" +
                                      $" web: {request.RequestObject}.";
                        }
                        else if (request.RequestTypeId == constants.AppConfiguration)
                        {
                            description = $"Petición para habilitar el acceso a la aplicación:" +
                                      $" {request.RequestObject}.";
                        }
                        else if (request.RequestTypeId == constants.DeviceConfiguration)
                        {
                            string[] time = request.RequestTime.ToString().Split('.');                           

                            if (time.Count() > 1)
                            {
                                numEntero = int.Parse(time[0]);
                                numDecimal = int.Parse(time[1]);
                            }
                            else
                            {
                                numEntero = int.Parse(time[0]);
                            }

                            if (numEntero > 0)
                            {
                                if (numEntero == 1)
                                {
                                    if (numDecimal > 0)
                                    {
                                        description = $"Petición para extender el tiempo de uso del " +
                                                                                  $"dispositivo por {numEntero} hora y {numDecimal}" +
                                                                                  $" minutos.";
                                    }
                                    else
                                    {
                                        description = $"Petición para extender el tiempo de uso del " +
                                          $"dispositivo por {numEntero} hora.";
                                    }
                                }
                                else
                                {
                                    if (numDecimal > 0)
                                    {
                                        description = $"Petición para extender el tiempo de uso del " +
                                          $"dispositivo por {numEntero} horas y {numDecimal}" +
                                          $" minutos.";
                                    }
                                    else
                                    {
                                        description = $"Petición para extender el tiempo de uso del " +
                                          $"dispositivo por {numEntero} horas.";
                                    }
                                }
                            }
                            else
                            {
                                description = $"Petición para extender el tiempo de uso del " +
                                          $"dispositivo por {numDecimal} minutos.";
                            }

                        }

                        // Estado de la petición
                        if (request.RequestTypeId == constants.WebConfiguration || request.RequestTypeId == constants.AppConfiguration)
                        {
                            this.dgvNotifications.Rows.Add(request.RequestObject, request.RequestTypeId,
                                      request.RequestId, this.imgInfant.Image, infantName, description);
                        }
                        else
                        {
                            string time = $"{numEntero}.{numDecimal}";
                            this.dgvNotifications.Rows.Add(time, request.RequestTypeId, request.RequestId, 
                                      this.imgInfant.Image, infantName, description);
                        }

                        DataGridViewImageCell bAccept = this.dgvNotifications.Rows[cont].Cells[6] as DataGridViewImageCell;
                        DataGridViewImageCell bNoAccept = this.dgvNotifications.Rows[cont].Cells[7] as DataGridViewImageCell;

                        if (request.RequestState == constants.RequestStateCreated)
                        {
                            bAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Aprobar;
                            bNoAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Desaprobar;

                            if (request.RequestTypeId == constants.DeviceConfiguration)
                            {
                                DateTime now = DateTime.Now;
                                
                                if (now.Date > request.RequestCreationDate.Date)
                                {
                                    RequestBO requestBO = new RequestBO();
                                    requestBO.UpdateRequest(request.RequestId, constants.RequestStateUnanswered);
                                    bAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Sin_Respuesta;
                                    bNoAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Blank;
                                    bNoAccept.Description = "Blank";
                                }                        
                            }
                        }
                        else if (request.RequestState == constants.RequestStateApproved)
                        {
                            bAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Aprobado;
                            bNoAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Blank;
                            bNoAccept.Description = "Blank";
                        }
                        else if (request.RequestState == constants.RequestStateDisapproved)
                        {
                            bAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Desaprobado;
                            bNoAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Blank;
                            bNoAccept.Description = "Blank";
                        }
                        else if (request.RequestState == constants.RequestStateUnanswered)
                        {
                            bAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Sin_Respuesta;
                            bNoAccept.Value = global::ParentalControlWindowsForm.Properties.Resources.Blank;
                            bNoAccept.Description = "Blank";
                        }

                        cont++;
                    }
                }
                else
                {
                    this.lblNoNotifications.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RequestBO requestBO = new RequestBO();
                Constants constants = new Constants();
                InfantAccountBO infantAccountBO = new InfantAccountBO();

                if(e.ColumnIndex == 6)
                {
                    DataGridViewImageCell bNoAccept = this.dgvNotifications.CurrentRow.Cells[7] as DataGridViewImageCell;
                    int requestId = Convert.ToInt32(this.dgvNotifications.CurrentRow.Cells[2].Value);
                    int requestTypeId = Convert.ToInt32(this.dgvNotifications.CurrentRow.Cells[1].Value);
                    string requestObject = this.dgvNotifications.CurrentRow.Cells[0].Value.ToString();
                    string infantName = this.dgvNotifications.CurrentRow.Cells[4].Value.ToString();
                    bool execute = false;

                    if (!(bNoAccept.Description.Equals("Blank")))
                    {
                        int infantId = infantAccountBO.GetInfantId(infantName);
                        
                        if(infantId != 0)
                        {
                            if (requestTypeId == constants.WebConfiguration)
                            {
                                if (requestBO.ApproveWebAccess(requestObject, infantId))
                                {
                                    if (requestBO.UpdateRequest(requestId, constants.RequestStateApproved))
                                    {
                                        MessageBox.Show("Petición Aprobada.");
                                        execute = true;
                                        this.Hide();
                                        FormNotifications formNotifications = new FormNotifications();
                                        formNotifications.parentId = this.parentId;
                                        formNotifications.Show();
                                    }
                                }
                            } 
                            else if (requestTypeId == constants.AppConfiguration)
                            {
                                if (requestBO.ApproveAppAccess(requestObject, infantId))
                                {
                                    if (requestBO.UpdateRequest(requestId, constants.RequestStateApproved))
                                    {
                                        MessageBox.Show("Petición Aprobada.");
                                        execute = true;
                                        this.Hide();
                                        FormNotifications formNotifications = new FormNotifications();
                                        formNotifications.parentId = this.parentId;
                                        formNotifications.Show();
                                    }
                                }
                            }
                            else if (requestTypeId == constants.DeviceConfiguration)
                            {
                                if (requestBO.UpdateRequest(requestId, constants.RequestStateApproved))
                                {
                                    MessageBox.Show("Petición Aprobada.");
                                    execute = true;
                                    this.Hide();
                                    FormNotifications formNotifications = new FormNotifications();
                                    formNotifications.parentId = this.parentId;
                                    formNotifications.Show();
                                }
                               
                            }
                        }

                        if (!execute)
                        {
                            MessageBox.Show("Ocurrió un error al aprobar la petición. Inténtalo de nuevo.");
                        }
                    }                   
                }
                else if (e.ColumnIndex == 7)
                {
                    int requestId = Convert.ToInt32(this.dgvNotifications.CurrentRow.Cells[2].Value);
                    DataGridViewImageCell bNoAccept = this.dgvNotifications.CurrentRow.Cells[7] as DataGridViewImageCell;

                    if (!(bNoAccept.Description.Equals("Blank")))
                    {
                        if (requestBO.UpdateRequest(requestId, constants.RequestStateDisapproved))
                        {
                            MessageBox.Show("Petición Desaprobada.");
                            this.Hide();
                            FormNotifications formNotifications = new FormNotifications();
                            formNotifications.parentId = this.parentId;
                            formNotifications.Show();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al desaprobar la petición. Inténtalo de nuevo.");
                        }
                    }                                      
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
