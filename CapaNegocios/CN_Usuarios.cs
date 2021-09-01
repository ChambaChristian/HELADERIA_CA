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
        public void insertarU(string usuario, string nombre, string apellido, string pass, string cedula, string correo, string direccion, string celular, string estado, string rol)
        {
            objetoCD.insertar_usuario(usuario, nombre, apellido, pass, cedula, correo, direccion, celular, estado, Convert.ToInt32(rol));
        }
        public void editarU(string usuario, string nombre, string apellido, string pass, string cedula, string correo, string direccion, string celular, string estado, string rol, string id)
        {
            objetoCD.editar_usuario(usuario, nombre, apellido, pass, cedula, correo, direccion, celular, estado, Convert.ToInt32(rol), Convert.ToInt32(id));
        }
        public void eliminarU(string id)
        {
            objetoCD.eliminar_usuario(Convert.ToInt32(id));
        }

       
        public void buscarU(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, string usu_id)
        {
            throw new NotImplementedException();
        }
    }
}
