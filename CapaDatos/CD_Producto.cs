using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class CD_Producto
    {
        //INSTACIACION DE LA CLASE CONEXION
        private CD_Conexion cn = new CD_Conexion();
        //PROPIEDADES DE SQL
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();
        //METODO DE MOSTRAR DATOS
        public DataTable mostrar_producto()
        {
            //PROCEDIMMIENTO ALMACENADO
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "MostrarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            cn.cerrar_conexion();
            return tabla;
        }
        public void insertar_producto(string codigo, string nombre, float precio)
        {
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "InsertarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prod_codigo", codigo);
            cmd.Parameters.AddWithValue("@prod_nombre", nombre);
            cmd.Parameters.AddWithValue("@prod_precio", precio);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.cerrar_conexion();

        }
        public void editar_producto(string codigo, string nombre, float precio, int id)
        {
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "EditarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prod_codigo", codigo);
            cmd.Parameters.AddWithValue("@prod_nombre", nombre);
            cmd.Parameters.AddWithValue("@prod_precio", precio);
            cmd.Parameters.AddWithValue("@prod_id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.cerrar_conexion();
        }
        public void eliminar_producto(int id)
        {
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "EliminarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prod_id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.cerrar_conexion();
        }
    }
}
