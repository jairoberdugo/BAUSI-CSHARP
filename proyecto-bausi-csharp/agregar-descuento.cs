using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace proyecto_bausi_csharp
{
    public partial class agregar_descuento : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=proyecto_bausi; Uid=root; pwd=");

        public agregar_descuento()
        {
            InitializeComponent();
            
        }

        private void agregar_descuento_Load(object sender, EventArgs e)
        {


        }
        public bool NoExiste(int id)
        {
            string sql = @"SELECT COUNT(*) FROM productos WHERE id ="+id;

            
               // conexion.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count == 0;

           // conexion.Close();
        }

        private void btn_descuento_todos_combos_Click(object sender, EventArgs e)
        {

            if (txt_valor_descuento.Text == "")
            {
                const string a = "¡POR FAVOR, INGRESA EL DESCUENTO!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);
                txt_valor_descuento.Text = "";
            }
            else
            {
                

                conexion.Open();
                int descuento = int.Parse(txt_valor_descuento.Text);

                const string message =
                "¡Esta apunto de apliar un descuento a todos los combos bausi!. ¿Desea continuar?";
                const string caption = "BAUSI";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    // cancel the closure of the form.
                    txt_valor_descuento.Text = "";
                }
                else if (result == DialogResult.Yes)
                {
                    try
                    {

                        string sentencia = "UPDATE productos SET descuento=" + descuento + " WHERE ref_producto=" + 3333;
                        MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                        cmd.ExecuteNonQuery();
                        const string m = "¡DESCUENTO APLICADO CORRECTAMENTE!";
                        const string c = "BAUSI";
                        MessageBox.Show(m, c);
                        txt_valor_descuento.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }




                conexion.Close();


            }

        }

        private void btn_descuento_todas_playeras_Click(object sender, EventArgs e)
        {

            if (txt_valor_descuento.Text == "")
            {
                const string a = "¡POR FAVOR, INGRESA EL DESCUENTO!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);
                txt_valor_descuento.Text = "";
            }
            else
            {
                conexion.Open();
                int descuento = int.Parse(txt_valor_descuento.Text);

                const string message =
                "Esta apunto de apliar un descuento a todas las playeras. ¿Desea continuar?";
                const string caption = "BAUSI";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    // cancel the closure of the form.
                    txt_valor_descuento.Text = "";
                }
                else if (result == DialogResult.Yes)
                {
                    try
                    {

                        string sentencia = "UPDATE productos SET descuento=" + descuento + " WHERE ref_producto=" + 1111;
                        MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                        cmd.ExecuteNonQuery();
                        const string m = "¡DESCUENTO APLICADO CORRECTAMENTE!";
                        const string c = "BAUSI";
                        MessageBox.Show(m, c);
                        txt_valor_descuento.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }




                conexion.Close();


            }



        }

        private void btn_descuento_todos_tshirts_Click(object sender, EventArgs e)
        {

            if (txt_valor_descuento.Text == "")
            {
                const string a = "¡POR FAVOR, INGRESA EL DESCUENTO!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);
                txt_valor_descuento.Text = "";
            }
            else
            {
                conexion.Open();
                int descuento = int.Parse(txt_valor_descuento.Text);

                const string message =
                "Esta apunto de apliar un descuento a todos los T-shirts. ¿Desea continuar?";
                const string caption = "BAUSI";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    // cancel the closure of the form.
                    txt_valor_descuento.Text = "";
                }
                else if (result == DialogResult.Yes)
                {
                    try
                    {

                        string sentencia = "UPDATE productos SET descuento=" + descuento + " WHERE ref_producto=" + 2222;
                        MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                        cmd.ExecuteNonQuery();
                        const string m = "¡DESCUENTO APLICADO CORRECTAMENTE!";
                        const string c = "BAUSI";
                        MessageBox.Show(m, c);
                        txt_valor_descuento.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }




                conexion.Close();


            }







        }

        private void btn_descuento_id_Click(object sender, EventArgs e)
        {
            conexion.Open();
            
            
           // MessageBox.Show("VARIABLE: "+var);
            if (txt_valor_descuento.Text == ""   )
            {
                const string a = "¡POR FAVOR, INGRESA EL DESCUENTO!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);
                txt_valor_descuento.Text = "";
            }
            else if (id_para_descuento.Text == "")
            {
                const string a = "¡POR FAVOR, INGRESA EL ID!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);
                //txt_valor_descuento.Text = "";

            } else if (NoExiste(int.Parse(id_para_descuento.Text))==true )
            {
                const string a = "¡EL ID INGRESADO NO SE ENCUENTRA EN LA BASE DE DATOS!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);

            }
            else
            {
                
                int descuento = int.Parse(txt_valor_descuento.Text);
                int id = int.Parse(id_para_descuento.Text);


                const string message =
                "Esta apunto de aplicar un descuento al producto con el id ingresado ¿Desea continuar?";
                const string caption = "BAUSI";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                
                if (result == DialogResult.No)
                {
                   
                    txt_valor_descuento.Text = "";
                }
                else if (result == DialogResult.Yes)
                {
                    try
                    {

                        string sentencia = "UPDATE productos SET descuento=" + descuento + " WHERE id=" + id;
                        MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                        cmd.ExecuteNonQuery();
                        const string m = "¡DESCUENTO APLICADO CORRECTAMENTE!";
                        const string c = "BAUSI";
                        MessageBox.Show(m, c);
                        txt_valor_descuento.Text = "";
                        id_para_descuento.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }




                


            }




            conexion.Close();




        }

        private void btn_eliminard_tshirts_Click(object sender, EventArgs e)
        {

            
                conexion.Open();
                
                 const string message =
                "Esta apunto de eliminar todos los descuentos que tienen los T-shirts. ¿Desea continuar?";
                const string caption = "BAUSI";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);


                if (result == DialogResult.No)
                {

                    txt_valor_descuento.Text = "";
                }
                else if (result == DialogResult.Yes)
                {
                    try
                    {

                        string sentencia = "UPDATE productos SET descuento=" + 0 + " WHERE ref_producto=" + 2222;
                        MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                        cmd.ExecuteNonQuery();
                        const string m = "¡DESCUENTOS ELIMINADOS CORRECTAMENTE!";
                        const string c = "BAUSI";
                        MessageBox.Show(m, c);
                        txt_valor_descuento.Text = "";
                        id_para_descuento.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                 conexion.Close();


            






        }

        private void btn_eliminard_combos_Click(object sender, EventArgs e)
        {

            conexion.Open();

            const string message =
           "Esta apunto de eliminar todos los descuentos que tienen los COMBOS BAUSI. ¿Desea continuar?";
            const string caption = "BAUSI";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {

                txt_valor_descuento.Text = "";
            }
            else if (result == DialogResult.Yes)
            {
                try
                {

                    string sentencia = "UPDATE productos SET descuento=" + 0 + " WHERE ref_producto=" + 3333;
                    MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                    cmd.ExecuteNonQuery();
                    const string m = "¡DESCUENTOS ELIMINADOS CORRECTAMENTE!";
                    const string c = "BAUSI";
                    MessageBox.Show(m, c);
                    txt_valor_descuento.Text = "";
                    id_para_descuento.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            conexion.Close();


        }

        private void btn_eliminard_playeras_Click(object sender, EventArgs e)
        {

            conexion.Open();

            const string message =
           "Esta apunto de eliminar todos los descuentos que tienen las PLAYERAS. ¿Desea continuar?";
            const string caption = "BAUSI";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {

                txt_valor_descuento.Text = "";
            }
            else if (result == DialogResult.Yes)
            {
                try
                {

                    string sentencia = "UPDATE productos SET descuento=" + 0 + " WHERE ref_producto=" + 1111;
                    MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                    cmd.ExecuteNonQuery();
                    const string m = "¡DESCUENTOS ELIMINADOS CORRECTAMENTE!";
                    const string c = "BAUSI";
                    MessageBox.Show(m, c);
                    txt_valor_descuento.Text = "";
                    id_para_descuento.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            conexion.Close();



        }

        private void btn_eliminar_todos_descuentos_Click(object sender, EventArgs e)
        {

            conexion.Open();

            const string message =
           "Esta apunto de eliminar todos los descuentos que tienen TODOS LOS PRODUCTOS. ¿Desea continuar?";
            const string caption = "BAUSI";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {

                txt_valor_descuento.Text = "";
            }
            else if (result == DialogResult.Yes)
            {
                try
                {

                    string sentencia1 = "UPDATE productos SET descuento=" + 0 + " WHERE ref_producto=" + 1111;
                    string sentencia2 = "UPDATE productos SET descuento=" + 0 + " WHERE ref_producto=" + 2222;
                    string sentencia3 = "UPDATE productos SET descuento=" + 0 + " WHERE ref_producto=" + 3333;

                    MySqlCommand cmd1 = new MySqlCommand(sentencia1, conexion);
                    cmd1.ExecuteNonQuery();
                    MySqlCommand cmd2 = new MySqlCommand(sentencia2, conexion);
                    cmd2.ExecuteNonQuery();
                    MySqlCommand cmd3 = new MySqlCommand(sentencia3, conexion);
                    cmd3.ExecuteNonQuery();
                    const string m = "¡DESCUENTOS ELIMINADOS CORRECTAMENTE!";
                    const string c = "BAUSI";
                    MessageBox.Show(m, c);
                    txt_valor_descuento.Text = "";
                    id_para_descuento.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            conexion.Close();



        }

        private void btn_descuento_atodos_Click(object sender, EventArgs e)
        {

            if (txt_valor_descuento.Text == "")
            {
                const string a = "¡POR FAVOR, INGRESA EL DESCUENTO!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);
                txt_valor_descuento.Text = "";
            }
            else
            {
                conexion.Open();
                int descuento = int.Parse(txt_valor_descuento.Text);

                const string message =
                "Esta apunto de aplicar un descuento a TODOS LOS PRODUCTOS. ¿Desea continuar?";
                const string caption = "BAUSI";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    // cancel the closure of the form.
                    txt_valor_descuento.Text = "";
                }
                else if (result == DialogResult.Yes)
                {
                    try
                    {

                        string sentencia1 = "UPDATE productos SET descuento=" + descuento + " WHERE ref_producto=" + 1111;
                        string sentencia2 = "UPDATE productos SET descuento=" + descuento + " WHERE ref_producto=" + 2222;
                        string sentencia3 = "UPDATE productos SET descuento=" + descuento + " WHERE ref_producto=" + 3333;
                        MySqlCommand cmd1 = new MySqlCommand(sentencia1, conexion);
                        cmd1.ExecuteNonQuery();
                        MySqlCommand cmd2 = new MySqlCommand(sentencia2, conexion);
                        cmd2.ExecuteNonQuery();
                        MySqlCommand cmd3 = new MySqlCommand(sentencia3, conexion);
                        cmd3.ExecuteNonQuery();
                        const string m = "¡DESCUENTO APLICADO CORRECTAMENTE!";
                        const string c = "BAUSI";
                        MessageBox.Show(m, c);
                        txt_valor_descuento.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }




                conexion.Close();


            }













        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            if (id_para_descuento.Text == "")
            {
                const string a = "¡POR FAVOR, INGRESA EL ID!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);
                txt_valor_descuento.Text = "";

            }
            else
            {

                
                
                int id = int.Parse(id_para_descuento.Text);


                const string message ="Esta apunto de ELIMINAR el descuento al producto con el id ingresado ¿Desea continuar?";
                const string caption = "BAUSI";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);


                if (result == DialogResult.No)
                {

                    txt_valor_descuento.Text = "";
                    id_para_descuento.Text = "";


                }
                else if (result == DialogResult.Yes)
                {
                    try
                    {

                        string sentencia = "UPDATE productos SET descuento=" + 0 + " WHERE id=" + id;
                        MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                        cmd.ExecuteNonQuery();
                        const string m = "¡DESCUENTO ELIMINADO CORRECTAMENTE!";
                        const string c = "BAUSI";
                        MessageBox.Show(m, c);
                        txt_valor_descuento.Text = "";
                        id_para_descuento.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                conexion.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           index i = new index();
            i.Visible = true;
            Visible = false; 
        }

        private void txt_valor_descuento_TextChanged(object sender, EventArgs e)
        {
            txt_valor_descuento.MaxLength = 2;
        }

        private void txt_valor_descuento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void id_para_descuento_TextChanged(object sender, EventArgs e)
        {
            id_para_descuento.MaxLength = 11;
        }

        private void id_para_descuento_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
