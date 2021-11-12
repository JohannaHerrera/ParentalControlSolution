using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParentalControl.Models.Schedule;
using ParentalControl.Business.BusinessBO;

namespace ParentalControlWindowsForm.Forms
{
    public partial class FormScheduleRegister : Form
    {
        public FormScheduleRegister()
        {
            
            InitializeComponent();
          
        }
        private void FormScheduleRegister_Load(object sender, EventArgs e)
        {
            dudHora.Text = DateTime.Now.ToString("hh");
            dudMinute.Text = DateTime.Now.ToString("mm");
            dudHoraFin.Text = DateTime.Now.ToString("hh");
            dudMinuteEnd.Text = DateTime.Now.ToString("mm");
        }
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd mmmm yyy");

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("¡En proceso!");
                ScheduleModel scheduleModel = new ScheduleModel();
                ScheduleBO scheduleBO = new ScheduleBO();
                //Convertir hora inicio a int
                int ih = Convert.ToInt32(Math.Round(dudHora.Value, 0));
                ////Convertir min inicio a int
                int im = Convert.ToInt32(Math.Round(dudMinute.Value, 0));
                ////Convertir hora fin a int
                int ihf =Convert.ToInt32(Math.Round(dudHoraFin.Value, 0)); ;
                ////Convertir min fin a int
                int ime = Convert.ToInt32(Math.Round(dudMinuteEnd.Value, 0));

                scheduleModel.ScheduleStartTime = new DateTime(2021, 11, 11, ih, im, 0);
                scheduleModel.ScheduleEndTime= new DateTime(2021, 11, 11, ihf, ime, 0);


                if (scheduleBO.RegisterSchedule(scheduleModel))
                {
                    MessageBox.Show("¡Se ha registrado satisfactoriamente!");
                    this.Hide();
                    FormSchedule formSchedule = new FormSchedule();
                    formSchedule.Show();
                }
                else
                {
                    String message = ("Error en la creacion de horario");
                    MessageBox.Show(message);
                }
               
            }            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}




        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblMnts_Click(object sender, EventArgs e)
        {

        }


    
    }
}
