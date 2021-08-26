using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Usuarios
    {
        private CD_Usuario objetoCD = new CD_Usuario();
        public DataTable traer_usuario()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar_usuario();
            return tabla;
        }
        public void insertarU(string usuario, string nombre, string apellido, string pass, string cedula, string correo, string direccion, string celular, string estado, int rol)
        {
            objetoCD.insertar_usuario(usuario, nombre, apellido, pass, cedula, correo, direccion, celular, estado, Convert.ToInt32(rol));
        }
        public void editarU(string usuario, string nombre, string apellido, string pass, string cedula, string correo, string direccion, string celular, string estado, int rol, int id)
        {
            objetoCD.editar_usuario(usuario, nombre, apellido, pass, cedula, correo, direccion, celular, estado, Convert.ToInt32(rol), Convert.ToInt32(id));
        }
        public void elimiarU(string id)
        {
            objetoCD.eliminar_usuario(Convert.ToInt32(id));
        }
    }
}
