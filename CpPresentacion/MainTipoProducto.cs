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
    public partial class MainTipoProducto : Form
    {
        public MainTipoProducto()
        {
            InitializeComponent();
        }

        private void btnNuevoTipoProducto_Click(object sender, EventArgs e)
        {
            FormularioNuevoTipoProducto formularioNuevoTipo = new FormularioNuevoTipoProducto();
            formularioNuevoTipo.ShowDialog();
        }

        private void btnEditarTipoProducto_Click(object sender, EventArgs e)
        {
            
            FormularioActualizarTipo formActualizarTipo = new FormularioActualizarTipo();


            if (dgvTipoMain.SelectedRows.Count > 0)
            {
                formActualizarTipo.txtIdTiporActualizar.Text = dgvTipoMain.CurrentRow.Cells[0].Value.ToString();
                formActualizarTipo.txtAreaTipoActualizar.Text = dgvTipoMain.CurrentRow.Cells[1].Value.ToString();

                formActualizarTipo.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione una fila de la lista de Areas o Tipos de Productos");
            }

            btnCargarTipoProducto_Click(sender, e);
        }

        private void btnCargarTipoProducto_Click(object sender, EventArgs e)
        {   

          
            negTipoProducto negTipoProducto = new negTipoProducto();
            string msj = "";

           
            List<TipoProducto> listaTipoProductos = negTipoProducto.consultarTodosLosTipos(out msj);

            if (msj.Equals("OK"))
            {

                dgvTipoMain.Rows.Clear();

                foreach (TipoProducto tipo in listaTipoProductos)
                {
                    dgvTipoMain.Rows.Add(tipo.Id_TipoProducto, tipo.Area);
                }
            }
            else
            {
                dgvTipoMain.Rows.Clear();
                MessageBox.Show(msj, "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminarTipoProducto_Click(object sender, EventArgs e)
        {
            if (dgvTipoMain.SelectedRows.Count <= 0)
            {
                btnCargarTipoProducto_Click(sender, e);
                MessageBox.Show("Selecione una fila de la lista de Tipos o Areas de producto");

            }
            else
            {
                if (MessageBox.Show("Los cambios no se pueden deshacer ¿Desea continuar?", "¡Se eliminara el registro.!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (dgvTipoMain.SelectedRows.Count > 0)
                    {

                        negProveedor negProveedor = new negProveedor();
                        negTipoProducto negTipo = new negTipoProducto();

                        int id = int.Parse(dgvTipoMain.CurrentRow.Cells["clmID"].Value.ToString());
                        string msj = "";
                      
                        negTipo.eliminarTipo(id, out msj);

                        if (msj.Equals("OK"))
                        {
                            MessageBox.Show("Se ha eliminado el Area/Tipo correctamente", "Proceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(msj, "Proceso incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione una fila de la lista de Areas/Tipos");
                    }

                    btnCargarTipoProducto_Click(sender, e);
                }
            }
        }
    }
}
