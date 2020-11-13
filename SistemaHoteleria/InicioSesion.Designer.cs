namespace SistemaHoteleria
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.linkLabelOlvidarContrasenia = new System.Windows.Forms.LinkLabel();
            this.buttonInicioSesion = new System.Windows.Forms.Button();
            this.panelContrasenia = new System.Windows.Forms.Panel();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.pictureBoxContrasenia = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBoxInicioSesion = new System.Windows.Forms.PictureBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicioSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelOlvidarContrasenia
            // 
            this.linkLabelOlvidarContrasenia.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.linkLabelOlvidarContrasenia.AutoSize = true;
            this.linkLabelOlvidarContrasenia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelOlvidarContrasenia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelOlvidarContrasenia.Location = new System.Drawing.Point(130, 480);
            this.linkLabelOlvidarContrasenia.Name = "linkLabelOlvidarContrasenia";
            this.linkLabelOlvidarContrasenia.Size = new System.Drawing.Size(131, 13);
            this.linkLabelOlvidarContrasenia.TabIndex = 0;
            this.linkLabelOlvidarContrasenia.TabStop = true;
            this.linkLabelOlvidarContrasenia.Text = "¿Olvidaste tu contraseña?";
            this.linkLabelOlvidarContrasenia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOlvidarContrasenia_LinkClicked);
            // 
            // buttonInicioSesion
            // 
            this.buttonInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(219)))));
            this.buttonInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicioSesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicioSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.buttonInicioSesion.Location = new System.Drawing.Point(120, 415);
            this.buttonInicioSesion.Name = "buttonInicioSesion";
            this.buttonInicioSesion.Size = new System.Drawing.Size(150, 54);
            this.buttonInicioSesion.TabIndex = 3;
            this.buttonInicioSesion.Text = "INICIAR SESIÓN";
            this.buttonInicioSesion.UseVisualStyleBackColor = false;
            this.buttonInicioSesion.Click += new System.EventHandler(this.buttonInicioSesion_Click);
            // 
            // panelContrasenia
            // 
            this.panelContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelContrasenia.Location = new System.Drawing.Point(45, 360);
            this.panelContrasenia.Name = "panelContrasenia";
            this.panelContrasenia.Size = new System.Drawing.Size(300, 1);
            this.panelContrasenia.TabIndex = 100;
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContrasenia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.textBoxContrasenia.ForeColor = System.Drawing.Color.White;
            this.textBoxContrasenia.HideSelection = false;
            this.textBoxContrasenia.Location = new System.Drawing.Point(98, 329);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.Size = new System.Drawing.Size(207, 19);
            this.textBoxContrasenia.TabIndex = 2;
            this.textBoxContrasenia.TabStop = false;
            this.textBoxContrasenia.Text = "Contraseña";
            this.textBoxContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxContrasenia.Click += new System.EventHandler(this.textBoxContrasenia_Click);
            this.textBoxContrasenia.TextChanged += new System.EventHandler(this.textBoxContrasenia_TextChanged);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelUsuario.Location = new System.Drawing.Point(45, 288);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(300, 1);
            this.panelUsuario.TabIndex = 100;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.textBoxUsuario.ForeColor = System.Drawing.Color.White;
            this.textBoxUsuario.HideSelection = false;
            this.textBoxUsuario.Location = new System.Drawing.Point(98, 257);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(207, 19);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.TabStop = false;
            this.textBoxUsuario.Text = "Usuario";
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsuario.Click += new System.EventHandler(this.textBoxUsuario_Click);
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // pictureBoxContrasenia
            // 
            this.pictureBoxContrasenia.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxContrasenia.Image")));
            this.pictureBoxContrasenia.Location = new System.Drawing.Point(45, 324);
            this.pictureBoxContrasenia.Name = "pictureBoxContrasenia";
            this.pictureBoxContrasenia.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContrasenia.TabIndex = 14;
            this.pictureBoxContrasenia.TabStop = false;
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.InitialImage")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(45, 252);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 11;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // pictureBoxInicioSesion
            // 
            this.pictureBoxInicioSesion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInicioSesion.Image")));
            this.pictureBoxInicioSesion.Location = new System.Drawing.Point(85, 10);
            this.pictureBoxInicioSesion.Name = "pictureBoxInicioSesion";
            this.pictureBoxInicioSesion.Size = new System.Drawing.Size(220, 205);
            this.pictureBoxInicioSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInicioSesion.TabIndex = 10;
            this.pictureBoxInicioSesion.TabStop = false;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.BackgroundImage")));
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(366, 12);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(20, 20);
            this.buttonCerrar.TabIndex = 5;
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.BackgroundImage")));
            this.buttonMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.Location = new System.Drawing.Point(340, 12);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimizar.TabIndex = 4;
            this.buttonMinimizar.UseVisualStyleBackColor = true;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Malgun Gothic", 12.25F);
            this.lblError.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblError.Location = new System.Drawing.Point(63, 376);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(265, 23);
            this.lblError.TabIndex = 101;
            this.lblError.Text = "Verifique el usuario o contraseña";
            this.lblError.Visible = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(398, 530);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.buttonMinimizar);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.linkLabelOlvidarContrasenia);
            this.Controls.Add(this.buttonInicioSesion);
            this.Controls.Add(this.panelContrasenia);
            this.Controls.Add(this.textBoxContrasenia);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.pictureBoxContrasenia);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.pictureBoxInicioSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicioSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelOlvidarContrasenia;
        private System.Windows.Forms.Button buttonInicioSesion;
        private System.Windows.Forms.Panel panelContrasenia;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.PictureBox pictureBoxContrasenia;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.PictureBox pictureBoxInicioSesion;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.Label lblError;
    }
}