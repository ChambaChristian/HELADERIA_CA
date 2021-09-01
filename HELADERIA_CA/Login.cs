using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HELADERIA_CA
{
    public partial class Login : Form
    {
        int contador = 0;
        private SqlConnection con = new SqlConnection("Data Source=CHRISTIAN;Initial Catalog=Heladeria_CA;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }
        private void Logear(string nombre, string passw)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_usuario where usu_usu = @nom and usu_estado = 'A'", con);
                cmd.Parameters.AddWithValue("nom", nombre);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                if (dt.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select usu_nombre, roles_id from Tbl_usuario where usu_usu = @nom and usu_pass = @pas and usu_estado = 'A'", con);
                    cmd1.Parameters.AddWithValue("nom", nombre);
                    cmd1.Parameters.AddWithValue("pas", passw);
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    con.Close();

                    if (dt1.Rows.Count == 1)
                    {
                        this.Hide();
                        if (dt1.Rows[0][1].ToString() == "1")
                        {

                            new MenuAdmin().ShowDialog();

                        }
                        else if (dt1.Rows[0][1].ToString() == "2")
                        {
                            new VistaCliente().ShowDialog();
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                        Limpiar2();
                        contador += 1;

                    }
                    if (contador > 2)
                    {
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand(" select * from Tbl_usuario where usu_usu = @nomb and usu_estado ='A'", con);
                        cmd2.Parameters.AddWithValue("nomb", nombre);
                        SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        con.Close();
                        if (dt2.Rows.Count == 1)
                        {
                            con.Open();
                            SqlCommand cmd3 = new SqlCommand("UPDATE Tbl_usuario SET usu_estado = 'I' WHERE usu_usu = @nomb", con);
                            cmd3.Parameters.AddWithValue("nomb", nombre);
                            SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                            DataTable dt3 = new DataTable();
                            sda3.Fill(dt3);
                            con.Close();


                        }
                        MessageBox.Show("Ha exedido el limite de intentos, se ha bloqueado su usuario. \nComuniquese con un asistente para recuperar su cuenta.");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado o bloqueado");
                    contador += 1;
                }
                if (contador > 2)
                {
                    MessageBox.Show("Ha exedido el limite de intentos");
                    Application.Exit();
                }

            }
            catch (Exception)
            {

                throw;
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
            if (string.IsNullOrEmpty(txt_usu.Text) || string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Por favor ingrese todos los datos");

            }
            else
            {
                Logear(txt_usu.Text, txt_pass.Text);
            }

        }
        private void Limpiar2()
        {
            txt_usu.Text = txt_pass.Text = "";

        }
    }
}
