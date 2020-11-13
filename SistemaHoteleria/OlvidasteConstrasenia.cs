using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHoteleria
{
    public partial class OlvidasteConstrasenia : Form
    {
        public OlvidasteConstrasenia()
        {
            InitializeComponent();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtRespuesta_Click(object sender, EventArgs e)
        {
            //modificacion de los elementos del usuario
            panelRespuesta.BackColor = Color.FromArgb(33, 164, 219);
            txtRespuesta.ForeColor = Color.FromArgb(33, 164, 219);
            if (txtRespuesta.Text == "Respuesta")
            {
                txtRespuesta.Text = "";
            }
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {
            if (txtRespuesta.Text == "Galva")
            {
                buttonRecuperar.Visible = true;
                gbContrasenia.Visible = true;
                gbRespuesta.Visible = false;
            }
            else
            {
                buttonRecuperar.Visible = false;
                gbContrasenia.Visible = false;
                gbRespuesta.Visible = true;
            }
        }

        private void buttonRecuperar_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_Click(object sender, EventArgs e)
        {
            //modificacion de los elementos del contrasenia
            //pictureBoxContrasenia.Image = Properties.Resources.apadlock;
            panelContrasenia.BackColor = Color.FromArgb(33, 164, 219);
            txtContrasenia.ForeColor = Color.FromArgb(33, 164, 219);
            if (txtContrasenia.Text == "Nueva Contraseña")
            {
                txtContrasenia.Text = "";
            }

            if (txtConfirmar.Text == "")
            {
                txtConfirmar.Text = "Confirme Contraseña";
            }
            //modificacion de los elementos de la usuario
            //pictureBoxUsuario.Image = Properties.Resources.aaaavatar;
            panelConfirmar.BackColor = Color.FromArgb(200, 200, 200);
            txtConfirmar.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void txtConfirmar_Click(object sender, EventArgs e)
        {
            //modificacion de los elementos del contrasenia
            //pictureBoxContrasenia.Image = Properties.Resources.apadlock;
            panelConfirmar.BackColor = Color.FromArgb(33, 164, 219);
            txtConfirmar.ForeColor = Color.FromArgb(33, 164, 219);
            if (txtConfirmar.Text == "Confirme Contraseña")
            {
                txtConfirmar.Text = "";
            }

            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "Nueva Contraseña";
            }
            //modificacion de los elementos de la usuario
            //pictureBoxUsuario.Image = Properties.Resources.aaaavatar;
            panelContrasenia.BackColor = Color.FromArgb(200, 200, 200);
            txtContrasenia.ForeColor = Color.FromArgb(200, 200, 200);
        }
    }
}
