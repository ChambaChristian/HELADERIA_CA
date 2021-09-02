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
    public partial class VistaCliente : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CHRISTIAN;Initial Catalog=Heladeria_CA;Integrated Security=True");
        
        
        
        private void facturar()
        {
            float precio1 = 0.50f;
            float precio2 = 1.00f;
            float precio3 = 1.50f;
            float precio4 = 0.75f;
            float precio5 = 2.50f;
            float precio6 = 3.50f;
            float precio7 = 3.50f;
            float precio8 = 4.00f;
            float precio9 = 4.00f;
            float iva = 0.14f;
            float subtotal = (Convert.ToInt32(txt_1.Text) * precio1) + (Convert.ToInt32(txt_2.Text) * precio2) + (Convert.ToInt32(txt_3.Text) * precio3) + (Convert.ToInt32(txt_4.Text) * precio4) + (Convert.ToInt32(txt_5.Text) * precio5) + (Convert.ToInt32(txt_6.Text) * precio6) + (Convert.ToInt32(txt_7.Text) * precio7) + (Convert.ToInt32(txt_8.Text) * precio8) + (Convert.ToInt32(txt_9.Text) * precio9);
            float total = subtotal * iva;
            try
            {
                con.Open();
                string query = "insert into Tbl_factura values('', '', '', '', '', @prod1, @saborp1, @prod2, @saborp2, @prod3, @saborp3, @prod4, @prod5, @prod6, @prod7, @prod8, @prod9, @subtotal, @total";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@prod1", txt_11.Text.Trim());
                cmd.Parameters.AddWithValue("@saborp1", cmb_1.SelectedValue);
                cmd.Parameters.AddWithValue("@prod2", txt_22.Text.Trim());
                cmd.Parameters.AddWithValue("@saborp2", cmb_2.SelectedValue);
                cmd.Parameters.AddWithValue("@prod3", txt_33.Text.Trim());
                cmd.Parameters.AddWithValue("@saborp3", cmb_3.SelectedValue);
                cmd.Parameters.AddWithValue("@prod4", txt_44.Text.Trim());
                cmd.Parameters.AddWithValue("@prod5", txt_55.Text.Trim());
                cmd.Parameters.AddWithValue("@prod6", txt_66.Text.Trim());
                cmd.Parameters.AddWithValue("@prod7", txt_77.Text.Trim());
                cmd.Parameters.AddWithValue("@prod8", txt_88.Text.Trim());
                cmd.Parameters.AddWithValue("@prod9", txt_99.Text.Trim());
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@total", total);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Orden generada exitosamente");
                this.Hide();
                new Factura().ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, no se pudo registrar su orden");
                throw;
            }
        }
        
        public VistaCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VistaCliente_Load(object sender, EventArgs e)
        {
            cmb_1.Text = "Seleccione un sabor";
            cmb_2.Text = "Seleccione un sabor";
            cmb_3.Text = "Seleccione un sabor";
        }

        private void btn_regre_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_orden_Click(object sender, EventArgs e)
        {
            if (cmb_1.Text == "Seleccione un sabor")
            {
                MessageBox.Show("Por favor seleccione un sabor");
            }
            else if (cmb_2.Text == "Seleccione un sabor")
            {
                MessageBox.Show("Por favor seleccione un sabor");
            }
            else if (cmb_3.Text == "Seleccione un sabor")
            {
                MessageBox.Show("Por favor seleccione un sabor");
            }
            else {
                this.Hide();
                new Factura().ShowDialog();
                this.Close();
            }
            
        }
        #region track_bars
        private void tb_1_Scroll(object sender, EventArgs e)
        {
            txt_1.Text = tb_1.Value.ToString();
        }

        private void tb_2_Scroll(object sender, EventArgs e)
        {
            txt_2.Text = tb_2.Value.ToString();
        }

        private void tb_3_Scroll(object sender, EventArgs e)
        {
            txt_3.Text = tb_3.Value.ToString();
        }

        private void tb_4_Scroll(object sender, EventArgs e)
        {
            txt_4.Text = tb_4.Value.ToString();
        }

        private void tb_5_Scroll(object sender, EventArgs e)
        {
            txt_5.Text = tb_5.Value.ToString();
        }

        private void tb_6_Scroll(object sender, EventArgs e)
        {
            txt_6.Text = tb_6.Value.ToString();
        }

        private void tb_7_Scroll(object sender, EventArgs e)
        {
            txt_7.Text = tb_7.Value.ToString();
        }

        private void tb_8_Scroll(object sender, EventArgs e)
        {
            txt_8.Text = tb_8.Value.ToString();
        }

        private void tb_9_Scroll(object sender, EventArgs e)
        {
            txt_9.Text = tb_9.Value.ToString();
        }
        #endregion


    }
}
