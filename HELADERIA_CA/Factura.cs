using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace HELADERIA_CA
{
    public partial class Factura : Form
    {
        CN_Factura objetoCN = new CN_Factura();
        private string fac_id = null;
        private bool editar = false;
        public Factura()
        {
            InitializeComponent();
        }
        private void mostrar_factura()
        {
            CN_Factura objetod = new CN_Factura();
            dgv_factura.DataSource = objetod.traer_factura();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_factura_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaCliente().ShowDialog();
            this.Close();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            mostrar_factura();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cedula.Text) && string.IsNullOrEmpty(txt_nombres.Text) && string.IsNullOrEmpty(txt_correo.Text))
            {
                MessageBox.Show("Por favor de doble click en una fila de la tabla para ingresar sus datos");
            }
            else
            {
                try
                {
                    objetoCN.editarF(txt_cedula.Text, txt_nombres.Text, txt_numero.Text, txt_correo.Text, txt_direccion.Text, fac_id);
                    MessageBox.Show("Los datos se editaron correctamente");
                    mostrar_factura();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los datos no se editaron \nOcurrio un error" + ex.Message);
                    throw;
                }
            }
        }
    }
}
