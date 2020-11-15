using Bunifu.Framework.UI;

namespace SistemaHoteleria
{
    partial class FRecepcionista
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRecepcionista));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.pbHora = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.pbBarraMenu = new System.Windows.Forms.PictureBox();
            this.ContenedorMenu = new System.Windows.Forms.Panel();
            this.MenuItems = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnVerFacturaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNuevaFacturacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVerHabitaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerHuespedes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarHuesped = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevoHuesped = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVerReservas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelarReserva = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarReserva = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbActivos = new System.Windows.Forms.PictureBox();
            this.lblActivos = new System.Windows.Forms.Label();
            this.btnNuevaReserva = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SeparadorMenuItem = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblWara = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.pbLogoWara = new System.Windows.Forms.PictureBox();
            this.ContenedorFormularios = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogoWaraForm = new System.Windows.Forms.PictureBox();
            this.Curva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimMenuItemsStart = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimMenuItemBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MoverVentana = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Curva2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaBtnNuevo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaBtnModificar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaBtnVer = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarraMenu)).BeginInit();
            this.ContenedorMenu.SuspendLayout();
            this.MenuItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoWara)).BeginInit();
            this.ContenedorFormularios.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoWaraForm)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.lblHora);
            this.BarraSuperior.Controls.Add(this.pbHora);
            this.BarraSuperior.Controls.Add(this.lblUsuario);
            this.BarraSuperior.Controls.Add(this.pbUser);
            this.BarraSuperior.Controls.Add(this.pbRestaurar);
            this.BarraSuperior.Controls.Add(this.buttonCerrar);
            this.BarraSuperior.Controls.Add(this.pbMinimizar);
            this.BarraSuperior.Controls.Add(this.pbMaximizar);
            this.BarraSuperior.Controls.Add(this.lblRol);
            this.BarraSuperior.Controls.Add(this.pbBarraMenu);
            this.AnimMenuItemBack.SetDecoration(this.BarraSuperior, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemsStart.SetDecoration(this.BarraSuperior, BunifuAnimatorNS.DecorationType.None);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1386, 67);
            this.BarraSuperior.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(855, 26);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(123, 20);
            this.lblHora.TabIndex = 113;
            this.lblHora.Text = "HORA ACTUAL";
            // 
            // pbHora
            // 
            this.pbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimMenuItemsStart.SetDecoration(this.pbHora, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbHora, BunifuAnimatorNS.DecorationType.None);
            this.pbHora.Image = ((System.Drawing.Image)(resources.GetObject("pbHora.Image")));
            this.pbHora.Location = new System.Drawing.Point(800, 12);
            this.pbHora.Name = "pbHora";
            this.pbHora.Size = new System.Drawing.Size(40, 40);
            this.pbHora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHora.TabIndex = 112;
            this.pbHora.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(462, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(151, 20);
            this.lblUsuario.TabIndex = 111;
            this.lblUsuario.Text = "USUARIO ACTUAL";
            // 
            // pbUser
            // 
            this.AnimMenuItemsStart.SetDecoration(this.pbUser, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbUser, BunifuAnimatorNS.DecorationType.None);
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(407, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(40, 40);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 110;
            this.pbUser.TabStop = false;
            // 
            // pbRestaurar
            // 
            this.pbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimMenuItemsStart.SetDecoration(this.pbRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.pbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pbRestaurar.Image")));
            this.pbRestaurar.Location = new System.Drawing.Point(1276, 12);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(40, 40);
            this.pbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestaurar.TabIndex = 5;
            this.pbRestaurar.TabStop = false;
            this.pbRestaurar.Visible = false;
            this.pbRestaurar.Click += new System.EventHandler(this.pbRestaurar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.BackgroundImage")));
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimMenuItemsStart.SetDecoration(this.buttonCerrar, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.buttonCerrar, BunifuAnimatorNS.DecorationType.None);
            this.buttonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(1322, 12);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(40, 40);
            this.buttonCerrar.TabIndex = 109;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimMenuItemsStart.SetDecoration(this.pbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(1230, 12);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(40, 40);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 4;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimMenuItemsStart.SetDecoration(this.pbMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(1276, 12);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(40, 40);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximizar.TabIndex = 3;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pbMaximizar_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.lblRol, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.lblRol, BunifuAnimatorNS.DecorationType.None);
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRol.Location = new System.Drawing.Point(69, 25);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(139, 20);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "RECEPCIONISTA";
            // 
            // pbBarraMenu
            // 
            this.pbBarraMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.pbBarraMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbBarraMenu, BunifuAnimatorNS.DecorationType.None);
            this.pbBarraMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbBarraMenu.Image")));
            this.pbBarraMenu.Location = new System.Drawing.Point(19, 12);
            this.pbBarraMenu.Name = "pbBarraMenu";
            this.pbBarraMenu.Size = new System.Drawing.Size(40, 40);
            this.pbBarraMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarraMenu.TabIndex = 0;
            this.pbBarraMenu.TabStop = false;
            this.pbBarraMenu.Click += new System.EventHandler(this.pbBarraMenu_Click);
            // 
            // ContenedorMenu
            // 
            this.ContenedorMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ContenedorMenu.Controls.Add(this.MenuItems);
            this.AnimMenuItemBack.SetDecoration(this.ContenedorMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemsStart.SetDecoration(this.ContenedorMenu, BunifuAnimatorNS.DecorationType.None);
            this.ContenedorMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContenedorMenu.Location = new System.Drawing.Point(0, 67);
            this.ContenedorMenu.Name = "ContenedorMenu";
            this.ContenedorMenu.Size = new System.Drawing.Size(290, 721);
            this.ContenedorMenu.TabIndex = 1;
            // 
            // MenuItems
            // 
            this.MenuItems.BackColor = System.Drawing.Color.Transparent;
            this.MenuItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuItems.BackgroundImage")));
            this.MenuItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuItems.Controls.Add(this.btnVerFacturaciones);
            this.MenuItems.Controls.Add(this.btnNuevaFacturacion);
            this.MenuItems.Controls.Add(this.pictureBox3);
            this.MenuItems.Controls.Add(this.label5);
            this.MenuItems.Controls.Add(this.btnVerHabitaciones);
            this.MenuItems.Controls.Add(this.pictureBox2);
            this.MenuItems.Controls.Add(this.label4);
            this.MenuItems.Controls.Add(this.btnVerHuespedes);
            this.MenuItems.Controls.Add(this.btnModificarHuesped);
            this.MenuItems.Controls.Add(this.pictureBox1);
            this.MenuItems.Controls.Add(this.label3);
            this.MenuItems.Controls.Add(this.btnNuevoHuesped);
            this.MenuItems.Controls.Add(this.btnVerReservas);
            this.MenuItems.Controls.Add(this.btnCancelarReserva);
            this.MenuItems.Controls.Add(this.btnModificarReserva);
            this.MenuItems.Controls.Add(this.pbActivos);
            this.MenuItems.Controls.Add(this.lblActivos);
            this.MenuItems.Controls.Add(this.btnNuevaReserva);
            this.MenuItems.Controls.Add(this.SeparadorMenuItem);
            this.MenuItems.Controls.Add(this.lblWara);
            this.MenuItems.Controls.Add(this.lblHotel);
            this.MenuItems.Controls.Add(this.pbLogoWara);
            this.AnimMenuItemBack.SetDecoration(this.MenuItems, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemsStart.SetDecoration(this.MenuItems, BunifuAnimatorNS.DecorationType.None);
            this.MenuItems.GradientBottomLeft = System.Drawing.Color.Red;
            this.MenuItems.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItems.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItems.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItems.Location = new System.Drawing.Point(5, 6);
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Quality = 10;
            this.MenuItems.Size = new System.Drawing.Size(280, 927);
            this.MenuItems.TabIndex = 0;
            // 
            // btnVerFacturaciones
            // 
            this.btnVerFacturaciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerFacturaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnVerFacturaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerFacturaciones.BorderRadius = 0;
            this.btnVerFacturaciones.ButtonText = "      Ver Facturaciones";
            this.btnVerFacturaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnVerFacturaciones, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnVerFacturaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnVerFacturaciones.DisabledColor = System.Drawing.Color.Transparent;
            this.btnVerFacturaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerFacturaciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerFacturaciones.Iconimage")));
            this.btnVerFacturaciones.Iconimage_right = null;
            this.btnVerFacturaciones.Iconimage_right_Selected = null;
            this.btnVerFacturaciones.Iconimage_Selected = null;
            this.btnVerFacturaciones.IconMarginLeft = 0;
            this.btnVerFacturaciones.IconMarginRight = 0;
            this.btnVerFacturaciones.IconRightVisible = true;
            this.btnVerFacturaciones.IconRightZoom = 0D;
            this.btnVerFacturaciones.IconVisible = true;
            this.btnVerFacturaciones.IconZoom = 40D;
            this.btnVerFacturaciones.IsTab = false;
            this.btnVerFacturaciones.Location = new System.Drawing.Point(67, 869);
            this.btnVerFacturaciones.Name = "btnVerFacturaciones";
            this.btnVerFacturaciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerFacturaciones.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnVerFacturaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerFacturaciones.selected = false;
            this.btnVerFacturaciones.Size = new System.Drawing.Size(218, 48);
            this.btnVerFacturaciones.TabIndex = 133;
            this.btnVerFacturaciones.Text = "      Ver Facturaciones";
            this.btnVerFacturaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerFacturaciones.Textcolor = System.Drawing.Color.White;
            this.btnVerFacturaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnNuevaFacturacion
            // 
            this.btnNuevaFacturacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevaFacturacion.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaFacturacion.BorderRadius = 0;
            this.btnNuevaFacturacion.ButtonText = "      Facturar";
            this.btnNuevaFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnNuevaFacturacion, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnNuevaFacturacion, BunifuAnimatorNS.DecorationType.None);
            this.btnNuevaFacturacion.DisabledColor = System.Drawing.Color.Transparent;
            this.btnNuevaFacturacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevaFacturacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevaFacturacion.Iconimage")));
            this.btnNuevaFacturacion.Iconimage_right = null;
            this.btnNuevaFacturacion.Iconimage_right_Selected = null;
            this.btnNuevaFacturacion.Iconimage_Selected = null;
            this.btnNuevaFacturacion.IconMarginLeft = 0;
            this.btnNuevaFacturacion.IconMarginRight = 0;
            this.btnNuevaFacturacion.IconRightVisible = true;
            this.btnNuevaFacturacion.IconRightZoom = 0D;
            this.btnNuevaFacturacion.IconVisible = true;
            this.btnNuevaFacturacion.IconZoom = 40D;
            this.btnNuevaFacturacion.IsTab = false;
            this.btnNuevaFacturacion.Location = new System.Drawing.Point(69, 815);
            this.btnNuevaFacturacion.Name = "btnNuevaFacturacion";
            this.btnNuevaFacturacion.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNuevaFacturacion.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnNuevaFacturacion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevaFacturacion.selected = false;
            this.btnNuevaFacturacion.Size = new System.Drawing.Size(213, 48);
            this.btnNuevaFacturacion.TabIndex = 132;
            this.btnNuevaFacturacion.Text = "      Facturar";
            this.btnNuevaFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaFacturacion.Textcolor = System.Drawing.Color.White;
            this.btnNuevaFacturacion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox3
            // 
            this.AnimMenuItemsStart.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 760);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 131;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(75, 767);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 31);
            this.label5.TabIndex = 130;
            this.label5.Text = "FACTURACION";
            // 
            // btnVerHabitaciones
            // 
            this.btnVerHabitaciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerHabitaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnVerHabitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerHabitaciones.BorderRadius = 0;
            this.btnVerHabitaciones.ButtonText = "      Ver Habitaciones";
            this.btnVerHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnVerHabitaciones, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnVerHabitaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnVerHabitaciones.DisabledColor = System.Drawing.Color.Transparent;
            this.btnVerHabitaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerHabitaciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerHabitaciones.Iconimage")));
            this.btnVerHabitaciones.Iconimage_right = null;
            this.btnVerHabitaciones.Iconimage_right_Selected = null;
            this.btnVerHabitaciones.Iconimage_Selected = null;
            this.btnVerHabitaciones.IconMarginLeft = 0;
            this.btnVerHabitaciones.IconMarginRight = 0;
            this.btnVerHabitaciones.IconRightVisible = true;
            this.btnVerHabitaciones.IconRightZoom = 0D;
            this.btnVerHabitaciones.IconVisible = true;
            this.btnVerHabitaciones.IconZoom = 40D;
            this.btnVerHabitaciones.IsTab = false;
            this.btnVerHabitaciones.Location = new System.Drawing.Point(69, 695);
            this.btnVerHabitaciones.Name = "btnVerHabitaciones";
            this.btnVerHabitaciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerHabitaciones.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnVerHabitaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerHabitaciones.selected = false;
            this.btnVerHabitaciones.Size = new System.Drawing.Size(216, 48);
            this.btnVerHabitaciones.TabIndex = 129;
            this.btnVerHabitaciones.Text = "      Ver Habitaciones";
            this.btnVerHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerHabitaciones.Textcolor = System.Drawing.Color.White;
            this.btnVerHabitaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox2
            // 
            this.AnimMenuItemsStart.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 638);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(78, 645);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 31);
            this.label4.TabIndex = 125;
            this.label4.Text = "HABITACIONES";
            // 
            // btnVerHuespedes
            // 
            this.btnVerHuespedes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerHuespedes.BackColor = System.Drawing.Color.Transparent;
            this.btnVerHuespedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerHuespedes.BorderRadius = 0;
            this.btnVerHuespedes.ButtonText = "      Ver Huespedes";
            this.btnVerHuespedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnVerHuespedes, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnVerHuespedes, BunifuAnimatorNS.DecorationType.None);
            this.btnVerHuespedes.DisabledColor = System.Drawing.Color.Transparent;
            this.btnVerHuespedes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerHuespedes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerHuespedes.Iconimage")));
            this.btnVerHuespedes.Iconimage_right = null;
            this.btnVerHuespedes.Iconimage_right_Selected = null;
            this.btnVerHuespedes.Iconimage_Selected = null;
            this.btnVerHuespedes.IconMarginLeft = 0;
            this.btnVerHuespedes.IconMarginRight = 0;
            this.btnVerHuespedes.IconRightVisible = true;
            this.btnVerHuespedes.IconRightZoom = 0D;
            this.btnVerHuespedes.IconVisible = true;
            this.btnVerHuespedes.IconZoom = 40D;
            this.btnVerHuespedes.IsTab = false;
            this.btnVerHuespedes.Location = new System.Drawing.Point(69, 568);
            this.btnVerHuespedes.Name = "btnVerHuespedes";
            this.btnVerHuespedes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerHuespedes.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnVerHuespedes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerHuespedes.selected = false;
            this.btnVerHuespedes.Size = new System.Drawing.Size(216, 48);
            this.btnVerHuespedes.TabIndex = 123;
            this.btnVerHuespedes.Text = "      Ver Huespedes";
            this.btnVerHuespedes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerHuespedes.Textcolor = System.Drawing.Color.White;
            this.btnVerHuespedes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHuespedes.Click += new System.EventHandler(this.btnVerHuespedes_Click);
            // 
            // btnModificarHuesped
            // 
            this.btnModificarHuesped.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarHuesped.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarHuesped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarHuesped.BorderRadius = 0;
            this.btnModificarHuesped.ButtonText = "      Modificar";
            this.btnModificarHuesped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnModificarHuesped, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnModificarHuesped, BunifuAnimatorNS.DecorationType.None);
            this.btnModificarHuesped.DisabledColor = System.Drawing.Color.Transparent;
            this.btnModificarHuesped.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarHuesped.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificarHuesped.Iconimage")));
            this.btnModificarHuesped.Iconimage_right = null;
            this.btnModificarHuesped.Iconimage_right_Selected = null;
            this.btnModificarHuesped.Iconimage_Selected = null;
            this.btnModificarHuesped.IconMarginLeft = 0;
            this.btnModificarHuesped.IconMarginRight = 0;
            this.btnModificarHuesped.IconRightVisible = true;
            this.btnModificarHuesped.IconRightZoom = 0D;
            this.btnModificarHuesped.IconVisible = true;
            this.btnModificarHuesped.IconZoom = 40D;
            this.btnModificarHuesped.IsTab = false;
            this.btnModificarHuesped.Location = new System.Drawing.Point(69, 514);
            this.btnModificarHuesped.Name = "btnModificarHuesped";
            this.btnModificarHuesped.Normalcolor = System.Drawing.Color.Transparent;
            this.btnModificarHuesped.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnModificarHuesped.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificarHuesped.selected = false;
            this.btnModificarHuesped.Size = new System.Drawing.Size(216, 48);
            this.btnModificarHuesped.TabIndex = 122;
            this.btnModificarHuesped.Text = "      Modificar";
            this.btnModificarHuesped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarHuesped.Textcolor = System.Drawing.Color.White;
            this.btnModificarHuesped.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHuesped.Click += new System.EventHandler(this.btnModificarHuesped_Click);
            // 
            // pictureBox1
            // 
            this.AnimMenuItemsStart.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(78, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 31);
            this.label3.TabIndex = 120;
            this.label3.Text = "HUESPEDES";
            // 
            // btnNuevoHuesped
            // 
            this.btnNuevoHuesped.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevoHuesped.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoHuesped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoHuesped.BorderRadius = 0;
            this.btnNuevoHuesped.ButtonText = "      Nuevo";
            this.btnNuevoHuesped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnNuevoHuesped, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnNuevoHuesped, BunifuAnimatorNS.DecorationType.None);
            this.btnNuevoHuesped.DisabledColor = System.Drawing.Color.Transparent;
            this.btnNuevoHuesped.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevoHuesped.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevoHuesped.Iconimage")));
            this.btnNuevoHuesped.Iconimage_right = null;
            this.btnNuevoHuesped.Iconimage_right_Selected = null;
            this.btnNuevoHuesped.Iconimage_Selected = null;
            this.btnNuevoHuesped.IconMarginLeft = 0;
            this.btnNuevoHuesped.IconMarginRight = 0;
            this.btnNuevoHuesped.IconRightVisible = true;
            this.btnNuevoHuesped.IconRightZoom = 0D;
            this.btnNuevoHuesped.IconVisible = true;
            this.btnNuevoHuesped.IconZoom = 40D;
            this.btnNuevoHuesped.IsTab = false;
            this.btnNuevoHuesped.Location = new System.Drawing.Point(69, 460);
            this.btnNuevoHuesped.Name = "btnNuevoHuesped";
            this.btnNuevoHuesped.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNuevoHuesped.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnNuevoHuesped.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevoHuesped.selected = false;
            this.btnNuevoHuesped.Size = new System.Drawing.Size(216, 48);
            this.btnNuevoHuesped.TabIndex = 119;
            this.btnNuevoHuesped.Text = "      Nuevo";
            this.btnNuevoHuesped.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoHuesped.Textcolor = System.Drawing.Color.White;
            this.btnNuevoHuesped.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoHuesped.Click += new System.EventHandler(this.btnNuevoHuesped_Click);
            // 
            // btnVerReservas
            // 
            this.btnVerReservas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerReservas.BackColor = System.Drawing.Color.Transparent;
            this.btnVerReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerReservas.BorderRadius = 0;
            this.btnVerReservas.ButtonText = "      Ver Reservas";
            this.btnVerReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnVerReservas, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnVerReservas, BunifuAnimatorNS.DecorationType.None);
            this.btnVerReservas.DisabledColor = System.Drawing.Color.Transparent;
            this.btnVerReservas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerReservas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerReservas.Iconimage")));
            this.btnVerReservas.Iconimage_right = null;
            this.btnVerReservas.Iconimage_right_Selected = null;
            this.btnVerReservas.Iconimage_Selected = null;
            this.btnVerReservas.IconMarginLeft = 0;
            this.btnVerReservas.IconMarginRight = 0;
            this.btnVerReservas.IconRightVisible = true;
            this.btnVerReservas.IconRightZoom = 0D;
            this.btnVerReservas.IconVisible = true;
            this.btnVerReservas.IconZoom = 40D;
            this.btnVerReservas.IsTab = false;
            this.btnVerReservas.Location = new System.Drawing.Point(69, 348);
            this.btnVerReservas.Name = "btnVerReservas";
            this.btnVerReservas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVerReservas.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnVerReservas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerReservas.selected = false;
            this.btnVerReservas.Size = new System.Drawing.Size(216, 48);
            this.btnVerReservas.TabIndex = 118;
            this.btnVerReservas.Text = "      Ver Reservas";
            this.btnVerReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerReservas.Textcolor = System.Drawing.Color.White;
            this.btnVerReservas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReservas.Click += new System.EventHandler(this.btnVerReservas_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarReserva.BorderRadius = 0;
            this.btnCancelarReserva.ButtonText = "      Cancelar";
            this.btnCancelarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnCancelarReserva, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnCancelarReserva, BunifuAnimatorNS.DecorationType.None);
            this.btnCancelarReserva.DisabledColor = System.Drawing.Color.Transparent;
            this.btnCancelarReserva.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelarReserva.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelarReserva.Iconimage")));
            this.btnCancelarReserva.Iconimage_right = null;
            this.btnCancelarReserva.Iconimage_right_Selected = null;
            this.btnCancelarReserva.Iconimage_Selected = null;
            this.btnCancelarReserva.IconMarginLeft = 0;
            this.btnCancelarReserva.IconMarginRight = 0;
            this.btnCancelarReserva.IconRightVisible = true;
            this.btnCancelarReserva.IconRightZoom = 0D;
            this.btnCancelarReserva.IconVisible = true;
            this.btnCancelarReserva.IconZoom = 40D;
            this.btnCancelarReserva.IsTab = false;
            this.btnCancelarReserva.Location = new System.Drawing.Point(69, 294);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCancelarReserva.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancelarReserva.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelarReserva.selected = false;
            this.btnCancelarReserva.Size = new System.Drawing.Size(216, 48);
            this.btnCancelarReserva.TabIndex = 117;
            this.btnCancelarReserva.Text = "      Cancelar";
            this.btnCancelarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarReserva.Textcolor = System.Drawing.Color.White;
            this.btnCancelarReserva.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarReserva.BorderRadius = 0;
            this.btnModificarReserva.ButtonText = "      Modificar";
            this.btnModificarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnModificarReserva, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnModificarReserva, BunifuAnimatorNS.DecorationType.None);
            this.btnModificarReserva.DisabledColor = System.Drawing.Color.Transparent;
            this.btnModificarReserva.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarReserva.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificarReserva.Iconimage")));
            this.btnModificarReserva.Iconimage_right = null;
            this.btnModificarReserva.Iconimage_right_Selected = null;
            this.btnModificarReserva.Iconimage_Selected = null;
            this.btnModificarReserva.IconMarginLeft = 0;
            this.btnModificarReserva.IconMarginRight = 0;
            this.btnModificarReserva.IconRightVisible = true;
            this.btnModificarReserva.IconRightZoom = 0D;
            this.btnModificarReserva.IconVisible = true;
            this.btnModificarReserva.IconZoom = 40D;
            this.btnModificarReserva.IsTab = false;
            this.btnModificarReserva.Location = new System.Drawing.Point(69, 240);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Normalcolor = System.Drawing.Color.Transparent;
            this.btnModificarReserva.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnModificarReserva.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificarReserva.selected = false;
            this.btnModificarReserva.Size = new System.Drawing.Size(216, 48);
            this.btnModificarReserva.TabIndex = 116;
            this.btnModificarReserva.Text = "      Modificar";
            this.btnModificarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarReserva.Textcolor = System.Drawing.Color.White;
            this.btnModificarReserva.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarReserva.Click += new System.EventHandler(this.btnModificarReserva_Click);
            // 
            // pbActivos
            // 
            this.AnimMenuItemsStart.SetDecoration(this.pbActivos, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbActivos, BunifuAnimatorNS.DecorationType.None);
            this.pbActivos.Image = ((System.Drawing.Image)(resources.GetObject("pbActivos.Image")));
            this.pbActivos.Location = new System.Drawing.Point(19, 140);
            this.pbActivos.Name = "pbActivos";
            this.pbActivos.Size = new System.Drawing.Size(40, 40);
            this.pbActivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActivos.TabIndex = 115;
            this.pbActivos.TabStop = false;
            // 
            // lblActivos
            // 
            this.lblActivos.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.lblActivos, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.lblActivos, BunifuAnimatorNS.DecorationType.None);
            this.lblActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActivos.Location = new System.Drawing.Point(78, 147);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(162, 31);
            this.lblActivos.TabIndex = 114;
            this.lblActivos.Text = "RESERVAS";
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevaReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaReserva.BorderRadius = 0;
            this.btnNuevaReserva.ButtonText = "      Nueva";
            this.btnNuevaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnNuevaReserva, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnNuevaReserva, BunifuAnimatorNS.DecorationType.None);
            this.btnNuevaReserva.DisabledColor = System.Drawing.Color.Transparent;
            this.btnNuevaReserva.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevaReserva.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevaReserva.Iconimage")));
            this.btnNuevaReserva.Iconimage_right = null;
            this.btnNuevaReserva.Iconimage_right_Selected = null;
            this.btnNuevaReserva.Iconimage_Selected = null;
            this.btnNuevaReserva.IconMarginLeft = 0;
            this.btnNuevaReserva.IconMarginRight = 0;
            this.btnNuevaReserva.IconRightVisible = true;
            this.btnNuevaReserva.IconRightZoom = 0D;
            this.btnNuevaReserva.IconVisible = true;
            this.btnNuevaReserva.IconZoom = 40D;
            this.btnNuevaReserva.IsTab = false;
            this.btnNuevaReserva.Location = new System.Drawing.Point(69, 186);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNuevaReserva.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnNuevaReserva.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevaReserva.selected = false;
            this.btnNuevaReserva.Size = new System.Drawing.Size(216, 48);
            this.btnNuevaReserva.TabIndex = 113;
            this.btnNuevaReserva.Text = "      Nueva";
            this.btnNuevaReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaReserva.Textcolor = System.Drawing.Color.White;
            this.btnNuevaReserva.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // SeparadorMenuItem
            // 
            this.SeparadorMenuItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeparadorMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.AnimMenuItemBack.SetDecoration(this.SeparadorMenuItem, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemsStart.SetDecoration(this.SeparadorMenuItem, BunifuAnimatorNS.DecorationType.None);
            this.SeparadorMenuItem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SeparadorMenuItem.LineThickness = 1;
            this.SeparadorMenuItem.Location = new System.Drawing.Point(12, 108);
            this.SeparadorMenuItem.Name = "SeparadorMenuItem";
            this.SeparadorMenuItem.Size = new System.Drawing.Size(255, 1);
            this.SeparadorMenuItem.TabIndex = 112;
            this.SeparadorMenuItem.Transparency = 255;
            this.SeparadorMenuItem.Vertical = false;
            // 
            // lblWara
            // 
            this.lblWara.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.lblWara, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.lblWara, BunifuAnimatorNS.DecorationType.None);
            this.lblWara.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWara.Location = new System.Drawing.Point(101, 50);
            this.lblWara.Name = "lblWara";
            this.lblWara.Size = new System.Drawing.Size(118, 37);
            this.lblWara.TabIndex = 111;
            this.lblWara.Text = "WARA";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.lblHotel, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.lblHotel, BunifuAnimatorNS.DecorationType.None);
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHotel.Location = new System.Drawing.Point(125, 35);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(62, 20);
            this.lblHotel.TabIndex = 110;
            this.lblHotel.Text = "HOTEL";
            // 
            // pbLogoWara
            // 
            this.pbLogoWara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.pbLogoWara, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbLogoWara, BunifuAnimatorNS.DecorationType.None);
            this.pbLogoWara.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoWara.Image")));
            this.pbLogoWara.Location = new System.Drawing.Point(7, 23);
            this.pbLogoWara.Name = "pbLogoWara";
            this.pbLogoWara.Size = new System.Drawing.Size(65, 65);
            this.pbLogoWara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoWara.TabIndex = 110;
            this.pbLogoWara.TabStop = false;
            this.pbLogoWara.Click += new System.EventHandler(this.pbLogoWara_Click);
            // 
            // ContenedorFormularios
            // 
            this.ContenedorFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ContenedorFormularios.Controls.Add(this.panelFormularios);
            this.AnimMenuItemBack.SetDecoration(this.ContenedorFormularios, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemsStart.SetDecoration(this.ContenedorFormularios, BunifuAnimatorNS.DecorationType.None);
            this.ContenedorFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorFormularios.Location = new System.Drawing.Point(290, 67);
            this.ContenedorFormularios.Name = "ContenedorFormularios";
            this.ContenedorFormularios.Size = new System.Drawing.Size(1096, 721);
            this.ContenedorFormularios.TabIndex = 1;
            // 
            // panelFormularios
            // 
            this.panelFormularios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelFormularios.Controls.Add(this.label1);
            this.panelFormularios.Controls.Add(this.label2);
            this.panelFormularios.Controls.Add(this.pbLogoWaraForm);
            this.AnimMenuItemBack.SetDecoration(this.panelFormularios, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemsStart.SetDecoration(this.panelFormularios, BunifuAnimatorNS.DecorationType.None);
            this.panelFormularios.Location = new System.Drawing.Point(11, 6);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1073, 703);
            this.panelFormularios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(514, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 153);
            this.label1.TabIndex = 119;
            this.label1.Text = "WARA";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(631, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 64);
            this.label2.TabIndex = 118;
            this.label2.Text = "HOTEL";
            // 
            // pbLogoWaraForm
            // 
            this.pbLogoWaraForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnimMenuItemsStart.SetDecoration(this.pbLogoWaraForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbLogoWaraForm, BunifuAnimatorNS.DecorationType.None);
            this.pbLogoWaraForm.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoWaraForm.Image")));
            this.pbLogoWaraForm.Location = new System.Drawing.Point(135, 206);
            this.pbLogoWaraForm.Name = "pbLogoWaraForm";
            this.pbLogoWaraForm.Size = new System.Drawing.Size(300, 300);
            this.pbLogoWaraForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoWaraForm.TabIndex = 118;
            this.pbLogoWaraForm.TabStop = false;
            // 
            // Curva
            // 
            this.Curva.ElipseRadius = 35;
            this.Curva.TargetControl = this.panelFormularios;
            // 
            // AnimMenuItemsStart
            // 
            this.AnimMenuItemsStart.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimMenuItemsStart.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimMenuItemsStart.DefaultAnimation = animation1;
            // 
            // AnimMenuItemBack
            // 
            this.AnimMenuItemBack.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimMenuItemBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.AnimMenuItemBack.DefaultAnimation = animation2;
            // 
            // MoverVentana
            // 
            this.MoverVentana.Fixed = true;
            this.MoverVentana.Horizontal = true;
            this.MoverVentana.TargetControl = this.BarraSuperior;
            this.MoverVentana.Vertical = true;
            // 
            // Curva2
            // 
            this.Curva2.ElipseRadius = 35;
            this.Curva2.TargetControl = this.MenuItems;
            // 
            // CurvaBtnNuevo
            // 
            this.CurvaBtnNuevo.ElipseRadius = 20;
            this.CurvaBtnNuevo.TargetControl = this.btnNuevaReserva;
            // 
            // CurvaBtnModificar
            // 
            this.CurvaBtnModificar.ElipseRadius = 20;
            this.CurvaBtnModificar.TargetControl = this.btnModificarReserva;
            // 
            // CurvaBtnVer
            // 
            this.CurvaBtnVer.ElipseRadius = 20;
            this.CurvaBtnVer.TargetControl = this.btnCancelarReserva;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // FRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.ContenedorFormularios);
            this.Controls.Add(this.ContenedorMenu);
            this.Controls.Add(this.BarraSuperior);
            this.AnimMenuItemBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemsStart.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRecepcionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalMantenimiento";
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarraMenu)).EndInit();
            this.ContenedorMenu.ResumeLayout(false);
            this.MenuItems.ResumeLayout(false);
            this.MenuItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoWara)).EndInit();
            this.ContenedorFormularios.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoWaraForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Panel ContenedorMenu;
        private System.Windows.Forms.Panel ContenedorFormularios;
        private System.Windows.Forms.PictureBox pbBarraMenu;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbRestaurar;
        private System.Windows.Forms.Button buttonCerrar;
        private Bunifu.Framework.UI.BunifuGradientPanel MenuItems;
        private System.Windows.Forms.PictureBox pbActivos;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblWara;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.PictureBox pbLogoWara;
        private BunifuFlatButton btnCancelarReserva;
        private BunifuFlatButton btnModificarReserva;
        private BunifuFlatButton btnNuevaReserva;
        private BunifuSeparator SeparadorMenuItem;
        private BunifuElipse Curva;
        private BunifuAnimatorNS.BunifuTransition AnimMenuItemsStart;
        private BunifuAnimatorNS.BunifuTransition AnimMenuItemBack;
        private BunifuDragControl MoverVentana;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pbHora;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pbUser;
        private BunifuElipse Curva2;
        private BunifuElipse CurvaBtnNuevo;
        private BunifuElipse CurvaBtnModificar;
        private BunifuElipse CurvaBtnVer;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogoWaraForm;
        private BunifuFlatButton btnVerReservas;
        private BunifuFlatButton btnVerHabitaciones;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private BunifuFlatButton btnVerHuespedes;
        private BunifuFlatButton btnModificarHuesped;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private BunifuFlatButton btnNuevoHuesped;
        private BunifuFlatButton btnVerFacturaciones;
        private BunifuFlatButton btnNuevaFacturacion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
    }
}