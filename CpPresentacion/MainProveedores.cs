using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CpNegocio;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CpPresentacion
{
    public partial class MainProveedores : Form
    {
        public MainProveedores()
        {
            InitializeComponent();
        }

        public void btnConsultarProv_Click(object sender, EventArgs e)
        {
             negProveedor negProveedor= new negProveedor();
            string msj = "";

            List<Proveedor> listaDeProveedor = negProveedor.consultarTodosLosProveedores(out msj);

            if (msj.Equals("OK"))
            {

                dgvProveedorMain.Rows.Clear();

                foreach (Proveedor proveedor in listaDeProveedor)
                {
                    dgvProveedorMain.Rows.Add(proveedor.Id_Proveedor, proveedor.Descripcion);
                }
            }
            else
            {
                dgvProveedorMain.Rows.Clear();
                MessageBox.Show(msj, "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            FormularioProveedor FormularioProveedor = new FormularioProveedor();
            FormularioProveedor.ShowDialog();
        }

        private void btnCerrarProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            FormActualizarProveedor frm = new FormActualizarProveedor();
           

            if (dgvProveedorMain.SelectedRows.Count > 0)
            {
                frm.txtIdProveedorActualizar.Text = dgvProveedorMain.CurrentRow.Cells[0].Value.ToString();
                frm.txtDescripcionProveedorActualizar.Text = dgvProveedorMain.CurrentRow.Cells[1].Value.ToString();
  
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione una fila de la lista de Proveedores");
            }

            btnConsultarProv_Click(sender, e);
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedorMain.SelectedRows.Count <= 0)
            {
                btnConsultarProv_Click(sender, e);
                MessageBox.Show("Selecione una fila de la lista de Proveedores");

            }
            else
            {
                if (MessageBox.Show("Los cambios no se pueden deshacer ¿Desea continuar?", "¡Se eliminara el registro.!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (dgvProveedorMain.SelectedRows.Count > 0)
                    {

                        negProveedor negProveedor = new negProveedor();

                        int id = int.Parse(dgvProveedorMain.CurrentRow.Cells["clmID"].Value.ToString());
                        string msj = "";
                        negProveedor.eliminarProveedor(id, out msj);

                        if (msj.Equals("OK"))
                        {
                            MessageBox.Show("Se ha eliminado el Proveedor correctamente", "Proceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(msj, "Proceso incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione una fila de la lista de Proveedores");
                    }

                    btnConsultarProv_Click(sender, e);
                }
            }
        }
    }
}
