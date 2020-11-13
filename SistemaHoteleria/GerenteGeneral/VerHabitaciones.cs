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
    public partial class VerHabitaciones : Form
    {
        public VerHabitaciones()
        {
            InitializeComponent();
        }

        public void CargarHabitaciones()
        {
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    if (txtFiltroId.text == "TODOS")
                    {
                        dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                      join dh in DB.DetalleHabitacion on h.idHabitacion equals dh.idDetalleHabitacion
                                                      select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado, dh.idTipo }
                                                      ).ToList();
                    }
                    else if (txtFiltroId.text == "" || txtFiltroId.text == "ID...")
                    {
                        decimal precio = 5000;
                        int nroCamas = 1;
                        if (cbPrecioMenos.SelectedItem != null && cbNroCamas.SelectedItem != null)
                        {
                            precio = decimal.Parse(cbPrecioMenos.SelectedItem.ToString());
                            nroCamas = int.Parse(cbNroCamas.SelectedItem.ToString());
                        }
                        dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                      join dh in DB.DetalleHabitacion on h.idHabitacion equals dh.idDetalleHabitacion
                                                      where dh.idTipo == cbFiltroTipo.SelectedValue.ToString() &&
                                                      h.estado == cbEstado.SelectedItem.ToString() &&
                                                      h.precio.Value <= precio &&
                                                      h.nroCamas.Value == nroCamas
                                                      select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado, dh.idTipo }
                                                      ).ToList();
                    }
                    else
                    {
                        decimal precio = 5000;
                        int nroCamas = 1;
                        if (cbPrecioMenos.SelectedItem != null && cbNroCamas.SelectedItem != null)
                        {
                            precio = decimal.Parse(cbPrecioMenos.SelectedItem.ToString());
                            nroCamas = int.Parse(cbNroCamas.SelectedItem.ToString());
                        }
                        dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                      join dh in DB.DetalleHabitacion on h.idHabitacion equals dh.idDetalleHabitacion
                                                      where h.idHabitacion.StartsWith(txtFiltroId.text) &&
                                                      dh.idTipo == cbFiltroTipo.SelectedValue.ToString() &&
                                                      h.estado == cbEstado.SelectedItem.ToString() &&
                                                      h.precio.Value <= precio &&
                                                      h.nroCamas.Value == nroCamas
                                                      select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado, dh.idTipo }
                                                      ).ToList();
                    }

                }
                catch (Exception)
                {
                }
            }
        }

        private void txtFiltroId_OnTextChange(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void cbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void VerHabitaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaHotelWaraDataSet.Tipo' Puede moverla o quitarla según sea necesario.
            this.tipoTableAdapter.Fill(this.sistemaHotelWaraDataSet.Tipo);
            cbEstado.SelectedIndex = 0;
            cbFiltroTipo.SelectedIndex = 0;
            cbNroCamas.SelectedIndex = 0;
            cbPrecioMenos.SelectedIndex = 0;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void cbPrecioMenos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void cbNroCamas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }
    }
}
