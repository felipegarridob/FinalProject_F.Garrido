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
    public partial class FormularioActualizarTipo : Form
    {
        public FormularioActualizarTipo()
        {
            InitializeComponent();
        }

        private void btnActualizarTipo_Click(object sender, EventArgs e)
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
               
                negTipoProducto negTipo = new negTipoProducto();

                string msj = "";



                if (txtAreaTipoActualizar.Text != "")
                {

                    //----------------------------------------------
                    int id = int.Parse(txtIdTiporActualizar.Text);
                    //para actualizar
                    negTipo.ActualizarTipoProducto(id, txtAreaTipoActualizar.Text, out msj);
                   

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
                    MessageBox.Show("Debe incluir un Area o Tipo para actualizar", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            
        }
    }
}
