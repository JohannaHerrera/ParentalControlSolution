
namespace ParentalControlWindowsForm.Forms
{
    partial class FormSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgNotifications = new System.Windows.Forms.PictureBox();
            this.imgScheedule = new System.Windows.Forms.PictureBox();
            this.imgInfants = new System.Windows.Forms.PictureBox();
            this.imgDevice = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.idSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editSchedule = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteSchedule = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddSchedule = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.btnLogout = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.btnMyAccount = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScheedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgNotifications);
            this.panel1.Controls.Add(this.imgScheedule);
            this.panel1.Controls.Add(this.imgInfants);
            this.panel1.Controls.Add(this.imgDevice);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 566);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Notificaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mi dispositivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cuentas Infantiles";
            // 
            // imgNotifications
            // 
            this.imgNotifications.Image = global::ParentalControlWindowsForm.Properties.Resources.notificaciones;
            this.imgNotifications.Location = new System.Drawing.Point(41, 433);
            this.imgNotifications.Name = "imgNotifications";
            this.imgNotifications.Size = new System.Drawing.Size(58, 54);
            this.imgNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNotifications.TabIndex = 4;
            this.imgNotifications.TabStop = false;
            this.imgNotifications.Click += new System.EventHandler(this.imgNotifications_Click);
            // 
            // imgScheedule
            // 
            this.imgScheedule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgScheedule.Image = global::ParentalControlWindowsForm.Properties.Resources.calendario;
            this.imgScheedule.Location = new System.Drawing.Point(39, 340);
            this.imgScheedule.Name = "imgScheedule";
            this.imgScheedule.Size = new System.Drawing.Size(64, 63);
            this.imgScheedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScheedule.TabIndex = 3;
            this.imgScheedule.TabStop = false;
            this.imgScheedule.Click += new System.EventHandler(this.imgScheedule_Click);
            // 
            // imgInfants
            // 
            this.imgInfants.Image = global::ParentalControlWindowsForm.Properties.Resources.children;
            this.imgInfants.Location = new System.Drawing.Point(35, 156);
            this.imgInfants.Name = "imgInfants";
            this.imgInfants.Size = new System.Drawing.Size(68, 62);
            this.imgInfants.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInfants.TabIndex = 2;
            this.imgInfants.TabStop = false;
            this.imgInfants.Click += new System.EventHandler(this.imgInfants_Click);
            // 
            // imgDevice
            // 
            this.imgDevice.Image = global::ParentalControlWindowsForm.Properties.Resources.devices;
            this.imgDevice.Location = new System.Drawing.Point(41, 248);
            this.imgDevice.Name = "imgDevice";
            this.imgDevice.Size = new System.Drawing.Size(58, 63);
            this.imgDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDevice.TabIndex = 1;
            this.imgDevice.TabStop = false;
            this.imgDevice.Click += new System.EventHandler(this.imgDevice_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::ParentalControlWindowsForm.Properties.Resources.control_parental;
            this.imgLogo.Location = new System.Drawing.Point(22, 26);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(100, 89);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.ForeColor = System.Drawing.Color.Black;
            this.lblSchedule.Location = new System.Drawing.Point(189, 57);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(111, 29);
            this.lblSchedule.TabIndex = 2;
            this.lblSchedule.Text = "Horarios De Uso";
            this.lblSchedule.Click += new System.EventHandler(this.lblSchedule_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(170, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 3);
            this.panel2.TabIndex = 3;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.AllowUserToResizeColumns = false;
            this.dgvSchedule.AllowUserToResizeRows = false;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.ColumnHeadersVisible = false;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSchedule,
            this.StartTime,
            this.EndTime,
            this.editSchedule,
            this.deleteSchedule});
            this.dgvSchedule.GridColor = System.Drawing.Color.White;
            this.dgvSchedule.Location = new System.Drawing.Point(287, 156);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowTemplate.DividerHeight = 5;
            this.dgvSchedule.RowTemplate.Height = 50;
            this.dgvSchedule.Size = new System.Drawing.Size(450, 298);
            this.dgvSchedule.TabIndex = 29;
            this.dgvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellContentClick);
            // 
            // idSchedule
            // 
            this.idSchedule.HeaderText = "Id Horario";
            this.idSchedule.Name = "idSchedule";
            this.idSchedule.ReadOnly = true;
            this.idSchedule.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idSchedule.Visible = false;
            // 
            // StartTime
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.StartTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.StartTime.HeaderText = "Hora Inicio";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StartTime.Width = 125;
            // 
            // EndTime
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.EndTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.EndTime.HeaderText = "Hora Fin";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EndTime.Width = 125;
            // 
            // editSchedule
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.editSchedule.DefaultCellStyle = dataGridViewCellStyle4;
            this.editSchedule.HeaderText = "";
            this.editSchedule.Name = "editSchedule";
            this.editSchedule.ReadOnly = true;
            this.editSchedule.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editSchedule.Width = 95;
            // 
            // deleteSchedule
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.deleteSchedule.DefaultCellStyle = dataGridViewCellStyle5;
            this.deleteSchedule.HeaderText = "";
            this.deleteSchedule.Image = global::ParentalControlWindowsForm.Properties.Resources.delete;
            this.deleteSchedule.Name = "deleteSchedule";
            this.deleteSchedule.ReadOnly = true;
            this.deleteSchedule.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteSchedule.Width = 95;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddSchedule.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnAddSchedule.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAddSchedule.BorderRadius = 10;
            this.btnAddSchedule.BorderSize = 0;
            this.btnAddSchedule.FlatAppearance.BorderSize = 0;
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
            this.btnAddSchedule.Location = new System.Drawing.Point(465, 480);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(112, 31);
            this.btnAddSchedule.TabIndex = 28;
            this.btnAddSchedule.Text = "Agregar";
            this.btnAddSchedule.TextColor = System.Drawing.Color.White;
            this.btnAddSchedule.UseVisualStyleBackColor = false;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(716, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 31);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMyAccount.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnMyAccount.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnMyAccount.BorderRadius = 10;
            this.btnMyAccount.BorderSize = 0;
            this.btnMyAccount.FlatAppearance.BorderSize = 0;
            this.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnMyAccount.ForeColor = System.Drawing.Color.White;
            this.btnMyAccount.Location = new System.Drawing.Point(587, 13);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(112, 31);
            this.btnMyAccount.TabIndex = 26;
            this.btnMyAccount.Text = "Mi Cuenta";
            this.btnMyAccount.TextColor = System.Drawing.Color.White;
            this.btnMyAccount.UseVisualStyleBackColor = false;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(300, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Hora Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(434, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hora Fin";
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSchedule);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMyAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(450, 490);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Parental";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScheedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgNotifications;
        private System.Windows.Forms.PictureBox imgScheedule;
        private System.Windows.Forms.PictureBox imgInfants;
        private System.Windows.Forms.PictureBox imgDevice;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Panel panel2;
        private Botones_Personalizados.OurButton btnLogout;
        private Botones_Personalizados.OurButton btnMyAccount;
        private Botones_Personalizados.OurButton btnAddSchedule;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewImageColumn editSchedule;
        private System.Windows.Forms.DataGridViewImageColumn deleteSchedule;
    }
}