namespace SistemaHoteleria.RecepcionistaHotel
{
    partial class ModificarHuesped
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbpais = new System.Windows.Forms.ComboBox();
            this.dtfechanac = new System.Windows.Forms.DateTimePicker();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtci = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(348, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(224, 355);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbpais
            // 
            this.cbpais.FormattingEnabled = true;
            this.cbpais.Items.AddRange(new object[] {
            "Bolivia",
            "Peru",
            "Argentina",
            "Brazil",
            "Uruguay",
            "Paraguay",
            "Chile",
            "Ecuador",
            "Venezuela"});
            this.cbpais.Location = new System.Drawing.Point(50, 247);
            this.cbpais.Name = "cbpais";
            this.cbpais.Size = new System.Drawing.Size(100, 21);
            this.cbpais.TabIndex = 16;
            // 
            // dtfechanac
            // 
            this.dtfechanac.Location = new System.Drawing.Point(50, 293);
            this.dtfechanac.Name = "dtfechanac";
            this.dtfechanac.Size = new System.Drawing.Size(100, 20);
            this.dtfechanac.TabIndex = 15;
            // 
            // txtmaterno
            // 
            this.txtmaterno.Location = new System.Drawing.Point(50, 190);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(100, 20);
            this.txtmaterno.TabIndex = 14;
            // 
            // txtpaterno
            // 
            this.txtpaterno.Location = new System.Drawing.Point(50, 144);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(100, 20);
            this.txtpaterno.TabIndex = 13;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(50, 98);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 12;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(185, 51);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 11;
            // 
            // txtci
            // 
            this.txtci.Location = new System.Drawing.Point(50, 51);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(100, 20);
            this.txtci.TabIndex = 10;
            this.txtci.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtci_KeyUp);
            // 
            // ModificarHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cbpais);
            this.Controls.Add(this.dtfechanac);
            this.Controls.Add(this.txtmaterno);
            this.Controls.Add(this.txtpaterno);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtci);
            this.Name = "ModificarHuesped";
            this.Text = "ModificarHuesped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cbpais;
        private System.Windows.Forms.DateTimePicker dtfechanac;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtci;
    }
}