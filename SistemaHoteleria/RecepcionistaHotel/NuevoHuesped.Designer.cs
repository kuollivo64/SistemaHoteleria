namespace SistemaHoteleria.RecepcionistaHotel
{
    partial class NuevoHuesped
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
            this.txtci = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.dtfechanac = new System.Windows.Forms.DateTimePicker();
            this.cbpais = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtci
            // 
            this.txtci.Location = new System.Drawing.Point(33, 50);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(100, 20);
            this.txtci.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(168, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(33, 97);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // txtpaterno
            // 
            this.txtpaterno.Location = new System.Drawing.Point(33, 143);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(100, 20);
            this.txtpaterno.TabIndex = 3;
            // 
            // txtmaterno
            // 
            this.txtmaterno.Location = new System.Drawing.Point(33, 189);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(100, 20);
            this.txtmaterno.TabIndex = 4;
            // 
            // dtfechanac
            // 
            this.dtfechanac.Location = new System.Drawing.Point(33, 292);
            this.dtfechanac.Name = "dtfechanac";
            this.dtfechanac.Size = new System.Drawing.Size(100, 20);
            this.dtfechanac.TabIndex = 6;
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
            this.cbpais.Location = new System.Drawing.Point(33, 246);
            this.cbpais.Name = "cbpais";
            this.cbpais.Size = new System.Drawing.Size(100, 21);
            this.cbpais.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(207, 354);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(331, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // NuevoHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbpais);
            this.Controls.Add(this.dtfechanac);
            this.Controls.Add(this.txtmaterno);
            this.Controls.Add(this.txtpaterno);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtci);
            this.Name = "NuevoHuesped";
            this.Text = "NuevoHuesped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.DateTimePicker dtfechanac;
        private System.Windows.Forms.ComboBox cbpais;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}