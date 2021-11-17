
namespace ParentalControlWindowsForm.Forms
{
    partial class FormInfantAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfantAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addInfantButton = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.dtgInfantAccounts = new System.Windows.Forms.DataGridView();
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
            this.lblInfantAccount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnLogout = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.btnMyAccount = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.InfantImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.InfantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Reglas = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfantAccounts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScheedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addInfantButton);
            this.panel1.Controls.Add(this.dtgInfantAccounts);
            this.panel1.Location = new System.Drawing.Point(215, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 315);
            this.panel1.TabIndex = 0;
            // 
            // addInfantButton
            // 
            this.addInfantButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addInfantButton.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.addInfantButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addInfantButton.BorderRadius = 20;
            this.addInfantButton.BorderSize = 0;
            this.addInfantButton.FlatAppearance.BorderSize = 0;
            this.addInfantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addInfantButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInfantButton.ForeColor = System.Drawing.Color.White;
            this.addInfantButton.Image = global::ParentalControlWindowsForm.Properties.Resources.AddInfantAccount;
            this.addInfantButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addInfantButton.Location = new System.Drawing.Point(415, 128);
            this.addInfantButton.Name = "addInfantButton";
            this.addInfantButton.Size = new System.Drawing.Size(187, 78);
            this.addInfantButton.TabIndex = 2;
            this.addInfantButton.Text = "   Agregar Hijo";
            this.addInfantButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addInfantButton.TextColor = System.Drawing.Color.White;
            this.addInfantButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addInfantButton.UseVisualStyleBackColor = false;
            this.addInfantButton.Click += new System.EventHandler(this.addInfantButton_Click);
            // 
            // dtgInfantAccounts
            // 
            this.dtgInfantAccounts.AllowUserToAddRows = false;
            this.dtgInfantAccounts.AllowUserToDeleteRows = false;
            this.dtgInfantAccounts.BackgroundColor = System.Drawing.Color.White;
            this.dtgInfantAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgInfantAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgInfantAccounts.ColumnHeadersHeight = 50;
            this.dtgInfantAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgInfantAccounts.ColumnHeadersVisible = false;
            this.dtgInfantAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfantImage,
            this.InfantName,
            this.EditButton,
            this.delete,
            this.Reglas});
            this.dtgInfantAccounts.EnableHeadersVisualStyles = false;
            this.dtgInfantAccounts.GridColor = System.Drawing.Color.White;
            this.dtgInfantAccounts.Location = new System.Drawing.Point(3, 3);
            this.dtgInfantAccounts.Name = "dtgInfantAccounts";
            this.dtgInfantAccounts.ReadOnly = true;
            this.dtgInfantAccounts.RowHeadersVisible = false;
            this.dtgInfantAccounts.RowHeadersWidth = 60;
            this.dtgInfantAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgInfantAccounts.RowTemplate.DividerHeight = 10;
            this.dtgInfantAccounts.RowTemplate.Height = 80;
            this.dtgInfantAccounts.Size = new System.Drawing.Size(406, 309);
            this.dtgInfantAccounts.TabIndex = 0;
            this.dtgInfantAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInfantAccounts_CellContentClick);
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
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click_1);
            // 
            // lblInfantAccount
            // 
            this.lblInfantAccount.AutoSize = true;
            this.lblInfantAccount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfantAccount.Location = new System.Drawing.Point(189, 57);
            this.lblInfantAccount.Name = "lblInfantAccount";
            this.lblInfantAccount.Size = new System.Drawing.Size(599, 29);
            this.lblInfantAccount.TabIndex = 2;
            this.lblInfantAccount.Text = "Selecciona la cuenta infantil que desees configurar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(170, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 2);
            this.panel3.TabIndex = 5;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::ParentalControlWindowsForm.Properties.Resources.editar_32;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
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
            this.btnLogout.Location = new System.Drawing.Point(725, 12);
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
            this.btnMyAccount.Location = new System.Drawing.Point(596, 12);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(112, 31);
            this.btnMyAccount.TabIndex = 26;
            this.btnMyAccount.Text = "Mi Cuenta";
            this.btnMyAccount.TextColor = System.Drawing.Color.White;
            this.btnMyAccount.UseVisualStyleBackColor = false;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // InfantImage
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.InfantImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.InfantImage.HeaderText = "Imagen";
            this.InfantImage.Name = "InfantImage";
            this.InfantImage.ReadOnly = true;
            this.InfantImage.Width = 70;
            // 
            // InfantName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.InfantName.DefaultCellStyle = dataGridViewCellStyle2;
            this.InfantName.HeaderText = "Nombre Infante";
            this.InfantName.Name = "InfantName";
            this.InfantName.ReadOnly = true;
            this.InfantName.Width = 150;
            // 
            // EditButton
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.EditButton.HeaderText = "Editar";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Width = 70;
            // 
            // delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete.HeaderText = "Eliminar";
            this.delete.Image = global::ParentalControlWindowsForm.Properties.Resources.editar_32;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 70;
            // 
            // Reglas
            // 
            this.Reglas.HeaderText = "Reglas";
            this.Reglas.Name = "Reglas";
            this.Reglas.ReadOnly = true;
            this.Reglas.Width = 70;
            // 
            // FormInfantAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMyAccount);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblInfantAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfantAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Parental";
            this.Load += new System.EventHandler(this.FormInfantAccount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfantAccounts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScheedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
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
        private System.Windows.Forms.Label lblInfantAccount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgInfantAccounts;
        private Botones_Personalizados.OurButton addInfantButton;
        private Botones_Personalizados.OurButton btnLogout;
        private Botones_Personalizados.OurButton btnMyAccount;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn InfantImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfantName;
        private System.Windows.Forms.DataGridViewImageColumn EditButton;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewImageColumn Reglas;
    }
}