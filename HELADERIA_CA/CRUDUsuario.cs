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
    public partial class CRUDUsuario : Form
    {
        private DataClasses1DataContext dc = new DataClasses1DataContext();
        string usu_id = null;
        public CRUDUsuario()
        {
            InitializeComponent();
        }
        private void cargar_usuario()
        {
            var query = from c in dc.Tbl_usuario select c;
            dgv_usuario.DataSource = query;
        }

        private void limpiar()
        {
            txt_user.Text = txt_nom.Text = txt_ape.Text = txt_contra.Text =txt_ced.Text =txt_correo.Text = txt_dire.Text = txt_num.Text  = txt_bus.Text = "";

            usu_id = null;
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
            if (string.IsNullOrEmpty(txt_ced.Text) || string.IsNullOrEmpty(txt_nom.Text) || string.IsNullOrEmpty(txt_contra.Text))
            {
                MessageBox.Show("Ingrese todos los datos");

            }
            else
            {
                try
                {
                    var query = new Tbl_usuario
                    {
                        usu_usu = txt_user.Text,
                        usu_nombre = txt_nom.Text,
                        usu_apellido = txt_ape.Text,
                        usu_pass = txt_contra.Text,
                        usu_cedula = txt_ced.Text,
                        usu_correo = txt_correo.Text,
                        usu_dire = txt_dire.Text,
                        usu_celular = txt_num.Text,
                        usu_estado = "A",
                        roles_id = 1
                    };
                    dc.Tbl_usuario.InsertOnSubmit(query);
                    dc.SubmitChanges();
                    MessageBox.Show("Datos guardados");
                    cargar_usuario();
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
            if (usu_id == null)
            {
                MessageBox.Show("Porfavor seleccione un registro a editar");
            }
            else
            {
                try
                {
                    var query = (from c in dc.Tbl_usuario where c.usu_id == Convert.ToInt32(usu_id) select c).First();
                    query.usu_usu = txt_user.Text;
                    query.usu_nombre = txt_nom.Text;
                    query.usu_apellido = txt_ape.Text;
                    query.usu_pass = txt_contra.Text;
                    query.usu_cedula = txt_ced.Text;
                    query.usu_correo = txt_correo.Text;
                    query.usu_dire = txt_dire.Text;
                    query.usu_celular = txt_num.Text;

                    dc.SubmitChanges();
                    MessageBox.Show("Datos editados");
                    cargar_usuario();
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
            if (usu_id == null)
            {
                MessageBox.Show("Porfavor seleccione un registro a eliminar");
            }
            else
            {
                try
                {
                    var query = (from c in dc.Tbl_usuario where c.usu_id == Convert.ToInt32(usu_id) select c).First();
                    dc.Tbl_usuario.DeleteOnSubmit(query);
                    dc.SubmitChanges();
                    MessageBox.Show("Datos eliminados");
                    cargar_usuario();
                    limpiar();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void dgv_usuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_usuario.SelectedRows.Count > 0)
            {
                if (dgv_usuario.CurrentRow.Cells["usu_id"].Value.ToString() == "0")
                {
                    MessageBox.Show("No se encuentran datos guardados");
                }
                else
                {
                    txt_user.Text = dgv_usuario.CurrentRow.Cells["usu_usu"].Value.ToString();
                    txt_nom.Text = dgv_usuario.CurrentRow.Cells["usu_nombre"].Value.ToString();
                    txt_ape.Text = dgv_usuario.CurrentRow.Cells["usu_apellido"].Value.ToString();
                    txt_contra.Text = dgv_usuario.CurrentRow.Cells["usu_pass"].Value.ToString();
                    txt_ced.Text = dgv_usuario.CurrentRow.Cells["usu_cedula"].Value.ToString();
                    txt_correo.Text = dgv_usuario.CurrentRow.Cells["usu_correo"].Value.ToString();
                    txt_dire.Text = dgv_usuario.CurrentRow.Cells["usu_dire"].Value.ToString();
                    txt_num.Text = dgv_usuario.CurrentRow.Cells["usu_celular"].Value.ToString();

                    usu_id = dgv_usuario.CurrentRow.Cells["usu_id"].Value.ToString();

                }
            }
        }

        private void txt_bus_KeyPress(object sender, KeyPressEventArgs e)
        {
            var query = from c in dc.Tbl_usuario where c.usu_cedula.Contains(txt_bus.Text) && c.usu_apellido.Contains(txt_bus.Text) select c;
            dgv_usuario.DataSource = query;
        }

        private void CRUDUsuario_Load(object sender, EventArgs e)
        {
            cargar_usuario();
        }
    }
}
