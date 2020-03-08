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
    public class negProveedor
    {
        public void registroDeNuevoProveedor(Proveedor proveedor, /*out bool id,*/ out bool descripcion,out string msj)
        {

            msj = "";
            //id = false;
            descripcion = false;
           

            //Valida que la descripcion/nombre de Proveedor no este vacia

            if (proveedor.Descripcion.Equals(""))
            {
                msj += "Error en el campo 'Descripcion', debe ingresar un dato" + "\n";
                descripcion = true;
            }

            // Si se cumplen las validaciones anteriores y la variable msj esta vacia se consume el metodo registrarProductoNuevo de la clase daoProducto en la capa CpPersitencia

            if (msj.Equals(""))
            {
                daoProveedor daoProveedor = new daoProveedor();

                daoProveedor.registrarProveedorNuevo(proveedor, out msj);

            }
        }

       public List<Proveedor> consultarTodosLosProveedores(out string msj)
        {
            msj = "";
            daoProveedor daoProveedor = new daoProveedor();
            return daoProveedor.consultaDeTodosLosProveedores(out msj);

        }

        public void eliminarProveedor(int id, out string msj)
        {
            msj = "";
            daoProveedor daoProveedor = new daoProveedor();
            daoProveedor.eliminarProveedor(id, out msj);
        }

        public DataTable SP_Proveedor(int id, out string msj)
        {
            msj = "";
            daoProveedor daoProveedor = new daoProveedor();
            DataTable tabla = new DataTable();
            tabla = daoProveedor.SP_Proveedor(id, out msj);
            return tabla;
        }

        public List<Proveedor> listaTodosProveedoresNeg()
        {
            daoProveedor daoProveedor = new daoProveedor();
            return daoProveedor.listaTodosProveedores();
        }

       public void cargaCmbProveedor(ComboBox cb, out string msj)
        {
            msj = "";
            daoProveedor daoProveedor = new daoProveedor();
            daoProveedor.llenarItemsProveedor(cb);
        }

        public void ActualizarProveedor(int id, string descripcion, out string msj)
        {
            msj = "";
            daoProveedor daoProducto = new daoProveedor();
            daoProducto.ActualizarProveedor(id, descripcion, out msj);

        }
    }
}
