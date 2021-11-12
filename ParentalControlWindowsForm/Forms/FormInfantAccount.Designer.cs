
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addInfantButton = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(250, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 315);
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
            this.addInfantButton.ForeColor = System.Drawing.Color.White;
            this.addInfantButton.Image = global::ParentalControlWindowsForm.Properties.Resources.AddInfantAccount;
            this.addInfantButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addInfantButton.Location = new System.Drawing.Point(304, 127);
            this.addInfantButton.Name = "addInfantButton";
            this.addInfantButton.Size = new System.Drawing.Size(157, 79);
            this.addInfantButton.TabIndex = 2;
            this.addInfantButton.Text = "Agregar Hijo";
            this.addInfantButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addInfantButton.TextColor = System.Drawing.Color.White;
            this.addInfantButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addInfantButton.UseVisualStyleBackColor = false;
            this.addInfantButton.Click += new System.EventHandler(this.addInfantButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 309);
            this.dataGridView1.TabIndex = 0;
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
            // 
            // lblInfantAccount
            // 
            this.lblInfantAccount.AutoSize = true;
            this.lblInfantAccount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfantAccount.Location = new System.Drawing.Point(198, 59);
            this.lblInfantAccount.Name = "lblInfantAccount";
            this.lblInfantAccount.Size = new System.Drawing.Size(599, 29);
            this.lblInfantAccount.TabIndex = 2;
            this.lblInfantAccount.Text = "Selecciona la cuenta infantil que desees configurar";
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMyAccount.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyAccount.ForeColor = System.Drawing.Color.White;
            this.btnMyAccount.Location = new System.Drawing.Point(587, 13);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(109, 31);
            this.btnMyAccount.TabIndex = 3;
            this.btnMyAccount.Text = "Mi Cuenta";
            this.btnMyAccount.UseVisualStyleBackColor = false;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(716, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 31);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(170, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 2);
            this.panel3.TabIndex = 5;
            // 
            // FormInfantAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMyAccount);
            this.Controls.Add(this.lblInfantAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfantAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Parental";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnMyAccount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Botones_Personalizados.OurButton addInfantButton;
    }
}