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
   public  class daoTipoProducto
    {
        private string cadena = @"Data Source=DESKTOP-RBBEAOT;Initial Catalog=PROYECTOFINAL;Integrated Security=True";


        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            if (conexion.State == ConnectionState.Closed)

                conexion.Open();
            return conexion;

        }

        public DataTable SP_TipoProducto(int id, out string msj)

        {
            msj = "";
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);

                SqlDataReader leer;
                DataTable tabla = new DataTable();
                SqlCommand comando = new SqlCommand();

                comando.Connection = AbrirConexion();
                comando.CommandText = "sp_Busqueda_Cod_Tipo_Producto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ID_TIPO_PRODUCTO", SqlDbType.Int).Value = id;
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

        public List<TipoProducto> listaTodosTipoProducto()
        {

            SqlConnection conexion = new SqlConnection(cadena);

            try
            {
                DataTable data = new DataTable();
                conexion.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM TIPO_PRODUCTO", conexion);
                sqlData.Fill(data);

                if (data.Rows.Count > 0)
                {
                    List<TipoProducto> tipos = new List<TipoProducto>();

                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        TipoProducto tipo = new TipoProducto();
                        tipo.Id_TipoProducto = Convert.ToInt32(data.Rows[i][0].ToString());
                        tipo.Area = data.Rows[i][1].ToString();

                        tipos.Add(tipo);
                    }

                    return tipos;
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

        public void llenarItemsTipoProducto(ComboBox cb)

        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT AREA FROM TIPO_PRODUCTO", conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr["AREA"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
            }
        }

        public void registrarTipoNuevo(TipoProducto TIPO, out string msj)
        {
            msj = "";


            try
            {
                //conexion a base de datos insercion de datos a BD
                //resolver dudas con respecto a id de producto, tengo error 
                SqlConnection conexion = new SqlConnection(cadena);

                string query = "INSERT INTO TIPO_PRODUCTO VALUES ('" + TIPO.Area + "');";
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

        public void ActualizarTipoProducto(int id, string area, out string msj)
        {
            msj = "";
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand("sp_Tipo_Actualizar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_TIPO_PRODUCTO", id);
                cmd.Parameters.AddWithValue("@AREA", area);

                conexion.Open();
                int aux = cmd.ExecuteNonQuery();
                conexion.Close();
                if (aux > 0)
                {
                    msj += "OK";
                }
                else
                {
                    msj += "Ocurrio un error durante la actualizacion ()!";
                }

            }
            catch (Exception ex)
            {

                msj = ex.Message;
            }

        }

        public List<TipoProducto> consultaDeTodosLosTipos(out string msj)
        {
            try
            {
                msj = "";
                SqlConnection conexion = new SqlConnection(cadena);
                string query = "SELECT * FROM TIPO_PRODUCTO";
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(query, conexion);
                DataTable tbltTpos = new DataTable();
                conexion.Open();
                sqlAdaptador.Fill(tbltTpos);
                conexion.Close();

                if (tbltTpos.Rows.Count > 0)
                {
                    
                    List<TipoProducto> listaTipos = new List<TipoProducto>();

                    for (int i = 0; i < tbltTpos.Rows.Count; i++)
                    {
                       
                        TipoProducto tipoNuevo = new TipoProducto(int.Parse(tbltTpos.Rows[i][0].ToString()), tbltTpos.Rows[i][1].ToString());
                        listaTipos.Add(tipoNuevo);
                    }

                    msj = "OK";
                    return listaTipos;
                }
                else
                {
                    msj = "No contiene Areas o Tipos registrados";
                    return new List<TipoProducto>();
                }
            }
            catch (Exception ex)
            {
                msj = ex.Message;
                return new List<TipoProducto>();
            }




        }

        public void eliminarTipo(int id, out string msj)
        {
            msj = "";

            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand("sp_Eliminar_Tipo_Producto", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                //variables del procedimiento
                cmd.Parameters.Add("@ID_TIPO_PRODUCTO", SqlDbType.Int).Value = id;
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

    }
}
