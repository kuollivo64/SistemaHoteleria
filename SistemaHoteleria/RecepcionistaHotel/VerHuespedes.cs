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
    public partial class VerHuespedes : Form
    {
        public VerHuespedes()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            using (SistemaHotelWaraEntitiesV1 nx = new SistemaHotelWaraEntitiesV1())
            {
                var query = from d
                            in nx.Huespedes
                            select d;
                dgHuespedes.DataSource = query.ToList();
            }
        }

        private void CargarDatos2(string a)
        {
            using (SistemaHotelWaraEntitiesV1 nx = new SistemaHotelWaraEntitiesV1())
            {
                var query = from d
                            in nx.Huespedes
                            where d.documento == a
                            select d;
                dgHuespedes.DataSource = query.ToList();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "")
            {
                CargarDatos();
            }
            else
            {
                CargarDatos2(textBox1.Text);
            }
        }
    }
}
