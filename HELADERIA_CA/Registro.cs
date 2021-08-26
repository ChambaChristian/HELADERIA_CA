
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HELADERIA_CA
{
    public partial class Registro : Form
    {

       SqlConnection con = new SqlConnection("Data Source=CHRISTIAN;Initial Catalog=Heladeria_CA;Integrated Security=True");
        public Registro()
        {
            InitializeComponent();
        }
        

        public void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }
        private void limpiar_registro()
        {
            txt_usuario.Text = txt_nombre.Text = txt_apellido.Text = txt_contrasenia.Text = txt_cedula.Text = txt_direccion.Text = txt_correo.Text = txt_numero.Text="";
        }
        private void registrar_registro()
        {
            try
            {
                con.Open();
                string query = "insert into Tbl_usuario values(@usu, @nom, @ape, @pass, @ced, @dir, @correo, @num, 'A', 2)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usu", txt_usuario.Text.Trim());
                cmd.Parameters.AddWithValue("@nom", txt_nombre.Text.Trim());
                cmd.Parameters.AddWithValue("@ape", txt_apellido.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txt_contrasenia.Text.Trim());
                cmd.Parameters.AddWithValue("@ced", txt_cedula.Text.Trim());
                
                cmd.Parameters.AddWithValue("@dir", txt_direccion.Text.Trim());
                cmd.Parameters.AddWithValue("@correo", txt_correo.Text.Trim());
                cmd.Parameters.AddWithValue("@num", txt_numero.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado exitosamente");
                limpiar_registro();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, no se pudo registrar al usuario");
                throw;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_apellido.Text) || string.IsNullOrEmpty(txt_contrasenia.Text) || string.IsNullOrEmpty(txt_cedula.Text) || string.IsNullOrEmpty(txt_direccion.Text) || string.IsNullOrEmpty(txt_numero.Text) || string.IsNullOrEmpty(txt_correo.Text))
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                registrar_registro();
            }
            }
           
        }
    
}

