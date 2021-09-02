using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using System.Linq;

namespace HELADERIA_CA
{
    public partial class CRUDProducto : Form
    {
        private DataClasses1DataContext dc = new DataClasses1DataContext();
        CN_Productos objetoCN = new CN_Productos();
        private string prod_id = null;
        private bool editar = false;
        public CRUDProducto()
        {
            InitializeComponent();
        }
        private void mostrar_producto()
        {
            CN_Productos objetod = new CN_Productos();
            dgv_producto.DataSource = objetod.traer_producto();
        }
        private void limpiar()
        {
            txt_bus.Clear();
            txt_cod.Clear();
            txt_nom.Clear();
            txt_nom.Clear();
            txt_pre.Clear();
            prod_id = null;
            editar = false;
            btn_guardar.Enabled = true;
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
            mostrar_producto();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cod.Text) && string.IsNullOrEmpty(txt_nom.Text) && string.IsNullOrEmpty(txt_pre.Text))
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }
            
            else
            {
                if (editar == false)
                {
                    try
                    {
                        objetoCN.insertarP(txt_cod.Text, txt_nom.Text, (float)Convert.ToDouble(txt_pre.Text));
                        MessageBox.Show("Datos insertados correctamente");
                        mostrar_producto();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se guardaron los datos. \nError: " + ex.Message);
                        throw;
                    }
                }
            }
        }

        private void btn_actu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cod.Text) && string.IsNullOrEmpty(txt_nom.Text) && string.IsNullOrEmpty(txt_pre.Text))
            {
                MessageBox.Show("Por favor de doble click en una fila de la tabla para editar");
            }
            else
            {
                try
                {
                    objetoCN.editarP(txt_cod.Text, txt_nom.Text, (float)Convert.ToDouble(txt_pre.Text), prod_id);
                    MessageBox.Show("Los datos se editaron correctamente");
                    mostrar_producto();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los datos no se editaron \nOcurrio un error" + ex.Message);
                    throw;
                }
            }
        }

        private void btn_elim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prod_id))
            {
                MessageBox.Show("Por favor de doble click en una fila de la tabla para eliminar");
            }
            else
            {
                try
                {
                    objetoCN.elimiarP(prod_id);
                    MessageBox.Show("Los datos se eliminaron correctamente");
                    mostrar_producto();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los datos no se eliminaron \nOcurrio un error" + ex.Message);
                    throw;
                }
            }
        }


        private void txt_bus_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            var query = from c in dc.Tbl_producto where c.prod_nombre .Contains(txt_bus.Text) select c;
            dgv_producto.DataSource = query;
        }

        private void dgv_prod_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dgv_producto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_producto.SelectedRows.Count > 0)
            {
                editar = true;
                txt_cod.Text = dgv_producto.CurrentRow.Cells["prod_codigo"].Value.ToString();
                txt_nom.Text = dgv_producto.CurrentRow.Cells["prod_nombre"].Value.ToString();
                txt_pre.Text = dgv_producto.CurrentRow.Cells["prod_precio"].Value.ToString();
                prod_id = dgv_producto.CurrentRow.Cells["prod_id"].Value.ToString();
                btn_guardar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Porfavor seleccione una fila");
                limpiar();
            }
        }
    }
}
