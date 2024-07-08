using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_bausi_csharp
{
    public partial class eliminar_producto : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=proyecto_bausi; Uid=root; pwd=");


        public eliminar_producto()
        {
            InitializeComponent();
        }
        public bool NoExiste(int id)
        {
          //  conexion.Open();
            string sql = @"SELECT COUNT(*) FROM productos WHERE id=" + id;




            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            

          // conexion.Close();
            return count == 0;
        }

        private void eliminar(String id)
        {

            try
            {
                //conexion.Open();
                //string id = txt_id_para_eliminar.Text;
                int idd = int.Parse(id);

                String query = "DELETE FROM existencia_productos WHERE id_producto=" + id;
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();

              //  MessageBox.Show(id);
                String query2 = "DELETE FROM productos P WHERE P.id=" + id;
                MySqlCommand comando2 = new MySqlCommand(query2, conexion);
                comando2.ExecuteNonQuery();

                const string a = "¡PRODUCTO ELIMINADO CORRECTAMENTE!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);

              //  conexion.Close();



            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
           



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            index i = new index();
            i.Visible = true;
            Visible = false;
        }

        private void txt_id_para_eliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }


            }
            catch (Exception ex)
            {
                const string a = "¡INGRESA UN PRECIO valido!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_id_para_eliminar_TextChanged(object sender, EventArgs e)
        {
            txt_id_para_eliminar.MaxLength = 7;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //conexion.Open();
            conexion.Open();
            if (txt_id_para_eliminar.Text == "")
            {

                const string a = "¡AGREGA EL ID PARA BUSCAR!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);

            }
            else if (NoExiste(int.Parse(txt_id_para_eliminar.Text)) == true)
            {
                const string a = "¡EL ID INGRESADO NO SE ENCUENTRA EN LA BASE DE DATOS!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);
                txt_id_para_eliminar.Text = "";

            }
            else
            {
                const string message =
                "ESTA APUNTO DE ELIMINAR ESTE PRODUCTO. ¿Desea continuar?";
                const string caption = "BAUSI";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                // If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    // cancel the closure of the form.
                    txt_id_para_eliminar.Text = "";
                }
                else if (result == DialogResult.Yes)
                {

                    eliminar(txt_id_para_eliminar.Text.ToString());
                    txt_id_para_eliminar.Text = "";



                }
                    
            }
           // conexion.Close();
            
            

            conexion.Close();

        }
    }
}
