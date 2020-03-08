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
    public partial class FormularioNuevoTipoProducto : Form
    {
        public FormularioNuevoTipoProducto()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtArea.Text = "";

            txtArea.BackColor = Color.White;

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
                MessageBox.Show("No se admiten valores que no sean numericos en los campos 'Valor de Compra', 'Valor de Venta', 'Cantidad de Stock', 'Stock Minimo' ");
                valida = false;
            }

            if (valida)
            {

                
                negTipoProducto negTipo = new negTipoProducto();


                string msj = ""; bool area;

                try
                {
                   
                    TipoProducto tipo = new TipoProducto(txtArea.Text);

                    negTipo.registroDeNuevoTpo(tipo, out area, out msj);

                   

                    if (msj.Equals("OK"))
                    {

                        MessageBox.Show("Registrado!", "Registro Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        limpiar();

                    }
                    else
                    {
                        MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (area == true)
                        {
                            txtArea.BackColor = Color.Red;
                        }
                        else
                        {
                            txtArea.BackColor = Color.White;
                        }
                        //-------------------------------------

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Existen campos vacios, reintente ", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
