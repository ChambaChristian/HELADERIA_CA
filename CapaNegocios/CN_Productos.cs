using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
   public class CN_Productos
    {
        private CD_Producto objetoCD = new CD_Producto();
        public DataTable traer_usuario()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar_producto();
            return tabla;
        }
        public void insertarP(string codigo, string nombre, float precio)
        {
            objetoCD.insertar_producto(codigo, nombre, (float)Convert.ToDouble(precio));
        }
        public void editarP(string codigo, string nombre, float precio, int id)
        {
            objetoCD.editar_producto(codigo, nombre, (float)Convert.ToDouble(precio), Convert.ToInt32(id)); 
        }
        public void elimiarP(string id)
        {
            objetoCD.eliminar_producto(Convert.ToInt32(id));
        }
    }
}
