using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proyecto_bausi_csharp
{
    public partial class agregar_producto : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=proyecto_bausi; Uid=root; pwd=");
        public agregar_producto()
        {
            InitializeComponent();
        }

        private void btn_agregar_playera_Click(object sender, EventArgs e)
        {
            
        }

        private void agregar_producto_Load(object sender, EventArgs e)
        {

        }

        private void btn_agg_playera_Click(object sender, EventArgs e)
        {
            String[] otrat = new string [2];
            String otra_talla="";
            if (txt_otraTalla.Text != "")
            {
               // otra_talla = txt_otraTalla.Text;
                otrat = txt_otraTalla.Text.Split(',');
                otra_talla = otrat[0];
                
            }
            
            int cant_otrat=0;

            if (txt_preciop.Text=="" || txt_nombrep.Text=="" || txt_descripcionp.Text == "")
            {
                const string a = "¡INGRESA TODOS LOS CAMPOS!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_tallaS.Text=="" && txt_tallaM.Text=="" && txt_tallaL.Text=="" && txt_otraTalla.Text=="")
            {
                const string a = "¡DEBES SURTIR POR LO MENOS UNA TALLA!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                int aux = 0;
                if (otra_talla != "")
                {
                    if (otra_talla != "XL" && otra_talla != "XS" && otra_talla != "XXL")
                    {
                        const string a = "¡ASEGURATE DE HABER ESCRITO OTRA TALLA VALIDA!";
                        const string oe = "BAUSI";
                        MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        /* otra_talla = "";
                         otrat[0] = "";*/
                        aux = 1;
                    }
                    else
                    {
                        otrat = txt_otraTalla.Text.Split(',');
                        otra_talla = otrat[0];
                        cant_otrat = int.Parse(otrat[1]);
                        
                    }
                    
                }

                
                if (aux == 0)
                {
                    if (txt_otraTalla.Text != "")
                    {

                        otrat = txt_otraTalla.Text.Split(',');
                        otra_talla = otrat[0];
                        cant_otrat = int.Parse(otrat[1]);


                    }
                    int preciop = int.Parse(txt_preciop.Text);
                    String nombrep = txt_nombrep.Text;
                    String descripcionp = txt_descripcionp.Text;
                    int cant_tallaS = 0;
                    int cant_tallaM = 0;
                    int cant_tallaL = 0;
                    if (txt_tallaS.Text != "")
                    {
                        cant_tallaS = int.Parse(txt_tallaS.Text);
                    }
                    if (txt_tallaM.Text != "")
                    {
                        cant_tallaM = int.Parse(txt_tallaM.Text);
                    }
                    if (txt_tallaL.Text != "")
                    {
                        cant_tallaL = int.Parse(txt_tallaL.Text);
                    }


                    //String otratalla = txt_otraTalla.Text;

                    OpenFileDialog abrir = new OpenFileDialog();
                    abrir.InitialDirectory = @"C:\imagenes\";
                    abrir.Filter = "txt files (*.jpg)|*.jpg|(*.png)|*.png";
                    if (abrir.ShowDialog() == DialogResult.OK)
                    {
                        String ruta = abrir.FileName;
                        String ruta2 = "";
                        String nombreimg = "";
                        string id = "";
                        String extencion = DateTime.Now.ToString();
                        extencion = extencion.Replace(" ", "");
                        extencion = extencion.Replace(".", "");
                        extencion = extencion.Replace("/", "");
                        extencion = extencion.Replace(":", "_");

                        int num = extencion.LastIndexOf(".png");
                        if (extencion.IndexOf(".png") != 0)
                        {
                            ruta2 = @"D:\xa\htdocs\bausi\playeras\IMG" + extencion + ".png";
                            nombreimg = "IMG" + extencion + ".png";
                        }
                        else if (extencion.IndexOf(".jpg") != 0)
                        {
                            ruta2 = @"D:\xa\htdocs\bausi\playeras\IMG" + extencion + ".jpg";
                            nombreimg = "IMG" + extencion + ".jpg";
                        }
                        File.Copy(ruta, ruta2);
                        try
                        {
                            conexion.Open();

                            String sentencia = "INSERT INTO productos (nombre,descripcion,imagen,precio," +
                            "ref_producto) VALUES ('" + nombrep + "','" + descripcionp + "','" + nombreimg + "'," + preciop + "," + 1111 + ")";
                            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                            cmd.ExecuteNonQuery();
                            String s = "SELECT LAST_INSERT_ID() AS id;";
                            MySqlCommand cm = new MySqlCommand(s, conexion);
                            MySqlDataReader c = cm.ExecuteReader();

                            if (c.Read())
                            {
                                id = c["id"].ToString();
                            }
                            c.Close();

                            //MessageBox.Show(id);

                            if (cant_tallaS != 0)
                            {
                                int k = int.Parse(id);
                                String S = "S";
                               // MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_tallaS + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();
                            }
                            if (cant_tallaM != 0)
                            {
                                int k = int.Parse(id);
                                String S = "M";
                                //  MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_tallaM + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();


                            }
                            if (cant_tallaL != 0)
                            {
                                int k = int.Parse(id);
                                String S = "L";
                                //  MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_tallaL + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();
                            }
                            if (cant_otrat != 0)
                            {
                                int k = int.Parse(id);
                                String S = otra_talla;
                                // MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_otrat + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();
                            }



                            const string a = "¡PRODUCTO AGREGADO CORRECTAMENTE!";
                            const string oe = "BAUSI";
                            MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.None);
                            txt_preciop.Text = "";
                            txt_nombrep.Text = "";
                            txt_descripcionp.Text = "";
                            txt_tallaS.Text = "";
                            txt_tallaM.Text = "";
                            txt_tallaL.Text = "";
                            txt_otraTalla.Text = "";
                            conexion.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());


                            // cmd.ExecuteNonQuery();
                            // cmd.ExecuteReader();

                        }

                    }

                }
                
               




            }

            


        }

        private void txt_preciop_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled =false;
                }
                else
                {
                    e.Handled = true;
                }


            } catch (Exception ex)
            {
                const string a = "¡INGRESA UN PRECIO valido!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void txt_nombrep_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                } 
                else if (char.I)
                {
                    e.Handled = true;
                }


            }
            catch (Exception ex)
            {
                const string a = "¡INGRESA UN PRECIO valido!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            index i = new index();
            i.Visible = true;
            Visible = false;
        }

        private void txt_tallaS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_tallaM_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_tallaL_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_otraTalla_TextChanged(object sender, EventArgs e)
        {
            txt_otraTalla.MaxLength = 9;
        }

        private void txt_preciop_TextChanged(object sender, EventArgs e)
        {
            txt_preciop.MaxLength = 10;
        }

        private void txt_tallaS_TextChanged(object sender, EventArgs e)
        {
            txt_tallaS.MaxLength = 7;
        }

        private void txt_tallaM_TextChanged(object sender, EventArgs e)
        {
            txt_tallaM.MaxLength = 7;
        }

        private void txt_tallaL_TextChanged(object sender, EventArgs e)
        {
            txt_tallaL.MaxLength = 7;
        }

        private void btn_agg_tshirts_Click(object sender, EventArgs e)
        {

            String[] otrat = new string[2];
            String otra_talla = "";
            if (txt_otraTalla.Text != "")
            {
                // otra_talla = txt_otraTalla.Text;
                otrat = txt_otraTalla.Text.Split(',');
                otra_talla = otrat[0];

            }

            int cant_otrat = 0;

            if (txt_preciop.Text == "" || txt_nombrep.Text == "" || txt_descripcionp.Text == "")
            {
                const string a = "¡INGRESA TODOS LOS CAMPOS!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_tallaS.Text == "" && txt_tallaM.Text == "" && txt_tallaL.Text == "" && txt_otraTalla.Text == "")
            {
                const string a = "¡DEBES SURTIR POR LO MENOS UNA TALLA!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int aux = 0;
                if (otra_talla != "")
                {
                    if (otra_talla != "XL" && otra_talla != "XS" && otra_talla != "XXL")
                    {
                        const string a = "¡ASEGURATE DE HABER ESCRITO OTRA TALLA VALIDA!";
                        const string oe = "BAUSI";
                        MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        /* otra_talla = "";
                         otrat[0] = "";*/
                        aux = 1;
                    }
                    else
                    {
                        otrat = txt_otraTalla.Text.Split(',');
                        otra_talla = otrat[0];
                        cant_otrat = int.Parse(otrat[1]);

                    }

                }


                if (aux == 0)
                {
                    if (txt_otraTalla.Text != "")
                    {

                        otrat = txt_otraTalla.Text.Split(',');
                        otra_talla = otrat[0];
                        cant_otrat = int.Parse(otrat[1]);


                    }
                    int preciop = int.Parse(txt_preciop.Text);
                    String nombrep = txt_nombrep.Text;
                    String descripcionp = txt_descripcionp.Text;
                    int cant_tallaS = 0;
                    int cant_tallaM = 0;
                    int cant_tallaL = 0;
                    if (txt_tallaS.Text != "")
                    {
                        cant_tallaS = int.Parse(txt_tallaS.Text);
                    }
                    if (txt_tallaM.Text != "")
                    {
                        cant_tallaM = int.Parse(txt_tallaM.Text);
                    }
                    if (txt_tallaL.Text != "")
                    {
                        cant_tallaL = int.Parse(txt_tallaL.Text);
                    }


                    //String otratalla = txt_otraTalla.Text;

                    OpenFileDialog abrir = new OpenFileDialog();
                    abrir.InitialDirectory = @"C:\imagenes\";
                    abrir.Filter = "txt files (*.jpg)|*.jpg|(*.png)|*.png";
                    if (abrir.ShowDialog() == DialogResult.OK)
                    {
                        String ruta = abrir.FileName;
                        String ruta2 = "";
                        String nombreimg = "";
                        string id = "";
                        String extencion = DateTime.Now.ToString();
                        extencion = extencion.Replace(" ", "");
                        extencion = extencion.Replace(".", "");
                        extencion = extencion.Replace("/", "");
                        extencion = extencion.Replace(":", "_");

                        int num = extencion.LastIndexOf(".png");
                        if (extencion.IndexOf(".png") != 0)
                        {
                            ruta2 = @"D:\xa\htdocs\bausi\tshirts\IMG" + extencion + ".png";
                            nombreimg = "IMG" + extencion + ".png";
                        }
                        else if (extencion.IndexOf(".jpg") != 0)
                        {
                            ruta2 = @"D:\xa\htdocs\bausi\tshirts\IMG" + extencion + ".jpg";
                            nombreimg = "IMG" + extencion + ".jpg";
                        }
                        File.Copy(ruta, ruta2);
                        try
                        {
                            conexion.Open();

                            String sentencia = "INSERT INTO productos (nombre,descripcion,imagen,precio," +
                            "ref_producto) VALUES ('" + nombrep + "','" + descripcionp + "','" + nombreimg + "'," + preciop + "," + 2222 + ")";
                            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                            cmd.ExecuteNonQuery();
                            String s = "SELECT LAST_INSERT_ID() AS id;";
                            MySqlCommand cm = new MySqlCommand(s, conexion);
                            MySqlDataReader c = cm.ExecuteReader();

                            if (c.Read())
                            {
                                id = c["id"].ToString();
                            }
                            c.Close();

                            //MessageBox.Show(id);

                            if (cant_tallaS != 0)
                            {
                                int k = int.Parse(id);
                                String S = "S";
                                // MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_tallaS + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();
                            }
                            if (cant_tallaM != 0)
                            {
                                int k = int.Parse(id);
                                String S = "M";
                                //  MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_tallaM + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();


                            }
                            if (cant_tallaL != 0)
                            {
                                int k = int.Parse(id);
                                String S = "L";
                                //  MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_tallaL + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();
                            }
                            if (cant_otrat != 0)
                            {
                                int k = int.Parse(id);
                                String S = otra_talla;
                                // MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_otrat + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();
                            }



                            const string a = "¡PRODUCTO AGREGADO CORRECTAMENTE!";
                            const string oe = "BAUSI";
                            MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.None);
                            conexion.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());


                            // cmd.ExecuteNonQuery();
                            // cmd.ExecuteReader();

                        }

                    }

                }






            }




        }

        private void btn_agregar_combo_Click(object sender, EventArgs e)
        {
            String[] otrat = new string[2];
            String otra_talla = "";
            if (txt_otraTalla.Text != "")
            {
                // otra_talla = txt_otraTalla.Text;
                otrat = txt_otraTalla.Text.Split(',');
                otra_talla = otrat[0];

            }

            int cant_otrat = 0;

            if (txt_preciop.Text == "" || txt_nombrep.Text == "" || txt_descripcionp.Text == "")
            {
                const string a = "¡INGRESA TODOS LOS CAMPOS!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_tallaS.Text == "" && txt_tallaM.Text == "" && txt_tallaL.Text == "" && txt_otraTalla.Text == "")
            {
                const string a = "¡DEBES SURTIR POR LO MENOS UNA TALLA!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int aux = 0;
                if (otra_talla != "")
                {
                    if (otra_talla != "XL" && otra_talla != "XS" && otra_talla != "XXL")
                    {
                        const string a = "¡ASEGURATE DE HABER ESCRITO OTRA TALLA VALIDA!";
                        const string oe = "BAUSI";
                        MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        /* otra_talla = "";
                         otrat[0] = "";*/
                        aux = 1;
                    }
                    else
                    {
                        otrat = txt_otraTalla.Text.Split(',');
                        otra_talla = otrat[0];
                        cant_otrat = int.Parse(otrat[1]);

                    }

                }


                if (aux == 0)
                {
                    if (txt_otraTalla.Text != "")
                    {

                        otrat = txt_otraTalla.Text.Split(',');
                        otra_talla = otrat[0];
                        cant_otrat = int.Parse(otrat[1]);


                    }
                    int preciop = int.Parse(txt_preciop.Text);
                    String nombrep = txt_nombrep.Text;
                    String descripcionp = txt_descripcionp.Text;
                    int cant_tallaS = 0;
                    int cant_tallaM = 0;
                    int cant_tallaL = 0;
                    if (txt_tallaS.Text != "")
                    {
                        cant_tallaS = int.Parse(txt_tallaS.Text);
                    }
                    if (txt_tallaM.Text != "")
                    {
                        cant_tallaM = int.Parse(txt_tallaM.Text);
                    }
                    if (txt_tallaL.Text != "")
                    {
                        cant_tallaL = int.Parse(txt_tallaL.Text);
                    }


                    //String otratalla = txt_otraTalla.Text;

                    OpenFileDialog abrir = new OpenFileDialog();
                    abrir.InitialDirectory = @"C:\imagenes\";
                    abrir.Filter = "txt files (*.jpg)|*.jpg|(*.png)|*.png";
                    if (abrir.ShowDialog() == DialogResult.OK)
                    {
                        String ruta = abrir.FileName;
                        String ruta2 = "";
                        String nombreimg = "";
                        string id = "";
                        String extencion = DateTime.Now.ToString();
                        extencion = extencion.Replace(" ", "");
                        extencion = extencion.Replace(".", "");
                        extencion = extencion.Replace("/", "");
                        extencion = extencion.Replace(":", "_");

                        int num = extencion.LastIndexOf(".png");
                        if (extencion.IndexOf(".png") != 0)
                        {
                            ruta2 = @"D:\xa\htdocs\bausi\combosbausi\IMG" + extencion + ".png";
                            nombreimg = "IMG" + extencion + ".png";
                        }
                        else if (extencion.IndexOf(".jpg") != 0)
                        {
                            ruta2 = @"D:\xa\htdocs\bausi\combosbausi\IMG" + extencion + ".jpg";
                            nombreimg = "IMG" + extencion + ".jpg";
                        }
                        File.Copy(ruta, ruta2);
                        try
                        {
                            conexion.Open();

                            String sentencia = "INSERT INTO productos (nombre,descripcion,imagen,precio," +
                            "ref_producto) VALUES ('" + nombrep + "','" + descripcionp + "','" + nombreimg + "'," + preciop + "," + 3333 + ")";
                            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
                            cmd.ExecuteNonQuery();
                            String s = "SELECT LAST_INSERT_ID() AS id;";
                            MySqlCommand cm = new MySqlCommand(s, conexion);
                            MySqlDataReader c = cm.ExecuteReader();

                            if (c.Read())
                            {
                                id = c["id"].ToString();
                            }
                            c.Close();

                            //MessageBox.Show(id);

                            if (cant_tallaS != 0)
                            {
                                int k = int.Parse(id);
                                String S = "S";
                                // MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_tallaS + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();
                            }
                            if (cant_tallaM != 0)
                            {
                                int k = int.Parse(id);
                                String S = "M";
                                //  MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_tallaM + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();


                            }
                            if (cant_tallaL != 0)
                            {
                                int k = int.Parse(id);
                                String S = "L";
                                //  MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_tallaL + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();
                            }
                            if (cant_otrat != 0)
                            {
                                int k = int.Parse(id);
                                String S = otra_talla;
                                // MessageBox.Show("int: " + k);
                                String sentencia2 = "INSERT INTO existencia_productos (talla,existencia,id_producto) VALUES ('" + S + "'," + cant_otrat + "," + k + ")";
                                MySqlCommand comando = new MySqlCommand(sentencia2, conexion);
                                comando.ExecuteNonQuery();
                            }



                            const string a = "¡PRODUCTO AGREGADO CORRECTAMENTE!";
                            const string oe = "BAUSI";
                            MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.None);
                            conexion.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());


                            // cmd.ExecuteNonQuery();
                            // cmd.ExecuteReader();

                        }

                    }

                }






            }
        }
    }
}
