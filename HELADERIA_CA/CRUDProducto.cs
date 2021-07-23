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
    public partial class CRUDProducto : Form
    {
        private DataClasses1DataContext dc = new DataClasses1DataContext();
        string prod_id = null;
        public CRUDProducto()
        {
            InitializeComponent();
        }
        private void cargar_producto()
        {
            var query = from c in dc.Tbl_productos select c;
            dgv_prod.DataSource = query;
        }
        private void limpiar()
        {
            txt_cod.Text = txt_nom.Text = txt_pre.Text = txt_bus.Text = "";
            prod_id = null;
        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAdmin().ShowDialog();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CRUDProducto_Load(object sender, EventArgs e)
        {
            cargar_producto();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cod.Text) || string.IsNullOrEmpty(txt_nom.Text) || string.IsNullOrEmpty(txt_pre.Text))
            {
                MessageBox.Show("Ingrese todos los datos");

            }
            else
            {
                try
                {
                    var query = new Tbl_productos
                    {
                        prod_cod = txt_cod.Text,
                        prod_nombre = txt_nom.Text,
                        prod_precio = txt_pre.Text
                    };
                    dc.Tbl_productos.InsertOnSubmit(query);
                    dc.SubmitChanges();
                    MessageBox.Show("Datos guardados");
                    cargar_producto();
                    limpiar();
                }
                catch (Exception)
                {

                      throw;
                }
            }
        }

        private void btn_actu_Click(object sender, EventArgs e)
        {
            if (prod_id == null)
            {
                MessageBox.Show("Porfavor seleccione un registro a editar");
            }
            else
            {
                try
                {
                    var q = (from c in dc.Tbl_productos where c.prod_id == Convert.ToInt32(prod_id) select c).First();
                    q.prod_cod = txt_cod.Text;
                    q.prod_nombre = txt_nom.Text;
                    q.prod_precio = txt_pre.Text;
                    dc.SubmitChanges();
                    MessageBox.Show("Datos editados");
                    cargar_producto();
                    limpiar();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_elim_Click(object sender, EventArgs e)
        {
            if (prod_id == null)
            {
                MessageBox.Show("Porfavor seleccione un registro a eliminar");
            }
            else
            {
                try
                {
                    var query = (from c in dc.Tbl_productos where c.prod_id == Convert.ToInt32(prod_id) select c).First();
                    dc.Tbl_productos.DeleteOnSubmit(query);
                    dc.SubmitChanges();
                    MessageBox.Show("Datos eliminados");
                    cargar_producto();
                    limpiar();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
 

        private void txt_bus_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            var query = from c in dc.Tbl_productos where c.prod_nombre.Contains(txt_bus.Text) select c;
            dgv_prod.DataSource = query;
        }

        private void dgv_prod_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_prod.SelectedRows.Count > 0)
            {
                if (dgv_prod.CurrentRow.Cells["prod_id"].Value.ToString() == "0")
                {
                    MessageBox.Show("No se encuentran datos guardados");
                }
                else
                {
                    txt_cod.Text = dgv_prod.CurrentRow.Cells["prod_cod"].Value.ToString();
                    txt_nom.Text = dgv_prod.CurrentRow.Cells["prod_nombre"].Value.ToString();
                    txt_pre.Text = dgv_prod.CurrentRow.Cells["prod_precio"].Value.ToString();

                    prod_id = dgv_prod.CurrentRow.Cells["prod_id"].Value.ToString();

                }
            }
        }
    }
}
