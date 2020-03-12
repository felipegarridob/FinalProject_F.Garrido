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
    public class daoProveedor
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


        //metodo elimina proveedor consume SP de la DB se capturan datos para ejecucion en formulario MainProveedores
        public void eliminarProveedor(int id, out string msj)
        {
            msj = "";

            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand("sp_Eliminar_Proveedor", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                //variables del procedimiento
                cmd.Parameters.Add("@ID_PROVEEDOR", SqlDbType.Int).Value = id;
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


        //registra nuevo Proveedor segun instruccion INSERT INTO, solo se ingresa DESCRIPCION del proveedor ya que le id es IDENTITY
        public void registrarProveedorNuevo(Proveedor proveedor, out string msj)
        {
            msj = "";

            try
            {
                //conexion a base de datos insercion de datos a BD
                //resolver dudas con respecto a id de producto, tengo error 
                SqlConnection conexion = new SqlConnection(cadena);

                string query = "INSERT INTO PROVEEDOR VALUES ('" + proveedor.Descripcion + "');";
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

        public List<Proveedor> consultaDeTodosLosProveedores(out string msj)
        {
            try
            {
                msj = "";
                SqlConnection conexion = new SqlConnection(cadena);
                string query = "SELECT * FROM PROVEEDOR";
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(query, conexion);
                DataTable tblProveedor = new DataTable();
                conexion.Open();
                sqlAdaptador.Fill(tblProveedor);
                conexion.Close();

                if (tblProveedor.Rows.Count > 0)
                {
                    List<Proveedor> listaDeProveedor = new List<Proveedor>();

                    for (int i = 0; i < tblProveedor.Rows.Count; i++)
                    {
                        Proveedor proveedorNuevo = new Proveedor(int.Parse(tblProveedor.Rows[i][0].ToString()), tblProveedor.Rows[i][1].ToString());
                        listaDeProveedor.Add(proveedorNuevo);
                    }

                    msj = "OK";
                    return listaDeProveedor;
                }
                else
                {
                    msj = "No contiene productos registrados";
                    return new List<Proveedor>();
                }
            }
            catch (Exception ex)
            {
                msj = ex.Message;
                return new List<Proveedor>();
            }




        }

        
        public DataTable SP_Proveedor(int id, out string msj)

        {
            msj = "";
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);

                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();

                comando.Connection = AbrirConexion();
                comando.CommandText = "sp_Busqueda_Cod_Proveedor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ID_PROVEEDOR", SqlDbType.Int).Value = id;
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

        public List<Proveedor> listaTodosProveedores()
        {

            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                DataTable data = new DataTable();
                conexion.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM PROVEEDOR", conexion);
                sqlData.Fill(data);

                if (data.Rows.Count > 0)
                {
                    List<Proveedor> proveedores = new List<Proveedor>();

                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        Proveedor proveedor = new Proveedor();
                        proveedor.Id_Proveedor = Convert.ToInt32(data.Rows[i][0].ToString());
                        proveedor.Descripcion = data.Rows[i][1].ToString();

                        proveedores.Add(proveedor);
                    }

                    return proveedores;
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

        public void llenarItemsProveedor(ComboBox cb)

        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT DESCRIPCION_PROVEEDOR FROM PROVEEDOR", conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr["DESCRIPCION_PROVEEDOR"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }
         //Misma logica usada en daoProductos solo se crea nuevo SP para actualizar Proveedor ademas de los parametros de entrada y salida
         //Se replica para daoTipoProducto
        public void ActualizarProveedor(int id, string descripcion,out string msj)
        {
            msj = "";
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand("sp_Proveedor_Actualizar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_PRPROVEEDOR", id);
                cmd.Parameters.AddWithValue("@DESCRIPCION_PROVEEDOR", descripcion);
               
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

    }
}

    
