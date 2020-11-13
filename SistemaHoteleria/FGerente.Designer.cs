using Bunifu.Framework.UI;

namespace SistemaHoteleria
{
    partial class FGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGerente));
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
            this.btnVerHabitaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdministrarTipos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarHabitacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevaHabitacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnual = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMensual = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSemanal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDespedir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbActivos = new System.Windows.Forms.PictureBox();
            this.lblActivos = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.lblRol.Size = new System.Drawing.Size(87, 20);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "GERENTE";
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
            this.MenuItems.Controls.Add(this.btnVerHabitaciones);
            this.MenuItems.Controls.Add(this.btnAdministrarTipos);
            this.MenuItems.Controls.Add(this.btnModificarHabitacion);
            this.MenuItems.Controls.Add(this.pictureBox2);
            this.MenuItems.Controls.Add(this.label4);
            this.MenuItems.Controls.Add(this.btnNuevaHabitacion);
            this.MenuItems.Controls.Add(this.btnAnual);
            this.MenuItems.Controls.Add(this.btnMensual);
            this.MenuItems.Controls.Add(this.pictureBox1);
            this.MenuItems.Controls.Add(this.label3);
            this.MenuItems.Controls.Add(this.btnSemanal);
            this.MenuItems.Controls.Add(this.bunifuFlatButton1);
            this.MenuItems.Controls.Add(this.btnDespedir);
            this.MenuItems.Controls.Add(this.btnModificar);
            this.MenuItems.Controls.Add(this.pbActivos);
            this.MenuItems.Controls.Add(this.lblActivos);
            this.MenuItems.Controls.Add(this.btnNuevo);
            this.MenuItems.Controls.Add(this.SeparadorMenuItem);
            this.MenuItems.Controls.Add(this.lblWara);
            this.MenuItems.Controls.Add(this.lblHotel);
            this.MenuItems.Controls.Add(this.pbLogoWara);
            this.AnimMenuItemBack.SetDecoration(this.MenuItems, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemsStart.SetDecoration(this.MenuItems, BunifuAnimatorNS.DecorationType.None);
            this.MenuItems.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(204)))), ((int)(((byte)(179)))));
            this.MenuItems.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItems.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItems.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItems.Location = new System.Drawing.Point(5, 6);
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Quality = 10;
            this.MenuItems.Size = new System.Drawing.Size(280, 927);
            this.MenuItems.TabIndex = 0;
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
            this.btnVerHabitaciones.Location = new System.Drawing.Point(69, 846);
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
            this.btnVerHabitaciones.Click += new System.EventHandler(this.btnVerHabitaciones_Click);
            // 
            // btnAdministrarTipos
            // 
            this.btnAdministrarTipos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdministrarTipos.BackColor = System.Drawing.Color.Transparent;
            this.btnAdministrarTipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdministrarTipos.BorderRadius = 0;
            this.btnAdministrarTipos.ButtonText = "      Administrar tipos";
            this.btnAdministrarTipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnAdministrarTipos, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnAdministrarTipos, BunifuAnimatorNS.DecorationType.None);
            this.btnAdministrarTipos.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAdministrarTipos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdministrarTipos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdministrarTipos.Iconimage")));
            this.btnAdministrarTipos.Iconimage_right = null;
            this.btnAdministrarTipos.Iconimage_right_Selected = null;
            this.btnAdministrarTipos.Iconimage_Selected = null;
            this.btnAdministrarTipos.IconMarginLeft = 0;
            this.btnAdministrarTipos.IconMarginRight = 0;
            this.btnAdministrarTipos.IconRightVisible = true;
            this.btnAdministrarTipos.IconRightZoom = 0D;
            this.btnAdministrarTipos.IconVisible = true;
            this.btnAdministrarTipos.IconZoom = 40D;
            this.btnAdministrarTipos.IsTab = false;
            this.btnAdministrarTipos.Location = new System.Drawing.Point(69, 792);
            this.btnAdministrarTipos.Name = "btnAdministrarTipos";
            this.btnAdministrarTipos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdministrarTipos.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnAdministrarTipos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdministrarTipos.selected = false;
            this.btnAdministrarTipos.Size = new System.Drawing.Size(216, 48);
            this.btnAdministrarTipos.TabIndex = 128;
            this.btnAdministrarTipos.Text = "      Administrar tipos";
            this.btnAdministrarTipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrarTipos.Textcolor = System.Drawing.Color.White;
            this.btnAdministrarTipos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarTipos.Click += new System.EventHandler(this.btnAdministrarTipos_Click);
            // 
            // btnModificarHabitacion
            // 
            this.btnModificarHabitacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarHabitacion.BorderRadius = 0;
            this.btnModificarHabitacion.ButtonText = "      Modificar Habitacion";
            this.btnModificarHabitacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnModificarHabitacion, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnModificarHabitacion, BunifuAnimatorNS.DecorationType.None);
            this.btnModificarHabitacion.DisabledColor = System.Drawing.Color.Transparent;
            this.btnModificarHabitacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarHabitacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificarHabitacion.Iconimage")));
            this.btnModificarHabitacion.Iconimage_right = null;
            this.btnModificarHabitacion.Iconimage_right_Selected = null;
            this.btnModificarHabitacion.Iconimage_Selected = null;
            this.btnModificarHabitacion.IconMarginLeft = 0;
            this.btnModificarHabitacion.IconMarginRight = 0;
            this.btnModificarHabitacion.IconRightVisible = true;
            this.btnModificarHabitacion.IconRightZoom = 0D;
            this.btnModificarHabitacion.IconVisible = true;
            this.btnModificarHabitacion.IconZoom = 40D;
            this.btnModificarHabitacion.IsTab = false;
            this.btnModificarHabitacion.Location = new System.Drawing.Point(69, 738);
            this.btnModificarHabitacion.Name = "btnModificarHabitacion";
            this.btnModificarHabitacion.Normalcolor = System.Drawing.Color.Transparent;
            this.btnModificarHabitacion.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnModificarHabitacion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificarHabitacion.selected = false;
            this.btnModificarHabitacion.Size = new System.Drawing.Size(216, 48);
            this.btnModificarHabitacion.TabIndex = 127;
            this.btnModificarHabitacion.Text = "      Modificar Habitacion";
            this.btnModificarHabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarHabitacion.Textcolor = System.Drawing.Color.White;
            this.btnModificarHabitacion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHabitacion.Click += new System.EventHandler(this.btnModificarHabitacion_Click);
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
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 125;
            this.label4.Text = "MI HOTEL";
            // 
            // btnNuevaHabitacion
            // 
            this.btnNuevaHabitacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevaHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaHabitacion.BorderRadius = 0;
            this.btnNuevaHabitacion.ButtonText = "      Nueva Habitacion";
            this.btnNuevaHabitacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnNuevaHabitacion, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnNuevaHabitacion, BunifuAnimatorNS.DecorationType.None);
            this.btnNuevaHabitacion.DisabledColor = System.Drawing.Color.Transparent;
            this.btnNuevaHabitacion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevaHabitacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevaHabitacion.Iconimage")));
            this.btnNuevaHabitacion.Iconimage_right = null;
            this.btnNuevaHabitacion.Iconimage_right_Selected = null;
            this.btnNuevaHabitacion.Iconimage_Selected = null;
            this.btnNuevaHabitacion.IconMarginLeft = 0;
            this.btnNuevaHabitacion.IconMarginRight = 0;
            this.btnNuevaHabitacion.IconRightVisible = true;
            this.btnNuevaHabitacion.IconRightZoom = 0D;
            this.btnNuevaHabitacion.IconVisible = true;
            this.btnNuevaHabitacion.IconZoom = 40D;
            this.btnNuevaHabitacion.IsTab = false;
            this.btnNuevaHabitacion.Location = new System.Drawing.Point(69, 684);
            this.btnNuevaHabitacion.Name = "btnNuevaHabitacion";
            this.btnNuevaHabitacion.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNuevaHabitacion.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnNuevaHabitacion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevaHabitacion.selected = false;
            this.btnNuevaHabitacion.Size = new System.Drawing.Size(216, 48);
            this.btnNuevaHabitacion.TabIndex = 124;
            this.btnNuevaHabitacion.Text = "      Nueva Habitacion";
            this.btnNuevaHabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaHabitacion.Textcolor = System.Drawing.Color.White;
            this.btnNuevaHabitacion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaHabitacion.Click += new System.EventHandler(this.btnNuevaHabitacion_Click);
            // 
            // btnAnual
            // 
            this.btnAnual.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnual.BackColor = System.Drawing.Color.Transparent;
            this.btnAnual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnual.BorderRadius = 0;
            this.btnAnual.ButtonText = "      Anual";
            this.btnAnual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnAnual, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnAnual, BunifuAnimatorNS.DecorationType.None);
            this.btnAnual.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAnual.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnual.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAnual.Iconimage")));
            this.btnAnual.Iconimage_right = null;
            this.btnAnual.Iconimage_right_Selected = null;
            this.btnAnual.Iconimage_Selected = null;
            this.btnAnual.IconMarginLeft = 0;
            this.btnAnual.IconMarginRight = 0;
            this.btnAnual.IconRightVisible = true;
            this.btnAnual.IconRightZoom = 0D;
            this.btnAnual.IconVisible = true;
            this.btnAnual.IconZoom = 40D;
            this.btnAnual.IsTab = false;
            this.btnAnual.Location = new System.Drawing.Point(69, 568);
            this.btnAnual.Name = "btnAnual";
            this.btnAnual.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAnual.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnAnual.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnual.selected = false;
            this.btnAnual.Size = new System.Drawing.Size(216, 48);
            this.btnAnual.TabIndex = 123;
            this.btnAnual.Text = "      Anual";
            this.btnAnual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnual.Textcolor = System.Drawing.Color.White;
            this.btnAnual.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnual.Click += new System.EventHandler(this.btnAnual_Click);
            // 
            // btnMensual
            // 
            this.btnMensual.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMensual.BackColor = System.Drawing.Color.Transparent;
            this.btnMensual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMensual.BorderRadius = 0;
            this.btnMensual.ButtonText = "      Mensual";
            this.btnMensual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnMensual, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnMensual, BunifuAnimatorNS.DecorationType.None);
            this.btnMensual.DisabledColor = System.Drawing.Color.Transparent;
            this.btnMensual.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMensual.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMensual.Iconimage")));
            this.btnMensual.Iconimage_right = null;
            this.btnMensual.Iconimage_right_Selected = null;
            this.btnMensual.Iconimage_Selected = null;
            this.btnMensual.IconMarginLeft = 0;
            this.btnMensual.IconMarginRight = 0;
            this.btnMensual.IconRightVisible = true;
            this.btnMensual.IconRightZoom = 0D;
            this.btnMensual.IconVisible = true;
            this.btnMensual.IconZoom = 40D;
            this.btnMensual.IsTab = false;
            this.btnMensual.Location = new System.Drawing.Point(69, 514);
            this.btnMensual.Name = "btnMensual";
            this.btnMensual.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMensual.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnMensual.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMensual.selected = false;
            this.btnMensual.Size = new System.Drawing.Size(216, 48);
            this.btnMensual.TabIndex = 122;
            this.btnMensual.Text = "      Mensual";
            this.btnMensual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensual.Textcolor = System.Drawing.Color.White;
            this.btnMensual.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensual.Click += new System.EventHandler(this.btnMensual_Click);
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
            this.label3.Size = new System.Drawing.Size(212, 31);
            this.label3.TabIndex = 120;
            this.label3.Text = "ESTADISTICAS";
            // 
            // btnSemanal
            // 
            this.btnSemanal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSemanal.BackColor = System.Drawing.Color.Transparent;
            this.btnSemanal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSemanal.BorderRadius = 0;
            this.btnSemanal.ButtonText = "      Semanal";
            this.btnSemanal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnSemanal, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnSemanal, BunifuAnimatorNS.DecorationType.None);
            this.btnSemanal.DisabledColor = System.Drawing.Color.Transparent;
            this.btnSemanal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSemanal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSemanal.Iconimage")));
            this.btnSemanal.Iconimage_right = null;
            this.btnSemanal.Iconimage_right_Selected = null;
            this.btnSemanal.Iconimage_Selected = null;
            this.btnSemanal.IconMarginLeft = 0;
            this.btnSemanal.IconMarginRight = 0;
            this.btnSemanal.IconRightVisible = true;
            this.btnSemanal.IconRightZoom = 0D;
            this.btnSemanal.IconVisible = true;
            this.btnSemanal.IconZoom = 40D;
            this.btnSemanal.IsTab = false;
            this.btnSemanal.Location = new System.Drawing.Point(69, 460);
            this.btnSemanal.Name = "btnSemanal";
            this.btnSemanal.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSemanal.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnSemanal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSemanal.selected = false;
            this.btnSemanal.Size = new System.Drawing.Size(216, 48);
            this.btnSemanal.TabIndex = 119;
            this.btnSemanal.Text = "      Semanal";
            this.btnSemanal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSemanal.Textcolor = System.Drawing.Color.White;
            this.btnSemanal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemanal.Click += new System.EventHandler(this.btnSemanal_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      Ver Empleados";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(69, 348);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(216, 48);
            this.bunifuFlatButton1.TabIndex = 118;
            this.bunifuFlatButton1.Text = "      Ver Empleados";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnDespedir
            // 
            this.btnDespedir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDespedir.BackColor = System.Drawing.Color.Transparent;
            this.btnDespedir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDespedir.BorderRadius = 0;
            this.btnDespedir.ButtonText = "      Despedir";
            this.btnDespedir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnDespedir, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnDespedir, BunifuAnimatorNS.DecorationType.None);
            this.btnDespedir.DisabledColor = System.Drawing.Color.Transparent;
            this.btnDespedir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDespedir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDespedir.Iconimage")));
            this.btnDespedir.Iconimage_right = null;
            this.btnDespedir.Iconimage_right_Selected = null;
            this.btnDespedir.Iconimage_Selected = null;
            this.btnDespedir.IconMarginLeft = 0;
            this.btnDespedir.IconMarginRight = 0;
            this.btnDespedir.IconRightVisible = true;
            this.btnDespedir.IconRightZoom = 0D;
            this.btnDespedir.IconVisible = true;
            this.btnDespedir.IconZoom = 40D;
            this.btnDespedir.IsTab = false;
            this.btnDespedir.Location = new System.Drawing.Point(69, 294);
            this.btnDespedir.Name = "btnDespedir";
            this.btnDespedir.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDespedir.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnDespedir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDespedir.selected = false;
            this.btnDespedir.Size = new System.Drawing.Size(216, 48);
            this.btnDespedir.TabIndex = 117;
            this.btnDespedir.Text = "      Despedir";
            this.btnDespedir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespedir.Textcolor = System.Drawing.Color.White;
            this.btnDespedir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespedir.Click += new System.EventHandler(this.btnDespedir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.ButtonText = "      Modificar";
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnModificar, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnModificar, BunifuAnimatorNS.DecorationType.None);
            this.btnModificar.DisabledColor = System.Drawing.Color.Transparent;
            this.btnModificar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificar.Iconimage")));
            this.btnModificar.Iconimage_right = null;
            this.btnModificar.Iconimage_right_Selected = null;
            this.btnModificar.Iconimage_Selected = null;
            this.btnModificar.IconMarginLeft = 0;
            this.btnModificar.IconMarginRight = 0;
            this.btnModificar.IconRightVisible = true;
            this.btnModificar.IconRightZoom = 0D;
            this.btnModificar.IconVisible = true;
            this.btnModificar.IconZoom = 40D;
            this.btnModificar.IsTab = false;
            this.btnModificar.Location = new System.Drawing.Point(69, 240);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnModificar.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnModificar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModificar.selected = false;
            this.btnModificar.Size = new System.Drawing.Size(216, 48);
            this.btnModificar.TabIndex = 116;
            this.btnModificar.Text = "      Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Textcolor = System.Drawing.Color.White;
            this.btnModificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.lblActivos.Size = new System.Drawing.Size(182, 31);
            this.lblActivos.TabIndex = 114;
            this.lblActivos.Text = "EMPLEADOS";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 0;
            this.btnNuevo.ButtonText = "      Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnNuevo, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnNuevo, BunifuAnimatorNS.DecorationType.None);
            this.btnNuevo.DisabledColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Iconimage")));
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 0;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 40D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(69, 186);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(216, 48);
            this.btnNuevo.TabIndex = 113;
            this.btnNuevo.Text = "      Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.CurvaBtnNuevo.TargetControl = this.btnNuevo;
            // 
            // CurvaBtnModificar
            // 
            this.CurvaBtnModificar.ElipseRadius = 20;
            this.CurvaBtnModificar.TargetControl = this.btnModificar;
            // 
            // CurvaBtnVer
            // 
            this.CurvaBtnVer.ElipseRadius = 20;
            this.CurvaBtnVer.TargetControl = this.btnDespedir;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // FGerente
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
            this.Name = "FGerente";
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
        private BunifuFlatButton btnDespedir;
        private BunifuFlatButton btnModificar;
        private BunifuFlatButton btnNuevo;
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
        private BunifuFlatButton bunifuFlatButton1;
        private BunifuFlatButton btnVerHabitaciones;
        private BunifuFlatButton btnAdministrarTipos;
        private BunifuFlatButton btnModificarHabitacion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private BunifuFlatButton btnNuevaHabitacion;
        private BunifuFlatButton btnAnual;
        private BunifuFlatButton btnMensual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private BunifuFlatButton btnSemanal;
    }
}