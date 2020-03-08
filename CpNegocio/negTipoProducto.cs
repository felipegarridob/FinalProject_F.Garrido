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
    public class negTipoProducto
    {


        /*
        Misma logica utilizada en negProducto y negProveedor
        se replican los metodos solo cambiando parametros y valores de entrada y salida segunn tablas y clases
             
        */
        public DataTable SP_TipoProducto(int id, out string msj)

        {
            msj = "";
            daoTipoProducto daoTipoProducto = new daoTipoProducto();
            DataTable tabla = new DataTable();
            tabla = daoTipoProducto.SP_TipoProducto(id, out msj);
            return tabla;

        }

        public List<TipoProducto> listaTodosTipoProductosNeg()
        {
            daoTipoProducto daoTipoProducto = new daoTipoProducto();
            return daoTipoProducto.listaTodosTipoProducto();

        }

        public void cargaCmbTipo(ComboBox cb, out string msj)
        {
            msj = "";
            daoTipoProducto daoTipoProducto = new daoTipoProducto();
            daoTipoProducto.llenarItemsTipoProducto(cb);
        }

        public void registroDeNuevoTpo(TipoProducto tipo, out bool area, out string msj)
        {

            msj = "";
            //id = false;
            area = false;


            //Valida que la descripcion/nombre de Proveedor no este vacia

            if (tipo.Area.Equals(""))
            {
                msj += "Error en el campo 'Area', debe ingresar un dato" + "\n";
                area = true;
            }

            // Si se cumplen las validaciones anteriores y la variable msj esta vacia se consume el metodo registrarProductoNuevo de la clase daoProducto en la capa CpPersitencia

            if (msj.Equals(""))
            {
                
                daoTipoProducto daoTipo = new daoTipoProducto();
                daoTipo.registrarTipoNuevo(tipo, out msj);
    

            }
        }

        public void ActualizarTipoProducto(int id, string area, out string msj)
        {
            msj = "";
            daoTipoProducto daoTipo = new daoTipoProducto();
            daoTipo.ActualizarTipoProducto(id, area, out msj);
           
        }

        public List<TipoProducto> consultarTodosLosTipos(out string msj)
        {
            msj = "";
            daoTipoProducto daoTipo = new daoTipoProducto();
            return daoTipo.consultaDeTodosLosTipos(out msj);

        }

        public void eliminarTipo(int id, out string msj)
        {
            msj = "";
            daoTipoProducto daoTipo = new daoTipoProducto();
            daoTipo.eliminarTipo(id, out msj);
        }
    }
}
