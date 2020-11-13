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
    public partial class NuevaHabitacion : Form
    {
        public NuevaHabitacion()
        {
            InitializeComponent();
        }

        public void limpiarCampos()
        {
            txtId.Text = "ID";
            txtCaracteristica.Text = "CARACTERISTICAS";
            cbTipoHabitacion.SelectedIndex = 0;
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
            swWifiLobby .Value = false;
            lblError.Visible = false;
        }

        private void NuevaHabitacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaHotelWaraDataSet.Tipo' Puede moverla o quitarla según sea necesario.
            this.tipoTableAdapter.Fill(this.sistemaHotelWaraDataSet.Tipo);
            limpiarCampos();
        }

        public void validarCampos()
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID";
            }
            if (txtCaracteristica.Text == "")
            {
                txtCaracteristica.Text = "CARACTERISTICAS";
            }
        }

        private void txtId_OnValueChanged(object sender, EventArgs e)
        {
            validarCampos();
            if (txtId.Text == "ID")
            {
                lblIdHabitacion.Text = "H";
            }
            else
            {
                lblIdHabitacion.Text = "H" + txtId.Text.ToUpper();
            }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (verificarAgregar())
            {
                try
                {
                    using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                    {
                        Habitaciones nuevo = new Habitaciones();
                        nuevo.idHabitacion = lblIdHabitacion.Text;
                        nuevo.caracteristicas = txtCaracteristica.Text;
                        nuevo.precio = nudPrecio.Value;
                        nuevo.nroPiso =  (int)nudNroPiso.Value;
                        nuevo.nroCamas = (int)nudNroCamas.Value;
                        nuevo.estado = "DISPONIBLE";
                        DB.Habitaciones.Add(nuevo);
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
                        DB.Servicios.Add(nuevo);
                        DB.SaveChanges();
                    }
                    using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                    {
                        DetalleHabitacion nuevo = new DetalleHabitacion();
                        nuevo.idDetalleHabitacion = lblIdHabitacion.Text;
                        nuevo.idTipo = cbTipoHabitacion.SelectedValue.ToString();
                        DB.DetalleHabitacion.Add(nuevo);
                        DB.SaveChanges();
                    }
                    MessageBox.Show("LA HABITACION AH SIDO REGISTRADA CON ÉXITO!");
                    limpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("OCURRIO UN ERROR CON EL REGISTRO DE LA HABITACION, VERIFIQUE EL ID DE LA HABITACION!");
                }
            }
            else lblError.Visible = true;
        }

        public bool verificarAgregar()
        {
            bool listo = true;

            if (nudPrecio.Value == 0 || nudPrecio.Value == 0 || nudPrecio.Value == 0 || txtId.Text == "ID" || txtCaracteristica.Text == "CARACTERISTICAS")
            {
                listo = false;
            }

            return listo;
        }
    }
}
