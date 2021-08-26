using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class CD_Conexion
    {//CADENA DE CONEXION
        private SqlConnection Conexion = new SqlConnection("Data Source=CHRISTIAN;Initial Catalog=Heladeria_CA;Integrated Security=True");
        //METODOS PARA ABRIR Y CERRAR CONEXION
        public SqlConnection abrir_conexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();

            }
            return Conexion;
        }
        public SqlConnection cerrar_conexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();

            }
            return Conexion;
        }
    }
}