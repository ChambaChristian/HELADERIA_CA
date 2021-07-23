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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_regre_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }

        private void btn_crudp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDProducto().ShowDialog();
            this.Close();
        }

        private void btn_crudu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CRUDUsuario().ShowDialog();
            this.Close();
        }
    }
}
