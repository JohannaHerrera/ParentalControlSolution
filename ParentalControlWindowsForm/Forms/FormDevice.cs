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
        public FormDevice()
        {
            InitializeComponent();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }
    }
}
