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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void textBoxUsuario_Click(object sender, EventArgs e)
        {
            //modificacion de los elementos del usuario
            //pictureBoxUsuario.Image = Properties.Resources.aavatar;
            panelUsuario.BackColor = Color.FromArgb(33, 164, 219);
            textBoxUsuario.ForeColor = Color.FromArgb(33, 164, 219);
            if (textBoxUsuario.Text=="Usuario")
            {
                textBoxUsuario.Text = "";
            }

            if (textBoxContrasenia.Text == "")
            {
                textBoxContrasenia.Text = "Contraseña";
            }
            //modificacion de los elementos de la contrasenia
            //pictureBoxContrasenia.Image= Properties.Resources.aaapadlock;
            panelContrasenia.BackColor = Color.FromArgb(200,200,200);
            textBoxContrasenia.ForeColor = Color.FromArgb(200,200,200);
        }

        private void textBoxContrasenia_Click(object sender, EventArgs e)
        {

            //modificacion de los elementos del contrasenia
            //pictureBoxContrasenia.Image = Properties.Resources.apadlock;
            panelContrasenia.BackColor = Color.FromArgb(33, 164, 219);
            textBoxContrasenia.ForeColor = Color.FromArgb(33, 164, 219);
            if (textBoxContrasenia.Text == "Contraseña")
            {
                textBoxContrasenia.Text = "";
            }

            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Usuario";
            }
            //modificacion de los elementos de la usuario
            //pictureBoxUsuario.Image = Properties.Resources.aaaavatar;
            panelUsuario.BackColor = Color.FromArgb(200, 200, 200);
            textBoxUsuario.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabelOlvidarContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvidasteConstrasenia olvidasteConstrasenia = new OlvidasteConstrasenia();
            Hide();
            DialogResult result = olvidasteConstrasenia.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void textBoxContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            if (textBoxContrasenia.Text != "Contraseña")
            {
                textBoxContrasenia.PasswordChar = '*';
            }
        }

        private void buttonInicioSesion_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "PM")
            {
                Hide();
                PersonalMantenimiento pm = new PersonalMantenimiento();
                DialogResult result = pm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Show();
                    lblError.Visible = false;
                }
            }
            else if(textBoxUsuario.Text == "PL")
            {
                Hide();
                PersonalLimpieza pm = new PersonalLimpieza();
                DialogResult result = pm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Show();
                    lblError.Visible = false;
                }
            }
            else if (textBoxUsuario.Text == "G")
            {
                Hide();
                FGerente pm = new FGerente();
                DialogResult result = pm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Show();
                    lblError.Visible = false;
                }
            }
            else if (textBoxUsuario.Text == "R")
            {
                Hide();
                FRecepcionista pm = new FRecepcionista();
                DialogResult result = pm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    Show();
                    lblError.Visible = false;
                }
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
