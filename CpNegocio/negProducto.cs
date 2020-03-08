using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CpPersitencia;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace CpNegocio
{
    public class negProducto
    {
            //SI
        public void registroDeNuevoProducto(Producto producto, out bool descripcion, out bool valorCompra, out bool valorVenta, out bool canStock, out bool stockMin, out bool idTipoProducto, out bool idProveedor, out string msj)
        {
            
            msj = "";
            //variable para validar que el valorVenta tenga al menos un 30% de sobrecargo sobre el valorCompra
            double valVentaTotal = producto.ValorCompra * 1.3;
            //id = false;
            descripcion = false;
            valorCompra = false;
            valorVenta = false;
            canStock = false;
            stockMin = false;
            idTipoProducto = false;
            idProveedor = false;
           

            //Valida que la descripcion/nombre de Producto no este vacia

            if (producto.Descripcion.Equals(""))
            {
                msj += "Error en el campo 'Descripcion', debe ingresar un dato" + "\n";
                descripcion = true;
            }

            // Validación de ValorCompra, no debe ser menor o igual a 0

            if (producto.ValorCompra<= 0)
            {
                msj += "El valor compra debe ser mayor que 0" + "\n";
                valorCompra = true;
            }

            //Validacion de ValorCompra, no debe ser mayor o igual a ValorVenta
            if (producto.ValorCompra >= producto.ValorVenta)
            {
                msj += "El 'Valor de  Compra' debe ser menor que el 'Valor de Venta' " + "\n";
                valorCompra = true;
            }

            //Validacion ValorVenta, no debe ser menor o igual a 0
            if (producto.ValorVenta <=0 )
            {
                msj += "El 'Valor de Venta' debe ser mayor que 0" + "\n";
                valorVenta = true;
            }

            //Validacion de ValorVenta, no debe ser menor que ValorCompra
            if (producto.ValorVenta <= producto.ValorCompra)
            {
                msj += "El 'Valor de Venta' debe ser mayor que el 'Valor de Compra'" + "\n";
                valorVenta = true;
            }

            //Validacion de ValorVenta, no debe ser menor que el valor VentaTotal, este ultimo corresponde al valor compra con un sobrecargo de 30%
            if (producto.ValorVenta < valVentaTotal)
            {
                msj = "El 'Valor de Venta' debe tener al menos un 30% de recargo sobre el 'Valor de Compra'."+ "\n" +"Valor sugerido: "+ valVentaTotal + "\n";
                valorVenta = true;
            }

            //Validacion de CantidadStock, no debe ser menor o igual a 0
            if (producto.CantidadStock <= 0)
            {
                msj += "La cantidad de stock ingresado debe ser mayor que 0"+ "\n";
                canStock = true;

            }

            //Validacion CantidadStock, no debe ser menor que el stockMinimo
            if (producto.CantidadStock < producto.StockMinimo)
            {
                msj = "La cantidad stock esta por debajo del stock minimo permitido"+ "\n";
                canStock = true;
            }

            //Validacion stockMinimo, no debe ser menor o igual a cuatro para condicionar un minimo de 5 unidades en stock
            if (producto.StockMinimo <= 4)
            {
                msj = "El stock minimo permitido debe ser igual o mayor a 5"+ "\n";
            }

          


            // Si se cumplen las validaciones anteriores y la variable msj esta vacia se consume el metodo registrarProductoNuevo de la clase daoProducto en la capa CpPersitencia

            if (msj.Equals(""))
            {
                daoProducto daoProducto = new daoProducto();

                daoProducto.registrarProductoNuevo(producto, out msj);

            }
        }
            //SI
        public void ActualizarProducto(int id, string descripcion, int valComp, int valVent, int cantStock, int stockMin, int idTipo, int idProv, out string msj )
         {
             msj = "";
             daoProducto daoProducto = new daoProducto();
             daoProducto.ActualizarProducto(id, descripcion,valComp,valVent, cantStock, stockMin, idTipo, idProv, out msj);

         }

        /*public void ActualizarProducto2(Producto producto, out bool descripcion, out bool valorCompra, out bool valorVenta, out bool canStock, out bool stockMin, out bool idTipoProducto, out bool idProveedor, out string msj)
        {
            msj = "";
            //variable para validar que el valorVenta tenga al menos un 30% de sobrecargo sobre el valorCompra
            double valVentaTotal = producto.ValorCompra * 1.3;
            //id = false;
            descripcion = false;
            valorCompra = false;
            valorVenta = false;
            canStock = false;
            stockMin = false;
            idTipoProducto = false;
            idProveedor = false;


            //Valida que la descripcion/nombre de Producto no este vacia

            if (producto.Descripcion.Equals(""))
            {
                msj += "Error en el campo 'Descripcion', debe ingresar un dato" + "\n";
                descripcion = true;
            }

            // Validación de ValorCompra, no debe ser menor o igual a 0

            if (producto.ValorCompra <= 0)
            {
                msj += "El valor compra debe ser mayor que 0" + "\n";
                valorCompra = true;
            }

            //Validacion de ValorCompra, no debe ser mayor o igual a ValorVenta
            if (producto.ValorCompra >= producto.ValorVenta)
            {
                msj += "El 'Valor de  Compra' debe ser menor que el 'Valor de Venta' " + "\n";
                valorCompra = true;
            }

            //Validacion ValorVenta, no debe ser menor o igual a 0
            if (producto.ValorVenta <= 0)
            {
                msj += "El 'Valor de Venta' debe ser mayor que 0" + "\n";
                valorVenta = true;
            }

            //Validacion de ValorVenta, no debe ser menor que ValorCompra
            if (producto.ValorVenta <= producto.ValorCompra)
            {
                msj += "El 'Valor de Venta' debe ser mayor que el 'Valor de Compra'" + "\n";
                valorVenta = true;
            }

            //Validacion de ValorVenta, no debe ser menor que el valor VentaTotal, este ultimo corresponde al valor compra con un sobrecargo de 30%
            if (producto.ValorVenta < valVentaTotal)
            {
                msj = "El 'Valor de Venta' debe tener al menos un 30% de recargo sobre el 'Valor de Compra'." + "\n" + "Valor sugerido: " + valVentaTotal + "\n";
                valorVenta = true;
            }

            //Validacion de CantidadStock, no debe ser menor o igual a 0
            if (producto.CantidadStock <= 0)
            {
                msj += "La cantidad de stock ingresado debe ser mayor que 0" + "\n";
                canStock = true;

            }

            //Validacion CantidadStock, no debe ser menor que el stockMinimo
            if (producto.CantidadStock < producto.StockMinimo)
            {
                msj = "La cantidad stock esta por debajo del stock minimo permitido" + "\n";
                canStock = true;
            }

            //Validacion stockMinimo, no debe ser menor o igual a cuatro para condicionar un minimo de 5 unidades en stock
            if (producto.StockMinimo <= 4)
            {
                msj = "El stock minimo permitido debe ser igual o mayor a 5" + "\n";
            }




            // Si se cumplen las validaciones anteriores y la variable msj esta vacia se consume el metodo registrarProductoNuevo de la clase daoProducto en la capa CpPersitencia

            if (msj.Equals(""))
            {
                daoProducto daoProducto = new daoProducto();

                daoProducto.ActualizarProducto2(producto, out msj);

            }
        }*/


            //SI

        public List<Producto> consultarTodosLosProductos(out string msj)
        {
            msj = "";
            daoProducto daoProducto = new daoProducto();
            return daoProducto.consultaDeTodosLosProductos(out msj);

        }


        //*****************SIN USO!!!*********************
        //SOLO LO COMENTADO
        /*public List<Proveedor> consultarTodosLosProveedores(out string msj)
        {
            msj = "";
            daoProducto daoProducto = new daoProducto();
            return daoProducto.consultaDeTodosLosProveedores(out msj);
        }
        /* public List<Proveedor> ProvSP(int id, out string msj)
       {
           msj = "";
           daoProducto daoProducto = new daoProducto();
           return daoProducto.ProvSP(id, out msj);
       }*/
        /*public void ConsultaProveedor(int id, out string msj)
        {
            msj = "";
            daoProducto daoProducto = new daoProducto();
            daoProducto.consultaProveedor(id, out msj);
        }*/
        /* public DataTable ProductosPorProveedor2()
        {
            
            daoProducto daoProducto = new daoProducto();
            DataTable tabla = new DataTable();
            tabla = daoProducto.consultaProductosPorProveedor2();
            return tabla;
        }*/
        /*public void actualizarProdcuto2(Producto producto, int id, out bool descripcion, out bool valorCompra, out bool valorVenta, out bool canStock, out bool stockMin, out bool idTipoProducto, out bool idProveedor, out string msj)
     {
         msj = "";
         //variable para validar que el valorVenta tenga al menos un 30% de sobrecargo sobre el valorCompra
         double valVentaTotal = producto.ValorCompra * 1.3;
         //id = false;
         descripcion = false;
         valorCompra = false;
         valorVenta = false;
         canStock = false;
         stockMin = false;
         idTipoProducto = false;
         idProveedor = false;


         //Valida que la descripcion/nombre de Producto no este vacia

         if (producto.Descripcion.Equals(""))
         {
             msj += "Error en el campo 'Descripcion', debe ingresar un dato" + "\n";
             descripcion = true;
         }

         // Validación de ValorCompra, no debe ser menor o igual a 0

         if (producto.ValorCompra <= 0)
         {
             msj += "El valor compra debe ser mayor que 0" + "\n";
             valorCompra = true;
         }

         //Validacion de ValorCompra, no debe ser mayor o igual a ValorVenta
         if (producto.ValorCompra >= producto.ValorVenta)
         {
             msj += "El 'Valor de  Compra' debe ser menor que el 'Valor de Venta' " + "\n";
             valorCompra = true;
         }

         //Validacion ValorVenta, no debe ser menor o igual a 0
         if (producto.ValorVenta <= 0)
         {
             msj += "El 'Valor de Venta' debe ser mayor que 0" + "\n";
             valorVenta = true;
         }

         //Validacion de ValorVenta, no debe ser menor que ValorCompra
         if (producto.ValorVenta <= producto.ValorCompra)
         {
             msj += "El 'Valor de Venta' debe ser mayor que el 'Valor de Compra'" + "\n";
             valorVenta = true;
         }

         //Validacion de ValorVenta, no debe ser menor que el valor VentaTotal, este ultimo corresponde al valor compra con un sobrecargo de 30%
         if (producto.ValorVenta < valVentaTotal)
         {
             msj = "El 'Valor de Venta' debe tener al menos un 30% de recargo sobre el 'Valor de Compra'." + "\n" + "Valor sugerido: " + valVentaTotal + "\n";
             valorVenta = true;
         }

         //Validacion de CantidadStock, no debe ser menor o igual a 0
         if (producto.CantidadStock <= 0)
         {
             msj += "La cantidad de stock ingresado debe ser mayor que 0" + "\n";
             canStock = true;

         }

         //Validacion CantidadStock, no debe ser menor que el stockMinimo
         if (producto.CantidadStock < producto.StockMinimo)
         {
             msj = "La cantidad stock esta por debajo del stock minimo permitido" + "\n";
             canStock = true;
         }

         //Validacion stockMinimo, no debe ser menor o igual a cuatro para condicionar un minimo de 5 unidades en stock
         if (producto.StockMinimo <= 4)
         {
             msj = "El stock minimo permitido debe ser igual o mayor a 5" + "\n";
         }




         // Si se cumplen las validaciones anteriores y la variable msj esta vacia se consume el metodo registrarProductoNuevo de la clase daoProducto en la capa CpPersitencia

         if (msj.Equals(""))

         {

             daoProducto daoProducto = new daoProducto();

             daoProducto.ActualizarProducto2(producto,id,out msj);

         }
     }*/

        public void EliminarProducto(int id, out string msj)
        {
            msj = "";
            daoProducto daoProducto = new daoProducto();
            daoProducto.eliminarProducto(id, out msj);
        }

        //==========C A R G A  I T E M S  C O M B O B O X==========
        //carga cmbProveedor

        

        public void cargaCmbProducto(ComboBox cb, out string msj)
        {
            msj = "";
            daoProducto daoProducto = new daoProducto();
            daoProducto.llenarItemsProducto(cb);
        }

        

        //===========L I S T A S===================
        /* Listas que obtienen los ID de las tablas
         */
        

        public List<Producto> listaTodosProductosNeg()
        {
            daoProducto daoProducto = new daoProducto();
            return daoProducto.listaTodosProductos();
        }

        //Lista TodosoProveedores

        //==========P R O C E D I M I E N T O S====
        /*Procedimientos almacenados para consultas
         */

            //SP PROVEEDOR

        public DataTable SP_Productos(int id, out string msj)
        {
            msj = "";
            daoProducto daoProducto = new daoProducto();
            DataTable tabla = new DataTable();
            tabla = daoProducto.SP_Productos(id, out msj);
            return tabla;
        }

       //sp tipo



    }
}
