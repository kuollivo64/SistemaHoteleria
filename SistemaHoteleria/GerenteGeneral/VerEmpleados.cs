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
    public partial class VerEmpleados : Form
    {
        public VerEmpleados()
        {
            InitializeComponent();
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            CargarGerentes("");
            cbTipo.SelectedIndex = 0;
        }

        public void CargarGerentes(string apellido)
        {
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

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void dgvEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}
