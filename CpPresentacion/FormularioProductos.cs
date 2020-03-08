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
    public partial class FormularioProductos : Form
    {
        private string cadena = @"Data Source=DESKTOP-RBBEAOT;Initial Catalog=PROYECTOFINAL;Integrated Security=True";

        public FormularioProductos()
        {

            InitializeComponent();
        }



        //========Carga de datos de BD a Combobox=========
        //------------------------------------------------------------------------------
        //Consume los dos metodos de carga de datos de BD a combobox de Formulario Productos
        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            string msj = "";
            negProducto negProducto = new negProducto();
            negProveedor negProveedor = new negProveedor();
            negTipoProducto negTipoProducto = new negTipoProducto();

            negProveedor.cargaCmbProveedor(cmbProveedor, out msj);
            negTipoProducto.cargaCmbTipo(cmbTipoProducto, out msj);


        }


        //Limpia los TextBox correspondientes al FormularioProductos. Podria usarse tambien en el formulario de modificacion de datos.
        public void limpiar()
        {
            txtDescripcionProducto.Text = "";
            txtValorCompra.Text = "";
            txtValorVenta.Text = "";
            txtCantidadStock.Text = "";
            txtStockMinimo.Text = "";


            txtDescripcionProducto.BackColor = Color.White;
            txtValorCompra.BackColor = Color.White;
            txtValorVenta.BackColor = Color.White;
            txtCantidadStock.BackColor = Color.White;
            txtStockMinimo.BackColor = Color.White;
        }
        //-------------------------------------------------------------------------------------------

        //Obtengo id Proveedor
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

        //Obtengo id TipoProducto
        public int obtenerIdTipoProducto(List<TipoProducto> listaTipoProducto, string ItemSelect)
        {
            if (listaTipoProducto.Count > 0)
            {
                if (!string.IsNullOrEmpty(ItemSelect))
                {
                    foreach (TipoProducto tipo in listaTipoProducto)
                    {
                        if (tipo.Area.Equals(ItemSelect)) //valido que descripcion de proveedor sea igual a la seleccion de cmb
                        {
                            return tipo.Id_TipoProducto; //retorno id de proveedor encontrado.
                        }
                    }
                }
            }

            return 0;
        }

        //Evento Click del Button btnGuardar en formulario productos.
        //Notas:
        //      -encontrar manera de capturar los datos de los combobox para asociar un proveedor y area a los productos agregados.
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
                negProducto negProducto = new negProducto();
                negProveedor negProveedor = new negProveedor();
                negTipoProducto negTipoProducto = new negTipoProducto();

                string msj = "";  bool descripcion; bool valorCompra; bool valorVenta; bool cantStock; bool stockMin; bool idTipoProducto; bool idProveedor;

                //List<Proveedor> listaProveedores = negProducto.listaTodosProveedoresNeg();

                int id_proveedor = obtenerIdProveedor(negProveedor.listaTodosProveedoresNeg(), cmbProveedor.SelectedItem.ToString());

                int id_tipoProducto = obtenerIdTipoProducto(negTipoProducto.listaTodosTipoProductosNeg(), cmbTipoProducto.SelectedItem.ToString());

                if (id_proveedor != 0)
                {

                    try
                    {
                        Producto producto = new Producto(txtDescripcionProducto.Text, int.Parse(txtValorCompra.Text), int.Parse(txtValorVenta.Text), int.Parse(txtCantidadStock.Text), int.Parse(txtStockMinimo.Text), id_tipoProducto, id_proveedor);

                        negProducto.registroDeNuevoProducto(producto, out descripcion, out valorCompra, out valorVenta, out cantStock, out stockMin, out idTipoProducto, out idProveedor, out msj);

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
                                txtDescripcionProducto.BackColor = Color.Red;
                            }
                            else
                            {
                                txtDescripcionProducto.BackColor = Color.White;
                            }
                            //-------------------------------------
                            if (valorCompra == true)
                            {
                                txtValorCompra.BackColor = Color.Red;
                            }
                            else
                            {
                                txtValorCompra.BackColor = Color.White;
                            }
                            //---------------------------------------------
                            if (valorVenta == true)
                            {
                                txtValorVenta.BackColor = Color.Red;
                            }
                            else
                            {
                                txtValorVenta.BackColor = Color.White;
                            }
                            //----------------------------------------
                            if (cantStock == true)
                            {
                                txtCantidadStock.BackColor = Color.Red;
                            }
                            else
                            {
                                txtCantidadStock.BackColor = Color.White;
                            }
                            //-------------------------------------
                            if (stockMin == true)
                            {
                                txtStockMinimo.BackColor = Color.Red;
                            }
                            else
                            {
                                txtStockMinimo.BackColor = Color.White;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Existen campos vacios o con formato erroneo, reintente ", "Error en Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                   
                }
                else
                {
                    MessageBox.Show(msj, "No existe el proveedor seleccionado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //-tengo error al ingresar datos "System.FormatException:'La cadena de entrada no tiene el formato correcto.'", este ocuure al insertar datos sin agregar ID.
            //-tengo error al ingresar datos "El nombre de columna o los valores especificados no corresdponden a la definicion de la tabla" este ocuure al ingresar datos sin ID
                

                



            }
            ProductoMain ProductoMain = new ProductoMain();
            ProductoMain.btnConsultar_Click(sender, e);
            

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
