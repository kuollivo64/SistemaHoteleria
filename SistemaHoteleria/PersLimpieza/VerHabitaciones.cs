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
    public partial class VerHabitaciones : Form
    {
        public VerHabitaciones()
        {
            InitializeComponent();
            MostarEstadoHabitacionez();
            MostarRegistros();
        }


        void MostarEstadoHabitacionez()
        {
            using (var contexto = new SistemaHotelWaraEntitiesV1())
            {
                var query = from d
                            in contexto.Habitaciones
                            select new {d.idHabitacion,d.estado,d.nroPiso,d.nroCamas};
                dgvEstadoHab.DataSource = query.ToList();
            }
        }

        void MostarRegistros()
        {
            using (var contexto = new SistemaHotelWaraEntitiesV1())
            {
                var query = from d
                            in contexto.RegistroLimpieza
                            select new { d.idRegistroLimpieza,d.informe,d.fecha,d.hora };
                dvgRegsitros.DataSource = query.ToList();
            }
        }
    }
}
