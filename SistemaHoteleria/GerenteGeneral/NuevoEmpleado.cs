using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHoteleria.Datos;

namespace SistemaHoteleria.GerenteGeneral
{
    public partial class NuevoEmpleado : Form
    {
        public NuevoEmpleado()
        {
            InitializeComponent();
            limpiarCampos();
            GenerarContrasenia();
        }

        private void UsuarioDisponible()
        {
            bool usuario = true;
            if (GenerarUsuario() != "")
            {
                while (usuario == true)
                {
                    if (ExisteUsuario(GenerarUsuario()) == false)
                    {
                        usuario = false;
                    }
                }
            }
        }

        public void limpiarCampos()
        {
            cbTipoEmpleado.SelectedIndex = 0;
            txtNombre.Text = "NOMBRE";
            txtPaterno.Text = "PATERNO";
            txtMaterno.Text = "MATERNO";
            txtEmail.Text = "E-MAIL";
            txtPregunta.Text = "PREGUNTA RECUPERACIÓN";
            txtRespuesta.Text = "RESPUESTA RECUPERACIÓN";
            dtpFechaNacimiento.Value = new DateTime(1999, 01, 01);
            lblError.Visible = false;
            lblUsuario.Text = "USUARIO";
            lblContra.Text = "000000";
            txtTelefono.Text = "TELEFONO";
        }

        public void verificarCampos()
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
            }
            if (txtPaterno.Text == "")
            {
                txtPaterno.Text = "PATERNO";
            }
            if (txtMaterno.Text == "")
            {
                txtMaterno.Text = "MATERNO";
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-MAIL";
            }
            if (txtPregunta.Text == "")
            {
                txtPregunta.Text = "PREGUNTA RECUPERACIÓN";
            }
            if (txtRespuesta.Text == "")
            {
                txtRespuesta.Text = "RESPUESTA RECUPERACIÓN";
            }
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "TELEFONO";
            }
        }

        public void GenerarContrasenia()
        {
            Random rn = new Random();
            lblContra.Text = rn.Next(100000, 999999).ToString();
        }

        public bool ExisteUsuario(string usuario)
        {
            bool existe = false;
            using (var db = new SistemaHotelWaraEntitiesV1())
            {
                switch (usuario[0])
                {
                    case 'M':
                        if (db.Mantenimiento.Find(usuario) != null) existe = true;
                        break;
                    case 'L':
                        if (db.Limpieza.Find(usuario) != null) existe = true;
                        break;
                    case 'G':
                        if (db.Gerente.Find(usuario) != null) existe = true;
                        break;
                    case 'R':
                        if (db.Recepcionista.Find(usuario) != null) existe = true;
                        break;
                }
            }
            return existe;
        }

        public string GenerarUsuario()
        {
            string usuario = "";
            if (txtNombre.Text != "" && txtPaterno.Text != "" && txtMaterno.Text != "" && cbTipoEmpleado.SelectedIndex != -1)
            {
                Random rn = new Random();
                int usuarioNumero = rn.Next(10, 99);

                if (cbTipoEmpleado.SelectedIndex == 3)
                {
                    usuario = "M" + txtNombre.Text[0] + txtPaterno.Text[0] + txtMaterno.Text[0] + usuarioNumero;
                }
                else if (cbTipoEmpleado.SelectedIndex == 2)
                {
                    usuario = "L" + txtNombre.Text[0] + txtPaterno.Text[0] + txtMaterno.Text[0] + usuarioNumero;
                }
                else if (cbTipoEmpleado.SelectedIndex == 1)
                {
                    usuario = "R" + txtNombre.Text[0] + txtPaterno.Text[0] + txtMaterno.Text[0] + usuarioNumero;
                }
                else
                {
                    usuario = "G" + txtNombre.Text[0] + txtPaterno.Text[0] + txtMaterno.Text[0] + usuarioNumero;
                }
            }
            else usuario = "";

            lblUsuario.Text = usuario.ToUpper();

            return usuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "NOMBRE" && txtPaterno.Text != "PATERNO" && txtMaterno.Text != "MATERNO" && txtEmail.Text != "E-MAIL" && txtPregunta.Text != "PREGUNTA RECUPERACIÓN" && txtRespuesta.Text != "RESPUESTA RECUPERACIÓN" && txtTelefono.Text != "TELEFONO")
            {

                try
                {
                    switch (cbTipoEmpleado.SelectedIndex)
                    {
                        case 0:
                            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                            {
                                Gerente nuevog = new Gerente();
                                nuevog.idEmpleado = lblUsuario.Text;
                                nuevog.contrasenia = lblContra.Text;
                                nuevog.nombre = txtNombre.Text;
                                nuevog.paterno = txtPaterno.Text;
                                nuevog.materno = txtMaterno.Text;
                                nuevog.email = txtEmail.Text;
                                nuevog.telefono = txtTelefono.Text;
                                nuevog.preguntaRecu = txtPregunta.Text;
                                nuevog.respuestaRecu = txtRespuesta.Text;
                                nuevog.fechaNacimiento = dtpFechaNacimiento.Value;
                                DB.Gerente.Add(nuevog);
                                DB.SaveChanges();
                                MessageBox.Show("EMPLEADO CREADO CON EXITO!");
                                limpiarCampos();
                            }
                            break;
                        case 1:
                            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                            {
                                Recepcionista nuevog = new Recepcionista();
                                nuevog.idEmpleado = lblUsuario.Text;
                                nuevog.contrasenia = lblContra.Text;
                                nuevog.nombre = txtNombre.Text;
                                nuevog.paterno = txtPaterno.Text;
                                nuevog.materno = txtMaterno.Text;
                                nuevog.email = txtEmail.Text;
                                nuevog.telefono = txtTelefono.Text;
                                nuevog.preguntaRecu = txtPregunta.Text;
                                nuevog.respuestaRecu = txtRespuesta.Text;
                                nuevog.fechaNacimiento = dtpFechaNacimiento.Value;
                                DB.Recepcionista.Add(nuevog);
                                DB.SaveChanges();
                                MessageBox.Show("EMPLEADO CREADO CON EXITO!");
                                limpiarCampos();
                            }
                            break;
                        case 2:
                            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                            {
                                Limpieza nuevog = new Limpieza();
                                nuevog.idEmpleado = lblUsuario.Text;
                                nuevog.contrasenia = lblContra.Text;
                                nuevog.nombre = txtNombre.Text;
                                nuevog.paterno = txtPaterno.Text;
                                nuevog.materno = txtMaterno.Text;
                                nuevog.email = txtEmail.Text;
                                nuevog.telefono = txtTelefono.Text;
                                nuevog.preguntaRecu = txtPregunta.Text;
                                nuevog.respuestaRecu = txtRespuesta.Text;
                                nuevog.fechaNacimiento = dtpFechaNacimiento.Value;
                                DB.Limpieza.Add(nuevog);
                                DB.SaveChanges();
                                MessageBox.Show("EMPLEADO CREADO CON EXITO!");
                                limpiarCampos();
                            }
                            break;
                        case 3:
                            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                            {
                                Mantenimiento nuevog = new Mantenimiento();
                                nuevog.idEmpleado = lblUsuario.Text;
                                nuevog.contrasenia = lblContra.Text;
                                nuevog.nombre = txtNombre.Text;
                                nuevog.paterno = txtPaterno.Text;
                                nuevog.materno = txtMaterno.Text;
                                nuevog.email = txtEmail.Text;
                                nuevog.telefono = txtTelefono.Text;
                                nuevog.preguntaRecu = txtPregunta.Text;
                                nuevog.respuestaRecu = txtRespuesta.Text;
                                nuevog.fechaNacimiento = dtpFechaNacimiento.Value;
                                DB.Mantenimiento.Add(nuevog);
                                DB.SaveChanges();
                                MessageBox.Show("EMPLEADO CREADO CON EXITO!");
                                limpiarCampos();
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR CON LA LLAVE PRIMARIA: " + ex.Message);
                }

            }
            else lblError.Visible = true;
        }

        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
            UsuarioDisponible();
        }

        private void txtPaterno_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
            UsuarioDisponible();
        }

        private void txtMaterno_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
            UsuarioDisponible();
        }

        private void txtEmail_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtPregunta_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtRespuesta_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void cbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarCampos();
            UsuarioDisponible();
        }

        private void dtpFechaNacimiento_onValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtTelefono_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }
    }
}
