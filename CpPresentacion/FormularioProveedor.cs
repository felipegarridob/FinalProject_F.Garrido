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
    public partial class FormularioProveedor : Form
    {
        public FormularioProveedor()
        {
            InitializeComponent();
        }

        public int obtenerIdProveedor(List<Proveedor> listaProveedor, string ItemSelect)
        {
            if (listaProveedor.Count > 0)
            {
                if (!string.IsNullOrEmpty(ItemSelect))
                {
                    foreach (Proveedor prov in listaProveedor)
                    {
                        if (prov.Descripcion.Equals(ItemSelect)) //valido que descripcion de proveedor sea igual a la seleccion de cmb
                        {
                            return prov.Id_Proveedor; //retorno id de proveedor encontrado.
                        }
                    }
                }
            }

            return 0;
        }

        public void limpiar()
        {
            txtDescripcionProveedor.Text = "";

            txtDescripcionProveedor.BackColor = Color.White;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormularioProveedor_Load(object sender, EventArgs e)
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
                MessageBox.Show("No se admiten valores que no sean numericos en los campos 'Valor de Compra', 'Valor de Venta', 'Cantidad de Stock', 'Stock Minimo' ");
                valida = false;
            }

            if (valida)
            {
                
                negProveedor negProveedor = new negProveedor();
                

                string msj = ""; bool descripcion;

                try
                {
                    Proveedor proveedor = new Proveedor(txtDescripcionProveedor.Text);

                    negProveedor.registroDeNuevoProveedor(proveedor, out descripcion, out msj);

                    if (msj.Equals("OK"))
                    {

                        MessageBox.Show("Registrado!", "Registro Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        limpiar();

                    }
                    else
                    {
                        MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (descripcion == true)
                        {
                            txtDescripcionProveedor.BackColor = Color.Red;
                        }
                        else
                        {
                            txtDescripcionProveedor.BackColor = Color.White;
                        }
                        //-------------------------------------

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Existen campos vacios o erroneos, reintente ", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
