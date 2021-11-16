
using ParentalControl.Business.BusinessBO;

namespace ParentalControlWindowsForm.Forms
{
    partial class FormDevice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgWindowsAccounts = new System.Windows.Forms.DataGridView();
            this.WindowsAccounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbInfantAccount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgNotifications = new System.Windows.Forms.PictureBox();
            this.imgScheedule = new System.Windows.Forms.PictureBox();
            this.imgInfants = new System.Windows.Forms.PictureBox();
            this.imgDevice = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.lblDeviceName = new System.Windows.Forms.TextBox();
            this.btnLogout = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.btnMyAccount = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.btnSave = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWindowsAccounts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScheedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgWindowsAccounts);
            this.panel1.Location = new System.Drawing.Point(250, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 315);
            this.panel1.TabIndex = 0;
            // 
            // dtgWindowsAccounts
            // 
            this.dtgWindowsAccounts.AllowUserToAddRows = false;
            this.dtgWindowsAccounts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtgWindowsAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgWindowsAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dtgWindowsAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgWindowsAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtgWindowsAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgWindowsAccounts.ColumnHeadersHeight = 5;
            this.dtgWindowsAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgWindowsAccounts.ColumnHeadersVisible = false;
            this.dtgWindowsAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WindowsAccounts,
            this.cmbInfantAccount});
            this.dtgWindowsAccounts.EnableHeadersVisualStyles = false;
            this.dtgWindowsAccounts.GridColor = System.Drawing.Color.White;
            this.dtgWindowsAccounts.Location = new System.Drawing.Point(0, 3);
            this.dtgWindowsAccounts.Name = "dtgWindowsAccounts";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtgWindowsAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgWindowsAccounts.RowHeadersVisible = false;
            this.dtgWindowsAccounts.RowHeadersWidth = 220;
            this.dtgWindowsAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtgWindowsAccounts.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgWindowsAccounts.RowTemplate.DividerHeight = 5;
            this.dtgWindowsAccounts.RowTemplate.Height = 50;
            this.dtgWindowsAccounts.Size = new System.Drawing.Size(516, 305);
            this.dtgWindowsAccounts.TabIndex = 0;
            // 
            // WindowsAccounts
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            this.WindowsAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.WindowsAccounts.FillWeight = 250F;
            this.WindowsAccounts.HeaderText = "Cuentas Windows";
            this.WindowsAccounts.MinimumWidth = 100;
            this.WindowsAccounts.Name = "WindowsAccounts";
            this.WindowsAccounts.Width = 250;
            // 
            // cmbInfantAccount
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 9, 5, 9);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.cmbInfantAccount.DefaultCellStyle = dataGridViewCellStyle4;
            this.cmbInfantAccount.FillWeight = 200F;
            this.cmbInfantAccount.HeaderText = "Cuentas Infantiles";
            this.cmbInfantAccount.MaxDropDownItems = 10;
            this.cmbInfantAccount.MinimumWidth = 100;
            this.cmbInfantAccount.Name = "cmbInfantAccount";
            this.cmbInfantAccount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmbInfantAccount.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.imgNotifications);
            this.panel2.Controls.Add(this.imgScheedule);
            this.panel2.Controls.Add(this.imgInfants);
            this.panel2.Controls.Add(this.imgDevice);
            this.panel2.Controls.Add(this.imgLogo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 566);
            this.panel2.TabIndex = 1;
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
            // 
            // imgScheedule
            // 
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(170, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 2);
            this.panel3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cuentas Windows";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cuentas Infantiles";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::ParentalControlWindowsForm.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(487, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 26);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::ParentalControlWindowsForm.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(450, 59);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 26);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEdit.TabIndex = 9;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.BackColor = System.Drawing.Color.White;
            this.lblDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDeviceName.Enabled = false;
            this.lblDeviceName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(189, 57);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(236, 28);
            this.lblDeviceName.TabIndex = 11;
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
            this.btnLogout.TabIndex = 28;
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
            this.btnMyAccount.TabIndex = 27;
            this.btnMyAccount.Text = "Mi Cuenta";
            this.btnMyAccount.TextColor = System.Drawing.Color.White;
            this.btnMyAccount.UseVisualStyleBackColor = false;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(441, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 31);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMyAccount);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Parental";
            this.Load += new System.EventHandler(this.FormDevice_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgWindowsAccounts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScheedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgNotifications;
        private System.Windows.Forms.PictureBox imgScheedule;
        private System.Windows.Forms.PictureBox imgInfants;
        private System.Windows.Forms.PictureBox imgDevice;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.DataGridView dtgWindowsAccounts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.TextBox lblDeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WindowsAccounts;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbInfantAccount;
        private Botones_Personalizados.OurButton btnLogout;
        private Botones_Personalizados.OurButton btnMyAccount;
        private Botones_Personalizados.OurButton btnSave;
    }
}