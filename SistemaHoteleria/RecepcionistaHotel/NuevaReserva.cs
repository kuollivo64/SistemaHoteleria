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

namespace SistemaHoteleria.RecepcionistaHotel
{
    public partial class NuevaReserva : Form
    {
        public NuevaReserva()
        {
            InitializeComponent();
            limpiarCampos();
            CargarHuespedes("");
            CargarHabitaciones();
        }

        public void ActualizarEstadoHabitaciones()
        {
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                var habitaciones = (from h in DB.DetalleReservas
                                    join r in DB.Reservas on h.idDetalleReservas equals r.idReserva
                                    where r.ingreso <= DateTime.Now && r.salida >= DateTime.Now
                                    select new { h.idHabitacion }
                                                      ).ToList();
                foreach (var i in habitaciones)
                {
                    Habitaciones h = DB.Habitaciones.Find(i.idHabitacion);
                    h.estado = "RESERVADA";
                    DB.Entry(h).State = System.Data.Entity.EntityState.Modified;
                    DB.SaveChanges();
                }
            }
        }

        public int obtenerId()
        {
            int id = 0;
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    var r = (from rs in DB.Reservas
                             orderby rs.idReserva descending
                             select rs.idReserva).First();
                    id = r + 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Es el primer registro");
                }
            }
            return id;
        }

        public void CargarHuespedes(string apellido)
        {
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    if (apellido == "" || apellido == "APELLIDO...")
                    {
                        dgvHuespedes.DataSource = (from d in DB.Huespedes
                                                   select d).ToList();
                    }
                    else
                    {
                        dgvHuespedes.DataSource = (from d in DB.Huespedes
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
                    else if (checkFiltroTipo.Checked)
                    {
                        if (txtFiltroId.text == "" || txtFiltroId.text == "ID...")
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
                                                          h.precio.Value <= precio &&
                                                          h.nroCamas.Value == nroCamas
                                                          select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado, dh.idTipo }
                                                          ).ToList();
                        }
                    }


                }
                catch (Exception)
                {
                }
            }
        }

        private void NuevaReserva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaHotelWaraDataSet.Tipo' Puede moverla o quitarla según sea necesario.
            this.tipoTableAdapter.Fill(this.sistemaHotelWaraDataSet.Tipo);
            cbFiltroTipo.SelectedIndex = 0;
            cbNroCamas.SelectedIndex = 0;
            cbPrecioMenos.SelectedIndex = 0;
            CargarHabitaciones();
        }

        private void txtFiltroApellido_OnTextChange(object sender, EventArgs e)
        {
            CargarHuespedes(txtFiltroApellido.text);
        }

        private void txtFiltroId_OnTextChange(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void cbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnAgregarHuesped_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvHuespedes.Rows[dgvHuespedes.CurrentRow.Index].Cells[0].Value.ToString();
                string nombre = dgvHuespedes.Rows[dgvHuespedes.CurrentRow.Index].Cells[1].Value.ToString() + " ";
                nombre += dgvHuespedes.Rows[dgvHuespedes.CurrentRow.Index].Cells[2].Value.ToString() + " ";
                nombre += dgvHuespedes.Rows[dgvHuespedes.CurrentRow.Index].Cells[3].Value.ToString();

                bool ok = true;
                for (int i = 0; i < dgvHuespedesSeleccionados.RowCount; i++)
                {
                    if (id == dgvHuespedesSeleccionados.Rows[i].Cells[0].Value.ToString())
                    {
                        ok = false;
                    }
                }

                if (ok)
                {
                    if (dgvHuespedesSeleccionados.RowCount + 1 <= int.Parse(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[3].Value.ToString()))
                    {
                        dgvHuespedesSeleccionados.Rows.Add(id, nombre);
                    }
                    else MessageBox.Show("El numero de huespedes no puede ser mayor al numero de camas de la habitacion!");
                }
                else MessageBox.Show("El huesped ya se encuentra agregado!");
            }
            catch (Exception)
            {
            }
        }

        private void btnQuitarHuesped_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHuespedesSeleccionados.Rows.RemoveAt(dgvHuespedesSeleccionados.CurrentRow.Index);
            }
            catch (Exception)
            {
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            int idR = int.Parse(lblIdReserva.Text);
            decimal subTotal = 0;
            decimal precioH = 0;
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    precioH = (decimal)DB.Habitaciones.Find(lblIdHabitacion.Text).precio;
                    Reservas nuevo = new Reservas();
                    nuevo.idReserva = idR;
                    nuevo.ingreso = dtpFechaIngreso.Value.Date;
                    nuevo.salida = dtpFechaSalida.Value.Date;
                    nuevo.estado = "SIN PAGAR";
                    DB.Reservas.Add(nuevo);
                    DB.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("error reservas");
                }
            }

            for (int i = 0; i < dgvHuespedesSeleccionados.RowCount; i++)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {
                    try
                    {
                        RegistroHuespedes nuevo = new RegistroHuespedes();
                        nuevo.idReserva = idR;
                        nuevo.idHuespedes = dgvHuespedesSeleccionados.Rows[i].Cells[0].Value.ToString();
                        DB.RegistroHuespedes.Add(nuevo);
                        DB.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("error registro huespedes");
                    }
                }
            }

            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    DetalleReservas nuevo = new DetalleReservas();
                    nuevo.idDetalleReservas = idR;
                    nuevo.idEmpleado = "RPMG54";
                    nuevo.idHabitacion = lblIdHabitacion.Text;
                    DB.DetalleReservas.Add(nuevo);
                    DB.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("error detalle reserva");
                }
            }

            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    Factura nuevo = new Factura();
                    nuevo.idFactura = idR;
                    nuevo.fecha = DateTime.Now.Date;

                    TimeSpan dias = dtpFechaSalida.Value.Date - dtpFechaIngreso.Value.Date;
                    subTotal += (precioH * (dias.Days + 1));

                    nuevo.total = subTotal;
                    DB.Factura.Add(nuevo);
                    DB.SaveChanges();

                    MessageBox.Show("Reserva realizada con exito!");
                    limpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("error facturacion");
                }
            }


        }

        public void limpiarCampos()
        {
            lblIdHabitacion.Text = "ID";
            btnReservar.Visible = false;
            lblIdReserva.Text = obtenerId().ToString();
            dtpFechaIngreso.Value = DateTime.Now.Date;
            dtpFechaSalida.Value = DateTime.Now.Date;
            dgvHuespedesSeleccionados.Rows.Clear();
            dgvHuespedesSeleccionados.Refresh();
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
            ActualizarEstadoHabitaciones();
        }

        private void dgvHabitaciones_Click(object sender, EventArgs e)
        {
            try
            {
                lblIdHabitacion.Text = dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[0].Value.ToString();
                CargarServicios(lblIdHabitacion.Text);
                List<DateTime> fechas = new List<DateTime>();

                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {
                    var habitaciones = (from h in DB.DetalleReservas
                                        join r in DB.Reservas on h.idDetalleReservas equals r.idReserva
                                        where r.ingreso <= DateTime.Now && r.salida >= DateTime.Now && lblIdHabitacion.Text == h.idHabitacion && r.estado != "CANCELADO"
                                        select new { h.idHabitacion, r.ingreso, r.salida }
                                                          ).ToList();
                    foreach (var h in habitaciones)
                    {
                        for (DateTime i = (DateTime)h.ingreso; i <= (DateTime)h.salida; i = i.AddDays(1))
                        {
                            fechas.Add(i);
                        }
                    }
                }

                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {
                    var habitaciones = (from h in DB.DetalleReservas
                                        join r in DB.Reservas on h.idDetalleReservas equals r.idReserva
                                        where r.ingreso >= DateTime.Now && lblIdHabitacion.Text == h.idHabitacion && r.estado != "CANCELADO"
                                        select new { h.idHabitacion, r.ingreso, r.salida }
                                                          ).ToList();
                    foreach (var h in habitaciones)
                    {
                        for (DateTime i = (DateTime)h.ingreso; i <= (DateTime)h.salida; i = i.AddDays(1))
                        {
                            fechas.Add(i);
                        }
                    }
                }

                calendarEstadoHabitacion.BoldedDates = fechas.ToArray();

                if (dgvHuespedesSeleccionados.RowCount > int.Parse(dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[3].Value.ToString()))
                {
                    dgvHuespedesSeleccionados.Rows.Clear();
                    dgvHuespedesSeleccionados.Refresh();
                }
            }
            catch (Exception)
            {
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

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (dtpFechaIngreso.Value.Date < DateTime.Now.Date)
            {
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "La fecha de ingreso no puede ser una fecha pasada!";
                btnReservar.Visible = false;
            }
            else if (dtpFechaIngreso.Value.Date > dtpFechaSalida.Value.Date)
            {
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "La fecha de ingreso no puede ser posterior a la fecha de salida!";
                btnReservar.Visible = false;
            }
            else if (dgvHuespedesSeleccionados.RowCount == 0)
            {
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Debe agregar al menos un huesped!";
                btnReservar.Visible = false;
            }
            else if (lblIdHabitacion.Text == "ID")
            {
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Debe seleccionar alguna habitacion!";
                btnReservar.Visible = false;
            }
            else if (verificarFechas().Contains(dtpFechaIngreso.Value.Date) || verificarFechas().Contains(dtpFechaSalida.Value.Date))
            {
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Las fechas seleccionadas ya estan reservadas!";
                btnReservar.Visible = false;
            }
            else
            {
                lblError.Visible = true;
                lblError.ForeColor = Color.FromArgb(0, 192, 192);
                lblError.Text = "Todo correcto!";
                btnReservar.Visible = true;
            }
        }

        public List<DateTime> verificarFechas()
        {
            List<DateTime> fechas = new List<DateTime>();
            try
            {

                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {
                    var habitaciones = (from h in DB.DetalleReservas
                                        join r in DB.Reservas on h.idDetalleReservas equals r.idReserva
                                        where r.ingreso <= DateTime.Now && r.salida >= DateTime.Now && lblIdHabitacion.Text == h.idHabitacion && r.estado != "CANCELADO"
                                        select new { h.idHabitacion, r.ingreso, r.salida }
                                                          ).ToList();
                    foreach (var h in habitaciones)
                    {
                        for (DateTime i = (DateTime)h.ingreso; i <= (DateTime)h.salida; i = i.AddDays(1))
                        {
                            fechas.Add(i);
                        }
                    }
                }

                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {
                    var habitaciones = (from h in DB.DetalleReservas
                                        join r in DB.Reservas on h.idDetalleReservas equals r.idReserva
                                        where r.ingreso >= DateTime.Now && lblIdHabitacion.Text == h.idHabitacion && r.estado != "CANCELADO"
                                        select new { h.idHabitacion, r.ingreso, r.salida }
                                                          ).ToList();
                    foreach (var h in habitaciones)
                    {
                        for (DateTime i = (DateTime)h.ingreso; i <= (DateTime)h.salida; i = i.AddDays(1))
                        {
                            fechas.Add(i);
                        }
                    }
                }

                return fechas;
            }
            catch (Exception)
            {
                return fechas;
            }
        }

        private void checkFiltroTipo_OnChange(object sender, EventArgs e)
        {
            if (checkFiltroTipo.Checked)
            {
                checkFiltroServicios.Checked = false;

                cbFiltroTipo.Enabled = true;
                cbNroCamas.Enabled = true;
                cbPrecioMenos.Enabled = true;

                swAireAcondicionado.Enabled = false;
                swAlberca.Enabled = false;
                swBarHotel.Enabled = false;
                swEstacionamiento.Enabled = false;
                swGym.Enabled = false;
                swMascotas.Enabled = false;
                swRestaurante.Enabled = false;
                swSpa.Enabled = false;
                swWifiHabitacion.Enabled = false;
                swWifiLobby.Enabled = false;
            }
            else
            {
                checkFiltroServicios.Checked = true;

                cbFiltroTipo.Enabled = false;
                cbNroCamas.Enabled = false;
                cbPrecioMenos.Enabled = false;

                swAireAcondicionado.Enabled = true;
                swAlberca.Enabled = true;
                swBarHotel.Enabled = true;
                swEstacionamiento.Enabled = true;
                swGym.Enabled = true;
                swMascotas.Enabled = true;
                swRestaurante.Enabled = true;
                swSpa.Enabled = true;
                swWifiHabitacion.Enabled = true;
                swWifiLobby.Enabled = true;
            }
        }

        private void checkFiltroServicios_OnChange(object sender, EventArgs e)
        {
            if (checkFiltroServicios.Checked)
            {
                checkFiltroTipo.Checked = false;

                swAireAcondicionado.Enabled = true;
                swAlberca.Enabled = true;
                swBarHotel.Enabled = true;
                swEstacionamiento.Enabled = true;
                swGym.Enabled = true;
                swMascotas.Enabled = true;
                swRestaurante.Enabled = true;
                swSpa.Enabled = true;
                swWifiHabitacion.Enabled = true;
                swWifiLobby.Enabled = true;

                cbFiltroTipo.Enabled = false;
                cbNroCamas.Enabled = false;
                cbPrecioMenos.Enabled = false;
            }
            else
            {
                checkFiltroTipo.Checked = true;

                swAireAcondicionado.Enabled = false;
                swAlberca.Enabled = false;
                swBarHotel.Enabled = false;
                swEstacionamiento.Enabled = false;
                swGym.Enabled = false;
                swMascotas.Enabled = false;
                swRestaurante.Enabled = false;
                swSpa.Enabled = false;
                swWifiHabitacion.Enabled = false;
                swWifiLobby.Enabled = false;

                cbFiltroTipo.Enabled = true;
                cbNroCamas.Enabled = true;
                cbPrecioMenos.Enabled = true;
            }
        }

        private void swWifiLobby_OnValueChange(object sender, EventArgs e)
        {
            if (swWifiLobby.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.wifiLobby == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                }
            }
        }

        private void swWifiHabitacion_OnValueChange(object sender, EventArgs e)
        {
            if (swWifiHabitacion.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.wifiHabitacion == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                } 
            }
        }

        private void swAlberca_OnValueChange(object sender, EventArgs e)
        {
            if (swAlberca.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.alberca == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                } 
            }
        }

        private void swSpa_OnValueChange(object sender, EventArgs e)
        {
            if (swSpa.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.spa == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                } 
            }
        }

        private void swEstacionamiento_OnValueChange(object sender, EventArgs e)
        {
            if (swEstacionamiento.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.estacionamiento == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                } 
            }
        }

        private void swMascotas_OnValueChange(object sender, EventArgs e)
        {
            if (swMascotas.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.mascotas == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                } 
            }
        }

        private void swAireAcondicionado_OnValueChange(object sender, EventArgs e)
        {
            if (swAireAcondicionado.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.aireAcondicionado == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                } 
            }
        }

        private void swRestaurante_OnValueChange(object sender, EventArgs e)
        {
            if (swRestaurante.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.restaurante == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                } 
            }
        }

        private void swBarHotel_OnValueChange(object sender, EventArgs e)
        {
            if (swBarHotel.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.barHotel == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                } 
            }
        }

        private void swGym_OnValueChange(object sender, EventArgs e)
        {
            if (swGym.Value)
            {
                using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                {

                    dgvHabitaciones.DataSource = (from h in DB.Habitaciones
                                                  join dh in DB.Servicios on h.idHabitacion equals dh.idServicio
                                                  where dh.gym == true
                                                  select new { h.idHabitacion, h.precio, h.nroPiso, h.nroCamas, h.estado }
                                                  ).ToList();

                } 
            }
        }
    }
}
