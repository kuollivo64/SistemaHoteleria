using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHoteleria.RecepcionistaHotel;

namespace SistemaHoteleria
{
    public partial class FRecepcionista : Form
    {
        public FRecepcionista()
        {
            InitializeComponent();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbBarraMenu_Click(object sender, EventArgs e)
        {
            if (MenuItems.Width == 280)
            {
                MenuItems.Visible = false;
                MenuItems.Width = 80;
                ContenedorMenu.Width = 90;
                AnimMenuItemsStart.Show(MenuItems);
            }
            else
            {
                MenuItems.Visible = false;
                MenuItems.Width = 280;
                ContenedorMenu.Width = 290;
                AnimMenuItemsStart.Show(MenuItems);
            }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortDateString()+ " "+DateTime.Now.ToLongTimeString();
        }

        private Form activoForm = null;
        private void abrirFormsHijos(Form nuevo)
        {
            if (activoForm!=null)
            {
                activoForm.Close();
                activoForm = nuevo;
                nuevo.TopLevel = false; //esto se comportara igual que un control
                nuevo.FormBorderStyle = FormBorderStyle.None;
                nuevo.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(nuevo);
                panelFormularios.Tag = nuevo;
                nuevo.BringToFront();
                nuevo.Show();
            }
            else
            {
                activoForm = nuevo;
                nuevo.TopLevel = false; //esto se comportara igual que un control
                nuevo.FormBorderStyle = FormBorderStyle.None;
                nuevo.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(nuevo);
                panelFormularios.Tag = nuevo;
                nuevo.BringToFront();
                nuevo.Show();
            }
        }

        private void cerrarFormHijo()
        {
            if (activoForm != null)
            {
                activoForm.Close();
            }
        }

        private void pbLogoWara_Click(object sender, EventArgs e)
        {
            cerrarFormHijo();
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
            abrirFormsHijos(new NuevaReserva());
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
            abrirFormsHijos(new VerReservas());
        }
    }
}
