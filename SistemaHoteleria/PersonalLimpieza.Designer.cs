using Bunifu.Framework.UI;

namespace SistemaHoteleria
{
    partial class PersonalLimpieza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalLimpieza));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
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
            this.btnVer = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.BarraSuperior.Size = new System.Drawing.Size(1400, 67);
            this.BarraSuperior.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.lblHora, BunifuAnimatorNS.DecorationType.None);
            this.lblHora.Font = new System.Drawing.Font("SEA GARDENS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(869, 26);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(112, 15);
            this.lblHora.TabIndex = 113;
            this.lblHora.Text = "HORA ACTUAL";
            // 
            // pbHora
            // 
            this.pbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimMenuItemsStart.SetDecoration(this.pbHora, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbHora, BunifuAnimatorNS.DecorationType.None);
            this.pbHora.Image = ((System.Drawing.Image)(resources.GetObject("pbHora.Image")));
            this.pbHora.Location = new System.Drawing.Point(814, 12);
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
            this.lblUsuario.Font = new System.Drawing.Font("SEA GARDENS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(462, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(137, 15);
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
            this.pbRestaurar.Location = new System.Drawing.Point(1290, 12);
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
            this.buttonCerrar.Location = new System.Drawing.Point(1336, 12);
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
            this.pbMinimizar.Location = new System.Drawing.Point(1244, 12);
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
            this.pbMaximizar.Location = new System.Drawing.Point(1290, 12);
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
            this.lblRol.Font = new System.Drawing.Font("SEA GARDENS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRol.Location = new System.Drawing.Point(69, 25);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(188, 15);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "PERSONAL DE LIMPIEZA";
            // 
            // pbBarraMenu
            // 
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
            this.ContenedorMenu.Size = new System.Drawing.Size(290, 933);
            this.ContenedorMenu.TabIndex = 1;
            // 
            // MenuItems
            // 
            this.MenuItems.BackColor = System.Drawing.Color.Transparent;
            this.MenuItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuItems.BackgroundImage")));
            this.MenuItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuItems.Controls.Add(this.btnVer);
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
            this.MenuItems.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.MenuItems.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItems.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItems.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MenuItems.Location = new System.Drawing.Point(5, 6);
            this.MenuItems.Name = "MenuItems";
            this.MenuItems.Quality = 10;
            this.MenuItems.Size = new System.Drawing.Size(280, 927);
            this.MenuItems.TabIndex = 0;
            // 
            // btnVer
            // 
            this.btnVer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVer.BackColor = System.Drawing.Color.Transparent;
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.BorderRadius = 0;
            this.btnVer.ButtonText = "      Ver Habitaciones";
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimMenuItemsStart.SetDecoration(this.btnVer, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.btnVer, BunifuAnimatorNS.DecorationType.None);
            this.btnVer.DisabledColor = System.Drawing.Color.Transparent;
            this.btnVer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVer.Iconimage")));
            this.btnVer.Iconimage_right = null;
            this.btnVer.Iconimage_right_Selected = null;
            this.btnVer.Iconimage_Selected = null;
            this.btnVer.IconMarginLeft = 0;
            this.btnVer.IconMarginRight = 0;
            this.btnVer.IconRightVisible = true;
            this.btnVer.IconRightZoom = 0D;
            this.btnVer.IconVisible = true;
            this.btnVer.IconZoom = 40D;
            this.btnVer.IsTab = false;
            this.btnVer.Location = new System.Drawing.Point(69, 294);
            this.btnVer.Name = "btnVer";
            this.btnVer.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVer.OnHovercolor = System.Drawing.SystemColors.WindowFrame;
            this.btnVer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVer.selected = false;
            this.btnVer.Size = new System.Drawing.Size(206, 48);
            this.btnVer.TabIndex = 117;
            this.btnVer.Text = "      Ver Habitaciones";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Textcolor = System.Drawing.Color.White;
            this.btnVer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.ButtonText = "      Modificar Registro";
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
            this.btnModificar.Size = new System.Drawing.Size(206, 48);
            this.btnModificar.TabIndex = 116;
            this.btnModificar.Text = "      Modificar Registro";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Textcolor = System.Drawing.Color.White;
            this.btnModificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pbActivos
            // 
            this.pbActivos.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.lblActivos.Font = new System.Drawing.Font("SEA GARDENS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActivos.Location = new System.Drawing.Point(78, 147);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(192, 26);
            this.lblActivos.TabIndex = 114;
            this.lblActivos.Text = "HABITACIONES";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 0;
            this.btnNuevo.ButtonText = "      Nuevo Registro";
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
            this.btnNuevo.Size = new System.Drawing.Size(206, 48);
            this.btnNuevo.TabIndex = 113;
            this.btnNuevo.Text = "      Nuevo Registro";
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
            this.lblWara.Font = new System.Drawing.Font("SEA GARDENS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWara.Location = new System.Drawing.Point(101, 50);
            this.lblWara.Name = "lblWara";
            this.lblWara.Size = new System.Drawing.Size(105, 29);
            this.lblWara.TabIndex = 111;
            this.lblWara.Text = "WARA";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.lblHotel, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.lblHotel, BunifuAnimatorNS.DecorationType.None);
            this.lblHotel.Font = new System.Drawing.Font("SEA GARDENS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHotel.Location = new System.Drawing.Point(125, 35);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(57, 15);
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
            this.ContenedorFormularios.Size = new System.Drawing.Size(1110, 933);
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
            this.panelFormularios.Size = new System.Drawing.Size(1087, 915);
            this.panelFormularios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("SEA GARDENS", 100F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(521, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 121);
            this.label1.TabIndex = 119;
            this.label1.Text = "WARA";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.AnimMenuItemsStart.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("SEA GARDENS", 42F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(638, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 51);
            this.label2.TabIndex = 118;
            this.label2.Text = "HOTEL";
            // 
            // pbLogoWaraForm
            // 
            this.pbLogoWaraForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnimMenuItemsStart.SetDecoration(this.pbLogoWaraForm, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemBack.SetDecoration(this.pbLogoWaraForm, BunifuAnimatorNS.DecorationType.None);
            this.pbLogoWaraForm.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoWaraForm.Image")));
            this.pbLogoWaraForm.Location = new System.Drawing.Point(142, 312);
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
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.AnimMenuItemsStart.DefaultAnimation = animation3;
            // 
            // AnimMenuItemBack
            // 
            this.AnimMenuItemBack.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimMenuItemBack.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.AnimMenuItemBack.DefaultAnimation = animation4;
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
            this.CurvaBtnVer.TargetControl = this.btnVer;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // PersonalLimpieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 1000);
            this.Controls.Add(this.ContenedorFormularios);
            this.Controls.Add(this.ContenedorMenu);
            this.Controls.Add(this.BarraSuperior);
            this.AnimMenuItemBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimMenuItemsStart.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalLimpieza";
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
        private BunifuFlatButton btnVer;
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
    }
}