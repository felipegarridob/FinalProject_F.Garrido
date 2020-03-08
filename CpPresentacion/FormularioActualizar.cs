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
    public partial class FormularioActualizar : Form
    {
        public FormularioActualizar()
        {
            InitializeComponent();
        }

        private void FormularioActualizar_Load(object sender, EventArgs e)
        {
            
            string msj = "";
            negProducto negProducto = new negProducto();
            negProveedor negProveedor = new negProveedor();
            negTipoProducto negTipoProducto = new negTipoProducto();

            negProveedor.cargaCmbProveedor(cmbProveedorActualizar, out msj);
            negTipoProducto.cargaCmbTipo(cmbTipoProductoActualizar, out msj);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
                negProducto negProducto = new negProducto();
                negProveedor negProveedor = new negProveedor();
                negTipoProducto negTipoProducto = new negTipoProducto();

                string msj = ""; 

                //List<Proveedor> listaProveedores = negProducto.listaTodosProveedoresNeg();
                FormularioProductos formulariorProductos = new FormularioProductos();

                int id_proveedor = formulariorProductos.obtenerIdProveedor(negProveedor.listaTodosProveedoresNeg(), cmbProveedorActualizar.SelectedItem.ToString());

                int id_tipoProducto = formulariorProductos.obtenerIdTipoProducto(negTipoProducto.listaTodosTipoProductosNeg(), cmbTipoProductoActualizar.SelectedItem.ToString());

                double PrecioVentaPor = int.Parse(txtValorCompraActualizar.Text) * 1.3;
                

                if (id_proveedor != 0)
                {
                    if (txtDescripcionProductoActualizar.Text != "")
                    {
                        txtDescripcionProductoActualizar.BackColor = Color.White;

                        if (txtValorCompraActualizar.Text != "" && int.Parse(txtValorCompraActualizar.Text) > 0)
                        {
                            txtValorCompraActualizar.BackColor = Color.White;

                            if (txtValorVentaActualizar.Text != "" && int.Parse(txtValorVentaActualizar.Text) > 0)
                            {
                                txtValorVentaActualizar.BackColor = Color.White;

                                if (txtCantidadStockActualizar.Text != "" && int.Parse(txtCantidadStockActualizar.Text)>0)
                                {
                                    txtCantidadStockActualizar.BackColor = Color.White;

                                    if (txtStockMinimoActualizar.Text != "" && int.Parse(txtStockMinimoActualizar.Text)>0)
                                    {
                                        txtStockMinimoActualizar.BackColor = Color.White;

                                        if (int.Parse(txtValorVentaActualizar.Text)>= PrecioVentaPor)
                                        {
                                                            //----------------------------------------------
                                                            int id = int.Parse(txtIdProductoActualizar.Text);
                                                            //para actualizar
                                                            negProducto.ActualizarProducto(int.Parse(txtIdProductoActualizar.Text), txtDescripcionProductoActualizar.Text, int.Parse(txtValorCompraActualizar.Text), int.Parse(txtValorVentaActualizar.Text), int.Parse(txtCantidadStockActualizar.Text), int.Parse(txtStockMinimoActualizar.Text), id_tipoProducto, id_proveedor, out msj);

                                                            if (msj.Equals("OK"))
                                                            {
                                                                MessageBox.Show("Actualizado!", "Edicion Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                formulariorProductos.limpiar();
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
                                            MessageBox.Show("El Valor de Venta debe tener al menos un 30% de recargo sobre el Valor de Compra. Valor venta minimo sugerido: "+PrecioVentaPor+"","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtValorVentaActualizar.BackColor = Color.Red;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("El campo esta vacio o es menor o igual a 0","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtStockMinimoActualizar.BackColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El campo esta vacio o es menor o igual a 0", "Atencion",MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtCantidadStockActualizar.BackColor = Color.Red;
                                    
                                }
                            }
                            else
                            {
                                MessageBox.Show("El campo esta vacio o es menor o igual a 0","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtValorVentaActualizar.BackColor = Color.Red;
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo esta vacio o es menor o igual a 0","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtValorCompraActualizar.BackColor = Color.Red;
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe incluir una descripcion", "Atencion",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDescripcionProductoActualizar.BackColor = Color.Red;
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show("No existe el proveedor seleccionado.","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            

        }

        private void btnCancelarActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la edicion?"+" Los cambios no se guardaran", "¡Atencion!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
