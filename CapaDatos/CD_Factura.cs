using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Factura
    {
        //INSTACIACION DE LA CLASE CONEXION
        private CD_Conexion cn = new CD_Conexion();
        //PROPIEDADES DE SQL
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();
        //METODO DE MOSTRAR DATOS
        public DataTable mostrar_factura()
        {
            //PROCEDIMMIENTO ALMACENADO
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "MostrarFactura";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            cn.cerrar_conexion();
            return tabla;
        }
        
        public void editar_factura(string cedula, string nombres, string correo, string numero, string direccion, int id)
        {
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "EditarFactura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fac_cedula", cedula);
            cmd.Parameters.AddWithValue("@fac_nombres", nombres);
            cmd.Parameters.AddWithValue("@fac_correo", correo);
            cmd.Parameters.AddWithValue("@fac_numero", numero);
            cmd.Parameters.AddWithValue("@fac_direccion", direccion);
            cmd.Parameters.AddWithValue("@fac_id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.cerrar_conexion();
        }
        public void insertar_factura(string prod1, string saborp1, string prod2, string saborp2, string prod3, string saborp3, string prod4, string prod5, string prod6, string prod7, string prod8, string prod9, float subtotal, float total)
        {
            cmd.Connection = cn.abrir_conexion();
            cmd.CommandText = "Ordenar2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fac_cedula", "");
            cmd.Parameters.AddWithValue("@fac_nombres", "");
            cmd.Parameters.AddWithValue("@fac_correo", "");
            cmd.Parameters.AddWithValue("@fac_numero", "");
            cmd.Parameters.AddWithValue("@fac_direccion", "");
            cmd.Parameters.AddWithValue("@fac_prod1", prod1);
            cmd.Parameters.AddWithValue("@fac_saborp1", saborp1);
            cmd.Parameters.AddWithValue("@fac_prod2", prod2);
            cmd.Parameters.AddWithValue("@fac_saborp2", saborp2);
            cmd.Parameters.AddWithValue("@fac_prod3", prod3);
            cmd.Parameters.AddWithValue("@fac_saborp3", saborp3);
            cmd.Parameters.AddWithValue("@fac_prod4", prod4);
            cmd.Parameters.AddWithValue("@fac_prod5", prod5);
            cmd.Parameters.AddWithValue("@fac_prod6", prod6);
            cmd.Parameters.AddWithValue("@fac_prod7", prod7);
            cmd.Parameters.AddWithValue("@fac_prod8", prod8);
            cmd.Parameters.AddWithValue("@fac_prod9", prod9);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.cerrar_conexion();

        }

    }
}

