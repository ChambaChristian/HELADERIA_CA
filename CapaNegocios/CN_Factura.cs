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
    public class CN_Factura
    {
        private CD_Factura objetoCD = new CD_Factura();
        public DataTable traer_factura()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar_factura();
            return tabla;
        }
        
        public void editarF(string cedula, string nombres, string correo, string numero, string direccion, string id)
        {
            objetoCD.editar_factura(cedula, nombres, correo, numero, direccion, Convert.ToInt32(id));
        }
        public void insertarF( string prod1, string saborp1, string prod2, string saborp2, string prod3, string saborp3, string prod4, string prod5, string prod6, string prod7, string prod8, string prod9, float subtotal, float total)
        {
            objetoCD.insertar_factura( prod1, saborp1, prod2, saborp2, prod3, saborp3, prod4, prod5, prod6, prod7, prod8, prod9, subtotal, total);
        }

    }
}

