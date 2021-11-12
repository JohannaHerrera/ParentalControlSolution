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
    public partial class FormSchedule : Form
    {
        public int parentId; 
       
        public FormSchedule()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSchedule_Click(object sender, EventArgs e)
        {

        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {

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

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormScheduleRegister formScheduleRegister = new FormScheduleRegister();
            //formHome.parentId = this.parentId;
            //Todas las ventanas necesitan el ID del papa?
            formScheduleRegister.Show();
        }
    }
}
