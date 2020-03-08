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
    public partial class FormActualizarProveedor : Form
    {
        public FormActualizarProveedor()
        {
            InitializeComponent();
        }

        private void lblIngresoProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool valida = false;

            try
            {

                valida = true;
            }
            catch (Exception)
            {
              
                valida = false;
            }

            if (valida)
            {
                negProveedor negProveedor = new negProveedor();
                

                string msj = "";
               
               

                if (txtDescripcionProveedorActualizar.Text != "")
                {

                    //----------------------------------------------
                    int id = int.Parse(txtIdProveedorActualizar.Text);
                    //para actualizar
                    negProveedor.ActualizarProveedor(id, txtDescripcionProveedorActualizar.Text, out msj);

                    if (msj.Equals("OK"))
                    {
                        MessageBox.Show("Actualizado!", "Edicion Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //----------------------------------------------
                }
                else
                {
                    MessageBox.Show("Debe incluir una descripcion para actualizar", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                      

            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
