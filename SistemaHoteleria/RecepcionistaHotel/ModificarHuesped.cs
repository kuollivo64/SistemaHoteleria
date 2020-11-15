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
    public partial class ModificarHuesped : Form
    {
        public ModificarHuesped()
        {
            InitializeComponent();
        }

        private void txtci_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtci.Text != "")
            {
                CargarDatos(txtci.Text);
            }
            else
            {
                Limpiar();
            }
        }

        private void CargarDatos(string a)
        {
            using (SistemaHotelWaraEntitiesV1 ne = new SistemaHotelWaraEntitiesV1())
            {
                var query = from d
                            in ne.Huespedes
                            where d.documento == a
                            select d;
                foreach (Huespedes b in query)
                {
                    txtid.Text = b.idHuesped;
                    txtnombre.Text = b.nombre;
                    txtpaterno.Text = b.paterno;
                    txtmaterno.Text = b.materno;
                    cbpais.Text = b.pais;
                    dtfechanac.Text = b.fechaNacimiento.ToString();
                }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta Seguro de cancelar la modificacion del huesped?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Huesped Modificado ");
                using (var contexto = new SistemaHotelWaraEntitiesV1())
                {
                    contexto.Entry(hp).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
