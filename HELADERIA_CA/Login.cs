using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HELADERIA_CA
{
    public partial class Login : Form
    {
        private DataClasses1DataContext dc = new DataClasses1DataContext();

        public Login()
        {
            InitializeComponent();
        }
        private bool LogearAdmin(string usuario, string password)
        {
            var q = from p in dc.Tbl_usuario
                    where p.usu_usu == txt_usu.Text
                    && p.usu_pass == txt_pass.Text
                    && p.roles_id == 1
                    select p;
            this.Hide();
            MessageBox.Show("Bienvenido al Sistema Administrador");
            new MenuAdmin().ShowDialog();
            this.Close();
            if (q.Any())
            {
                return true;
                
            }
            else
            {
                return false;

            }
        }
        private bool LogearCliente(string usuario, string password)
        {
            var q = from p in dc.Tbl_usuario
                    where p.usu_usu == txt_usu.Text
                    && p.usu_pass == txt_pass.Text
                    && p.roles_id == 2
                    select p;

            if (q.Any())
            {
                return true;

            }
            else
            {
                return false;

            }
            if (string.IsNullOrEmpty(txt_usu.Text) || string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Por favor llene todos los datos");
            }
        }


        private void lbl_regis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Registro().ShowDialog();
            this.Close();
          
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (LogearCliente(txt_usu.Text, txt_pass.Text))
            {
                MessageBox.Show("Bienvenido al Sistema Cliente");
                this.Hide();
                new VistaCliente().ShowDialog();
                this.Close();
            }
            else
            {
                LogearAdmin(txt_usu.Text, txt_pass.Text);
            }


        }
    }
}
