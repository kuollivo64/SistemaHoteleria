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
    public partial class AdministrarTipos : Form
    {
        public AdministrarTipos()
        {
            InitializeComponent();
            cargarTipos();
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            cbAccion.SelectedIndex = 0;
            txtId.Text = "ID";
            txtDescripcion.Text = "DESCRIPCION";
            cargarTipos();
        }

        public void validarCampos()
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID";
            }
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "DESCRIPCION";
            }
        }

        private void cargarTipos()
        {
            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
            {
                try
                {
                    dgvTipos.DataSource = (from t in DB.Tipo
                                           select new
                                           {
                                               ID = t.idTipo,
                                               DESCRIPCION = t.descripcion,
                                           }).ToList();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR EN LA CONSULTA");
                }
            }
        }

        private void dgvTipos_Click(object sender, EventArgs e)
        {
            txtId.Text = dgvTipos.Rows[dgvTipos.CurrentRow.Index].Cells[0].Value.ToString();
            txtDescripcion.Text = dgvTipos.Rows[dgvTipos.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "ID" && txtDescripcion.Text != "DESCRIPCION")
            {
                switch (cbAccion.SelectedItem.ToString())
                {
                    case "AGREGAR":
                        try
                        {
                            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                            {
                                Tipo nuevo = new Tipo();
                                nuevo.idTipo = txtId.Text;
                                nuevo.descripcion = txtDescripcion.Text;
                                DB.Tipo.Add(nuevo);
                                DB.SaveChanges();
                                limpiarCampos();
                            }
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    case "MODIFICAR":
                        try
                        {
                            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                            {
                                Tipo nuevo = new Tipo();
                                nuevo.idTipo = txtId.Text;
                                nuevo.descripcion = txtDescripcion.Text;
                                DB.Entry(nuevo).State = System.Data.Entity.EntityState.Modified;
                                DB.SaveChanges();
                                limpiarCampos();
                            }
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    default:
                        try
                        {
                            using (SistemaHotelWaraEntitiesV1 DB = new SistemaHotelWaraEntitiesV1())
                            {
                                Tipo nuevo = DB.Tipo.Find(txtId.Text);
                                DB.Tipo.Remove(nuevo);
                                DB.SaveChanges();
                                limpiarCampos();
                            }
                        }
                        catch (Exception)
                        {
                        }
                        break;
                }
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void cbAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtId_OnValueChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtCaracteristica_OnValueChanged(object sender, EventArgs e)
        {
            validarCampos();
        }
    }
}
