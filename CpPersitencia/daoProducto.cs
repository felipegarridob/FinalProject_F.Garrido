using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using System.Windows.Forms;

namespace CpPersitencia
{
    public class daoProducto
    {
        //************Autenticacion de Windows*********************************
        //private string cadena = @"Data Source=DESKTOP-RBBEAOT;Initial Catalog=PROYECTOFINAL;Integrated Security=True";

        //************Autenticacion usuario registrado en DB*******************************************************************
        private string cadena = @"Data Source=DESKTOP-RBBEAOT;Initial Catalog=PROYECTOFINAL; user id = sa; password = Felgar.1982";


        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            if (conexion.State == ConnectionState.Closed)
            
                conexion.Open();
                return conexion;
            
        }

        //metodo elimina producto, sin uso, falta crear procedimiento almacenado en DB para ser consumido
        //Se  replica para daoProveedor y daoTipoProducto, cambiando parametros de entrada y salida
        public void eliminarProducto(int id, out string msj)
        {
            msj = "";

            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand("ELIMINAR_PRODUCTO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                //variables del procedimiento
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@ERROR", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                conexion.Open();
                int aux = cmd.ExecuteNonQuery();
                conexion.Close();
                string error = cmd.Parameters["@ERROR"].Value.ToString();
                msj = error;
            }
            catch (Exception ex)
            {
                msj = ex.Message;
            }
        }

        //Metodo agrega datos a la DB segun instruccion INSERT INTO
        //Se  replica para daoProveedor y daoTipoProducto, cambiando parametros de entrada y salida
        public void registrarProductoNuevo(Producto producto, out string msj)
        {
            msj = "";

            try
            {
                //conexion a base de datos insercion de datos a BD

                SqlConnection conexion = new SqlConnection(cadena);
                string query = "INSERT INTO PRODUCTO (DESCRIPCION_PRODUCTO, VALOR_COMPRA, VALOR_VENTA, CANTIDAD_STOCK, STOCK_MINIMO, FK_ID_TIPO_PRODUCTO, FK_ID_PROVEEDOR ) VALUES ('" + producto.Descripcion + "', " + producto.ValorCompra + "," + producto.ValorVenta + " , " + producto.CantidadStock + " , " + producto.StockMinimo + " , " + producto.Id_tipoProducto + " , " + producto.Id_proveedor + ");";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                conexion.Open();
                int aux = cmd.ExecuteNonQuery();
                conexion.Close();

                if (aux > 0)
                {
                    msj += "OK";
                }
                else
                {
                    msj += "Ocurrio un error durante el registro!";
                }

            }
            catch (Exception ex)
            {
                msj += ex.Message;
            }

        }


        /*Metodo actualiza datos de la tabla PRODUCTO segun procedimeinto almacenado se envian datos desde el formulario de actualizacion
         *Se  replica para daoProveedor y daoTipoProducto, cambiando parametros de entrada y salida
         */
        public void ActualizarProducto(int id, string descripcion, int valComp, int valVent, int cantStock, int stockMin, int idTipo, int idProv, out string msj)
        {
            msj = "";
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand("PROC_ACTUALIZAR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_PRODUCTO", id);
                cmd.Parameters.AddWithValue("@DESCRIPCION_PRODUCTO", descripcion);
                cmd.Parameters.AddWithValue("@VALOR_VENTA", valVent);
                cmd.Parameters.AddWithValue("@VALOR_COMPRA", valComp);
                cmd.Parameters.AddWithValue("@CANTIDAD_STOCK", cantStock);
                cmd.Parameters.AddWithValue("@STOCK_MINIMO", stockMin);
                cmd.Parameters.AddWithValue("@FK_ID_TIPO_PRODUCTO", idTipo);
                cmd.Parameters.AddWithValue("@FK_ID_PROVEEDOR", idProv);
                conexion.Open();
                int aux = cmd.ExecuteNonQuery();
                conexion.Close();
                if (aux > 0)
                {
                    msj += "OK";
                }
                else
                {
                    msj += "Ocurrio un error durante la actualizacion (ProcActualizar)!";
                }

            }
            catch (Exception ex)
            {

                msj = ex.Message;
            }

        }



        //realzia conexion a DB y realiza consulta a tabla PRODUCTO segun instruccion SELECT * , si el resultado del conteo de filas es mayor a 0,
        // crea una lista (listaDeProductos) y recorrer todas las filas existentes y cargar datos en un DataTable (tblProducto)
        // y ser agregados a listaDeProductos para posteriormente ser retornada.
        //Este metodo sera consumido en consultarTodosLosProductos de la clase negProducto en la capa CpNegocio
        //Se  replica para daoProveedor y daoTipoProducto, cambiando parametros de entrada y salida
        public List<Producto> consultaDeTodosLosProductos(out string msj)
        {
            try
            {
                msj = "";

                SqlConnection conexion = new SqlConnection(cadena);
                string query = "SELECT * FROM PRODUCTO"; //SELECT * FROM VW_INFO_TODOS_LOS_PRODUCTOS   se intento probar una vista, sin resultados
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(query, conexion);
                DataTable tblProducto = new DataTable();
                conexion.Open();
                sqlAdaptador.Fill(tblProducto);
                conexion.Close();

                if (tblProducto.Rows.Count > 0)
                {
                    List<Producto> listaDeProductos = new List<Producto>();

                    for (int i = 0; i < tblProducto.Rows.Count; i++)
                    {
                        Producto productoNuevo = new Producto(int.Parse(tblProducto.Rows[i][0].ToString()), tblProducto.Rows[i][1].ToString(), int.Parse(tblProducto.Rows[i][2].ToString()), int.Parse(tblProducto.Rows[i][3].ToString()), int.Parse(tblProducto.Rows[i][4].ToString()), int.Parse(tblProducto.Rows[i][5].ToString()), int.Parse(tblProducto.Rows[i][6].ToString()), int.Parse(tblProducto.Rows[i][7].ToString()));
                        listaDeProductos.Add(productoNuevo);
                    }

                    msj = "OK";
                    return listaDeProductos;
                }
                else
                {
                    msj = "No contiene productos registrados";
                    return new List<Producto>();
                }
            }
            catch (Exception ex)
            {
                msj = ex.Message;
                return new List<Producto>();
            }


        }

        //*******************SIN USO!!!*************************
        //SOLO LO COMENTADO
        //metodos fallidos
        /*public List<Proveedor> consultaDeTodosLosProveedores(out string msj)
        {
            try
            {
                msj = "";

                SqlConnection conexion = new SqlConnection(cadena);
                string query = "SELECT * FROM PROVEEDOR"; //SELECT * FROM VW_INFO_TODOS_LOS_PRODUCTOS
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(query, conexion);
                DataTable tblProveedor = new DataTable();
                conexion.Open();
                sqlAdaptador.Fill(tblProveedor);
                conexion.Close();

                if (tblProveedor.Rows.Count > 0)
                {
                    List<Proveedor> listaDeProveedores = new List<Proveedor>();

                    for (int i = 0; i < tblProveedor.Rows.Count; i++)
                    {
                        Proveedor proveedorNuevo = new Proveedor(int.Parse(tblProveedor.Rows[i][0].ToString()), tblProveedor.Rows[i][1].ToString());
                        listaDeProveedores.Add(proveedorNuevo);
                    }

                    msj = "OK";
                    return listaDeProveedores;
                }
                else
                {
                    msj = "No contiene Proveedores registrados";
                    return new List<Proveedor>();
                }
            }
            catch (Exception ex)
            {
                msj = ex.Message;
                return new List<Proveedor>();
            }
        }
        */
        /*public List<Proveedor> ProvSP(int id, out string msj)
      {
          try
          {
              msj = "";

              SqlConnection conexion = new SqlConnection(cadena);
              conexion.Open();
              SqlCommand cmd = new SqlCommand();
              string query = "sp_Busqueda_Cod_Proveedor";
              SqlDataAdapter sqlAdaptador = new SqlDataAdapter(query, conexion);
              DataTable tblProveedor = new DataTable();
              conexion.Open();
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.Add("@ID_PROVEEDOR", SqlDbType.Int).Value = id;
              cmd.Parameters.Add("@ERROR", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
              conexion.Open();
              conexion.Close();

              sqlAdaptador.Fill(tblProveedor);


              if (tblProveedor.Rows.Count > 0)
              {
                  List<Proveedor> listaDeProveedores = new List<Proveedor>();

                  for (int i = 0; i < tblProveedor.Rows.Count; i++)
                  {
                      Proveedor proveedorNuevo = new Proveedor(int.Parse(tblProveedor.Rows[i][0].ToString()), tblProveedor.Rows[i][1].ToString());
                      listaDeProveedores.Add(proveedorNuevo);
                  }

                  msj = "OK";
                  return listaDeProveedores;
              }
              else
              {
                  msj = "No contiene Proveedores registrados";
                  return new List<Proveedor>();
              }
          }
          catch (Exception ex)
          {
              msj = ex.Message;
              return new List<Proveedor>();
          }
      }*/
        /*public void consultaProveedor(int id, out string msj)
        {
            msj = "";

            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand("sp_Busqueda_Cod_Proveedor", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_PROVEEDOR", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@ERROR", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                conexion.Open();
                
               
                conexion.Close();
                string error = cmd.Parameters["@ERROR"].Value.ToString();
                msj = error;
             

            }
            catch (Exception ex)
            {
                msj = ex.Message;
            }
        }*/
        /*public DataTable consultaProductosPorProveedor2()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(cadena);


                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "ProductosXProvedor";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.Close();
                return tabla;      
              
        }*/
        /* public void ActualizarProducto2(Producto producto, int id, out string msj)
     {
         msj = "";
         try
         {
             SqlConnection conexion = new SqlConnection(cadena);
             SqlCommand cmd = new SqlCommand("PROC_ACTUALIZAR", conexion);
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.AddWithValue("@ID_PRODUCTO", producto.NumeroSerie);
             cmd.Parameters.AddWithValue("@DESCRIPCION_PRODUCTO", producto.Descripcion);
             cmd.Parameters.AddWithValue("@VALOR_VENTA", producto.ValorVenta);
             cmd.Parameters.AddWithValue("@VALOR_COMPRA", producto.ValorCompra);
             cmd.Parameters.AddWithValue("@CANTIDAD_STOCK", producto.CantidadStock);
             cmd.Parameters.AddWithValue("@FK_ID_TIPO_PRODUCTO", producto.Id_tipoProducto);
             cmd.Parameters.AddWithValue("@FK_ID_PROVEEDOR", producto.Id_proveedor);
             cmd.Parameters.AddWithValue("@STOCK_MINIMO", producto.StockMinimo);

             /*cmd.Parameters.AddWithValue("@ID_PRODUCTO", SqlDbType.Int).Value = producto.NumeroSerie;
             cmd.Parameters.Add("@DESCRIPCION_PRODUCTO", SqlDbType.VarChar, 50).Value = producto.Descripcion;
             cmd.Parameters.Add("@VALOR_VENTA", SqlDbType.Int).Value = producto.ValorVenta;
             cmd.Parameters.Add("@VALOR_COMPRA", SqlDbType.Int).Value = producto.ValorCompra;
             cmd.Parameters.Add("@CANTIDAD_STOCK", SqlDbType.Int).Value = producto.CantidadStock;
             cmd.Parameters.Add("@STOCK_MINIMO", SqlDbType.Int).Value = producto.StockMinimo;
             cmd.Parameters.Add("@FK_ID_TIPO_PRODUCTO", SqlDbType.Int).Value = producto.Id_tipoProducto;
             cmd.Parameters.Add("@FK_ID_PROVEEDOR", SqlDbType.Int).Value = producto.Id_proveedor;
             conexion.Open();
             int aux = cmd.ExecuteNonQuery();
             conexion.Close();
             if (aux > 0)
             {
                 msj += "OK";
             }
             else
             {
                 msj += "Ocurrio un error durante la actualizacion (ProcActualizar)!";
             }

         }
         catch (Exception ex)
         {

             msj = ex.Message;
         }
     }*/
        /*public void ActualizarProductoNOSE(Producto producto, out string msj)
       {
           msj = "";

           try
           {
               //conexion a base de datos insercion de datos a BD

               SqlConnection conexion = new SqlConnection(cadena);


               //======1============ se setean las variables con los atributos de producto
               string query = "UPDATE PRODUCTO SET DESCRIPCION_PRODUCTO = @descripcionProd, VALOR_COMPRA = @valCompra, VALOR_VENTA = @valVenta, CANTIDAD_STOCK = @cantStock, STOCK_MINIMO = @stockMin, FK_ID_TIPO_PRODUCTO = @idTipo, FK_ID_PROVEEDOR = @idProv WHERE ID_PRODUCTO = @idProd";
               SqlCommand cmd = new SqlCommand(query, conexion);
               cmd.Parameters.AddWithValue("@descripcionProd", producto.Descripcion);
               cmd.Parameters.AddWithValue("@valCompra", producto.ValorCompra);
               cmd.Parameters.AddWithValue("@valVenta", producto.ValorVenta);
               cmd.Parameters.AddWithValue("@cantStock", producto.CantidadStock);
               cmd.Parameters.AddWithValue("@stockMin", producto.StockMinimo);
               cmd.Parameters.AddWithValue("@idTipo", producto.Id_tipoProducto);
               cmd.Parameters.AddWithValue("@idProv", producto.Id_proveedor);
               cmd.Parameters.AddWithValue("@idProd", producto.NumeroSerie);

               //======2============Incluye los parametros en la consulta
               // string query = "UPDATE PRODUCTO SET DESCRIPCION_PRODUCTO = '"+producto.Descripcion+"', VALOR_COMPRA = "+producto.ValorCompra+", VALOR_VENTA = "+producto.ValorVenta+", CANTIDAD_STOCK = "+producto.CantidadStock+", STOCK_MINIMO = "+producto.StockMinimo+", FK_ID_TIPO_PRODUCTO = "+producto.Id_tipoProducto+", FK_ID_PROVEEDOR = "+producto.Id_proveedor+" WHERE ID_PRODUCTO = " + producto.NumeroSerie;

               //=====2.1============ Incluye los parametros en la consulta con el id_producto fuera de las comillas        
               // string query = "UPDATE PRODUCTO SET DESCRIPCION_PRODUCTO = '" + producto.Descripcion + "', VALOR_COMPRA = "+producto.ValorCompra+", VALOR_VENTA = "+producto.ValorVenta+", CANTIDAD_STOCK = "+producto.CantidadStock+", STOCK_MINIMO = "+producto.StockMinimo+", FK_ID_TIPO_PRODUCTO = "+producto.Id_tipoProducto+", FK_ID_PROVEEDOR = "+producto.Id_proveedor+" WHERE ID_PRODUCTO = "+producto.NumeroSerie+"";
               //SqlCommand cmd = new SqlCommand(query, conexion);

               cmd.CommandType = System.Data.CommandType.Text;
               conexion.Open();

               int aux = cmd.ExecuteNonQuery();
               conexion.Close();

               if (aux > 0)
               {
                   msj += "OK";
               }
               else
               {
                   msj += "Ocurrio un error durante la actualizacion!";
               }

           }
           catch (Exception ex)
           {
               msj += ex.Message;
           }

       }*/



        //================P R O C E D I M I E N T O S==================================
        /*En uso y funcionando, consume SP de la DB que entrega informacion de la
         * tabla PRODUCTO
         *Se  replica para daoProveedor y daoTipoProducto, cambiando parametros de entrada y salida
         */
        public DataTable SP_Productos(int id, out string msj)

        {
            msj = "";
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);

                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();

                comando.Connection = AbrirConexion();
                comando.CommandText = "sp_Busqueda_Cod_Producto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ID_PRODUCTO", SqlDbType.Int).Value = id;
                comando.Parameters.Add("@ERROR", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.Close();

                string error = comando.Parameters["@ERROR"].Value.ToString();
                msj = error;
                return tabla;

            }
            catch (Exception ex)
            {
                msj = ex.Message;
                return new DataTable();


            }



        }



        //==============L L E N A R  C O M B O B O X===============================
        /*En uso y funcionando, carga los combobox del sistema con datos 
         * obtenidos de la DB mostrando 'DESCRIPCION' o 'N0MBRE de Productos'
         * Se  replica para daoProveedor y daoTipoProducto, cambiando parametros de entrada y salida
         */
        public void llenarItemsProducto(ComboBox cb)

        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCTO", conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr["DESCRIPCION_PRODUCTO"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }


        //===============C R E A C I O N  D E  L I S T A S=========================
        /*En uso, crea listas que seran utilizadas para obtener los ID
         de los Items selecionados en los disntintos combobox
         Se  replica para daoProveedor y daoTipoProducto, cambiando parametros de entrada y salida
         */

        public List<Producto> listaTodosProductos()
        {

            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                DataTable data = new DataTable();
                conexion.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM PRODUCTO", conexion);
                sqlData.Fill(data);

                if (data.Rows.Count > 0)
                {
                    List<Producto> ListaProductos = new List<Producto>();

                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        Producto producto = new Producto();
                        producto.NumeroSerie = Convert.ToInt32(data.Rows[i][0].ToString());
                        producto.Descripcion = data.Rows[i][1].ToString();
                        /*producto.ValorCompra = Convert.ToInt32(data.Rows[i][2].ToString());
                        producto.ValorVenta = Convert.ToInt32(data.Rows[i][3].ToString());
                        producto.CantidadStock = Convert.ToInt32(data.Rows[i][4].ToString());
                        producto.StockMinimo = Convert.ToInt32(data.Rows[i][5].ToString());
                        producto.Id_tipoProducto = Convert.ToInt32(data.Rows[i][6].ToString());
                        producto.Id_proveedor = Convert.ToInt32(data.Rows[i][7].ToString());*/

                        ListaProductos.Add(producto);
                    }

                    return ListaProductos;
                }
                else
                {
                    return null;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}