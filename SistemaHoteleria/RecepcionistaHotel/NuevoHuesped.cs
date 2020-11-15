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
    public partial class NuevoHuesped : Form
    {
        public NuevoHuesped()
        {
            InitializeComponent();
            Random rand = new Random();
            int numero = rand.Next(19999,99999);
            txtid.Text = numero.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Huespedes hp = new Huespedes();
                hp.idHuesped = txtid.Text;
                hp.documento = txtci.Text;
                hp.nombre = txtnombre.Text;
                hp.paterno = txtpaterno.Text;
                hp.materno = txtmaterno.Text;
                hp.pais = cbpais.Text;
                hp.fechaNacimiento = Convert.ToDateTime(dtfechanac.Text).Date;
                MessageBox.Show("Nuevo Huesped Agregado ");
                using (var contexto = new SistemaHotelWaraEntitiesV1())
                {
                    contexto.Huespedes.Add(hp);
                    contexto.SaveChanges();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void txtid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta Seguro de cancelar el registro del huesped?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Limpiar();
            }
        }


        void Limpiar()
        {
            txtid.Clear();
            txtci.Clear();
            txtnombre.Clear();
            txtpaterno.Clear();
            txtmaterno.Clear();
            cbpais.ResetText();
            dtfechanac.ResetText();
        }
    }
}
