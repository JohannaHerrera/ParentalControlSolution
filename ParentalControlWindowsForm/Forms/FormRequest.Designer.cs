
namespace ParentalControlWindowsForm.Forms
{
    partial class FormRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequest));
            this.lblRequestTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRequestType = new System.Windows.Forms.ComboBox();
            this.pnlRequest = new System.Windows.Forms.Panel();
            this.cmbObject = new System.Windows.Forms.ComboBox();
            this.lblObject = new System.Windows.Forms.Label();
            this.lblNoProtected = new System.Windows.Forms.Label();
            this.ptBoxCheck = new System.Windows.Forms.PictureBox();
            this.ptBoxRequestImage = new System.Windows.Forms.PictureBox();
            this.Line = new System.Windows.Forms.Panel();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbHours = new System.Windows.Forms.ComboBox();
            this.cmbMinutes = new System.Windows.Forms.ComboBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnSendRequest = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.btnLogin = new ParentalControlWindowsForm.Botones_Personalizados.OurButton();
            this.lblNoNotifications = new System.Windows.Forms.Label();
            this.pnlRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxRequestImage)).BeginInit();
            this.pnlNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequestTitle
            // 
            this.lblRequestTitle.AutoSize = true;
            this.lblRequestTitle.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRequestTitle.Location = new System.Drawing.Point(186, 61);
            this.lblRequestTitle.Name = "lblRequestTitle";
            this.lblRequestTitle.Size = new System.Drawing.Size(171, 43);
            this.lblRequestTitle.TabIndex = 1;
            this.lblRequestTitle.Text = "Peticiones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.panel1.Location = new System.Drawing.Point(45, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 4);
            this.panel1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Selecciona el tipo de petición que deseas realizar:";
            // 
            // cmbRequestType
            // 
            this.cmbRequestType.BackColor = System.Drawing.Color.White;
            this.cmbRequestType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRequestType.FormattingEnabled = true;
            this.cmbRequestType.Location = new System.Drawing.Point(13, 104);
            this.cmbRequestType.Name = "cmbRequestType";
            this.cmbRequestType.Size = new System.Drawing.Size(197, 24);
            this.cmbRequestType.TabIndex = 53;
            this.cmbRequestType.SelectedIndexChanged += new System.EventHandler(this.cmbRequestType_SelectedIndexChanged);
            // 
            // pnlRequest
            // 
            this.pnlRequest.BackColor = System.Drawing.Color.White;
            this.pnlRequest.Controls.Add(this.lblMinutes);
            this.pnlRequest.Controls.Add(this.lblHours);
            this.pnlRequest.Controls.Add(this.cmbMinutes);
            this.pnlRequest.Controls.Add(this.cmbHours);
            this.pnlRequest.Controls.Add(this.btnSendRequest);
            this.pnlRequest.Controls.Add(this.cmbObject);
            this.pnlRequest.Controls.Add(this.lblObject);
            this.pnlRequest.Controls.Add(this.label3);
            this.pnlRequest.Controls.Add(this.cmbRequestType);
            this.pnlRequest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlRequest.Location = new System.Drawing.Point(421, 156);
            this.pnlRequest.Name = "pnlRequest";
            this.pnlRequest.Size = new System.Drawing.Size(377, 355);
            this.pnlRequest.TabIndex = 54;
            // 
            // cmbObject
            // 
            this.cmbObject.BackColor = System.Drawing.Color.White;
            this.cmbObject.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObject.FormattingEnabled = true;
            this.cmbObject.Location = new System.Drawing.Point(13, 212);
            this.cmbObject.Name = "cmbObject";
            this.cmbObject.Size = new System.Drawing.Size(197, 24);
            this.cmbObject.TabIndex = 55;
            this.cmbObject.Visible = false;
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblObject.Location = new System.Drawing.Point(10, 161);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(176, 18);
            this.lblObject.TabIndex = 54;
            this.lblObject.Text = "Selecciona la categoría:";
            this.lblObject.Visible = false;
            // 
            // lblNoProtected
            // 
            this.lblNoProtected.AutoSize = true;
            this.lblNoProtected.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoProtected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblNoProtected.Location = new System.Drawing.Point(382, 3);
            this.lblNoProtected.Name = "lblNoProtected";
            this.lblNoProtected.Size = new System.Drawing.Size(425, 58);
            this.lblNoProtected.TabIndex = 55;
            this.lblNoProtected.Text = "¡El usuario actual no está protegido\r\ncon el Sistema de Control Parental!";
            // 
            // ptBoxCheck
            // 
            this.ptBoxCheck.Image = global::ParentalControlWindowsForm.Properties.Resources.okay;
            this.ptBoxCheck.Location = new System.Drawing.Point(767, 444);
            this.ptBoxCheck.Name = "ptBoxCheck";
            this.ptBoxCheck.Size = new System.Drawing.Size(116, 115);
            this.ptBoxCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBoxCheck.TabIndex = 56;
            this.ptBoxCheck.TabStop = false;
            // 
            // ptBoxRequestImage
            // 
            this.ptBoxRequestImage.Image = global::ParentalControlWindowsForm.Properties.Resources.control_parental;
            this.ptBoxRequestImage.Location = new System.Drawing.Point(70, 1);
            this.ptBoxRequestImage.Name = "ptBoxRequestImage";
            this.ptBoxRequestImage.Size = new System.Drawing.Size(110, 103);
            this.ptBoxRequestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBoxRequestImage.TabIndex = 0;
            this.ptBoxRequestImage.TabStop = false;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.Line.Location = new System.Drawing.Point(401, 150);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(4, 370);
            this.Line.TabIndex = 51;
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.Controls.Add(this.lblNoNotifications);
            this.pnlNotifications.Controls.Add(this.dgvNotifications);
            this.pnlNotifications.Controls.Add(this.label1);
            this.pnlNotifications.Location = new System.Drawing.Point(70, 154);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(316, 357);
            this.pnlNotifications.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(90, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = "Notificaciones";
            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotifications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifications.ColumnHeadersVisible = false;
            this.dgvNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Request,
            this.State});
            this.dgvNotifications.GridColor = System.Drawing.Color.White;
            this.dgvNotifications.Location = new System.Drawing.Point(4, 43);
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.RowHeadersVisible = false;
            this.dgvNotifications.Size = new System.Drawing.Size(309, 310);
            this.dgvNotifications.TabIndex = 58;
            // 
            // Request
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Request.DefaultCellStyle = dataGridViewCellStyle1;
            this.Request.HeaderText = "Petición";
            this.Request.Name = "Request";
            this.Request.ReadOnly = true;
            this.Request.Width = 200;
            // 
            // State
            // 
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.State.DefaultCellStyle = dataGridViewCellStyle2;
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // cmbHours
            // 
            this.cmbHours.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHours.FormattingEnabled = true;
            this.cmbHours.Location = new System.Drawing.Point(13, 212);
            this.cmbHours.Name = "cmbHours";
            this.cmbHours.Size = new System.Drawing.Size(66, 24);
            this.cmbHours.TabIndex = 57;
            this.cmbHours.Visible = false;
            // 
            // cmbMinutes
            // 
            this.cmbMinutes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinutes.FormattingEnabled = true;
            this.cmbMinutes.Location = new System.Drawing.Point(144, 212);
            this.cmbMinutes.Name = "cmbMinutes";
            this.cmbMinutes.Size = new System.Drawing.Size(66, 24);
            this.cmbMinutes.TabIndex = 58;
            this.cmbMinutes.Visible = false;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(85, 219);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(47, 17);
            this.lblHours.TabIndex = 59;
            this.lblHours.Text = "Horas";
            this.lblHours.Visible = false;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(216, 219);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(58, 17);
            this.lblMinutes.TabIndex = 60;
            this.lblMinutes.Text = "Minutos";
            this.lblMinutes.Visible = false;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.btnSendRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(181)))), ((int)(((byte)(126)))));
            this.btnSendRequest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSendRequest.BorderRadius = 10;
            this.btnSendRequest.BorderSize = 0;
            this.btnSendRequest.FlatAppearance.BorderSize = 0;
            this.btnSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.ForeColor = System.Drawing.Color.White;
            this.btnSendRequest.Location = new System.Drawing.Point(268, 264);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(109, 71);
            this.btnSendRequest.TabIndex = 56;
            this.btnSendRequest.Text = "Enviar Petición";
            this.btnSendRequest.TextColor = System.Drawing.Color.White;
            this.btnSendRequest.UseVisualStyleBackColor = false;
            this.btnSendRequest.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundColor = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 3;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(219)))), ((int)(((byte)(251)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Location = new System.Drawing.Point(705, 85);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Iniciar Sesión como Padre";
            this.btnLogin.TextColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblNoNotifications
            // 
            this.lblNoNotifications.AutoSize = true;
            this.lblNoNotifications.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lblNoNotifications.Location = new System.Drawing.Point(98, 155);
            this.lblNoNotifications.Name = "lblNoNotifications";
            this.lblNoNotifications.Size = new System.Drawing.Size(125, 66);
            this.lblNoNotifications.TabIndex = 59;
            this.lblNoNotifications.Text = "Aún no tienes\r\nninguna\r\nnotificación";
            this.lblNoNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoNotifications.Visible = false;
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlNotifications);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.lblNoProtected);
            this.Controls.Add(this.ptBoxCheck);
            this.Controls.Add(this.pnlRequest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblRequestTitle);
            this.Controls.Add(this.ptBoxRequestImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Parental";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            this.pnlRequest.ResumeLayout(false);
            this.pnlRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxRequestImage)).EndInit();
            this.pnlNotifications.ResumeLayout(false);
            this.pnlNotifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Botones_Personalizados.OurButton btnLogin;
        private System.Windows.Forms.Label lblRequestTitle;
        private System.Windows.Forms.PictureBox ptBoxRequestImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRequestType;
        private System.Windows.Forms.Panel pnlRequest;
        private System.Windows.Forms.Label lblNoProtected;
        private System.Windows.Forms.PictureBox ptBoxCheck;
        private System.Windows.Forms.ComboBox cmbObject;
        private System.Windows.Forms.Label lblObject;
        private Botones_Personalizados.OurButton btnSendRequest;
        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNotifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.ComboBox cmbMinutes;
        private System.Windows.Forms.ComboBox cmbHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblNoNotifications;
    }
}