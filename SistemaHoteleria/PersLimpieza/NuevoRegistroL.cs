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

namespace SistemaHoteleria.PersLimpieza
{
    public partial class NuevoRegistroL : Form
    {
        public NuevoRegistroL()
        {
            InitializeComponent();
            MostrarHabitaciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Random ramdon = new Random();
            int idReg = ramdon.Next(19999,99999);
            RegistroLimpieza limp = new RegistroLimpieza();
            limp.idRegistroLimpieza = idReg.ToString();
            limp.fecha = DateTime.Now.Date;
            limp.hora = Convert.ToString(DateTime.Now.Hour) +":"+ Convert.ToString(DateTime.Now.Minute);
            limp.informe = txbInforme.Text;
            DetalleRegistroLimpiezas det = new DetalleRegistroLimpiezas();
            det.idEmpleado = "LPVP32";
            det.idHabitacion = lblHabitacion.Text;
            det.idRegistroLimpieza = idReg.ToString();
            using (var contexto = new SistemaHotelWaraEntitiesV1())
            {
                contexto.RegistroLimpieza.Add(limp);
                contexto.DetalleRegistroLimpiezas.Add(det);
                contexto.SaveChanges();
                Limpiar();
                MessageBox.Show("Informe de la Habitacion " + lblHabitacion.Text + " se registro");
            }
        }

        void MostrarHabitaciones()
        {
            using (var contexto = new SistemaHotelWaraEntitiesV1())
            {
                var quiery = from d
                             in contexto.Habitaciones
                             select new {d.idHabitacion,d.caracteristicas,d.nroCamas,d.nroPiso };
                dgvHabitaciones.DataSource = quiery.ToList();
            }
        }

        private void SeleccionarHab(object sender, DataGridViewCellEventArgs e)
        {
            lblHabitacion.Text = dgvHabitaciones.Rows[dgvHabitaciones.CurrentRow.Index].Cells[0].Value.ToString();
        }
        void Limpiar()
        {
            txbInforme.Text = "";
            lblHabitacion.Text = "";

        }
    }
}
