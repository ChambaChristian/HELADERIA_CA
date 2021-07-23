
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


namespace HELADERIA_CA
{
    public partial class Registro : Form
    {
        private DataClasses1DataContext dc = new DataClasses1DataContext();
        
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
                var query = new Tbl_usuario
                {
                    usu_usu = txt_usuario.Text,
                    usu_nombre = txt_nombre.Text,
                    usu_apellido = txt_apellido.Text,
                    usu_pass = txt_contrasenia.Text,
                    usu_cedula = txt_cedula.Text,
                    usu_correo = txt_correo.Text,
                    usu_dire = txt_direccion.Text,
                    usu_celular = txt_numero.Text,
                    usu_estado = "A",
                    roles_id = 2
                };
                dc.Tbl_usuario.InsertOnSubmit(query);
                dc.SubmitChanges();
                MessageBox.Show("Se ha registrado exitosamente");
                limpiar_registro();
            }
            catch (Exception)
            {

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

