using ParentalControl.Data;
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

namespace ParentalControlWindowsForm.Forms
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los datos solicitados.");
                return;
            }

            try
            {
                SqlConnection connection = SQLConexionDataBase.BuildSqlConnection();
                SqlCommand query = new SqlCommand
                    ("SELECT * FROM Parent where ParentEmail=@username and ParentPassword=@password", connection);

                query.Parameters.AddWithValue("@username", txtUser.Text);
                query.Parameters.AddWithValue("@password", txtPassword.Text);
                connection.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(query);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                connection.Close();
                int count = ds.Tables[0].Rows.Count;

                //Si el login es exitoso, ingresa a Home
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    FormHome formHome = new FormHome();
                    formHome.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
