using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaHoteleria.GerenteGeneral
{
    public partial class Semanal : Form
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=SistemaHotelWara;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Semanal()
        {
            InitializeComponent();
        }

        private void Semanal_Load(object sender, EventArgs e)
        {
            //HabitacionesPreferidas();
        }

        private void HabitacionesPreferidas()
        {
            ArrayList habitaciones = new ArrayList();
            ArrayList cantidadReservas = new ArrayList();

            cmd = new SqlCommand("aquivaelprocedimiento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                habitaciones.Add(dr.GetString(0));
                cantidadReservas.Add(dr.GetInt32(1));
            }
            chHabitacionPreferidas.Series[0].Points.DataBindXY(habitaciones, cantidadReservas);
            dr.Close();
            conexion.Close();
        }
    }
}
