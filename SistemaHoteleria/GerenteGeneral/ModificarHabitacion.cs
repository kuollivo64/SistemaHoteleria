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
    public partial class ModificarHabitacion : Form
    {
        public ModificarHabitacion()
        {
            InitializeComponent();
        }

        public void limpiarCampos()
        {
            lblIdHabitacion.Text = "H";
            txtCaracteristica.Text = "CARACTERISTICAS";
            nudNroCamas.Value = 0;
            nudNroPiso.Value = 0;
            nudPrecio.Value = 0;
            swAireAcondicionado.Value = false;
            swAlberca.Value = false;
            swBarHotel.Value = false;
            swEstacionamiento.Value = false;
            swGym.Value = false;
            swMascotas.Value = false;
            swRestaurante.Value = false;
            swSpa.Value = false;
            swWifiHabitacion.Value = false;
            swWifiLobby.Value = false;
            lblError.Visible = false;
            CargarHabitaciones();
            cbTipoHabitacion.SelectedIndex = 0;
            cbEstadoH.SelectedIndex = 0;

        }

        public void validarCampos()
        {
            if (txtCaracteristica.Text == "")
            {
                txtCaracteristica.Text = "CARACTERISTICAS";
            }
        }

        private void ModificarHabitacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaHotelWaraDataSet.Tipo' Puede moverla o quitarla según sea necesario.
            this.tipoTableAdapter.Fill(this.sistemaHotelWaraDataSet.Tipo);
            limpiarCampos();
        }

        private void txtCaracteristica_OnValueChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void cbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void nudNroPiso_ValueChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void nudNroCamas_ValueChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swWifiLobby_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swWifiHabitacion_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swAlberca_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swSpa_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swEstacionamiento_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swMascotas_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swAireAcondicionado_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swRestaurante_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swBarHotel_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void swGym_OnValueChange(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void cbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void txtFiltroId_OnTextChange(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        public void CargarHabitaciones()
        {
            DataTable dt = new DataTable();
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
                        dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                      join dh in DB.DetalleHabitacion on h.idHabitacion equals dh.idDetalleHabitacion
                                                      where dh.idTipo == cbFiltroTipo.SelectedValue.ToString() 
                                                      select new {h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado, dh.idTipo}
                                                      ).ToList();
                    }
                    else
                    {
                        dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                      join dh in DB.DetalleHabitacion on h.idHabitacion equals dh.idDetalleHabitacion
                                                      where h.idHabitacion.StartsWith(txtFiltroId.text) && dh.idTipo == cbFiltroTipo.SelectedValue.ToString()
                                                      select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado, dh.idTipo }
                                                      ).ToList();
                    }

                }
                catch (Exception)
                {
                }
            }
        }

        public void CargarServicios(string idHabitacion)
        {
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                Servicios s = DB.Servicios.Find(idHabitacion);
                swAireAcondicionado.Value = (bool)s.aireAcondicionado;
                swAlberca.Value = (bool)s.alberca;
                swBarHotel.Value = (bool)s.barHotel;
                swEstacionamiento.Value = (bool)s.estacionamiento;
                swGym.Value = (bool)s.gym;
                swMascotas.Value = (bool)s.mascotas;
                swRestaurante.Value = (bool)s.restaurante;
                swSpa.Value = (bool)s.spa;
                swWifiHabitacion.Value = (bool)s.wifiHabitacion;
                swWifiLobby.Value = (bool)s.wifiLobby;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lblIdHabitacion.Text != "H" && txtCaracteristica.Text != "CARACTERISTICAS" && nudNroCamas.Value != 0 && nudNroPiso.Value != 0 && nudPrecio.Value != 0)
            {
                try
                {
                    using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                    {
                        Habitaciones nuevo = new Habitaciones();
                        nuevo.idHabitacion = lblIdHabitacion.Text;
                        nuevo.caracteristicas = txtCaracteristica.Text;
                        nuevo.precio = nudPrecio.Value;
                        nuevo.nroPiso = (int)nudNroPiso.Value;
                        nuevo.nroCamas = (int)nudNroCamas.Value;
                        nuevo.estado = cbEstadoH.SelectedItem.ToString();
                        DB.Entry(nuevo).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                    }
                    using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                    {
                        Servicios nuevo = new Servicios();
                        nuevo.idServicio = lblIdHabitacion.Text;
                        nuevo.wifiHabitacion = swWifiHabitacion.Value;
                        nuevo.wifiLobby = swWifiLobby.Value;
                        nuevo.alberca = swAlberca.Value;
                        nuevo.spa = swSpa.Value;
                        nuevo.estacionamiento = swEstacionamiento.Value;
                        nuevo.mascotas = swMascotas.Value;
                        nuevo.aireAcondicionado = swAireAcondicionado.Value;
                        nuevo.restaurante = swRestaurante.Value;
                        nuevo.barHotel = swBarHotel.Value;
                        nuevo.gym = swGym.Value;
                        DB.Entry(nuevo).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                    }
                    using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                    {
                        DetalleHabitacion nuevo = new DetalleHabitacion();
                        nuevo.idDetalleHabitacion = lblIdHabitacion.Text;
                        nuevo.idTipo = cbTipoHabitacion.SelectedValue.ToString();
                        DB.Entry(nuevo).State = System.Data.Entity.EntityState.Modified;
                        DB.SaveChanges();
                    }
                    MessageBox.Show("LA HABITACION AH SIDO MODIFICADA CON ÉXITO!");
                    limpiarCampos();
            }
                catch (Exception)
            {
                MessageBox.Show("OCURRIO UN ERROR CON LA MODIFICACION DE LA HABITACION, VERIFIQUE EL ID DE LA HABITACION!");
            }
        }
            else lblError.Visible = true;
        }

        private void dgvHabitaciones_Click(object sender, EventArgs e)
        {
            lblIdHabitacion.Text = dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[0].Value.ToString();
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                Habitaciones h = DB.Habitaciones.Find(lblIdHabitacion.Text);
                nudPrecio.Value = (decimal)h.precio;
                nudNroPiso.Value = (decimal)h.nroPiso;
                nudNroCamas.Value = (decimal)h.nroCamas;
                txtCaracteristica.Text = h.caracteristicas;
                cbEstadoH.SelectedIndex = cbEstadoH.FindString(h.estado);
            }
            String tipo = dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[5].Value.ToString();
            cbTipoHabitacion.SelectedIndex = cbTipoHabitacion.FindString(tipo);
            CargarServicios(lblIdHabitacion.Text);
        }

        private void cbEstadoH_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
