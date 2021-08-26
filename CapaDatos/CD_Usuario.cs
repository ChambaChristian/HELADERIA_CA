using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuario
    {
        //INSTACIACION DE LA CLASE CONEXION
        private CD_Conexion cn = new CD_Conexion();
        //PROPIEDADES DE SQL
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();
        //METODO DE MOSTRAR DATOS
        public DataTable mostrar_usuario()
        {
            //PROCEDIMMIENTO ALMACENADO
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "MostrarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            cn.cerrar_conexion();
            return tabla;
        }
        public void insertar_usuario(string usuario, string nombre, string apellido, string pass, string cedula, string correo, string direccion, string celular, string estado, int rol)
        {
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "InsertarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu_usu", usuario);
            cmd.Parameters.AddWithValue("@usu_nombre", nombre);
            cmd.Parameters.AddWithValue("@usu_apellido", apellido);
            cmd.Parameters.AddWithValue("@usu_pass", pass);
            cmd.Parameters.AddWithValue("@usu_cedula", cedula);
            cmd.Parameters.AddWithValue("@usu_correo", correo);
            cmd.Parameters.AddWithValue("@usu_dire", direccion);
            cmd.Parameters.AddWithValue("@usu_celular", celular);
            cmd.Parameters.AddWithValue("@usu_estado", estado);
            cmd.Parameters.AddWithValue("@roles_id", rol);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.cerrar_conexion();

        }
        public void editar_usuario(string usuario, string nombre, string apellido, string pass, string cedula, string correo, string direccion, string celular, string estado, int rol, int id)
        {
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "EditarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu_usu", usuario);
            cmd.Parameters.AddWithValue("@usu_nombre", nombre);
            cmd.Parameters.AddWithValue("@usu_apellido", apellido);
            cmd.Parameters.AddWithValue("@usu_pass", pass);
            cmd.Parameters.AddWithValue("@usu_cedula", cedula);
            cmd.Parameters.AddWithValue("@usu_correo", correo);
            cmd.Parameters.AddWithValue("@usu_dire", direccion);
            cmd.Parameters.AddWithValue("@usu_celular", celular);
            cmd.Parameters.AddWithValue("@usu_estado", estado);
            cmd.Parameters.AddWithValue("@roles_id", rol);
            cmd.Parameters.AddWithValue("@usu_id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.cerrar_conexion();
        }
        public void eliminar_usuario(int id)
        {
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "EliminarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu_id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.cerrar_conexion();
        }
    }
}
  
