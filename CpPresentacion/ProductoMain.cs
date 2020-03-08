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

namespace CpPresentacion
{
    public partial class ProductoMain : Form
    {
        public ProductoMain()
        {
            InitializeComponent();
        }

     


        //Evento clik del Button btnConsultar, consume consultarTodosLosProductos de la clase negProducto en la capa CpNegocio 
        //que a su vez consume consultaDeTodosLosProductos de la clase daoProducto en la capa CpPersistencia
        // cargar los datos obtenidos en DataGridView dvgProductosMain
        public void btnConsultar_Click(object sender, EventArgs e)
        {   
            
            negProducto negProducto = new negProducto();
            string msj = "";

            List<Producto> listaDeProductos = negProducto.consultarTodosLosProductos(out msj);

            if (msj.Equals("OK"))
            {

                dvgProductosMain.Rows.Clear();

                foreach (Producto producto in listaDeProductos)
                {
                    dvgProductosMain.Rows.Add(producto.NumeroSerie, producto.Descripcion, producto.ValorCompra, producto.ValorVenta, producto.CantidadStock, producto.StockMinimo, producto.Id_tipoProducto, producto.Id_proveedor);
                }
            }
            else
            {
                dvgProductosMain.Rows.Clear();
                MessageBox.Show(msj, "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            //ProdxProv PxP = new ProdxProv();
            //PxP.ShowDialog();
            Consultas PantallaConsultas = new Consultas();
            PantallaConsultas.ShowDialog();
           
        }

        //Evento click del Button btnNuevo que nos envia al WinForm FormularioProductos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormularioProductos pantallaFormularioProductos = new FormularioProductos();
            pantallaFormularioProductos.ShowDialog();    
        }

        //Evento click del Button btnEditar que nos envia al WinForm FormularioProductos con datos de una fila selecionada
        //en el DataGridView dvgProductosMain. Valida que exista una fila selecionada para poder editar.
        //Nota: resolver error. Cuando no se a cargado la lista en el DataGridView con el btnConsultar y se presiona btnEditar
        // arroja un error.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormularioActualizar frm = new FormularioActualizar();
            negProveedor negProveedor = new negProveedor();
            //int id_proveedor = obtenerIdProveedor(negProveedor.listaTodosProveedoresNeg(), frm.cmbProveedorActualizar.SelectedItem.ToString());
          
            if (dvgProductosMain.SelectedRows.Count > 0)
            {
                frm.txtIdProductoActualizar.Text = dvgProductosMain.CurrentRow.Cells[0].Value.ToString();
                frm.txtDescripcionProductoActualizar.Text = dvgProductosMain.CurrentRow.Cells[1].Value.ToString();
                frm.txtValorCompraActualizar.Text = dvgProductosMain.CurrentRow.Cells[2].Value.ToString();
                frm.txtValorVentaActualizar.Text = dvgProductosMain.CurrentRow.Cells[3].Value.ToString();
                frm.txtCantidadStockActualizar.Text = dvgProductosMain.CurrentRow.Cells[4].Value.ToString();
                frm.txtStockMinimoActualizar.Text = dvgProductosMain.CurrentRow.Cells[5].Value.ToString(); 
                frm.cmbProveedorActualizar.Text = dvgProductosMain.CurrentRow.Cells[6].Value.ToString();
                frm.cmbTipoProductoActualizar.Text = dvgProductosMain.CurrentRow.Cells[7].Value.ToString();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Selecione una fila de la lista de productos");
            }
            btnConsultar_Click(sender, e);
            

        }


        //evento click en Button btnElimar, sin uso aun. Consume eliminaProducto de la clase negProducto en la capa CpNegocio
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgProductosMain.SelectedRows.Count <= 0)
            {
                btnConsultar_Click(sender, e);
                MessageBox.Show("Selecione una fila de la lista de productos");
                
            }
            else
            {
                if (MessageBox.Show("Los cambios no se pueden deshacer ¿Desea continuar?", "¡Se eliminara el registro.!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (dvgProductosMain.SelectedRows.Count > 0)
                    {

                        negProducto negProducto = new negProducto();

                        int id = int.Parse(dvgProductosMain.CurrentRow.Cells["clmID"].Value.ToString());
                        string msj = "";
                        negProducto.EliminarProducto(id, out msj);

                        if (msj.Equals("OK"))
                        {
                            MessageBox.Show("Se ha eliminado el producto correctamente", "Proceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(msj, "Proceso incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione una fila de la lista de productos");
                    }

                    btnConsultar_Click(sender, e);
                }
            }
           
            

            

        }

       
    }
}
