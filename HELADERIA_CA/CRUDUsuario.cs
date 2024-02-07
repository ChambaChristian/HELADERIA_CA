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
    public partial class CRUDUsuario : Form
    {
        private DataClasses1DataContext dc = new DataClasses1DataContext();
        CN_Usuarios objetoCN = new CN_Usuarios();
        //DECLARAMOS VARIABLES
        private string usu_id = null;
        private bool editar = false;
        public CRUDUsuario()
        {
            InitializeComponent();
        }
        private void mostrar_usuario()
        {
            CN_Usuarios objetod = new CN_Usuarios();
            dgv_usu.DataSource = objetod.traer_usuario();
        }

        private void limpiar()
        {
            txt_bus.Clear();
            txt_user.Clear();
            txt_nom.Clear();
            txt_ape.Clear();
            txt_contra.Clear();
            txt_ced.Clear();
            txt_correo.Clear();
            txt_dire.Clear();
            txt_num.Clear();
            usu_id = null;
            editar = false;
            cmb_rol.Text = "Seleccione una opción";
            cmb_estado.Text = "Seleccione una opción";

            btn_guardar.Enabled = true;
        }

        private void btn_regre_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAdmin().ShowDialog();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nom.Text) && string.IsNullOrEmpty(txt_ape.Text) && string.IsNullOrEmpty(txt_dire.Text))
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }
            else if (cmb_rol.Text == "Seleccione una opción")
            {
                MessageBox.Show("Por favor seleccione una de las dos opciones");
            }
            else if (cmb_estado.Text == "Seleccione una opción")
            {
                MessageBox.Show("Por favor seleccione una de las dos opciones");
            }
            else
            {
                if (editar == false)
                {
                    try
                    {
                        objetoCN.insertarU(txt_user.Text, txt_nom.Text, txt_ape.Text, txt_contra.Text, txt_ced.Text, txt_correo.Text, txt_dire.Text, txt_num.Text, cmb_estado.Text, cmb_rol.Text);
                        MessageBox.Show("Datos insertados correctamente");
                        mostrar_usuario();
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
            if (string.IsNullOrEmpty(txt_nom.Text) && string.IsNullOrEmpty(txt_ape.Text) && string.IsNullOrEmpty(txt_dire.Text))
            {
                MessageBox.Show("Por favor de doble click en una fila de la tabla para editar");
            }
            else
            {
                try
                {
                    objetoCN.editarU(txt_user.Text, txt_nom.Text, txt_ape.Text, txt_contra.Text, txt_ced.Text, txt_correo.Text, txt_dire.Text, txt_num.Text, cmb_estado.Text, cmb_rol.Text, usu_id);
                    MessageBox.Show("Los datos se editaron correctamente");
                    mostrar_usuario();
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
            if (string.IsNullOrEmpty(usu_id))
            {
                MessageBox.Show("Por favor de doble click en una fila de la tabla para eliminar");
            }
            else
            {
                try
                {
                    objetoCN.eliminarU(usu_id);
                    MessageBox.Show("Los datos se eliminaron correctamente");
                    mostrar_usuario();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Los datos no se eliminaron \nOcurrio un error" + ex.Message);
                    throw;
                }
            }
        }


    

        private void CRUDUsuario_Load(object sender, EventArgs e)
        {
            mostrar_usuario();
            cmb_rol.Text = "Seleccione una opción";
            cmb_estado.Text = "Seleccione una opción";
        }

        private void dgv_usu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_usu.SelectedRows.Count > 0)
            {
                editar = true;
                txt_user.Text = dgv_usu.CurrentRow.Cells["usu_usu"].Value.ToString();
                txt_nom.Text = dgv_usu.CurrentRow.Cells["usu_nombre"].Value.ToString();
                txt_ape.Text = dgv_usu.CurrentRow.Cells["usu_apellido"].Value.ToString();
                txt_contra.Text = dgv_usu.CurrentRow.Cells["usu_pass"].Value.ToString();
                txt_ced.Text = dgv_usu.CurrentRow.Cells["usu_cedula"].Value.ToString();
                txt_correo.Text = dgv_usu.CurrentRow.Cells["usu_correo"].Value.ToString();
                txt_dire.Text = dgv_usu.CurrentRow.Cells["usu_dire"].Value.ToString();
                txt_num.Text = dgv_usu.CurrentRow.Cells["usu_celular"].Value.ToString();
                cmb_estado.Text = dgv_usu.CurrentRow.Cells["usu_estado"].Value.ToString();
                cmb_rol.Text = dgv_usu.CurrentRow.Cells["roles_id"].Value.ToString();
                usu_id = dgv_usu.CurrentRow.Cells["usu_id"].Value.ToString();
                btn_guardar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Porfavor seleccione una fila");
                limpiar();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAdmin().ShowDialog();
            this.Close();
        }

        private void txt_bus_KeyPress(object sender, KeyPressEventArgs e)
        {
            var query = from c in dc.Tbl_usuario where c.usu_cedula.Contains(txt_bus.Text) || c.usu_nombre.Contains(txt_bus.Text) || c.usu_apellido.Contains(txt_bus.Text) select c;
            dgv_usu.DataSource = query;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
