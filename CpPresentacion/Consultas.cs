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
    public partial class Consultas : Form
    {
        private string cadena = @"Data Source=DESKTOP-RBBEAOT;Initial Catalog=PROYECTOFINAL;Integrated Security=True";
        public Consultas()
        {
            InitializeComponent();
        }

        private bool Editartipo = false;

        private void Consultas_Load(object sender, EventArgs e)
        {
            string msj = "";
            negProducto negProducto = new negProducto();
            negProveedor negProveedor = new negProveedor();
            negTipoProducto negTipoProducto = new negTipoProducto();

            negProveedor.cargaCmbProveedor(cmbProveedorConsultas, out msj);
            negTipoProducto.cargaCmbTipo(cmbTipoProductoConsultas, out msj);
            negProducto.cargaCmbProducto(cmbProductoConsultas, out msj);
           // Seleccion();

        }

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
        //Obtengo id Producto
        public int obtenerIdProducto(List<Producto> listaProducto, string ItemSelect)
        {
            if (listaProducto.Count > 0)
            {
                if (!string.IsNullOrEmpty(ItemSelect))
                {
                    foreach (Producto producto in listaProducto)
                    {
                        if (producto.Descripcion.Equals(ItemSelect)) //valido que descripcion de proveedor sea igual a la seleccion de cmb
                        {
                            return producto.NumeroSerie; //retorno id de proveedor encontrado.
                        }
                    }
                }
            }

            return 0;
        }

        private void btnAceptarConsultas_Click(object sender, EventArgs e)
        {
            if (rBtnProducto.Checked == false && rBtnProveedor.Checked == false && rBtnTipo.Checked == false)
            {
                gBoxOpciones.ForeColor = Color.Red;
                MessageBox.Show("Debe selecionar una opcion ", "Sin Seleccion'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {

                gBoxOpciones.ForeColor = Color.Green;

                if (rBtnProducto.Checked == true)
                    {

                        ConsultaProductos();
                    }

                    if (rBtnProveedor.Checked == true)
                    {
                        ConsultasProveedor();
                    }
                    if (rBtnTipo.Checked == true)
                    {
                        ConsultasTipoProductos();
                    }

                }

           
           
            
            
            


        }

        private void ConsultaProductos()
        {
            this.dgvConsultas.Visible = true;
            negProducto negProducto = new negProducto();
            string msj = "";
            int id_producto = obtenerIdProducto(negProducto.listaTodosProductosNeg(), cmbProductoConsultas.SelectedItem.ToString());
            dgvConsultas.DataSource = negProducto.SP_Productos(id_producto, out msj);

        }

        private void ConsultasProveedor()
        {
            
            this.dgvConsultas.Visible = true;
            negProveedor negProveedor = new negProveedor();
            string msj = "";
            int id_proveedor = obtenerIdProveedor(negProveedor.listaTodosProveedoresNeg(),cmbProveedorConsultas.SelectedItem.ToString());
            
            dgvConsultas.DataSource = negProveedor.SP_Proveedor(id_proveedor, out msj);
        }

        private void ConsultasTipoProductos()
        {
            this.dgvConsultas.Visible = true;
            negProducto negProducto = new negProducto();
            negTipoProducto negTipoProducto = new negTipoProducto();

            string msj = "";
            int id_proveedor = obtenerIdTipoProducto(negTipoProducto.listaTodosTipoProductosNeg(), cmbTipoProductoConsultas.SelectedItem.ToString());

            dgvConsultas.DataSource = negTipoProducto.SP_TipoProducto(id_proveedor, out msj);
        }

        private void rBtnProducto_MouseClick(object sender, MouseEventArgs e)
        {
            lblTipoInfo.Visible = false;
            lblProveedorInfo.Visible = false;
            lblProductoInfo.Visible = true;
            this.cmbProductoConsultas.Enabled = true;
            this.cmbProveedorConsultas.Enabled = false;
            this.cmbTipoProductoConsultas.Enabled = false;
           // MessageBox.Show("Elija una opcion del menu deplegable", "Selecciono 'Producto'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.cmbProveedorConsultas.Enabled = false;
            this.cmbTipoProductoConsultas.Enabled = false;
        }

        private void rBtnProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            lblProductoInfo.Visible = false;
            lblTipoInfo.Visible = false;
            lblProveedorInfo.Visible = true;
            this.cmbProveedorConsultas.Enabled = true;
            this.cmbTipoProductoConsultas.Enabled = false;
            this.cmbProductoConsultas.Enabled = false;
            //MessageBox.Show("Elija una opcion del menu deplegable", "Selecciono 'Proveedor'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void rBtnTipo_MouseClick(object sender, MouseEventArgs e)
        {
            lblProveedorInfo.Visible = false;
            lblProductoInfo.Visible = false;
            lblTipoInfo.Visible = true;
            this.cmbTipoProductoConsultas.Enabled = true;
            this.cmbProductoConsultas.Enabled = false;
            this.cmbProveedorConsultas.Enabled = false;
           // MessageBox.Show("Elija una opcion del menu deplegable", "Selecciono 'Tipo de Producto'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelarConsultas_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mensaje. ¿Desea salir de la consulta?", "¡Atencion!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
            
        }
    }
}
