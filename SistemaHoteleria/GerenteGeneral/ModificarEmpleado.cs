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
    public partial class ModificarEmpleado : Form
    {
        public ModificarEmpleado()
        {
            InitializeComponent();
            limpiarCampos();
            CargarGerentes(txtFiltroApellido.text);
        }

        public void limpiarCampos()
        {
            cbTipo.SelectedIndex = 0;
            txtNombre.Text = "NOMBRE";
            txtPaterno.Text = "PATERNO";
            txtMaterno.Text = "MATERNO";
            txtEmail.Text = "E-MAIL";
            txtPregunta.Text = "PREGUNTA RECUPERACIÓN";
            txtRespuesta.Text = "RESPUESTA RECUPERACIÓN";
            dtpFechaNacimiento.Value = new DateTime(1999, 01, 01);
            lblError.Visible = false;
            txtFiltroApellido.text = "APELLIDO...";
            txtTelefono.Text = "TELEFONO";
            lblUsuario.Text = "USUARIO";
            lblContra.Text = "000000";
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

        public void CargarGerentes(string apellido)
        {
            DataTable dt = new DataTable();
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    if (apellido == "" || apellido == "APELLIDO...")
                    {
                        dgvEmpleados.DataSource = (from d in DB.Gerente
                                                   select d).ToList();
                    }
                    else
                    {
                        dgvEmpleados.DataSource = (from d in DB.Gerente
                                                   where d.paterno.StartsWith(apellido) || d.materno.StartsWith(apellido)
                                                   select d).ToList();
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR EN LA CONSULTA");
                }
            }
        }

        public void CargarRecepcionista(string apellido)
        {
            DataTable dt = new DataTable();
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    if (apellido == "" || apellido == "APELLIDO...")
                    {
                        dgvEmpleados.DataSource = (from d in DB.Recepcionista
                                                   select d).ToList();
                    }
                    else
                    {
                        dgvEmpleados.DataSource = (from d in DB.Recepcionista
                                                   where d.paterno.StartsWith(apellido) || d.materno.StartsWith(apellido)
                                                   select d).ToList();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR EN LA CONSULTA");
                }
            }
        }

        public void CargarLimpieza(string apellido)
        {
            DataTable dt = new DataTable();
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    if (apellido == "" || apellido == "APELLIDO...")
                    {
                        dgvEmpleados.DataSource = (from d in DB.Limpieza
                                                   select d).ToList();
                    }
                    else
                    {
                        dgvEmpleados.DataSource = (from d in DB.Limpieza
                                                   where d.paterno.StartsWith(apellido) || d.materno.StartsWith(apellido)
                                                   select d).ToList();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR EN LA CONSULTA");
                }
            }
        }

        public void CargarMantenimiento(string apellido)
        {
            DataTable dt = new DataTable();
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    if (apellido == "" || apellido == "APELLIDO...")
                    {
                        dgvEmpleados.DataSource = (from d in DB.Mantenimiento
                                                   select d).ToList();
                    }
                    else
                    {
                        dgvEmpleados.DataSource = (from d in DB.Mantenimiento
                                                   where d.paterno.StartsWith(apellido) || d.materno.StartsWith(apellido)
                                                   select d).ToList();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR EN LA CONSULTA");
                }
            }
        }

        private void txtNombre_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtPaterno_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void txtMaterno_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
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

        private void txtTelefono_OnValueChanged(object sender, EventArgs e)
        {
            verificarCampos();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarCampos();
            if (txtFiltroApellido.text == "APELLIDO..." || txtFiltroApellido.text == "")
            {
                switch (cbTipo.SelectedIndex)
                {
                    case 0:
                        CargarGerentes(txtFiltroApellido.text);
                        break;
                    case 1:
                        CargarMantenimiento(txtFiltroApellido.text);
                        break;
                    case 2:
                        CargarRecepcionista(txtFiltroApellido.text);
                        break;
                    case 3:
                        CargarLimpieza(txtFiltroApellido.text);
                        break;
                }
            }
        }

        private void txtFiltroApellido_Click(object sender, EventArgs e)
        {
            if (txtFiltroApellido.text == "APELLIDO...")
            {
                txtFiltroApellido.text = "";
            }
        }

        private void txtFiltroApellido_OnTextChange(object sender, EventArgs e)
        {
            switch (cbTipo.SelectedIndex)
            {
                case 0:
                    CargarGerentes(txtFiltroApellido.text);
                    break;
                case 1:
                    CargarMantenimiento(txtFiltroApellido.text);
                    break;
                case 2:
                    CargarRecepcionista(txtFiltroApellido.text);
                    break;
                case 3:
                    CargarLimpieza(txtFiltroApellido.text);
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "NOMBRE" && txtPaterno.Text != "PATERNO" && txtMaterno.Text != "MATERNO" && txtEmail.Text != "E-MAIL" && txtPregunta.Text != "PREGUNTA RECUPERACIÓN" && txtRespuesta.Text != "RESPUESTA RECUPERACIÓN" && txtTelefono.Text != "TELEFONO")
            {
                try
                {
                    switch (lblUsuario.Text[0])
                    {
                        case 'G':
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
                                DB.Entry(nuevog).State = System.Data.Entity.EntityState.Modified;
                                DB.SaveChanges();
                                MessageBox.Show("EMPLEADO MODIFICADO CON EXITO!");
                                limpiarCampos();
                                CargarGerentes("");
                            }
                            break;
                        case 'R':
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
                                DB.Entry(nuevog).State = System.Data.Entity.EntityState.Modified;
                                DB.SaveChanges();
                                MessageBox.Show("EMPLEADO MODIFICADO CON EXITO!");
                                limpiarCampos();
                                CargarRecepcionista("");
                            }
                            break;
                        case 'L':
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
                                DB.Entry(nuevog).State = System.Data.Entity.EntityState.Modified;
                                DB.SaveChanges();
                                MessageBox.Show("EMPLEADO MODIFICADO CON EXITO!");
                                limpiarCampos();
                                CargarLimpieza("");
                            }
                            break;
                        case 'M':
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
                                DB.Entry(nuevog).State = System.Data.Entity.EntityState.Modified;
                                DB.SaveChanges();
                                MessageBox.Show("EMPLEADO MODIFICADO CON EXITO!");
                                limpiarCampos();
                                CargarMantenimiento("");
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

        private void dgvEmpleados_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString();
            lblContra.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[1].Value.ToString();
            txtNombre.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[2].Value.ToString();
            txtPaterno.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[3].Value.ToString();
            txtMaterno.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[4].Value.ToString();
            txtEmail.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[5].Value.ToString();
            txtTelefono.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[6].Value.ToString();
            dtpFechaNacimiento.Value = DateTime.Parse(dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[7].Value.ToString());
            txtPregunta.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[8].Value.ToString();
            txtRespuesta.Text = dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[9].Value.ToString();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
