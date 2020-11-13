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
    public partial class ModificarRegistroL : Form
    {
        public ModificarRegistroL()
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0;
           
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new SistemaHotelWaraEntitiesV1())
                {
                    if (cbFiltro.SelectedIndex == 0)
                    {
                        var lis = contexto.exo_DiezDatos2();
                        dgvRegistros.DataSource = lis.ToList();
                    }
                    else if (cbFiltro.SelectedIndex == 1)
                    {
                        var lis = contexto.exo_SieteDiasPL2();
                        dgvRegistros.DataSource = lis.ToList();
                    }
                    else if (cbFiltro.SelectedIndex == 2)
                    {
                        var lis = contexto.exo_UnMesPL2();
                        dgvRegistros.DataSource = lis.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No Disponibles" + ex.Message);
            }
        }

        private void Seleccion(object sender, DataGridViewCellEventArgs e)
        {
            lblIdRegistro.Text = dgvRegistros.Rows[dgvRegistros.CurrentRow.Index].Cells[0].Value.ToString();
            lblHabitacion.Text = dgvRegistros.Rows[dgvRegistros.CurrentRow.Index].Cells[3].Value.ToString();
            txbInforme.Text = dgvRegistros.Rows[dgvRegistros.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistroLimpieza reg = new RegistroLimpieza();
            reg.idRegistroLimpieza = lblIdRegistro.Text;
            reg.fecha = Convert.ToDateTime(dgvRegistros.Rows[dgvRegistros.CurrentRow.Index].Cells[1].Value);
            reg.hora = dgvRegistros.Rows[dgvRegistros.CurrentRow.Index].Cells[2].Value.ToString();
            reg.informe = txbInforme.Text;
            using (var contexto = new SistemaHotelWaraEntitiesV1())
            {
                contexto.Entry(reg).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                Limpiar();
                MessageBox.Show("Registro Modificado");
            }
        }
        void Limpiar()
        {
            txbInforme.Text = "";
            lblHabitacion.Text = "";
            lblIdRegistro.Text = "";
        }
    }
}
